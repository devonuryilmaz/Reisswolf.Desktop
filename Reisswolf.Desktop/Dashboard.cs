using MetroFramework.Forms;
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
        int dataCount = 0;
        int incomeReportPageNum = 0;
        int incomeReportTotalCount = 0;
        int sentReportPageNum = 0;
        int sentReportTotalCount = 0;

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
                    if (incomeData == null)
                    {
                        incomeData = Core.database.FIBAIncome.FirstOrDefault(x => x.DocumentSerialNo == barcode && x.IsSent == false);
                        if (incomeData != null)
                            listView1.Items.Insert(0, incomeData.DocumentSerialNo, incomeData.DocumentSerialNo, "");
                    }

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
            dataCount = Core.database.FIBAIncome.Where(p => p.IsSent == false).Count();

            if (dataCount > 100)
            {
                lblTotalRecordCount.Text += (' ' + dataCount.ToString());
                lblRecordCount.Text += " 100";
            }
            else
            {
                lblTotalRecordCount.Text += (' ' + dataCount.ToString());
                lblRecordCount.Text += (' ' + dataCount.ToString());
            }

            incomesData = Core.database.FIBAIncome
                .Where(p => p.IsSent == false).Take(100).ToList();

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
                model.barcodeCourierArchive = row.Cells["ScannedBarcodeCourierArchive"].Value.ToString();

                tableData.documentSerialNo = row.Cells["ScannedDocumentSerialNo"].Value.ToString();
                tableData.parcelCodeArchive = row.Cells["ScannedArchiveNo"].Value.ToString();

                model.TABLE.Add(tableData);

                sentBarcodes.Add(tableData.documentSerialNo);
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
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Core.TokenModel.access_token);
                    request.Content = httpContent;

                    using (var response = await client
                               .SendAsync(request, HttpCompletionOption.ResponseHeadersRead)
                               .ConfigureAwait(false))
                    {
                        response.EnsureSuccessStatusCode();

                        var responseContent = await response.Content.ReadAsStringAsync();

                        var responseModel = JsonConvert.DeserializeObject<ArchiveResponseModel>(responseContent);

                        lblProgressBar.Text = "Veri gönderildi, veritabanı kayıtları oluşturuluyor.";
                        sendDataProgressBar.Value = 70;
                        sendDataProgressBar.Update();
                        var dataCount = responseModel.TABLE != null ? responseModel.TABLE.Count : 0;
                        var index = 1;
                        List<string> successDatas = new List<string>();
                        Dictionary<string, string> failDatas = new Dictionary<string, string>();

                        if (dataCount > 0)
                        {
                            foreach (var data in responseModel.TABLE)
                            {
                                if (data.ResultCode == "0")
                                {
                                    var incomeData = incomesData.FirstOrDefault(x => x.DocumentSerialNo == data.DocumentSerialNo);

                                    FIBAOutgoing sentData = new FIBAOutgoing()
                                    {
                                        DocumentSerialNo = data.DocumentSerialNo,
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
                                    successDatas.Add(data.DocumentSerialNo);
                                }
                                else
                                {
                                    index++;
                                    failDatas.Add(data.DocumentSerialNo ?? index.ToString(), data.Message);
                                }
                            }

                            Core.database.FIBAOutgoing.AddRange(sendedDatas);
                            Core.database.FIBAIncome.AddOrUpdate(sendedIncomeDatas.ToArray());
                            await Core.database.SaveChangesAsync();
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

                    var message = ex.InnerException != null ? ex.InnerException.InnerException.Message : ex.Message;

                    MessageBox.Show($"Veriler Gönderilirken Hata Oluştu.\n Hata: {message}", "Veri Gönderimi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sendDataProgressBar.Visible = lblProgressBar.Visible = false;
                }
            }
        }

        private string CreateBatchNumber()
        {
            return "RSW" + DateTime.Now.ToString("yyyyMMddHHmm");
        }

        private async Task<bool> GetTokenFromService()
        {
            using (var client = new System.Net.Http.HttpClient())
            using (var request = new HttpRequestMessage(HttpMethod.Post, ExportApi.Default.AuthUrl))
            {
                try
                {
                    var authenticationString = $"{ExportApi.Default.ClientId}:{ExportApi.Default.ClientSecret}";
                    var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(authenticationString));

                    request.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);

                    using (var response = await client
                               .SendAsync(request, HttpCompletionOption.ResponseHeadersRead)
                               .ConfigureAwait(false))
                    {
                        response.EnsureSuccessStatusCode();

                        var responseContent = await response.Content.ReadAsStringAsync();

                        var tokenModel = JsonConvert.DeserializeObject<ServiceTokenModel>(responseContent);

                        Core.TokenModel = tokenModel;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                    //_logger.LogInformation("PdfError");
                    //_logger.LogInformation(JsonConvert.SerializeObject(ex));
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
            var data = Core.database.FIBAOutgoing
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

            dataGridSentReport.DataSource = data;

            lblOutgoingReportTotalRecord.Text = "Toplam Kayıt Sayısı: " + data.Count;
        }

        private async void FilterForIncomeData()
        {
            var count = Core.database.FIBAIncome
                 .WhereIf(!string.IsNullOrWhiteSpace(txtRprIncomeDocSerialNo.Text), x => x.DocumentSerialNo == txtRprIncomeDocSerialNo.Text)
                 .WhereIf(!string.IsNullOrWhiteSpace(txtRprIncomeCompanyCode.Text), x => x.CompanyCode == txtRprIncomeCompanyCode.Text)
                 .WhereIf(!string.IsNullOrWhiteSpace(txtRprIncomeNationalIdNo.Text), x => x.NationalIdentityNo == txtRprIncomeNationalIdNo.Text)
                 .WhereIf(chkIncludeIncomeDates.Checked, x => x.CreatedDate >= dtIncomeStartDate.Value && x.CreatedDate <= dtIncomeEndDate.Value)
                 .WhereIf(cmbIncomeSuccessStatus.SelectedIndex == 1, x => x.IsSuccessFlag == true)
                 .WhereIf(cmbIncomeSuccessStatus.SelectedIndex == 2, x => x.IsSuccessFlag == false)
                 .WhereIf(cmbIncomeSendFlag.SelectedIndex == 1, x => x.IsSent == true)
                 .WhereIf(cmbIncomeSendFlag.SelectedIndex == 2, x => x.IsSent == false).Count();

            var data = await GetIncomeReport();

            incomeReportTotalCount = count;
            dataGridIncomeReport.DataSource = data;
            lblIncomeReportTotalRecord.Text = "Toplam Kayıt Sayısı: " + count;
            lblIncomeReportPage.Text = "Sayfa: 1/" + ((count / 100) + 1);
            btnIncomeNextPage.Enabled = true;
        }

        private void btnIncomeDataExportToExcel_Click(object sender, EventArgs e)
        {
            var data = GetIncomeReport(0, incomeReportTotalCount);
            dataGridIncomeReport.DataSource = data;
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

        private void tabIncomeData_Enter(object sender, EventArgs e)
        {
            if (dataGridIncomeReport.RowCount == 0)
            {
                btnIncomePreviousPage.Enabled = btnIncomeNextPage.Enabled = false;
                incomeReportPageNum = 1;
            }
        }

        private async void btnIncomeNextPage_Click(object sender, EventArgs e)
        {
            if (incomeReportPageNum == ((incomeReportTotalCount / 100) + 1))
            {
                btnIncomeNextPage.Enabled = false;
                return;
            }

            incomeReportPageNum++;
            btnIncomePreviousPage.Enabled = true;

            var data = await GetIncomeReport(incomeReportPageNum);

            dataGridIncomeReport.DataSource = data;

            lblIncomeReportPage.Text = "Sayfa: " + incomeReportPageNum.ToString() + "/" + ((incomeReportTotalCount / 100) + 1);
        }

        private async void btnIncomePreviousPage_Click(object sender, EventArgs e)
        {
            if (incomeReportPageNum == 1)
            {
                btnIncomeNextPage.Enabled = false;
                return;
            }

            incomeReportPageNum--;
            btnIncomeNextPage.Enabled = true;

            var data = await GetIncomeReport(incomeReportPageNum);

            dataGridIncomeReport.DataSource = data;

            lblIncomeReportPage.Text = "Sayfa: " + incomeReportPageNum.ToString() + "/" + ((incomeReportTotalCount / 100) + 1);
        }

        private async Task<List<FIBAIncome>> GetIncomeReport(int page = 1, int take = 100)
        {
            return await Core.database.FIBAIncome
                 .WhereIf(!string.IsNullOrWhiteSpace(txtRprIncomeDocSerialNo.Text), x => x.DocumentSerialNo == txtRprIncomeDocSerialNo.Text)
                 .WhereIf(!string.IsNullOrWhiteSpace(txtRprIncomeCompanyCode.Text), x => x.CompanyCode == txtRprIncomeCompanyCode.Text)
                 .WhereIf(!string.IsNullOrWhiteSpace(txtRprIncomeNationalIdNo.Text), x => x.NationalIdentityNo == txtRprIncomeNationalIdNo.Text)
                 .WhereIf(chkIncludeIncomeDates.Checked, x => x.CreatedDate >= dtIncomeStartDate.Value && x.CreatedDate <= dtIncomeEndDate.Value)
                 .WhereIf(cmbIncomeSuccessStatus.SelectedIndex == 1, x => x.IsSuccessFlag == true)
                 .WhereIf(cmbIncomeSuccessStatus.SelectedIndex == 2, x => x.IsSuccessFlag == false)
                 .WhereIf(cmbIncomeSendFlag.SelectedIndex == 1, x => x.IsSent == true)
                 .WhereIf(cmbIncomeSendFlag.SelectedIndex == 2, x => x.IsSent == false)
                 .OrderBy(x => x.CreatedDate)
                 .Skip((page - 1) * 100)
                 .Take(take)
                 .ToListAsync();
        }
    }
}
