namespace DoAn1
{
    partial class ReportDanhThu
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
            this.HoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLiSieuThiDataSet = new DoAn1.QuanLiSieuThiDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpfromYear = new System.Windows.Forms.DateTimePicker();
            this.dtptoYear = new System.Windows.Forms.DateTimePicker();
            this.btThongKe = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HoaDonTableAdapter = new DoAn1.QuanLiSieuThiDataSetTableAdapters.HoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLiSieuThiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // HoaDonBindingSource
            // 
            this.HoaDonBindingSource.DataMember = "HoaDon";
            this.HoaDonBindingSource.DataSource = this.QuanLiSieuThiDataSet;
            // 
            // QuanLiSieuThiDataSet
            // 
            this.QuanLiSieuThiDataSet.DataSetName = "QuanLiSieuThiDataSet";
            this.QuanLiSieuThiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(394, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(203, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Từ";
            // 
            // dtpfromYear
            // 
            this.dtpfromYear.CustomFormat = "";
            this.dtpfromYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfromYear.Location = new System.Drawing.Point(233, 16);
            this.dtpfromYear.Name = "dtpfromYear";
            this.dtpfromYear.Size = new System.Drawing.Size(101, 20);
            this.dtpfromYear.TabIndex = 8;
            this.dtpfromYear.Value = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            // 
            // dtptoYear
            // 
            this.dtptoYear.CustomFormat = "";
            this.dtptoYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptoYear.Location = new System.Drawing.Point(432, 16);
            this.dtptoYear.Name = "dtptoYear";
            this.dtptoYear.Size = new System.Drawing.Size(85, 20);
            this.dtptoYear.TabIndex = 7;
            // 
            // btThongKe
            // 
            this.btThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btThongKe.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThongKe.ForeColor = System.Drawing.Color.Maroon;
            this.btThongKe.Location = new System.Drawing.Point(582, 12);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(125, 31);
            this.btThongKe.TabIndex = 6;
            this.btThongKe.Text = "Thống Kê";
            this.btThongKe.UseVisualStyleBackColor = false;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAn1.reportingDoanhThu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(51, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(803, 449);
            this.reportViewer1.TabIndex = 11;
            // 
            // HoaDonTableAdapter
            // 
            this.HoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // ReportDanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(889, 534);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpfromYear);
            this.Controls.Add(this.dtptoYear);
            this.Controls.Add(this.btThongKe);
            this.Name = "ReportDanhThu";
            this.Text = "Doanh Thu Cửa Hàng";
            this.Load += new System.EventHandler(this.ReportDanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLiSieuThiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpfromYear;
        private System.Windows.Forms.DateTimePicker dtptoYear;
        private System.Windows.Forms.Button btThongKe;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HoaDonBindingSource;
        private QuanLiSieuThiDataSet QuanLiSieuThiDataSet;
        private QuanLiSieuThiDataSetTableAdapters.HoaDonTableAdapter HoaDonTableAdapter;
    }
}