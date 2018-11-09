namespace DoAn1
{
    partial class reportInHoaDon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.View_InHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLiSieuThiDataSet = new DoAn1.QuanLiSieuThiDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.View_InHoaDonTableAdapter = new DoAn1.QuanLiSieuThiDataSetTableAdapters.View_InHoaDonTableAdapter();
            this.cbmahd = new System.Windows.Forms.ComboBox();
            this.cbmakh = new System.Windows.Forms.ComboBox();
            this.cbname = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.View_InHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLiSieuThiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // View_InHoaDonBindingSource
            // 
            this.View_InHoaDonBindingSource.DataMember = "View_InHoaDon";
            this.View_InHoaDonBindingSource.DataSource = this.QuanLiSieuThiDataSet;
            // 
            // QuanLiSieuThiDataSet
            // 
            this.QuanLiSieuThiDataSet.DataSetName = "QuanLiSieuThiDataSet";
            this.QuanLiSieuThiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_InHoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAn1.reportingInHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(513, 669);
            this.reportViewer1.TabIndex = 0;
            // 
            // View_InHoaDonTableAdapter
            // 
            this.View_InHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // cbmahd
            // 
            this.cbmahd.DataSource = this.View_InHoaDonBindingSource;
            this.cbmahd.DisplayMember = "MaHD";
            this.cbmahd.FormattingEnabled = true;
            this.cbmahd.Location = new System.Drawing.Point(231, 63);
            this.cbmahd.Name = "cbmahd";
            this.cbmahd.Size = new System.Drawing.Size(121, 21);
            this.cbmahd.TabIndex = 1;
            this.cbmahd.ValueMember = "MaHD";
            this.cbmahd.Visible = false;
            // 
            // cbmakh
            // 
            this.cbmakh.DataSource = this.View_InHoaDonBindingSource;
            this.cbmakh.DisplayMember = "MaKH";
            this.cbmakh.FormattingEnabled = true;
            this.cbmakh.Location = new System.Drawing.Point(231, 99);
            this.cbmakh.Name = "cbmakh";
            this.cbmakh.Size = new System.Drawing.Size(121, 21);
            this.cbmakh.TabIndex = 2;
            this.cbmakh.ValueMember = "MaKH";
            this.cbmakh.Visible = false;
            // 
            // cbname
            // 
            this.cbname.DataSource = this.View_InHoaDonBindingSource;
            this.cbname.DisplayMember = "TenNV";
            this.cbname.FormattingEnabled = true;
            this.cbname.Location = new System.Drawing.Point(231, 142);
            this.cbname.Name = "cbname";
            this.cbname.Size = new System.Drawing.Size(121, 21);
            this.cbname.TabIndex = 3;
            this.cbname.ValueMember = "TenNV";
            this.cbname.Visible = false;
            // 
            // reportInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 669);
            this.Controls.Add(this.cbname);
            this.Controls.Add(this.cbmakh);
            this.Controls.Add(this.cbmahd);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportInHoaDon";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.reportInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_InHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLiSieuThiDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_InHoaDonBindingSource;
        private QuanLiSieuThiDataSet QuanLiSieuThiDataSet;
        private QuanLiSieuThiDataSetTableAdapters.View_InHoaDonTableAdapter View_InHoaDonTableAdapter;
        private System.Windows.Forms.ComboBox cbmahd;
        private System.Windows.Forms.ComboBox cbmakh;
        private System.Windows.Forms.ComboBox cbname;
    }
}