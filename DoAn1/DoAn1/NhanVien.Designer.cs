namespace DoAn1
{
    partial class NhanVien
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
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiSieuThiDataSet = new DoAn1.QuanLiSieuThiDataSet();
            this.btLS = new System.Windows.Forms.Button();
            this.btNhap = new System.Windows.Forms.Button();
            this.rbtTenSP = new System.Windows.Forms.RadioButton();
            this.rbtMaSP = new System.Windows.Forms.RadioButton();
            this.txbTimKiemGV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.nhanVienTableAdapter = new DoAn1.QuanLiSieuThiDataSetTableAdapters.NhanVienTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiSieuThiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNV
            // 
            this.dgvNV.AutoGenerateColumns = false;
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.hoNVDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dgvNV.DataSource = this.nhanVienBindingSource;
            this.dgvNV.Location = new System.Drawing.Point(17, 112);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.Size = new System.Drawing.Size(642, 207);
            this.dgvNV.TabIndex = 0;
            this.dgvNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNV_CellContentClick);
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "Tên NV";
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            // 
            // hoNVDataGridViewTextBoxColumn
            // 
            this.hoNVDataGridViewTextBoxColumn.DataPropertyName = "HoNV";
            this.hoNVDataGridViewTextBoxColumn.HeaderText = "Họ NV";
            this.hoNVDataGridViewTextBoxColumn.Name = "hoNVDataGridViewTextBoxColumn";
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới Tính";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Mật Khẩu";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.quanLiSieuThiDataSet;
            // 
            // quanLiSieuThiDataSet
            // 
            this.quanLiSieuThiDataSet.DataSetName = "QuanLiSieuThiDataSet";
            this.quanLiSieuThiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btLS
            // 
            this.btLS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btLS.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLS.ForeColor = System.Drawing.Color.Maroon;
            this.btLS.Location = new System.Drawing.Point(693, 188);
            this.btLS.Name = "btLS";
            this.btLS.Size = new System.Drawing.Size(105, 50);
            this.btLS.TabIndex = 22;
            this.btLS.Text = "Sửa ";
            this.btLS.UseVisualStyleBackColor = false;
            this.btLS.Click += new System.EventHandler(this.btLS_Click);
            // 
            // btNhap
            // 
            this.btNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btNhap.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btNhap.ForeColor = System.Drawing.Color.Maroon;
            this.btNhap.Location = new System.Drawing.Point(693, 109);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(105, 52);
            this.btNhap.TabIndex = 21;
            this.btNhap.Text = "Thêm ";
            this.btNhap.UseVisualStyleBackColor = false;
            this.btNhap.Click += new System.EventHandler(this.btNhap_Click);
            // 
            // rbtTenSP
            // 
            this.rbtTenSP.AutoSize = true;
            this.rbtTenSP.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTenSP.Location = new System.Drawing.Point(418, 69);
            this.rbtTenSP.Name = "rbtTenSP";
            this.rbtTenSP.Size = new System.Drawing.Size(130, 23);
            this.rbtTenSP.TabIndex = 20;
            this.rbtTenSP.TabStop = true;
            this.rbtTenSP.Text = "Tên Nhân Viên";
            this.rbtTenSP.UseVisualStyleBackColor = true;
            // 
            // rbtMaSP
            // 
            this.rbtMaSP.AutoSize = true;
            this.rbtMaSP.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMaSP.Location = new System.Drawing.Point(275, 67);
            this.rbtMaSP.Name = "rbtMaSP";
            this.rbtMaSP.Size = new System.Drawing.Size(125, 23);
            this.rbtMaSP.TabIndex = 19;
            this.rbtMaSP.TabStop = true;
            this.rbtMaSP.Text = "Mã Nhân Viên";
            this.rbtMaSP.UseVisualStyleBackColor = true;
            // 
            // txbTimKiemGV
            // 
            this.txbTimKiemGV.Location = new System.Drawing.Point(136, 67);
            this.txbTimKiemGV.Multiline = true;
            this.txbTimKiemGV.Name = "txbTimKiemGV";
            this.txbTimKiemGV.Size = new System.Drawing.Size(133, 21);
            this.txbTimKiemGV.TabIndex = 18;
            this.txbTimKiemGV.TextChanged += new System.EventHandler(this.txbTimKiemGV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tìm kiếm :";
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btUpdate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btUpdate.ForeColor = System.Drawing.Color.Maroon;
            this.btUpdate.Location = new System.Drawing.Point(693, 262);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(105, 44);
            this.btUpdate.TabIndex = 23;
            this.btUpdate.Text = "Cập Nhật ";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(307, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 31);
            this.label3.TabIndex = 76;
            this.label3.Text = "Danh Sách Nhân Viên";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(818, 342);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btLS);
            this.Controls.Add(this.btNhap);
            this.Controls.Add(this.rbtTenSP);
            this.Controls.Add(this.rbtMaSP);
            this.Controls.Add(this.txbTimKiemGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvNV);
            this.Name = "NhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiSieuThiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.Button btLS;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.RadioButton rbtTenSP;
        private System.Windows.Forms.RadioButton rbtMaSP;
        private System.Windows.Forms.TextBox txbTimKiemGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btUpdate;
        private QuanLiSieuThiDataSet quanLiSieuThiDataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QuanLiSieuThiDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}