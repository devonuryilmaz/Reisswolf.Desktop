using MetroFramework;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Reisswolf.Desktop
{
    public partial class Dashboard : MetroForm
    {
        List<FIBAIncome> incomesData;
        List<string> scannedBarcodes = new List<string>();
        public Dashboard()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            metroTabControl1.SelectedTab = metroTabControl1.TabPages[0];
            SetData();

            txtCourrierNo.Enter += TxtCourrierNo_Enter;
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtArchiveNo.Text == "" || txtCourrierNo.Text == "" || txtBarcode.Text == "")
                return;

            if (e.KeyChar == (char)Keys.Enter)
            {
                string barcode = txtBarcode.Text;

                if (scannedBarcodes.Contains(barcode))
                    System.Windows.Forms.MessageBox.Show("Barkod daha önce okutulmuştur. Lütfen listeyi kontrol ediniz.", "Uyarı");
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
                            var result = MessageBox.Show(this, "\nTaranacak kayıtlar mevcuttur.", "Taranacak Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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

            var result = MetroMessageBox.Show(this, "\nListedeki veriler veritabanından tekrar çekilecek.\nOnaylıyor musunuz?",
                                               "Veritabanından Veri Çek",
                                               MessageBoxButtons.YesNoCancel,
                                               MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SetData();
            }
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

        #endregion

        #region Methods

        private void SetData(bool? addToExistData = false)
        {
            incomesData = Core.database.FIBAIncome.ToList();

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

            sendDataProgressBar.Value = 0;
            lblProgressBar.Text = "Servis ile veritabanı bağlantısı kuruluyor.";

            sendDataProgressBar.Visible = lblProgressBar.Visible = true;

            if (!await GetTokenFromService())
            {
                System.Windows.Forms.MessageBox.Show("Servis ile bağlantı kurulamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                        if (dataCount > 0)
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
                                        NationalIdentityNo = incomeData != null && string.IsNullOrWhiteSpace(incomeData.NationalIdentityNo) ? incomeData.NationalIdentityNo : "",
                                        CompanyCode = incomeData != null && string.IsNullOrWhiteSpace(incomeData.CompanyCode) ? incomeData.CompanyCode : ""
                                    };

                                    sendDataProgressBar.Value = 70 + index++ * 100 / (70 + dataCount);
                                    sendDataProgressBar.Update();
                                }
                            }

                        lblProgressBar.Text = "İşlem tamamlandı!";
                        sendDataProgressBar.Value = 100;
                        sendDataProgressBar.Update();

                        //System.Windows.Forms.MessageBox.Show("Veriler Gönderildi.", "Veri Gönderimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show(this, "\nVeriler Gönderildi.", "Veri Gönderimi", MessageBoxButtons.OK, MessageBoxIcon.Information, 125);

                        sendDataProgressBar.Visible = lblProgressBar.Visible = false;

                        dataGridScannedBarcodes.Rows.Clear();
                        scannedBarcodes.Clear();

                        sentBarcodes.ForEach(x =>
                        {
                            listView1.Items.RemoveByKey(x);
                        });
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
                    Status = (int)EnumOutgoingStatus.Waiting
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

                dataGridScannedBarcodes.Rows.Clear();
                scannedBarcodes.Clear();

                waitingDataString.ForEach(x =>
                {
                    listView1.Items.RemoveByKey(x);
                });
            }
            catch (Exception)
            {

            }
        }

        private async Task GetWaitedDatasAsync()
        {
            var incomeDatas = await Core.database.FIBAIncome.Where(x => x.IsSent == false).ToListAsync();
            var outgoingDatas = await Core.database.FIBAOutgoing.Where(x => x.Status == (int)EnumOutgoingStatus.Waiting).ToListAsync();
            List<string> listedItems = new List<string>();
            dataGridScannedBarcodes.Rows.Clear();

            foreach (ListViewItem listViewItem in listView1.Items)
            {
                listedItems.Add(listViewItem.Text.ToString());
            }

            incomeDatas = incomeDatas.Where(x => !listedItems.Any(s => s == x.DocumentSerialNo)).ToList();

            foreach (var incomeData in incomeDatas)
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

                dataGridScannedBarcodes.Rows.Add(outgoingData.BarcodeCourrierArchiveNo, outgoingData.BarcodeCourrierArchiveNo, outgoingData.DocumentSerialNo, outgoingData.NationalIdentityNo, outgoingData.CompanyCode, outgoingData.IsScanned);
                scannedBarcodes.Add(outgoingData.DocumentSerialNo);

            }
        }

        #endregion

        #region Report

        private void btnReportWithFilter_Click(object sender, EventArgs e)
        {
            ReportWithFilter();
        }

        private void btnSentDataExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(dataGridScannedBarcodes, "Gönderilenler");
        }

        private void ReportWithFilter()
        {
            var predicate = PredicateBuilder.True<FIBAOutgoing>();

            if (!string.IsNullOrWhiteSpace(txtReportArchiveNo.Text))
                predicate.And(x => x.ParcelCodeArchiveNo == txtReportArchiveNo.Text);

            if (string.IsNullOrWhiteSpace(txtReportBarcode.Text))
                predicate.And(x => x.DocumentSerialNo == txtReportBarcode.Text);

            if (string.IsNullOrWhiteSpace(txtReportCourrierNo.Text))
                predicate.And(x => x.BarcodeCourrierArchiveNo == txtReportCourrierNo.Text);

            if (string.IsNullOrWhiteSpace(txtReportNationalIdNo.Text))
                predicate.And(x => x.NationalIdentityNo == txtReportNationalIdNo.Text);

            if (string.IsNullOrWhiteSpace(txtReportBatchNo.Text))
                predicate.And(x => x.BatchNumber == txtReportBatchNo.Text);

            var data = Core.database.FIBAOutgoing
                .Where(predicate)
                .ToList();
        }

        private void ExportToExcel(DataGridView dataGridView, string fileName)
        {
            Excel.Application excel = new Excel.Application();

            excel.Visible = true;

            Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);

            Excel.Worksheet sheet1 = (Excel.Worksheet)workbook.Sheets[1];

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                sheet1.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    sheet1.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = fileName;
            saveFileDialoge.DefaultExt = ".xlsx";

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
