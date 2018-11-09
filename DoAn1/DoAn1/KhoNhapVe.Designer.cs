namespace DoAn1
{
    partial class KhoNhapVe
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
            this.dgvKhoHang = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.rbtTenSP = new System.Windows.Forms.RadioButton();
            this.rbtMaSP = new System.Windows.Forms.RadioButton();
            this.txbTimKiemGV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btNhap = new System.Windows.Forms.Button();
            this.btLS = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.quanLiSieuThiDataSet = new DoAn1.QuanLiSieuThiDataSet();
            this.khoNhapVeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoNhapVeTableAdapter = new DoAn1.QuanLiSieuThiDataSetTableAdapters.KhoNhapVeTableAdapter();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhapHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongSiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLSPTrong1SPSiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLSPDonTrongTongSLSPSiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia1SPDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiSieuThiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoNhapVeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhoHang
            // 
            this.dgvKhoHang.AutoGenerateColumns = false;
            this.dgvKhoHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSpDataGridViewTextBoxColumn,
            this.ngayNhapHangDataGridViewTextBoxColumn,
            this.soLuongSiDataGridViewTextBoxColumn,
            this.sLSPTrong1SPSiDataGridViewTextBoxColumn,
            this.sLSPDonTrongTongSLSPSiDataGridViewTextBoxColumn,
            this.gia1SPDonDataGridViewTextBoxColumn});
            this.dgvKhoHang.DataSource = this.khoNhapVeBindingSource;
            this.dgvKhoHang.Location = new System.Drawing.Point(21, 121);
            this.dgvKhoHang.Name = "dgvKhoHang";
            this.dgvKhoHang.ReadOnly = true;
            this.dgvKhoHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhoHang.Size = new System.Drawing.Size(846, 233);
            this.dgvKhoHang.TabIndex = 1;
            this.dgvKhoHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoHang_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(893, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cập Nhật";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbtTenSP
            // 
            this.rbtTenSP.AutoSize = true;
            this.rbtTenSP.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTenSP.Location = new System.Drawing.Point(522, 88);
            this.rbtTenSP.Name = "rbtTenSP";
            this.rbtTenSP.Size = new System.Drawing.Size(126, 23);
            this.rbtTenSP.TabIndex = 14;
            this.rbtTenSP.TabStop = true;
            this.rbtTenSP.Text = "Tên Sản Phẩm";
            this.rbtTenSP.UseVisualStyleBackColor = true;
            // 
            // rbtMaSP
            // 
            this.rbtMaSP.AutoSize = true;
            this.rbtMaSP.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMaSP.Location = new System.Drawing.Point(379, 86);
            this.rbtMaSP.Name = "rbtMaSP";
            this.rbtMaSP.Size = new System.Drawing.Size(121, 23);
            this.rbtMaSP.TabIndex = 13;
            this.rbtMaSP.TabStop = true;
            this.rbtMaSP.Text = "Mã Sản Phẩm";
            this.rbtMaSP.UseVisualStyleBackColor = true;
            this.rbtMaSP.CheckedChanged += new System.EventHandler(this.rbtMaSP_CheckedChanged);
            // 
            // txbTimKiemGV
            // 
            this.txbTimKiemGV.Location = new System.Drawing.Point(180, 86);
            this.txbTimKiemGV.Multiline = true;
            this.txbTimKiemGV.Name = "txbTimKiemGV";
            this.txbTimKiemGV.Size = new System.Drawing.Size(180, 21);
            this.txbTimKiemGV.TabIndex = 12;
            this.txbTimKiemGV.TextChanged += new System.EventHandler(this.txbTimKiemGV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tìm kiếm :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(893, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 44);
            this.button2.TabIndex = 15;
            this.button2.Text = "Hàng Hóa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btNhap
            // 
            this.btNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btNhap.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btNhap.ForeColor = System.Drawing.Color.Maroon;
            this.btNhap.Location = new System.Drawing.Point(893, 121);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(113, 44);
            this.btNhap.TabIndex = 2;
            this.btNhap.Text = "Nhập";
            this.btNhap.UseVisualStyleBackColor = false;
            this.btNhap.Click += new System.EventHandler(this.btNhap_Click);
            // 
            // btLS
            // 
            this.btLS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btLS.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLS.ForeColor = System.Drawing.Color.Maroon;
            this.btLS.Location = new System.Drawing.Point(893, 249);
            this.btLS.Name = "btLS";
            this.btLS.Size = new System.Drawing.Size(113, 44);
            this.btLS.TabIndex = 4;
            this.btLS.Text = "Lịch Sử ";
            this.btLS.UseVisualStyleBackColor = false;
            this.btLS.Click += new System.EventHandler(this.btLS_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(491, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 76;
            this.label3.Text = "Kho Hàng";
            // 
            // quanLiSieuThiDataSet
            // 
            this.quanLiSieuThiDataSet.DataSetName = "QuanLiSieuThiDataSet";
            this.quanLiSieuThiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoNhapVeBindingSource
            // 
            this.khoNhapVeBindingSource.DataMember = "KhoNhapVe";
            this.khoNhapVeBindingSource.DataSource = this.quanLiSieuThiDataSet;
            // 
            // khoNhapVeTableAdapter
            // 
            this.khoNhapVeTableAdapter.ClearBeforeFill = true;
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã SP";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            this.maSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenSpDataGridViewTextBoxColumn
            // 
            this.tenSpDataGridViewTextBoxColumn.DataPropertyName = "TenSp";
            this.tenSpDataGridViewTextBoxColumn.HeaderText = "Tên SP";
            this.tenSpDataGridViewTextBoxColumn.Name = "tenSpDataGridViewTextBoxColumn";
            this.tenSpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayNhapHangDataGridViewTextBoxColumn
            // 
            this.ngayNhapHangDataGridViewTextBoxColumn.DataPropertyName = "NgayNhapHang";
            this.ngayNhapHangDataGridViewTextBoxColumn.HeaderText = "Ngày Nhập";
            this.ngayNhapHangDataGridViewTextBoxColumn.Name = "ngayNhapHangDataGridViewTextBoxColumn";
            this.ngayNhapHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongSiDataGridViewTextBoxColumn
            // 
            this.soLuongSiDataGridViewTextBoxColumn.DataPropertyName = "SoLuongSi";
            this.soLuongSiDataGridViewTextBoxColumn.HeaderText = "Số Lượng Sỉ";
            this.soLuongSiDataGridViewTextBoxColumn.Name = "soLuongSiDataGridViewTextBoxColumn";
            this.soLuongSiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sLSPTrong1SPSiDataGridViewTextBoxColumn
            // 
            this.sLSPTrong1SPSiDataGridViewTextBoxColumn.DataPropertyName = "SLSPTrong1SPSi";
            this.sLSPTrong1SPSiDataGridViewTextBoxColumn.HeaderText = "SLSP Trong 1 SP Sỉ";
            this.sLSPTrong1SPSiDataGridViewTextBoxColumn.Name = "sLSPTrong1SPSiDataGridViewTextBoxColumn";
            this.sLSPTrong1SPSiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sLSPDonTrongTongSLSPSiDataGridViewTextBoxColumn
            // 
            this.sLSPDonTrongTongSLSPSiDataGridViewTextBoxColumn.DataPropertyName = "SLSPDonTrongTongSLSPSi";
            this.sLSPDonTrongTongSLSPSiDataGridViewTextBoxColumn.HeaderText = "SLSP Đơn Trong Tổng SLSP Sỉ";
            this.sLSPDonTrongTongSLSPSiDataGridViewTextBoxColumn.Name = "sLSPDonTrongTongSLSPSiDataGridViewTextBoxColumn";
            this.sLSPDonTrongTongSLSPSiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gia1SPDonDataGridViewTextBoxColumn
            // 
            this.gia1SPDonDataGridViewTextBoxColumn.DataPropertyName = "Gia1SPDon";
            this.gia1SPDonDataGridViewTextBoxColumn.HeaderText = "Giá 1 SP Đơn";
            this.gia1SPDonDataGridViewTextBoxColumn.Name = "gia1SPDonDataGridViewTextBoxColumn";
            this.gia1SPDonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // KhoNhapVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1040, 392);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rbtTenSP);
            this.Controls.Add(this.rbtMaSP);
            this.Controls.Add(this.txbTimKiemGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btLS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btNhap);
            this.Controls.Add(this.dgvKhoHang);
            this.Name = "KhoNhapVe";
            this.Text = "KHO HÀNG";
            this.Load += new System.EventHandler(this.KhoNhapVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiSieuThiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoNhapVeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKhoHang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtTenSP;
        private System.Windows.Forms.RadioButton rbtMaSP;
        private System.Windows.Forms.TextBox txbTimKiemGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.Button btLS;
        private System.Windows.Forms.Label label3;
        private QuanLiSieuThiDataSet quanLiSieuThiDataSet;
        private System.Windows.Forms.BindingSource khoNhapVeBindingSource;
        private QuanLiSieuThiDataSetTableAdapters.KhoNhapVeTableAdapter khoNhapVeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhapHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongSiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLSPTrong1SPSiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLSPDonTrongTongSLSPSiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia1SPDonDataGridViewTextBoxColumn;
    }
}