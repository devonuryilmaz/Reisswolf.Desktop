﻿using MetroFramework.Forms;
using Newtonsoft.Json;
using Reisswolf.Desktop.Helpers;
using Reisswolf.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Reisswolf.Desktop
{
    public partial class Dashboard : MetroForm
    {
        List<FIBAIncome> incomesData;
        List<string> scannedBarcodes = new List<string>();
        bool dataFromWaitedDatas = false;

        public Dashboard()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            dtIncomeEndDate.Value = dtIncomeStartDate.Value = dtOutGoingStartDate.Value = dtOutGoingEndDate.Value = DateTime.Today.Date;

            metroTabControl1.SelectedTab = metroTabControl1.TabPages[0];
            //if (!CheckWaitedDatas())
            SetData();

            txtCourrierNo.Enter += TxtCourrierNo_Enter;
        }

        protected override void OnLoad(EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            base.OnLoad(e);
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtArchiveNo.Text == "" || txtCourrierNo.Text == "" || txtBarcode.Text == "")
                return;

            if (e.KeyChar == (char)Keys.Enter)
            {
                string barcode = txtBarcode.Text;

                if (scannedBarcodes.Contains(barcode))
                    MessageBox.Show("Barkod daha önce okutulmuştur. Lütfen listeyi kontrol ediniz.", "Uyarı");
                else
                {
                    var incomeData = incomesData.FirstOrDefault(x => x.DocumentSerialNo == barcode);
                    var nationalIdentityNo = incomeData != null && !string.IsNullOrWhiteSpace(incomeData.NationalIdentityNo) ? incomeData.NationalIdentityNo : string.Empty;
                    var companyCode = incomeData != null && !string.IsNullOrWhiteSpace(incomeData.CompanyCode) ? incomeData.CompanyCode : string.Empty;
                    var itWillScanFlag = incomeData != null ? incomeData.ItWillScanFlag : false;

                    if (listView1.Items[barcode] != null)
                    {
                        listView1.Items[barcode].BackColor = Color.GreenYellow;

                        if (incomeData != null && incomeData.ItWillScanFlag)
                        {
                            var result = MessageBox.Show("Taranacak kayıtlar mevcuttur.", "Taranacak Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Barkod numarası '{barcode}' gelen verilerde bulunamadı!", "Uyarı");
                        txtBarcode.Text = string.Empty;
                        txtBarcode.Focus();
                        e.Handled = true;
                        return;
                    }

                    dataGridScannedBarcodes.Rows.Add(txtCourrierNo.Text, txtArchiveNo.Text, barcode, nationalIdentityNo, companyCode, itWillScanFlag);
                    scannedBarcodes.Add(barcode);
                }
                txtBarcode.Text = string.Empty;
                txtBarcode.Focus();
                e.Handled = true;
            }
        }

        #region Button click events
        private void btnGetDataFromDb_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show(this, "Listedeki veriler veritabanından tekrar çekilecek.\nOnaylıyor musunuz?",
                                               "Veritabanından Veri Çek",
                                               MessageBoxButtons.YesNoCancel,
                                               MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dataGridScannedBarcodes.Rows.Count > 0)
                {
                    MessageBox.Show("İşlem yapılmamış kayıtlar var. \nVeritabanından veri almadan önce işlem yapılmamış kayıtları kaydediniz ya da gönderiniz.", "Uyarı");
                }
                else
                    SetData();
            }

            txtBarcode.Focus();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            await SendData();
        }

        private async void btnSaveList_ClickAsync(object sender, EventArgs e)
        {
            await SaveDataFromDataSource();
        }


        private async void btnGetSavedData_Click(object sender, EventArgs e)
        {
            await GetWaitedDatasAsync();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        #endregion

        #region Methods

        private void ClearData(List<string> barcodeList = null)
        {
            dataGridScannedBarcodes.Rows.Clear();
            scannedBarcodes.Clear();
            txtArchiveNo.Text = txtCourrierNo.Text = string.Empty;
            dataFromWaitedDatas = false;

            if (barcodeList != null)
            {
                barcodeList.ForEach(x =>
                {
                    listView1.Items.RemoveByKey(x);
                });
            }

            foreach (ListViewItem item in listView1.Items)
            {
                item.BackColor = Color.Transparent;
            }
        }

        private bool CheckWaitedDatas()
        {
            var outgoingDatas = Core.database.FIBAOutgoing.Where(x => x.Status == (int)EnumOutgoingStatus.Waiting && x.CreatedBy == Core.ActiveUser.ID).ToList();
            if (outgoingDatas.Count > 0)
            {
                MessageBox.Show("Bekleyen kayıtlar mevcut!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetWaitedDatasAsync();
                return true;
            }

            return false;
        }

        private void SetData(bool? addToExistData = false)
        {
            incomesData = Core.database.FIBAIncome
                .Where(p => p.IsSent == false).ToList();

            // Outgoingte Waitingde olanlar

            listView1.Items.Clear();
            ColDocumentSerialNo.Width = listView1.Width;
            foreach (var data in incomesData)
            {
                listView1.Items.Add(data.DocumentSerialNo, data.DocumentSerialNo, "");
            }
        }

        private async Task SendData()
        {
            var sentTime = DateTime.Now;
            List<string> sentBarcodes = new List<string>();
            List<FIBAOutgoing> sendedDatas = new List<FIBAOutgoing>();
            List<FIBAIncome> sendedIncomeDatas = new List<FIBAIncome>();

            sendDataProgressBar.Value = 0;
            lblProgressBar.Text = "Servis ile veritabanı bağlantısı kuruluyor.";

            sendDataProgressBar.Visible = lblProgressBar.Visible = true;

            if (!await GetTokenFromService())
            {
                MessageBox.Show("Servis ile bağlantı kurulamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblProgressBar.Text = "Veri hazılanıyor.";
            sendDataProgressBar.Value = 10;
            sendDataProgressBar.Update();

            string batchNumber = CreateBatchNumber();
            DocumentFromArchiveModel model = new DocumentFromArchiveModel();

            foreach (DataGridViewRow row in dataGridScannedBarcodes.Rows)
            {
                DocumentArchiveModel tableData = new DocumentArchiveModel();
                model.archiveBagId = row.Cells["ScannedBarcodeCourierArchive"].Value.ToString();

                tableData.barcodeNumber = row.Cells["ScannedDocumentSerialNo"].Value.ToString();
                tableData.parcelCodeArchive = row.Cells["ScannedArchiveNo"].Value.ToString();

                model.archiveDocumentList.Add(tableData);

                sentBarcodes.Add(tableData.barcodeNumber);
            }

            lblProgressBar.Text = "Veri gönderiliyor.";
            sendDataProgressBar.Value = 40;
            sendDataProgressBar.Update();

            using (var client = new System.Net.Http.HttpClient())
            using (var request = new HttpRequestMessage(HttpMethod.Post, ExportApi.Default.ServisUrl))
            using (var httpContent = HttpContentHelper.CreateHttpContent(model))
            {
                try
                {
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Core.TokenModel.token);
                    request.Content = httpContent;

                    using (var response = await client
                               .SendAsync(request, HttpCompletionOption.ResponseHeadersRead)
                               .ConfigureAwait(false))
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();

                        var responseModel = JsonConvert.DeserializeObject<ArchiveResponseModel>(responseContent);

                        if (responseModel.error != null)
                        {
                            MessageBox.Show($"Hata Kodu: {responseModel.error.code} \n" +
                                $"Hata Mesajı: {responseModel.error.message}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            lblProgressBar.Text = "";
                            sendDataProgressBar.Value = 0;
                            sendDataProgressBar.Visible = false;
                            sendDataProgressBar.Update();
                            return;
                        }

                        lblProgressBar.Text = "Veri gönderildi, veritabanı kayıtları oluşturuluyor.";
                        sendDataProgressBar.Value = 70;
                        sendDataProgressBar.Update();
                        var dataCount = responseModel.barcodeList != null ? responseModel.barcodeList.Count : 0;
                        var index = 1;
                        List<string> successDatas = new List<string>();
                        List<string> failDatas = new List<string>();

                        if (dataCount > 0)
                        {
                            foreach (var data in responseModel.barcodeList)
                            {
                                var incomeData = incomesData.FirstOrDefault(x => x.DocumentSerialNo == data);

                                if (incomeData == null)
                                    continue;

                                FIBAOutgoing sentData = new FIBAOutgoing()
                                {
                                    DocumentSerialNo = data,
                                    BarcodeCourrierArchiveNo = txtCourrierNo.Text,
                                    ParcelCodeArchiveNo = txtArchiveNo.Text,
                                    BatchNumber = batchNumber,
                                    SentTime = sentTime,
                                    IsScanned = true,
                                    Status = (int)EnumOutgoingStatus.Sent,
                                    NationalIdentityNo = incomeData != null && !string.IsNullOrWhiteSpace(incomeData.NationalIdentityNo) ? incomeData.NationalIdentityNo : "",
                                    CompanyCode = incomeData != null && !string.IsNullOrWhiteSpace(incomeData.CompanyCode) ? incomeData.CompanyCode : "",
                                    CreatedBy = Core.ActiveUser.ID,
                                    CreatedDate = sentTime,
                                    IsActive = true,
                                    IsDeleted = false
                                };

                                sendDataProgressBar.Value = 70 + index++ * 100 / (70 + dataCount);
                                sendDataProgressBar.Update();

                                incomeData.IsSent = true;
                                incomeData.IsSuccessFlag = true;

                                sendedDatas.Add(sentData);
                                sendedIncomeDatas.Add(incomeData);
                                successDatas.Add(data);
                            }

                            var failBarcodes = sentBarcodes.Where(x => !responseModel.barcodeList.Contains(x)).ToList();
                            failDatas = failBarcodes;

                            Core.database.FIBAOutgoing.AddRange(sendedDatas);
                            Core.database.FIBAIncome.AddOrUpdate(sendedIncomeDatas.ToArray());
                            await Core.database.SaveChangesAsync();
                        }
                        else
                        {
                            failDatas = sentBarcodes;
                        }

                        lblProgressBar.Text = "İşlem tamamlandı!";
                        sendDataProgressBar.Value = 100;
                        sendDataProgressBar.Update();

                        if (DialogResult.OK == MessageBox.Show("Veriler Gönderildi.", "Veri Gönderimi", MessageBoxButtons.OK, MessageBoxIcon.Information))
                        {
                            SendResults sr = new SendResults(successDatas, failDatas);
                            sr.ShowDialog();
                        }

                        sendDataProgressBar.Visible = lblProgressBar.Visible = false;

                        ClearData(sentBarcodes);
                    }
                }
                catch (Exception ex)
                {
                    //_logger.LogInformation("PdfError");
                    //_logger.LogInformation(JsonConvert.SerializeObject(ex));
                }
            }
        }

        private string CreateBatchNumber()
        {
            return "RSW" + DateTime.Now.ToString("yyyyMMddHHmm");
        }

        private async Task<bool> GetTokenFromService()
        {
            var loginModel = new LoginModel()
            {
                userName = ExportApi.Default.UserName,
                password = ExportApi.Default.Password,
            };

            using (var client = new System.Net.Http.HttpClient())
            using (var request = new HttpRequestMessage(HttpMethod.Post, ExportApi.Default.AuthUrl))
            using (var httpContent = HttpContentHelper.CreateHttpContent(loginModel))
            {
                try
                {
                    request.Content = httpContent;

                    using (var response = await client
                               .SendAsync(request, HttpCompletionOption.ResponseHeadersRead)
                               .ConfigureAwait(false))
                    {
                        using (var content = response.Content)
                        {
                            var result = await content.ReadAsStringAsync();
                            var model = JsonConvert.DeserializeObject<ServiceTokenModel>(result);

                            if (model.error != null)
                            {
                                MessageBox.Show($"Hata Kodu: {model.error.code} \n" +
                                    $"Hata Mesajı: {model.error.message}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }

                            Core.TokenModel = model;
                        }
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

            return true;
        }

        private async Task SaveDataFromDataSource()
        {
            if (dataGridScannedBarcodes.Rows.Count <= 0)
                return;

            if (!dataFromWaitedDatas)
            {
                DateTime saveTime = DateTime.Now;

                List<FIBAOutgoing> waitingDatas = new List<FIBAOutgoing>();
                List<string> waitingDataString = new List<string>();

                foreach (DataGridViewRow row in dataGridScannedBarcodes.Rows)
                {
                    var barcodeCourierArchive = row.Cells["ScannedBarcodeCourierArchive"].Value.ToString() ?? "";
                    var documentSerialNo = row.Cells["ScannedDocumentSerialNo"].Value.ToString() ?? "";
                    var companyCode = row.Cells["ScannedCompanyCode"].Value.ToString() ?? "";
                    var nationalIdentityNo = row.Cells["ScannedNationalIdentityNo"].Value.ToString() ?? "";
                    var archiveNo = row.Cells["ScannedArchiveNo"].Value.ToString() ?? "";
                    var isScanned = Convert.ToBoolean(row.Cells["ScannedItWillScanFlag"].Value);

                    waitingDataString.Add(documentSerialNo);

                    FIBAOutgoing outgoingData = new FIBAOutgoing()
                    {
                        BarcodeCourrierArchiveNo = barcodeCourierArchive,
                        DocumentSerialNo = documentSerialNo,
                        CompanyCode = companyCode,
                        NationalIdentityNo = nationalIdentityNo,
                        ParcelCodeArchiveNo = archiveNo,
                        IsScanned = isScanned,
                        Status = (int)EnumOutgoingStatus.Waiting,
                        CreatedBy = Core.ActiveUser.ID,
                        CreatedDate = saveTime,
                        IsActive = true,
                        IsDeleted = false
                    };

                    waitingDatas.Add(outgoingData);
                }

                List<FIBAIncome> incomingDatas = new List<FIBAIncome>();

                incomingDatas = incomesData.Where(x => waitingDataString.Contains(x.DocumentSerialNo)).ToList();

                foreach (var incomeData in incomingDatas)
                {
                    incomeData.IsSent = false;
                    incomeData.ModifyDate = DateTime.Now;
                    Core.database.FIBAIncome.AddOrUpdate(incomeData);
                }
                Core.database.FIBAOutgoing.AddRange(waitingDatas);

                try
                {
                    await Core.database.SaveChangesAsync();

                    ClearData(waitingDataString);
                }
                catch (Exception)
                {

                }
            }
            else
            {

            }
        }

        private async Task GetWaitedDatasAsync()
        {
            incomesData = await Core.database.FIBAIncome.Where(x => x.IsSent == false).ToListAsync();
            var outgoingDatas = await Core.database.FIBAOutgoing.Where(x => x.Status == (int)EnumOutgoingStatus.Waiting && x.CreatedBy == Core.ActiveUser.ID).ToListAsync();
            List<string> listedItems = new List<string>();
            dataGridScannedBarcodes.Rows.Clear();

            foreach (ListViewItem listViewItem in listView1.Items)
            {
                listedItems.Add(listViewItem.Text.ToString());
            }

            incomesData = incomesData.Where(x => !listedItems.Any(s => s == x.DocumentSerialNo)).ToList();

            foreach (var incomeData in incomesData)
                listView1.Items.Add(incomeData.DocumentSerialNo, incomeData.DocumentSerialNo, "");

            foreach (var outgoingData in outgoingDatas)
            {
                if (listView1.Items.IndexOfKey(outgoingData.DocumentSerialNo) > -1)
                {
                    ListViewItem listViewItem = listView1.Items.Find(outgoingData.DocumentSerialNo, false).FirstOrDefault();
                    listViewItem.BackColor = Color.GreenYellow;
                }
                else
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = outgoingData.DocumentSerialNo;
                    listView1.Items.Add(outgoingData.DocumentSerialNo, outgoingData.DocumentSerialNo, "");

                    listViewItem = listView1.Items.Find(outgoingData.DocumentSerialNo, false).FirstOrDefault();
                    listViewItem.BackColor = Color.GreenYellow;
                }

                dataGridScannedBarcodes.Rows.Add(outgoingData.BarcodeCourrierArchiveNo, outgoingData.ParcelCodeArchiveNo, outgoingData.DocumentSerialNo, outgoingData.NationalIdentityNo, outgoingData.CompanyCode, outgoingData.IsScanned);
                scannedBarcodes.Add(outgoingData.DocumentSerialNo);
            }

            txtCourrierNo.Text = outgoingDatas.FirstOrDefault().BarcodeCourrierArchiveNo;
            txtArchiveNo.Text = outgoingDatas.FirstOrDefault().ParcelCodeArchiveNo;

            dataFromWaitedDatas = true;
        }

        #endregion

        #region Report

        private void btnReportOutgoingData_Click(object sender, EventArgs e)
        {
            FilterForOutgoingData();
        }

        private void btnReportIncomeData_Click(object sender, EventArgs e)
        {
            FilterForIncomeData();
        }

        private void btnSentDataExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(dataGridSentReport, "Gönderilenler");
        }

        private void FilterForOutgoingData()
        {
            dataGridSentReport.DataSource = Core.database.FIBAOutgoing
                 .WhereIf(!string.IsNullOrWhiteSpace(txtReportArchiveNo.Text), x => x.ParcelCodeArchiveNo == txtReportArchiveNo.Text)
                 .WhereIf(!string.IsNullOrWhiteSpace(txtRprOutGoingDocSerialNo.Text), x => x.DocumentSerialNo == txtRprOutGoingDocSerialNo.Text)
                 .WhereIf(!string.IsNullOrWhiteSpace(txtReportCourrierNo.Text), x => x.BarcodeCourrierArchiveNo == txtReportCourrierNo.Text)
                 .WhereIf(!string.IsNullOrWhiteSpace(txtRprOutgoingNationalIdNo.Text), x => x.NationalIdentityNo == txtRprOutgoingNationalIdNo.Text)
                 .WhereIf(!string.IsNullOrWhiteSpace(txtRprOutgoingCompanyCode.Text), x => x.CompanyCode == txtRprOutgoingCompanyCode.Text)
                 .WhereIf(!string.IsNullOrWhiteSpace(txtReportBatchNo.Text), x => x.BatchNumber == txtReportBatchNo.Text)
                 .WhereIf(cmbOutStatus.SelectedIndex > 0, x => x.Status == cmbOutStatus.SelectedIndex - 1)
                 .WhereIf(chkIncludeOutDates.Checked, x => x.CreatedDate >= dtOutGoingStartDate.Value && x.CreatedDate <= dtOutGoingEndDate.Value)
                 .Where(x => x.CreatedBy == Core.ActiveUser.ID)
                 .ToList();
        }

        private void FilterForIncomeData()
        {
            dataGridIncomeReport.DataSource = Core.database.FIBAIncome
                 .WhereIf(!string.IsNullOrWhiteSpace(txtRprIncomeDocSerialNo.Text), x => x.DocumentSerialNo == txtRprIncomeDocSerialNo.Text)
                 .WhereIf(!string.IsNullOrWhiteSpace(txtRprIncomeCompanyCode.Text), x => x.CompanyCode == txtRprIncomeCompanyCode.Text)
                 .WhereIf(!string.IsNullOrWhiteSpace(txtRprIncomeNationalIdNo.Text), x => x.NationalIdentityNo == txtRprIncomeNationalIdNo.Text)
                 .WhereIf(chkIncludeOutDates.Checked, x => x.CreatedDate >= dtIncomeStartDate.Value && x.CreatedDate <= dtIncomeEndDate.Value)
                 .WhereIf(cmbIncomeSuccessStatus.SelectedIndex == 1, x => x.IsSuccessFlag == true)
                 .WhereIf(cmbIncomeSuccessStatus.SelectedIndex == 2, x => x.IsSuccessFlag == false)
                 .WhereIf(cmbIncomeSendFlag.SelectedIndex == 1, x => x.IsSent == true)
                 .WhereIf(cmbIncomeSendFlag.SelectedIndex == 2, x => x.IsSent == false)
                 .ToList();
        }

        private void btnIncomeDataExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(dataGridIncomeReport, "Gelenler");
        }

        private void ExportToExcel(DataGridView dataGridView, string fileName)
        {
            Excel.Application excel = new Excel.Application();

            //excel.Visible = true;

            Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);

            Excel.Worksheet sheet1 = (Excel.Worksheet)workbook.Sheets[1];
            Excel.Range cells = sheet1.Cells;
            cells.NumberFormat = "@";

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                sheet1.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    sheet1.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value != null ? dataGridView.Rows[i].Cells[j].Value.ToString() : "";
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = fileName;
            saveFileDialoge.DefaultExt = ".xlsx";

            excel.DisplayAlerts = false;

            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }

            workbook.Close();

            excel.Quit();
        }

        #endregion

        #region Form events

        protected override void OnShown(EventArgs e)
        {
            txtCourrierNo.Focus();
        }

        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }

        private void TxtCourrierNo_Enter(object sender, EventArgs e)
        {
            if (dataGridScannedBarcodes.Rows.Count > 0)
            {
                System.Windows.Forms.MessageBox.Show("Verileri kaydetmeden ya da göndermeden 'Kurye Barkod No' değiştirilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBarcode.Focus();
            }
        }

        private void dataGridScannedBarcodes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (!btnSend.Enabled)
                btnSend.Enabled = true;
        }

        private void dataGridScannedBarcodes_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (btnSend.Enabled && dataGridScannedBarcodes.Rows.Count <= 0)
                btnSend.Enabled = false;
        }
        #endregion
    }
}
