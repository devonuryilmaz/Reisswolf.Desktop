namespace Reisswolf.Desktop
{
    partial class SendResults
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
            this.successListView = new System.Windows.Forms.ListView();
            this.ColDocumentSerialNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.failListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblBarcode = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // successListView
            // 
            this.successListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.successListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColDocumentSerialNo});
            this.successListView.FullRowSelect = true;
            this.successListView.GridLines = true;
            this.successListView.HideSelection = false;
            this.successListView.Location = new System.Drawing.Point(23, 102);
            this.successListView.Name = "successListView";
            this.successListView.ShowGroups = false;
            this.successListView.Size = new System.Drawing.Size(370, 335);
            this.successListView.TabIndex = 7;
            this.successListView.UseCompatibleStateImageBehavior = false;
            this.successListView.View = System.Windows.Forms.View.Details;
            // 
            // ColDocumentSerialNo
            // 
            this.ColDocumentSerialNo.Text = "MOF Barkod";
            this.ColDocumentSerialNo.Width = 350;
            // 
            // failListView
            // 
            this.failListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.failListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.failListView.FullRowSelect = true;
            this.failListView.GridLines = true;
            this.failListView.HideSelection = false;
            this.failListView.Location = new System.Drawing.Point(407, 102);
            this.failListView.Name = "failListView";
            this.failListView.ShowGroups = false;
            this.failListView.Size = new System.Drawing.Size(370, 335);
            this.failListView.TabIndex = 8;
            this.failListView.UseCompatibleStateImageBehavior = false;
            this.failListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MOF Barkod";
            this.columnHeader1.Width = 357;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(23, 80);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(137, 19);
            this.lblBarcode.TabIndex = 9;
            this.lblBarcode.Text = "Başarılı Gönderilenler:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(407, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(145, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Başarısız Gönderilenler:";
            // 
            // SendResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.failListView);
            this.Controls.Add(this.successListView);
            this.Name = "SendResults";
            this.Text = "SendResults";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ColumnHeader ColDocumentSerialNo;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        private MetroFramework.Controls.MetroLabel lblBarcode;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public System.Windows.Forms.ListView failListView;
        public System.Windows.Forms.ListView successListView;
    }
}