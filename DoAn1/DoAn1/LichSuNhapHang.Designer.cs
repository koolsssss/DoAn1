namespace DoAn1
{
    partial class LichSuNhapHang
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
            this.dgvLS = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.quanLiSieuThiDataSet = new DoAn1.QuanLiSieuThiDataSet();
            this.lichSuNhapHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lichSuNhapHangTableAdapter = new DoAn1.QuanLiSieuThiDataSetTableAdapters.LichSuNhapHangTableAdapter();
            this.ngayNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongSPSiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongSPLeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiSieuThiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichSuNhapHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLS
            // 
            this.dgvLS.AutoGenerateColumns = false;
            this.dgvLS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngayNhapDataGridViewTextBoxColumn,
            this.maSPDataGridViewTextBoxColumn,
            this.soLuongSPSiDataGridViewTextBoxColumn,
            this.soLuongSPLeDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn});
            this.dgvLS.DataSource = this.lichSuNhapHangBindingSource;
            this.dgvLS.Location = new System.Drawing.Point(12, 113);
            this.dgvLS.Name = "dgvLS";
            this.dgvLS.Size = new System.Drawing.Size(630, 258);
            this.dgvLS.TabIndex = 0;
            this.dgvLS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(136, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm theo ngày:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(288, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(261, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 31);
            this.label3.TabIndex = 76;
            this.label3.Text = "Lịch Sử Nhập Hàng";
            // 
            // quanLiSieuThiDataSet
            // 
            this.quanLiSieuThiDataSet.DataSetName = "QuanLiSieuThiDataSet";
            this.quanLiSieuThiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lichSuNhapHangBindingSource
            // 
            this.lichSuNhapHangBindingSource.DataMember = "LichSuNhapHang";
            this.lichSuNhapHangBindingSource.DataSource = this.quanLiSieuThiDataSet;
            // 
            // lichSuNhapHangTableAdapter
            // 
            this.lichSuNhapHangTableAdapter.ClearBeforeFill = true;
            // 
            // ngayNhapDataGridViewTextBoxColumn
            // 
            this.ngayNhapDataGridViewTextBoxColumn.DataPropertyName = "NgayNhap";
            this.ngayNhapDataGridViewTextBoxColumn.HeaderText = "Ngày Nhập";
            this.ngayNhapDataGridViewTextBoxColumn.Name = "ngayNhapDataGridViewTextBoxColumn";
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã SP";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            // 
            // soLuongSPSiDataGridViewTextBoxColumn
            // 
            this.soLuongSPSiDataGridViewTextBoxColumn.DataPropertyName = "SoLuongSPSi";
            this.soLuongSPSiDataGridViewTextBoxColumn.HeaderText = "Số Lượng SP Sỉ";
            this.soLuongSPSiDataGridViewTextBoxColumn.Name = "soLuongSPSiDataGridViewTextBoxColumn";
            // 
            // soLuongSPLeDataGridViewTextBoxColumn
            // 
            this.soLuongSPLeDataGridViewTextBoxColumn.DataPropertyName = "SoLuongSPLe";
            this.soLuongSPLeDataGridViewTextBoxColumn.HeaderText = "Số Lượng SP Lẻ";
            this.soLuongSPLeDataGridViewTextBoxColumn.Name = "soLuongSPLeDataGridViewTextBoxColumn";
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "Tổng Tiền";
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            // 
            // LichSuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(654, 384);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLS);
            this.Name = "LichSuNhapHang";
            this.Text = "Lịch Sử Nhập Hàng";
            this.Load += new System.EventHandler(this.LichSuNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiSieuThiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichSuNhapHangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private QuanLiSieuThiDataSet quanLiSieuThiDataSet;
        private System.Windows.Forms.BindingSource lichSuNhapHangBindingSource;
        private QuanLiSieuThiDataSetTableAdapters.LichSuNhapHangTableAdapter lichSuNhapHangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongSPSiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongSPLeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
    }
}