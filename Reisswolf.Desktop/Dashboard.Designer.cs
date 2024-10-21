namespace Reisswolf.Desktop
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("DocumentSerialNo", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabMofMovements = new MetroFramework.Controls.MetroTabPage();
            this.lblRecordCount = new MetroFramework.Controls.MetroLabel();
            this.btnClearFields = new MetroFramework.Controls.MetroButton();
            this.lblProgressBar = new MetroFramework.Controls.MetroLabel();
            this.sendDataProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.btnGetSavedData = new MetroFramework.Controls.MetroButton();
            this.btnGetDataFromDb = new MetroFramework.Controls.MetroButton();
            this.btnSaveList = new MetroFramework.Controls.MetroButton();
            this.lblTotalRecordCount = new MetroFramework.Controls.MetroLabel();
            this.dataGridScannedBarcodes = new System.Windows.Forms.DataGridView();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCourrierNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtArchiveNo = new MetroFramework.Controls.MetroTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColDocumentSerialNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblBarcode = new MetroFramework.Controls.MetroLabel();
            this.txtBarcode = new MetroFramework.Controls.MetroTextBox();
            this.tabIncomeData = new MetroFramework.Controls.MetroTabPage();
            this.lblIncomeReportPage = new MetroFramework.Controls.MetroLabel();
            this.btnIncomePreviousPage = new MetroFramework.Controls.MetroButton();
            this.btnIncomeNextPage = new MetroFramework.Controls.MetroButton();
            this.lblIncomeReportTotalRecord = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.cmbIncomeSuccessStatus = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.cmbIncomeSendFlag = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.txtRprIncomeCompanyCode = new MetroFramework.Controls.MetroTextBox();
            this.chkIncludeIncomeDates = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dtIncomeEndDate = new MetroFramework.Controls.MetroDateTime();
            this.dtIncomeStartDate = new MetroFramework.Controls.MetroDateTime();
            this.btnReportIncomeData = new MetroFramework.Controls.MetroButton();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txtRprIncomeNationalIdNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.txtRprIncomeDocSerialNo = new MetroFramework.Controls.MetroTextBox();
            this.btnIncomeDataExportToExcel = new MetroFramework.Controls.MetroButton();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.dataGridIncomeReport = new System.Windows.Forms.DataGridView();
            this.CreatedByUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItWillScanFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabSentData = new MetroFramework.Controls.MetroTabPage();
            this.lblOutgoingReportTotalRecord = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txtRprOutgoingCompanyCode = new MetroFramework.Controls.MetroTextBox();
            this.chkIncludeOutDates = new MetroFramework.Controls.MetroCheckBox();
            this.dtOutGoingEndDate = new MetroFramework.Controls.MetroDateTime();
            this.dtOutGoingStartDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmbOutStatus = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnReportOutgoingData = new MetroFramework.Controls.MetroButton();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtReportBatchNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtRprOutgoingNationalIdNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtRprOutGoingDocSerialNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtReportArchiveNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btnSentDataExportToExcel = new MetroFramework.Controls.MetroButton();
            this.txtReportCourrierNo = new MetroFramework.Controls.MetroTextBox();
            this.dataGridSentReport = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScannedBarcodeCourierArchive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScannedArchiveNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScannedDocumentSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScannedNationalIdentityNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScannedCompanyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScannedItWillScanFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIBAIncomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ısScannedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.barcodeCourrierArchiveNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelCodeArchiveNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentSerialNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalIdentityNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sentTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIBAOutgoingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroTabControl1.SuspendLayout();
            this.tabMofMovements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridScannedBarcodes)).BeginInit();
            this.tabIncomeData.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIncomeReport)).BeginInit();
            this.tabSentData.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSentReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIBAIncomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIBAOutgoingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabMofMovements);
            this.metroTabControl1.Controls.Add(this.tabIncomeData);
            this.metroTabControl1.Controls.Add(this.tabSentData);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1084, 676);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabMofMovements
            // 
            this.tabMofMovements.Controls.Add(this.lblRecordCount);
            this.tabMofMovements.Controls.Add(this.btnClearFields);
            this.tabMofMovements.Controls.Add(this.lblProgressBar);
            this.tabMofMovements.Controls.Add(this.sendDataProgressBar);
            this.tabMofMovements.Controls.Add(this.btnGetSavedData);
            this.tabMofMovements.Controls.Add(this.btnGetDataFromDb);
            this.tabMofMovements.Controls.Add(this.btnSaveList);
            this.tabMofMovements.Controls.Add(this.lblTotalRecordCount);
            this.tabMofMovements.Controls.Add(this.dataGridScannedBarcodes);
            this.tabMofMovements.Controls.Add(this.btnSend);
            this.tabMofMovements.Controls.Add(this.metroLabel2);
            this.tabMofMovements.Controls.Add(this.txtCourrierNo);
            this.tabMofMovements.Controls.Add(this.metroLabel1);
            this.tabMofMovements.Controls.Add(this.txtArchiveNo);
            this.tabMofMovements.Controls.Add(this.listView1);
            this.tabMofMovements.Controls.Add(this.lblBarcode);
            this.tabMofMovements.Controls.Add(this.txtBarcode);
            this.tabMofMovements.HorizontalScrollbarBarColor = true;
            this.tabMofMovements.HorizontalScrollbarHighlightOnWheel = false;
            this.tabMofMovements.HorizontalScrollbarSize = 10;
            this.tabMofMovements.Location = new System.Drawing.Point(4, 38);
            this.tabMofMovements.Name = "tabMofMovements";
            this.tabMofMovements.Size = new System.Drawing.Size(1076, 634);
            this.tabMofMovements.TabIndex = 0;
            this.tabMofMovements.Text = "MOF İşlemleri";
            this.tabMofMovements.VerticalScrollbarBarColor = true;
            this.tabMofMovements.VerticalScrollbarHighlightOnWheel = false;
            this.tabMofMovements.VerticalScrollbarSize = 10;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblRecordCount.Location = new System.Drawing.Point(3, 561);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(145, 19);
            this.lblRecordCount.TabIndex = 20;
            this.lblRecordCount.Text = "Gösterilen Kayıt Sayısı:";
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(3, 173);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(148, 48);
            this.btnClearFields.TabIndex = 19;
            this.btnClearFields.Text = "Verileri Temizle";
            this.btnClearFields.UseSelectable = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgressBar.AutoSize = true;
            this.lblProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.lblProgressBar.Location = new System.Drawing.Point(716, 7);
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(94, 19);
            this.lblProgressBar.TabIndex = 18;
            this.lblProgressBar.Text = "lblProgressBar";
            this.lblProgressBar.UseCustomBackColor = true;
            this.lblProgressBar.Visible = false;
            // 
            // sendDataProgressBar
            // 
            this.sendDataProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendDataProgressBar.Location = new System.Drawing.Point(527, 5);
            this.sendDataProgressBar.Name = "sendDataProgressBar";
            this.sendDataProgressBar.Size = new System.Drawing.Size(183, 23);
            this.sendDataProgressBar.Style = MetroFramework.MetroColorStyle.Green;
            this.sendDataProgressBar.TabIndex = 1;
            this.sendDataProgressBar.Visible = false;
            // 
            // btnGetSavedData
            // 
            this.btnGetSavedData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetSavedData.Location = new System.Drawing.Point(3, 583);
            this.btnGetSavedData.Name = "btnGetSavedData";
            this.btnGetSavedData.Size = new System.Drawing.Size(148, 48);
            this.btnGetSavedData.TabIndex = 17;
            this.btnGetSavedData.Text = "Bekleyenleri Getir";
            this.btnGetSavedData.UseSelectable = true;
            this.btnGetSavedData.Click += new System.EventHandler(this.btnGetSavedData_Click);
            // 
            // btnGetDataFromDb
            // 
            this.btnGetDataFromDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetDataFromDb.Location = new System.Drawing.Point(161, 583);
            this.btnGetDataFromDb.Name = "btnGetDataFromDb";
            this.btnGetDataFromDb.Size = new System.Drawing.Size(148, 48);
            this.btnGetDataFromDb.TabIndex = 16;
            this.btnGetDataFromDb.Text = "Veritabanından Veri Çek";
            this.btnGetDataFromDb.UseSelectable = true;
            this.btnGetDataFromDb.Click += new System.EventHandler(this.btnGetDataFromDb_Click);
            // 
            // btnSaveList
            // 
            this.btnSaveList.Location = new System.Drawing.Point(3, 119);
            this.btnSaveList.Name = "btnSaveList";
            this.btnSaveList.Size = new System.Drawing.Size(148, 48);
            this.btnSaveList.TabIndex = 5;
            this.btnSaveList.Text = "Listeyi Kaydet";
            this.btnSaveList.UseSelectable = true;
            this.btnSaveList.Click += new System.EventHandler(this.btnSaveList_ClickAsync);
            // 
            // lblTotalRecordCount
            // 
            this.lblTotalRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalRecordCount.AutoSize = true;
            this.lblTotalRecordCount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTotalRecordCount.Location = new System.Drawing.Point(3, 542);
            this.lblTotalRecordCount.Name = "lblTotalRecordCount";
            this.lblTotalRecordCount.Size = new System.Drawing.Size(127, 19);
            this.lblTotalRecordCount.TabIndex = 15;
            this.lblTotalRecordCount.Text = "Toplam Kayıt Sayısı:";
            // 
            // dataGridScannedBarcodes
            // 
            this.dataGridScannedBarcodes.AllowUserToAddRows = false;
            this.dataGridScannedBarcodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridScannedBarcodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridScannedBarcodes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScannedBarcodeCourierArchive,
            this.ScannedArchiveNo,
            this.ScannedDocumentSerialNo,
            this.ScannedNationalIdentityNo,
            this.ScannedCompanyCode,
            this.ScannedItWillScanFlag});
            this.dataGridScannedBarcodes.Location = new System.Drawing.Point(527, 32);
            this.dataGridScannedBarcodes.Name = "dataGridScannedBarcodes";
            this.dataGridScannedBarcodes.ReadOnly = true;
            this.dataGridScannedBarcodes.Size = new System.Drawing.Size(546, 599);
            this.dataGridScannedBarcodes.TabIndex = 7;
            this.dataGridScannedBarcodes.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridScannedBarcodes_RowsAdded);
            this.dataGridScannedBarcodes.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridScannedBarcodes_RowsRemoved);
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(161, 119);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(148, 48);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Gönder";
            this.btnSend.UseSelectable = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "MOF Barkodu";
            // 
            // txtCourrierNo
            // 
            // 
            // 
            // 
            this.txtCourrierNo.CustomButton.Image = null;
            this.txtCourrierNo.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txtCourrierNo.CustomButton.Name = "";
            this.txtCourrierNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCourrierNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCourrierNo.CustomButton.TabIndex = 1;
            this.txtCourrierNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCourrierNo.CustomButton.UseSelectable = true;
            this.txtCourrierNo.CustomButton.Visible = false;
            this.txtCourrierNo.Lines = new string[0];
            this.txtCourrierNo.Location = new System.Drawing.Point(161, 32);
            this.txtCourrierNo.MaxLength = 32767;
            this.txtCourrierNo.Name = "txtCourrierNo";
            this.txtCourrierNo.PasswordChar = '\0';
            this.txtCourrierNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCourrierNo.SelectedText = "";
            this.txtCourrierNo.SelectionLength = 0;
            this.txtCourrierNo.SelectionStart = 0;
            this.txtCourrierNo.ShortcutsEnabled = true;
            this.txtCourrierNo.Size = new System.Drawing.Size(148, 23);
            this.txtCourrierNo.TabIndex = 0;
            this.txtCourrierNo.UseSelectable = true;
            this.txtCourrierNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCourrierNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCourrierNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCourrierNo_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 61);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Arşiv Koli No";
            // 
            // txtArchiveNo
            // 
            // 
            // 
            // 
            this.txtArchiveNo.CustomButton.Image = null;
            this.txtArchiveNo.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txtArchiveNo.CustomButton.Name = "";
            this.txtArchiveNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtArchiveNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtArchiveNo.CustomButton.TabIndex = 1;
            this.txtArchiveNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtArchiveNo.CustomButton.UseSelectable = true;
            this.txtArchiveNo.CustomButton.Visible = false;
            this.txtArchiveNo.Lines = new string[0];
            this.txtArchiveNo.Location = new System.Drawing.Point(161, 61);
            this.txtArchiveNo.MaxLength = 12;
            this.txtArchiveNo.Name = "txtArchiveNo";
            this.txtArchiveNo.PasswordChar = '\0';
            this.txtArchiveNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtArchiveNo.SelectedText = "";
            this.txtArchiveNo.SelectionLength = 0;
            this.txtArchiveNo.SelectionStart = 0;
            this.txtArchiveNo.ShortcutsEnabled = true;
            this.txtArchiveNo.Size = new System.Drawing.Size(148, 23);
            this.txtArchiveNo.TabIndex = 1;
            this.txtArchiveNo.UseSelectable = true;
            this.txtArchiveNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtArchiveNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtArchiveNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArchiveNo_KeyPress);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColDocumentSerialNo});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            listViewGroup2.Header = "DocumentSerialNo";
            listViewGroup2.Name = "MOFS";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(315, 32);
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(206, 599);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ColDocumentSerialNo
            // 
            this.ColDocumentSerialNo.Text = "MOF Barkod";
            this.ColDocumentSerialNo.Width = 162;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(3, 32);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(110, 19);
            this.lblBarcode.TabIndex = 8;
            this.lblBarcode.Text = "Kurye Barkod No";
            // 
            // txtBarcode
            // 
            // 
            // 
            // 
            this.txtBarcode.CustomButton.Image = null;
            this.txtBarcode.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txtBarcode.CustomButton.Name = "";
            this.txtBarcode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBarcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBarcode.CustomButton.TabIndex = 1;
            this.txtBarcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBarcode.CustomButton.UseSelectable = true;
            this.txtBarcode.CustomButton.Visible = false;
            this.txtBarcode.Lines = new string[0];
            this.txtBarcode.Location = new System.Drawing.Point(161, 90);
            this.txtBarcode.MaxLength = 32767;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PasswordChar = '\0';
            this.txtBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBarcode.SelectedText = "";
            this.txtBarcode.SelectionLength = 0;
            this.txtBarcode.SelectionStart = 0;
            this.txtBarcode.ShortcutsEnabled = true;
            this.txtBarcode.Size = new System.Drawing.Size(148, 23);
            this.txtBarcode.TabIndex = 3;
            this.txtBarcode.UseSelectable = true;
            this.txtBarcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBarcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // tabIncomeData
            // 
            this.tabIncomeData.Controls.Add(this.lblIncomeReportPage);
            this.tabIncomeData.Controls.Add(this.btnIncomePreviousPage);
            this.tabIncomeData.Controls.Add(this.btnIncomeNextPage);
            this.tabIncomeData.Controls.Add(this.lblIncomeReportTotalRecord);
            this.tabIncomeData.Controls.Add(this.metroPanel2);
            this.tabIncomeData.Controls.Add(this.dataGridIncomeReport);
            this.tabIncomeData.HorizontalScrollbarBarColor = true;
            this.tabIncomeData.HorizontalScrollbarHighlightOnWheel = false;
            this.tabIncomeData.HorizontalScrollbarSize = 10;
            this.tabIncomeData.Location = new System.Drawing.Point(4, 38);
            this.tabIncomeData.Name = "tabIncomeData";
            this.tabIncomeData.Size = new System.Drawing.Size(1076, 634);
            this.tabIncomeData.TabIndex = 2;
            this.tabIncomeData.Text = "Gelenler";
            this.tabIncomeData.VerticalScrollbarBarColor = true;
            this.tabIncomeData.VerticalScrollbarHighlightOnWheel = false;
            this.tabIncomeData.VerticalScrollbarSize = 10;
            this.tabIncomeData.Enter += new System.EventHandler(this.tabIncomeData_Enter);
            // 
            // lblIncomeReportPage
            // 
            this.lblIncomeReportPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIncomeReportPage.AutoSize = true;
            this.lblIncomeReportPage.Location = new System.Drawing.Point(915, 103);
            this.lblIncomeReportPage.Name = "lblIncomeReportPage";
            this.lblIncomeReportPage.Size = new System.Drawing.Size(43, 19);
            this.lblIncomeReportPage.TabIndex = 28;
            this.lblIncomeReportPage.Text = "Sayfa:";
            // 
            // btnIncomePreviousPage
            // 
            this.btnIncomePreviousPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncomePreviousPage.BackgroundImage = global::Reisswolf.Desktop.Properties.Resources.Actions_go_previous_icon;
            this.btnIncomePreviousPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIncomePreviousPage.Location = new System.Drawing.Point(1015, 102);
            this.btnIncomePreviousPage.MaximumSize = new System.Drawing.Size(25, 20);
            this.btnIncomePreviousPage.Name = "btnIncomePreviousPage";
            this.btnIncomePreviousPage.Size = new System.Drawing.Size(25, 20);
            this.btnIncomePreviousPage.TabIndex = 27;
            this.btnIncomePreviousPage.UseSelectable = true;
            this.btnIncomePreviousPage.Click += new System.EventHandler(this.btnIncomePreviousPage_Click);
            // 
            // btnIncomeNextPage
            // 
            this.btnIncomeNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncomeNextPage.BackgroundImage = global::Reisswolf.Desktop.Properties.Resources.Actions_go_next_icon;
            this.btnIncomeNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIncomeNextPage.Location = new System.Drawing.Point(1045, 102);
            this.btnIncomeNextPage.MaximumSize = new System.Drawing.Size(25, 20);
            this.btnIncomeNextPage.Name = "btnIncomeNextPage";
            this.btnIncomeNextPage.Size = new System.Drawing.Size(25, 20);
            this.btnIncomeNextPage.TabIndex = 26;
            this.btnIncomeNextPage.UseSelectable = true;
            this.btnIncomeNextPage.Click += new System.EventHandler(this.btnIncomeNextPage_Click);
            // 
            // lblIncomeReportTotalRecord
            // 
            this.lblIncomeReportTotalRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIncomeReportTotalRecord.AutoSize = true;
            this.lblIncomeReportTotalRecord.Location = new System.Drawing.Point(0, 103);
            this.lblIncomeReportTotalRecord.Name = "lblIncomeReportTotalRecord";
            this.lblIncomeReportTotalRecord.Size = new System.Drawing.Size(121, 19);
            this.lblIncomeReportTotalRecord.TabIndex = 16;
            this.lblIncomeReportTotalRecord.Text = "Toplam Kayıt Sayısı:";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.Controls.Add(this.cmbIncomeSuccessStatus);
            this.metroPanel2.Controls.Add(this.metroLabel18);
            this.metroPanel2.Controls.Add(this.cmbIncomeSendFlag);
            this.metroPanel2.Controls.Add(this.metroLabel17);
            this.metroPanel2.Controls.Add(this.txtRprIncomeCompanyCode);
            this.metroPanel2.Controls.Add(this.chkIncludeIncomeDates);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.dtIncomeEndDate);
            this.metroPanel2.Controls.Add(this.dtIncomeStartDate);
            this.metroPanel2.Controls.Add(this.btnReportIncomeData);
            this.metroPanel2.Controls.Add(this.metroLabel15);
            this.metroPanel2.Controls.Add(this.txtRprIncomeNationalIdNo);
            this.metroPanel2.Controls.Add(this.metroLabel16);
            this.metroPanel2.Controls.Add(this.txtRprIncomeDocSerialNo);
            this.metroPanel2.Controls.Add(this.btnIncomeDataExportToExcel);
            this.metroPanel2.Controls.Add(this.metroLabel14);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1073, 97);
            this.metroPanel2.TabIndex = 15;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // cmbIncomeSuccessStatus
            // 
            this.cmbIncomeSuccessStatus.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbIncomeSuccessStatus.FormattingEnabled = true;
            this.cmbIncomeSuccessStatus.ItemHeight = 19;
            this.cmbIncomeSuccessStatus.Items.AddRange(new object[] {
            "Hepsi",
            "Başarılı",
            "Başarısız"});
            this.cmbIncomeSuccessStatus.Location = new System.Drawing.Point(349, 32);
            this.cmbIncomeSuccessStatus.Name = "cmbIncomeSuccessStatus";
            this.cmbIncomeSuccessStatus.Size = new System.Drawing.Size(126, 25);
            this.cmbIncomeSuccessStatus.TabIndex = 40;
            this.cmbIncomeSuccessStatus.UseSelectable = true;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(251, 32);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(95, 19);
            this.metroLabel18.TabIndex = 39;
            this.metroLabel18.Text = "Başarı Durumu";
            // 
            // cmbIncomeSendFlag
            // 
            this.cmbIncomeSendFlag.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbIncomeSendFlag.FormattingEnabled = true;
            this.cmbIncomeSendFlag.ItemHeight = 19;
            this.cmbIncomeSendFlag.Items.AddRange(new object[] {
            "Hepsi",
            "Gönderilen",
            "Gönderilmeyen"});
            this.cmbIncomeSendFlag.Location = new System.Drawing.Point(617, 3);
            this.cmbIncomeSendFlag.Name = "cmbIncomeSendFlag";
            this.cmbIncomeSendFlag.Size = new System.Drawing.Size(126, 25);
            this.cmbIncomeSendFlag.TabIndex = 38;
            this.cmbIncomeSendFlag.UseSelectable = true;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(482, 3);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(129, 19);
            this.metroLabel17.TabIndex = 37;
            this.metroLabel17.Text = "Gönderilme Durumu";
            // 
            // txtRprIncomeCompanyCode
            // 
            // 
            // 
            // 
            this.txtRprIncomeCompanyCode.CustomButton.Image = null;
            this.txtRprIncomeCompanyCode.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtRprIncomeCompanyCode.CustomButton.Name = "";
            this.txtRprIncomeCompanyCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRprIncomeCompanyCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRprIncomeCompanyCode.CustomButton.TabIndex = 1;
            this.txtRprIncomeCompanyCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRprIncomeCompanyCode.CustomButton.UseSelectable = true;
            this.txtRprIncomeCompanyCode.CustomButton.Visible = false;
            this.txtRprIncomeCompanyCode.Lines = new string[0];
            this.txtRprIncomeCompanyCode.Location = new System.Drawing.Point(349, 3);
            this.txtRprIncomeCompanyCode.MaxLength = 32767;
            this.txtRprIncomeCompanyCode.Name = "txtRprIncomeCompanyCode";
            this.txtRprIncomeCompanyCode.PasswordChar = '\0';
            this.txtRprIncomeCompanyCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRprIncomeCompanyCode.SelectedText = "";
            this.txtRprIncomeCompanyCode.SelectionLength = 0;
            this.txtRprIncomeCompanyCode.SelectionStart = 0;
            this.txtRprIncomeCompanyCode.ShortcutsEnabled = true;
            this.txtRprIncomeCompanyCode.Size = new System.Drawing.Size(126, 23);
            this.txtRprIncomeCompanyCode.TabIndex = 35;
            this.txtRprIncomeCompanyCode.UseSelectable = true;
            this.txtRprIncomeCompanyCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRprIncomeCompanyCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkIncludeIncomeDates
            // 
            this.chkIncludeIncomeDates.AutoSize = true;
            this.chkIncludeIncomeDates.Location = new System.Drawing.Point(481, 68);
            this.chkIncludeIncomeDates.Name = "chkIncludeIncomeDates";
            this.chkIncludeIncomeDates.Size = new System.Drawing.Size(148, 15);
            this.chkIncludeIncomeDates.TabIndex = 34;
            this.chkIncludeIncomeDates.Text = "Tarihleri Filtreye Dahil Et";
            this.chkIncludeIncomeDates.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 64);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(104, 19);
            this.metroLabel5.TabIndex = 31;
            this.metroLabel5.Text = "Oluşturma Tarihi";
            // 
            // dtIncomeEndDate
            // 
            this.dtIncomeEndDate.CustomFormat = "dd-MM-yyyy HH:mm";
            this.dtIncomeEndDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtIncomeEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtIncomeEndDate.Location = new System.Drawing.Point(298, 62);
            this.dtIncomeEndDate.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dtIncomeEndDate.MinDate = new System.DateTime(2009, 12, 31, 0, 0, 0, 0);
            this.dtIncomeEndDate.MinimumSize = new System.Drawing.Size(4, 25);
            this.dtIncomeEndDate.Name = "dtIncomeEndDate";
            this.dtIncomeEndDate.Size = new System.Drawing.Size(177, 25);
            this.dtIncomeEndDate.TabIndex = 29;
            this.dtIncomeEndDate.Value = new System.DateTime(2023, 4, 21, 0, 0, 0, 0);
            // 
            // dtIncomeStartDate
            // 
            this.dtIncomeStartDate.CustomFormat = "dd-MM-yyyy HH:mm";
            this.dtIncomeStartDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtIncomeStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtIncomeStartDate.Location = new System.Drawing.Point(119, 62);
            this.dtIncomeStartDate.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dtIncomeStartDate.MinDate = new System.DateTime(2009, 12, 31, 0, 0, 0, 0);
            this.dtIncomeStartDate.MinimumSize = new System.Drawing.Size(4, 25);
            this.dtIncomeStartDate.Name = "dtIncomeStartDate";
            this.dtIncomeStartDate.Size = new System.Drawing.Size(173, 25);
            this.dtIncomeStartDate.TabIndex = 28;
            this.dtIncomeStartDate.Value = new System.DateTime(2023, 4, 21, 0, 0, 0, 0);
            // 
            // btnReportIncomeData
            // 
            this.btnReportIncomeData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportIncomeData.Location = new System.Drawing.Point(754, 3);
            this.btnReportIncomeData.Name = "btnReportIncomeData";
            this.btnReportIncomeData.Size = new System.Drawing.Size(155, 48);
            this.btnReportIncomeData.TabIndex = 25;
            this.btnReportIncomeData.Text = "Filtrele";
            this.btnReportIncomeData.UseSelectable = true;
            this.btnReportIncomeData.Click += new System.EventHandler(this.btnReportIncomeData_Click);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(3, 32);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(41, 19);
            this.metroLabel15.TabIndex = 22;
            this.metroLabel15.Text = "TCKN";
            // 
            // txtRprIncomeNationalIdNo
            // 
            // 
            // 
            // 
            this.txtRprIncomeNationalIdNo.CustomButton.Image = null;
            this.txtRprIncomeNationalIdNo.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtRprIncomeNationalIdNo.CustomButton.Name = "";
            this.txtRprIncomeNationalIdNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRprIncomeNationalIdNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRprIncomeNationalIdNo.CustomButton.TabIndex = 1;
            this.txtRprIncomeNationalIdNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRprIncomeNationalIdNo.CustomButton.UseSelectable = true;
            this.txtRprIncomeNationalIdNo.CustomButton.Visible = false;
            this.txtRprIncomeNationalIdNo.Lines = new string[0];
            this.txtRprIncomeNationalIdNo.Location = new System.Drawing.Point(119, 32);
            this.txtRprIncomeNationalIdNo.MaxLength = 32767;
            this.txtRprIncomeNationalIdNo.Name = "txtRprIncomeNationalIdNo";
            this.txtRprIncomeNationalIdNo.PasswordChar = '\0';
            this.txtRprIncomeNationalIdNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRprIncomeNationalIdNo.SelectedText = "";
            this.txtRprIncomeNationalIdNo.SelectionLength = 0;
            this.txtRprIncomeNationalIdNo.SelectionStart = 0;
            this.txtRprIncomeNationalIdNo.ShortcutsEnabled = true;
            this.txtRprIncomeNationalIdNo.Size = new System.Drawing.Size(126, 23);
            this.txtRprIncomeNationalIdNo.TabIndex = 21;
            this.txtRprIncomeNationalIdNo.UseSelectable = true;
            this.txtRprIncomeNationalIdNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRprIncomeNationalIdNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(3, 3);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(92, 19);
            this.metroLabel16.TabIndex = 20;
            this.metroLabel16.Text = "MOF Barkodu";
            // 
            // txtRprIncomeDocSerialNo
            // 
            // 
            // 
            // 
            this.txtRprIncomeDocSerialNo.CustomButton.Image = null;
            this.txtRprIncomeDocSerialNo.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtRprIncomeDocSerialNo.CustomButton.Name = "";
            this.txtRprIncomeDocSerialNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRprIncomeDocSerialNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRprIncomeDocSerialNo.CustomButton.TabIndex = 1;
            this.txtRprIncomeDocSerialNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRprIncomeDocSerialNo.CustomButton.UseSelectable = true;
            this.txtRprIncomeDocSerialNo.CustomButton.Visible = false;
            this.txtRprIncomeDocSerialNo.Lines = new string[0];
            this.txtRprIncomeDocSerialNo.Location = new System.Drawing.Point(119, 3);
            this.txtRprIncomeDocSerialNo.MaxLength = 32767;
            this.txtRprIncomeDocSerialNo.Name = "txtRprIncomeDocSerialNo";
            this.txtRprIncomeDocSerialNo.PasswordChar = '\0';
            this.txtRprIncomeDocSerialNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRprIncomeDocSerialNo.SelectedText = "";
            this.txtRprIncomeDocSerialNo.SelectionLength = 0;
            this.txtRprIncomeDocSerialNo.SelectionStart = 0;
            this.txtRprIncomeDocSerialNo.ShortcutsEnabled = true;
            this.txtRprIncomeDocSerialNo.Size = new System.Drawing.Size(126, 23);
            this.txtRprIncomeDocSerialNo.TabIndex = 19;
            this.txtRprIncomeDocSerialNo.UseSelectable = true;
            this.txtRprIncomeDocSerialNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRprIncomeDocSerialNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnIncomeDataExportToExcel
            // 
            this.btnIncomeDataExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncomeDataExportToExcel.Location = new System.Drawing.Point(915, 3);
            this.btnIncomeDataExportToExcel.Name = "btnIncomeDataExportToExcel";
            this.btnIncomeDataExportToExcel.Size = new System.Drawing.Size(155, 48);
            this.btnIncomeDataExportToExcel.TabIndex = 12;
            this.btnIncomeDataExportToExcel.Text = "Excel\'e Çıkart";
            this.btnIncomeDataExportToExcel.UseSelectable = true;
            this.btnIncomeDataExportToExcel.Click += new System.EventHandler(this.btnIncomeDataExportToExcel_Click);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(251, 3);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(102, 19);
            this.metroLabel14.TabIndex = 36;
            this.metroLabel14.Text = "Company Code";
            // 
            // dataGridIncomeReport
            // 
            this.dataGridIncomeReport.AllowUserToAddRows = false;
            this.dataGridIncomeReport.AllowUserToDeleteRows = false;
            this.dataGridIncomeReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridIncomeReport.AutoGenerateColumns = false;
            this.dataGridIncomeReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIncomeReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.CreatedByUser,
            this.CreatedDate,
            this.ModifiedUserName,
            this.ModifyDate,
            this.ItWillScanFlag});
            this.dataGridIncomeReport.DataSource = this.fIBAIncomeBindingSource;
            this.dataGridIncomeReport.Location = new System.Drawing.Point(0, 125);
            this.dataGridIncomeReport.Name = "dataGridIncomeReport";
            this.dataGridIncomeReport.ReadOnly = true;
            this.dataGridIncomeReport.Size = new System.Drawing.Size(1073, 518);
            this.dataGridIncomeReport.TabIndex = 14;
            // 
            // CreatedByUser
            // 
            this.CreatedByUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CreatedByUser.DataPropertyName = "CreatedUserName";
            this.CreatedByUser.HeaderText = "Oluşturan Kullanıcı";
            this.CreatedByUser.Name = "CreatedByUser";
            this.CreatedByUser.ReadOnly = true;
            // 
            // CreatedDate
            // 
            this.CreatedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CreatedDate.DataPropertyName = "CreatedDate";
            this.CreatedDate.HeaderText = "Oluşturma Tarihi";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            // 
            // ModifiedUserName
            // 
            this.ModifiedUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModifiedUserName.DataPropertyName = "ModifiedUserName";
            this.ModifiedUserName.HeaderText = "Düzenleyen Kullanıcı";
            this.ModifiedUserName.Name = "ModifiedUserName";
            this.ModifiedUserName.ReadOnly = true;
            // 
            // ModifyDate
            // 
            this.ModifyDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModifyDate.DataPropertyName = "ModifyDate";
            this.ModifyDate.HeaderText = "Düzenleme Tarihi";
            this.ModifyDate.Name = "ModifyDate";
            this.ModifyDate.ReadOnly = true;
            // 
            // ItWillScanFlag
            // 
            this.ItWillScanFlag.DataPropertyName = "ItWillScanFlag";
            this.ItWillScanFlag.HeaderText = "Taranacak";
            this.ItWillScanFlag.Name = "ItWillScanFlag";
            this.ItWillScanFlag.ReadOnly = true;
            // 
            // tabSentData
            // 
            this.tabSentData.Controls.Add(this.lblOutgoingReportTotalRecord);
            this.tabSentData.Controls.Add(this.metroPanel1);
            this.tabSentData.Controls.Add(this.dataGridSentReport);
            this.tabSentData.HorizontalScrollbarBarColor = true;
            this.tabSentData.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSentData.HorizontalScrollbarSize = 10;
            this.tabSentData.Location = new System.Drawing.Point(4, 38);
            this.tabSentData.Name = "tabSentData";
            this.tabSentData.Size = new System.Drawing.Size(1076, 634);
            this.tabSentData.TabIndex = 1;
            this.tabSentData.Text = "Gönderilenler";
            this.tabSentData.VerticalScrollbarBarColor = true;
            this.tabSentData.VerticalScrollbarHighlightOnWheel = false;
            this.tabSentData.VerticalScrollbarSize = 10;
            // 
            // lblOutgoingReportTotalRecord
            // 
            this.lblOutgoingReportTotalRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutgoingReportTotalRecord.AutoSize = true;
            this.lblOutgoingReportTotalRecord.Location = new System.Drawing.Point(0, 103);
            this.lblOutgoingReportTotalRecord.Name = "lblOutgoingReportTotalRecord";
            this.lblOutgoingReportTotalRecord.Size = new System.Drawing.Size(121, 19);
            this.lblOutgoingReportTotalRecord.TabIndex = 17;
            this.lblOutgoingReportTotalRecord.Text = "Toplam Kayıt Sayısı:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.metroLabel13);
            this.metroPanel1.Controls.Add(this.txtRprOutgoingCompanyCode);
            this.metroPanel1.Controls.Add(this.chkIncludeOutDates);
            this.metroPanel1.Controls.Add(this.dtOutGoingEndDate);
            this.metroPanel1.Controls.Add(this.dtOutGoingStartDate);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.cmbOutStatus);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.btnReportOutgoingData);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.txtReportBatchNo);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.txtRprOutgoingNationalIdNo);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.txtRprOutGoingDocSerialNo);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.txtReportArchiveNo);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.btnSentDataExportToExcel);
            this.metroPanel1.Controls.Add(this.txtReportCourrierNo);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1073, 97);
            this.metroPanel1.TabIndex = 13;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(3, 61);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(102, 19);
            this.metroLabel13.TabIndex = 35;
            this.metroLabel13.Text = "Company Code";
            // 
            // txtRprOutgoingCompanyCode
            // 
            // 
            // 
            // 
            this.txtRprOutgoingCompanyCode.CustomButton.Image = null;
            this.txtRprOutgoingCompanyCode.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtRprOutgoingCompanyCode.CustomButton.Name = "";
            this.txtRprOutgoingCompanyCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRprOutgoingCompanyCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRprOutgoingCompanyCode.CustomButton.TabIndex = 1;
            this.txtRprOutgoingCompanyCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRprOutgoingCompanyCode.CustomButton.UseSelectable = true;
            this.txtRprOutgoingCompanyCode.CustomButton.Visible = false;
            this.txtRprOutgoingCompanyCode.Lines = new string[0];
            this.txtRprOutgoingCompanyCode.Location = new System.Drawing.Point(119, 61);
            this.txtRprOutgoingCompanyCode.MaxLength = 32767;
            this.txtRprOutgoingCompanyCode.Name = "txtRprOutgoingCompanyCode";
            this.txtRprOutgoingCompanyCode.PasswordChar = '\0';
            this.txtRprOutgoingCompanyCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRprOutgoingCompanyCode.SelectedText = "";
            this.txtRprOutgoingCompanyCode.SelectionLength = 0;
            this.txtRprOutgoingCompanyCode.SelectionStart = 0;
            this.txtRprOutgoingCompanyCode.ShortcutsEnabled = true;
            this.txtRprOutgoingCompanyCode.Size = new System.Drawing.Size(126, 23);
            this.txtRprOutgoingCompanyCode.TabIndex = 34;
            this.txtRprOutgoingCompanyCode.UseSelectable = true;
            this.txtRprOutgoingCompanyCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRprOutgoingCompanyCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkIncludeOutDates
            // 
            this.chkIncludeOutDates.AutoSize = true;
            this.chkIncludeOutDates.Location = new System.Drawing.Point(719, 65);
            this.chkIncludeOutDates.Name = "chkIncludeOutDates";
            this.chkIncludeOutDates.Size = new System.Drawing.Size(148, 15);
            this.chkIncludeOutDates.TabIndex = 33;
            this.chkIncludeOutDates.Text = "Tarihleri Filtreye Dahil Et";
            this.chkIncludeOutDates.UseSelectable = true;
            // 
            // dtOutGoingEndDate
            // 
            this.dtOutGoingEndDate.CustomFormat = "dd-MM-yyyy HH:mm";
            this.dtOutGoingEndDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtOutGoingEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOutGoingEndDate.Location = new System.Drawing.Point(540, 61);
            this.dtOutGoingEndDate.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dtOutGoingEndDate.MinDate = new System.DateTime(2009, 12, 31, 0, 0, 0, 0);
            this.dtOutGoingEndDate.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtOutGoingEndDate.Name = "dtOutGoingEndDate";
            this.dtOutGoingEndDate.Size = new System.Drawing.Size(173, 25);
            this.dtOutGoingEndDate.TabIndex = 32;
            this.dtOutGoingEndDate.Value = new System.DateTime(2023, 4, 21, 0, 0, 0, 0);
            // 
            // dtOutGoingStartDate
            // 
            this.dtOutGoingStartDate.CustomFormat = "dd-MM-yyyy HH:mm";
            this.dtOutGoingStartDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtOutGoingStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOutGoingStartDate.Location = new System.Drawing.Point(361, 61);
            this.dtOutGoingStartDate.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dtOutGoingStartDate.MinDate = new System.DateTime(2009, 12, 31, 0, 0, 0, 0);
            this.dtOutGoingStartDate.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtOutGoingStartDate.Name = "dtOutGoingStartDate";
            this.dtOutGoingStartDate.Size = new System.Drawing.Size(173, 25);
            this.dtOutGoingStartDate.TabIndex = 31;
            this.dtOutGoingStartDate.Value = new System.DateTime(2023, 4, 21, 0, 0, 0, 0);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(251, 61);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(104, 19);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "Oluşturma Tarihi";
            // 
            // cmbOutStatus
            // 
            this.cmbOutStatus.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbOutStatus.FormattingEnabled = true;
            this.cmbOutStatus.ItemHeight = 19;
            this.cmbOutStatus.Items.AddRange(new object[] {
            "Hepsi",
            "Bekleyen",
            "Gönderilen"});
            this.cmbOutStatus.Location = new System.Drawing.Point(577, 32);
            this.cmbOutStatus.Name = "cmbOutStatus";
            this.cmbOutStatus.Size = new System.Drawing.Size(126, 25);
            this.cmbOutStatus.TabIndex = 27;
            this.cmbOutStatus.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(493, 32);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Durum";
            // 
            // btnReportOutgoingData
            // 
            this.btnReportOutgoingData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportOutgoingData.Location = new System.Drawing.Point(754, 3);
            this.btnReportOutgoingData.Name = "btnReportOutgoingData";
            this.btnReportOutgoingData.Size = new System.Drawing.Size(155, 48);
            this.btnReportOutgoingData.TabIndex = 25;
            this.btnReportOutgoingData.Text = "Filtrele";
            this.btnReportOutgoingData.UseSelectable = true;
            this.btnReportOutgoingData.Click += new System.EventHandler(this.btnReportOutgoingData_Click);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(493, 3);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(78, 19);
            this.metroLabel12.TabIndex = 24;
            this.metroLabel12.Text = "Gönderi No";
            // 
            // txtReportBatchNo
            // 
            // 
            // 
            // 
            this.txtReportBatchNo.CustomButton.Image = null;
            this.txtReportBatchNo.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtReportBatchNo.CustomButton.Name = "";
            this.txtReportBatchNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtReportBatchNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReportBatchNo.CustomButton.TabIndex = 1;
            this.txtReportBatchNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReportBatchNo.CustomButton.UseSelectable = true;
            this.txtReportBatchNo.CustomButton.Visible = false;
            this.txtReportBatchNo.Lines = new string[0];
            this.txtReportBatchNo.Location = new System.Drawing.Point(577, 3);
            this.txtReportBatchNo.MaxLength = 32767;
            this.txtReportBatchNo.Name = "txtReportBatchNo";
            this.txtReportBatchNo.PasswordChar = '\0';
            this.txtReportBatchNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReportBatchNo.SelectedText = "";
            this.txtReportBatchNo.SelectionLength = 0;
            this.txtReportBatchNo.SelectionStart = 0;
            this.txtReportBatchNo.ShortcutsEnabled = true;
            this.txtReportBatchNo.Size = new System.Drawing.Size(126, 23);
            this.txtReportBatchNo.TabIndex = 23;
            this.txtReportBatchNo.UseSelectable = true;
            this.txtReportBatchNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReportBatchNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(251, 32);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(41, 19);
            this.metroLabel10.TabIndex = 22;
            this.metroLabel10.Text = "TCKN";
            // 
            // txtRprOutgoingNationalIdNo
            // 
            // 
            // 
            // 
            this.txtRprOutgoingNationalIdNo.CustomButton.Image = null;
            this.txtRprOutgoingNationalIdNo.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtRprOutgoingNationalIdNo.CustomButton.Name = "";
            this.txtRprOutgoingNationalIdNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRprOutgoingNationalIdNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRprOutgoingNationalIdNo.CustomButton.TabIndex = 1;
            this.txtRprOutgoingNationalIdNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRprOutgoingNationalIdNo.CustomButton.UseSelectable = true;
            this.txtRprOutgoingNationalIdNo.CustomButton.Visible = false;
            this.txtRprOutgoingNationalIdNo.Lines = new string[0];
            this.txtRprOutgoingNationalIdNo.Location = new System.Drawing.Point(361, 32);
            this.txtRprOutgoingNationalIdNo.MaxLength = 32767;
            this.txtRprOutgoingNationalIdNo.Name = "txtRprOutgoingNationalIdNo";
            this.txtRprOutgoingNationalIdNo.PasswordChar = '\0';
            this.txtRprOutgoingNationalIdNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRprOutgoingNationalIdNo.SelectedText = "";
            this.txtRprOutgoingNationalIdNo.SelectionLength = 0;
            this.txtRprOutgoingNationalIdNo.SelectionStart = 0;
            this.txtRprOutgoingNationalIdNo.ShortcutsEnabled = true;
            this.txtRprOutgoingNationalIdNo.Size = new System.Drawing.Size(126, 23);
            this.txtRprOutgoingNationalIdNo.TabIndex = 21;
            this.txtRprOutgoingNationalIdNo.UseSelectable = true;
            this.txtRprOutgoingNationalIdNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRprOutgoingNationalIdNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(251, 3);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(92, 19);
            this.metroLabel11.TabIndex = 20;
            this.metroLabel11.Text = "MOF Barkodu";
            // 
            // txtRprOutGoingDocSerialNo
            // 
            // 
            // 
            // 
            this.txtRprOutGoingDocSerialNo.CustomButton.Image = null;
            this.txtRprOutGoingDocSerialNo.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtRprOutGoingDocSerialNo.CustomButton.Name = "";
            this.txtRprOutGoingDocSerialNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRprOutGoingDocSerialNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRprOutGoingDocSerialNo.CustomButton.TabIndex = 1;
            this.txtRprOutGoingDocSerialNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRprOutGoingDocSerialNo.CustomButton.UseSelectable = true;
            this.txtRprOutGoingDocSerialNo.CustomButton.Visible = false;
            this.txtRprOutGoingDocSerialNo.Lines = new string[0];
            this.txtRprOutGoingDocSerialNo.Location = new System.Drawing.Point(361, 3);
            this.txtRprOutGoingDocSerialNo.MaxLength = 32767;
            this.txtRprOutGoingDocSerialNo.Name = "txtRprOutGoingDocSerialNo";
            this.txtRprOutGoingDocSerialNo.PasswordChar = '\0';
            this.txtRprOutGoingDocSerialNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRprOutGoingDocSerialNo.SelectedText = "";
            this.txtRprOutGoingDocSerialNo.SelectionLength = 0;
            this.txtRprOutGoingDocSerialNo.SelectionStart = 0;
            this.txtRprOutGoingDocSerialNo.ShortcutsEnabled = true;
            this.txtRprOutGoingDocSerialNo.Size = new System.Drawing.Size(126, 23);
            this.txtRprOutGoingDocSerialNo.TabIndex = 19;
            this.txtRprOutGoingDocSerialNo.UseSelectable = true;
            this.txtRprOutGoingDocSerialNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRprOutGoingDocSerialNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(3, 32);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(84, 19);
            this.metroLabel9.TabIndex = 18;
            this.metroLabel9.Text = "Arşiv Koli No";
            // 
            // txtReportArchiveNo
            // 
            // 
            // 
            // 
            this.txtReportArchiveNo.CustomButton.Image = null;
            this.txtReportArchiveNo.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtReportArchiveNo.CustomButton.Name = "";
            this.txtReportArchiveNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtReportArchiveNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReportArchiveNo.CustomButton.TabIndex = 1;
            this.txtReportArchiveNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReportArchiveNo.CustomButton.UseSelectable = true;
            this.txtReportArchiveNo.CustomButton.Visible = false;
            this.txtReportArchiveNo.Lines = new string[0];
            this.txtReportArchiveNo.Location = new System.Drawing.Point(119, 32);
            this.txtReportArchiveNo.MaxLength = 32767;
            this.txtReportArchiveNo.Name = "txtReportArchiveNo";
            this.txtReportArchiveNo.PasswordChar = '\0';
            this.txtReportArchiveNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReportArchiveNo.SelectedText = "";
            this.txtReportArchiveNo.SelectionLength = 0;
            this.txtReportArchiveNo.SelectionStart = 0;
            this.txtReportArchiveNo.ShortcutsEnabled = true;
            this.txtReportArchiveNo.Size = new System.Drawing.Size(126, 23);
            this.txtReportArchiveNo.TabIndex = 17;
            this.txtReportArchiveNo.UseSelectable = true;
            this.txtReportArchiveNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReportArchiveNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 3);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(110, 19);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Kurye Barkod No";
            // 
            // btnSentDataExportToExcel
            // 
            this.btnSentDataExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSentDataExportToExcel.Location = new System.Drawing.Point(915, 3);
            this.btnSentDataExportToExcel.Name = "btnSentDataExportToExcel";
            this.btnSentDataExportToExcel.Size = new System.Drawing.Size(155, 48);
            this.btnSentDataExportToExcel.TabIndex = 12;
            this.btnSentDataExportToExcel.Text = "Excel\'e Çıkart";
            this.btnSentDataExportToExcel.UseSelectable = true;
            this.btnSentDataExportToExcel.Click += new System.EventHandler(this.btnSentDataExportToExcel_Click);
            // 
            // txtReportCourrierNo
            // 
            // 
            // 
            // 
            this.txtReportCourrierNo.CustomButton.Image = null;
            this.txtReportCourrierNo.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtReportCourrierNo.CustomButton.Name = "";
            this.txtReportCourrierNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtReportCourrierNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReportCourrierNo.CustomButton.TabIndex = 1;
            this.txtReportCourrierNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReportCourrierNo.CustomButton.UseSelectable = true;
            this.txtReportCourrierNo.CustomButton.Visible = false;
            this.txtReportCourrierNo.Lines = new string[0];
            this.txtReportCourrierNo.Location = new System.Drawing.Point(119, 3);
            this.txtReportCourrierNo.MaxLength = 32767;
            this.txtReportCourrierNo.Name = "txtReportCourrierNo";
            this.txtReportCourrierNo.PasswordChar = '\0';
            this.txtReportCourrierNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReportCourrierNo.SelectedText = "";
            this.txtReportCourrierNo.SelectionLength = 0;
            this.txtReportCourrierNo.SelectionStart = 0;
            this.txtReportCourrierNo.ShortcutsEnabled = true;
            this.txtReportCourrierNo.Size = new System.Drawing.Size(126, 23);
            this.txtReportCourrierNo.TabIndex = 15;
            this.txtReportCourrierNo.UseSelectable = true;
            this.txtReportCourrierNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReportCourrierNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dataGridSentReport
            // 
            this.dataGridSentReport.AllowUserToAddRows = false;
            this.dataGridSentReport.AllowUserToDeleteRows = false;
            this.dataGridSentReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSentReport.AutoGenerateColumns = false;
            this.dataGridSentReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSentReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ısScannedDataGridViewCheckBoxColumn,
            this.barcodeCourrierArchiveNoDataGridViewTextBoxColumn,
            this.parcelCodeArchiveNoDataGridViewTextBoxColumn,
            this.documentSerialNoDataGridViewTextBoxColumn1,
            this.nationalIdentityNoDataGridViewTextBoxColumn1,
            this.companyCodeDataGridViewTextBoxColumn1,
            this.batchNumberDataGridViewTextBoxColumn,
            this.sentTimeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridSentReport.DataSource = this.fIBAOutgoingBindingSource;
            this.dataGridSentReport.Location = new System.Drawing.Point(0, 125);
            this.dataGridSentReport.Name = "dataGridSentReport";
            this.dataGridSentReport.ReadOnly = true;
            this.dataGridSentReport.Size = new System.Drawing.Size(1073, 518);
            this.dataGridSentReport.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CreatedByUser";
            this.dataGridViewTextBoxColumn1.HeaderText = "Oluşturan Kullanıcı";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ScannedBarcodeCourierArchive
            // 
            this.ScannedBarcodeCourierArchive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ScannedBarcodeCourierArchive.HeaderText = "Kurye Barkod No";
            this.ScannedBarcodeCourierArchive.Name = "ScannedBarcodeCourierArchive";
            this.ScannedBarcodeCourierArchive.ReadOnly = true;
            // 
            // ScannedArchiveNo
            // 
            this.ScannedArchiveNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ScannedArchiveNo.HeaderText = "Arşiv Koli No";
            this.ScannedArchiveNo.Name = "ScannedArchiveNo";
            this.ScannedArchiveNo.ReadOnly = true;
            // 
            // ScannedDocumentSerialNo
            // 
            this.ScannedDocumentSerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ScannedDocumentSerialNo.HeaderText = "MOF Barkodu";
            this.ScannedDocumentSerialNo.Name = "ScannedDocumentSerialNo";
            this.ScannedDocumentSerialNo.ReadOnly = true;
            // 
            // ScannedNationalIdentityNo
            // 
            this.ScannedNationalIdentityNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ScannedNationalIdentityNo.HeaderText = "TCKN";
            this.ScannedNationalIdentityNo.Name = "ScannedNationalIdentityNo";
            this.ScannedNationalIdentityNo.ReadOnly = true;
            // 
            // ScannedCompanyCode
            // 
            this.ScannedCompanyCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ScannedCompanyCode.HeaderText = "Company Code";
            this.ScannedCompanyCode.Name = "ScannedCompanyCode";
            this.ScannedCompanyCode.ReadOnly = true;
            // 
            // ScannedItWillScanFlag
            // 
            this.ScannedItWillScanFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ScannedItWillScanFlag.HeaderText = "Taranacak";
            this.ScannedItWillScanFlag.Name = "ScannedItWillScanFlag";
            this.ScannedItWillScanFlag.ReadOnly = true;
            this.ScannedItWillScanFlag.Width = 65;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DocumentSerialNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "MOF Barkodu";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NationalIdentityNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "TCKN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CompanyCode";
            this.dataGridViewTextBoxColumn4.HeaderText = "CompanyCode";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // fIBAIncomeBindingSource
            // 
            this.fIBAIncomeBindingSource.DataSource = typeof(Reisswolf.Desktop.FIBAIncome);
            // 
            // ısScannedDataGridViewCheckBoxColumn
            // 
            this.ısScannedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ısScannedDataGridViewCheckBoxColumn.DataPropertyName = "IsScanned";
            this.ısScannedDataGridViewCheckBoxColumn.HeaderText = "Tarandı";
            this.ısScannedDataGridViewCheckBoxColumn.Name = "ısScannedDataGridViewCheckBoxColumn";
            this.ısScannedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // barcodeCourrierArchiveNoDataGridViewTextBoxColumn
            // 
            this.barcodeCourrierArchiveNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.barcodeCourrierArchiveNoDataGridViewTextBoxColumn.DataPropertyName = "BarcodeCourrierArchiveNo";
            this.barcodeCourrierArchiveNoDataGridViewTextBoxColumn.HeaderText = "Kurye Barkod No";
            this.barcodeCourrierArchiveNoDataGridViewTextBoxColumn.Name = "barcodeCourrierArchiveNoDataGridViewTextBoxColumn";
            this.barcodeCourrierArchiveNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parcelCodeArchiveNoDataGridViewTextBoxColumn
            // 
            this.parcelCodeArchiveNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.parcelCodeArchiveNoDataGridViewTextBoxColumn.DataPropertyName = "ParcelCodeArchiveNo";
            this.parcelCodeArchiveNoDataGridViewTextBoxColumn.HeaderText = "Arşiv Koli No";
            this.parcelCodeArchiveNoDataGridViewTextBoxColumn.Name = "parcelCodeArchiveNoDataGridViewTextBoxColumn";
            this.parcelCodeArchiveNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentSerialNoDataGridViewTextBoxColumn1
            // 
            this.documentSerialNoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.documentSerialNoDataGridViewTextBoxColumn1.DataPropertyName = "DocumentSerialNo";
            this.documentSerialNoDataGridViewTextBoxColumn1.HeaderText = "MOF Barkodu";
            this.documentSerialNoDataGridViewTextBoxColumn1.Name = "documentSerialNoDataGridViewTextBoxColumn1";
            this.documentSerialNoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nationalIdentityNoDataGridViewTextBoxColumn1
            // 
            this.nationalIdentityNoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nationalIdentityNoDataGridViewTextBoxColumn1.DataPropertyName = "NationalIdentityNo";
            this.nationalIdentityNoDataGridViewTextBoxColumn1.HeaderText = "TCKN";
            this.nationalIdentityNoDataGridViewTextBoxColumn1.Name = "nationalIdentityNoDataGridViewTextBoxColumn1";
            this.nationalIdentityNoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // companyCodeDataGridViewTextBoxColumn1
            // 
            this.companyCodeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.companyCodeDataGridViewTextBoxColumn1.DataPropertyName = "CompanyCode";
            this.companyCodeDataGridViewTextBoxColumn1.HeaderText = "CompanyCode";
            this.companyCodeDataGridViewTextBoxColumn1.Name = "companyCodeDataGridViewTextBoxColumn1";
            this.companyCodeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // batchNumberDataGridViewTextBoxColumn
            // 
            this.batchNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.batchNumberDataGridViewTextBoxColumn.DataPropertyName = "BatchNumber";
            this.batchNumberDataGridViewTextBoxColumn.HeaderText = "Gönderi No";
            this.batchNumberDataGridViewTextBoxColumn.Name = "batchNumberDataGridViewTextBoxColumn";
            this.batchNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sentTimeDataGridViewTextBoxColumn
            // 
            this.sentTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sentTimeDataGridViewTextBoxColumn.DataPropertyName = "SentTime";
            dataGridViewCellStyle2.Format = "G";
            dataGridViewCellStyle2.NullValue = null;
            this.sentTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.sentTimeDataGridViewTextBoxColumn.HeaderText = "Gönderim Tarihi";
            this.sentTimeDataGridViewTextBoxColumn.Name = "sentTimeDataGridViewTextBoxColumn";
            this.sentTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Durum";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fIBAOutgoingBindingSource
            // 
            this.fIBAOutgoingBindingSource.DataSource = typeof(Reisswolf.Desktop.FIBAOutgoing);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 756);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Dashboard";
            this.Resizable = false;
            this.Text = "Dashboard";
            this.metroTabControl1.ResumeLayout(false);
            this.tabMofMovements.ResumeLayout(false);
            this.tabMofMovements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridScannedBarcodes)).EndInit();
            this.tabIncomeData.ResumeLayout(false);
            this.tabIncomeData.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIncomeReport)).EndInit();
            this.tabSentData.ResumeLayout(false);
            this.tabSentData.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSentReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIBAIncomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIBAOutgoingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabMofMovements;
        private MetroFramework.Controls.MetroLabel lblBarcode;
        private MetroFramework.Controls.MetroTextBox txtBarcode;
        private MetroFramework.Controls.MetroTabPage tabSentData;
        private System.Windows.Forms.ListView listView1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtCourrierNo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtArchiveNo;
        private MetroFramework.Controls.MetroButton btnSend;
        private System.Windows.Forms.DataGridView dataGridScannedBarcodes;
        private MetroFramework.Controls.MetroButton btnSaveList;
        public System.Windows.Forms.ColumnHeader ColDocumentSerialNo;
        private MetroFramework.Controls.MetroButton btnGetDataFromDb;
        private System.Windows.Forms.BindingSource fIBAOutgoingBindingSource;
        private System.Windows.Forms.DataGridView dataGridSentReport;
        private MetroFramework.Controls.MetroButton btnSentDataExportToExcel;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtReportArchiveNo;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtReportCourrierNo;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtRprOutgoingNationalIdNo;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtRprOutGoingDocSerialNo;
        private MetroFramework.Controls.MetroButton btnReportOutgoingData;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtReportBatchNo;
        private System.Windows.Forms.BindingSource fIBAIncomeBindingSource;
        private MetroFramework.Controls.MetroTabPage tabIncomeData;
        private MetroFramework.Controls.MetroButton btnGetSavedData;
        private MetroFramework.Controls.MetroComboBox cmbOutStatus;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroDateTime dtIncomeEndDate;
        private MetroFramework.Controls.MetroDateTime dtIncomeStartDate;
        private MetroFramework.Controls.MetroButton btnReportIncomeData;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox txtRprIncomeNationalIdNo;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox txtRprIncomeDocSerialNo;
        private MetroFramework.Controls.MetroButton btnIncomeDataExportToExcel;
        private System.Windows.Forms.DataGridView dataGridIncomeReport;
        private MetroFramework.Controls.MetroDateTime dtOutGoingEndDate;
        private MetroFramework.Controls.MetroDateTime dtOutGoingStartDate;
        private MetroFramework.Controls.MetroProgressBar sendDataProgressBar;
        public MetroFramework.Controls.MetroLabel lblProgressBar;
        private MetroFramework.Controls.MetroCheckBox chkIncludeOutDates;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroCheckBox chkIncludeIncomeDates;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ısScannedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeCourrierArchiveNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelCodeArchiveNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentSerialNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalIdentityNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sentTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox txtRprIncomeCompanyCode;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox txtRprOutgoingCompanyCode;
        private MetroFramework.Controls.MetroComboBox cmbIncomeSuccessStatus;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroComboBox cmbIncomeSendFlag;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroButton btnClearFields;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedByUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifyDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ItWillScanFlag;
        private MetroFramework.Controls.MetroLabel lblRecordCount;
        private MetroFramework.Controls.MetroLabel lblTotalRecordCount;
        private MetroFramework.Controls.MetroLabel lblIncomeReportTotalRecord;
        private MetroFramework.Controls.MetroLabel lblOutgoingReportTotalRecord;
        private MetroFramework.Controls.MetroButton btnIncomeNextPage;
        private MetroFramework.Controls.MetroButton btnIncomePreviousPage;
        private MetroFramework.Controls.MetroLabel lblIncomeReportPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScannedBarcodeCourierArchive;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScannedArchiveNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScannedDocumentSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScannedNationalIdentityNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScannedCompanyCode;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ScannedItWillScanFlag;
    }
}