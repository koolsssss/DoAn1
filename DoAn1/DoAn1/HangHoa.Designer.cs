namespace DoAn1
{
    partial class HangHoa
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
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.quanLiSieuThiDataSet = new DoAn1.QuanLiSieuThiDataSet();
            this.txbTimKiemGV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtTenSP = new System.Windows.Forms.RadioButton();
            this.rbtMaSP = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.sanPhamTableAdapter = new DoAn1.QuanLiSieuThiDataSetTableAdapters.SanPhamTableAdapter();
            this.sanPhamBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loaiSanPhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinhSiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinhLeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiSieuThiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.maNCCDataGridViewTextBoxColumn,
            this.donViTinhLeDataGridViewTextBoxColumn,
            this.donViTinhSiDataGridViewTextBoxColumn,
            this.loaiSanPhamDataGridViewTextBoxColumn});
            this.dgvHangHoa.Location = new System.Drawing.Point(12, 156);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.Size = new System.Drawing.Size(941, 315);
            this.dgvHangHoa.TabIndex = 0;
            this.dgvHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellClick);
            this.dgvHangHoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellContentClick);
            // 
            // quanLiSieuThiDataSet
            // 
            this.quanLiSieuThiDataSet.DataSetName = "QuanLiSieuThiDataSet";
            this.quanLiSieuThiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txbTimKiemGV
            // 
            this.txbTimKiemGV.Location = new System.Drawing.Point(116, 101);
            this.txbTimKiemGV.Multiline = true;
            this.txbTimKiemGV.Name = "txbTimKiemGV";
            this.txbTimKiemGV.Size = new System.Drawing.Size(180, 21);
            this.txbTimKiemGV.TabIndex = 7;
            this.txbTimKiemGV.TextChanged += new System.EventHandler(this.txbTimKiemGV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tìm kiếm :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rbtTenSP
            // 
            this.rbtTenSP.AutoSize = true;
            this.rbtTenSP.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTenSP.Location = new System.Drawing.Point(458, 103);
            this.rbtTenSP.Name = "rbtTenSP";
            this.rbtTenSP.Size = new System.Drawing.Size(126, 23);
            this.rbtTenSP.TabIndex = 10;
            this.rbtTenSP.TabStop = true;
            this.rbtTenSP.Text = "Tên Sản Phẩm";
            this.rbtTenSP.UseVisualStyleBackColor = true;
            this.rbtTenSP.CheckedChanged += new System.EventHandler(this.rbtTenSP_CheckedChanged);
            // 
            // rbtMaSP
            // 
            this.rbtMaSP.AutoSize = true;
            this.rbtMaSP.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMaSP.Location = new System.Drawing.Point(315, 101);
            this.rbtMaSP.Name = "rbtMaSP";
            this.rbtMaSP.Size = new System.Drawing.Size(121, 23);
            this.rbtMaSP.TabIndex = 9;
            this.rbtMaSP.TabStop = true;
            this.rbtMaSP.Text = "Mã Sản Phẩm";
            this.rbtMaSP.UseVisualStyleBackColor = true;
            this.rbtMaSP.CheckedChanged += new System.EventHandler(this.rbtMaSP_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(332, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 31);
            this.label3.TabIndex = 76;
            this.label3.Text = "Danh Sách Hàng Hóa";
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // sanPhamBindingSource1
            // 
            this.sanPhamBindingSource1.DataMember = "SanPham";
            this.sanPhamBindingSource1.DataSource = this.quanLiSieuThiDataSet;
            // 
            // loaiSanPhamDataGridViewTextBoxColumn
            // 
            this.loaiSanPhamDataGridViewTextBoxColumn.DataPropertyName = "LoaiSanPham";
            this.loaiSanPhamDataGridViewTextBoxColumn.HeaderText = "Loại";
            this.loaiSanPhamDataGridViewTextBoxColumn.Name = "loaiSanPhamDataGridViewTextBoxColumn";
            // 
            // donViTinhSiDataGridViewTextBoxColumn
            // 
            this.donViTinhSiDataGridViewTextBoxColumn.DataPropertyName = "DonViTinhSi";
            this.donViTinhSiDataGridViewTextBoxColumn.HeaderText = "Đơn Vị Tính Sỉ";
            this.donViTinhSiDataGridViewTextBoxColumn.Name = "donViTinhSiDataGridViewTextBoxColumn";
            // 
            // donViTinhLeDataGridViewTextBoxColumn
            // 
            this.donViTinhLeDataGridViewTextBoxColumn.DataPropertyName = "DonViTinhLe";
            this.donViTinhLeDataGridViewTextBoxColumn.HeaderText = "Đơn Vị Tính Lẻ";
            this.donViTinhLeDataGridViewTextBoxColumn.Name = "donViTinhLeDataGridViewTextBoxColumn";
            // 
            // maNCCDataGridViewTextBoxColumn
            // 
            this.maNCCDataGridViewTextBoxColumn.DataPropertyName = "MaNCC";
            this.maNCCDataGridViewTextBoxColumn.HeaderText = "Mã NCC";
            this.maNCCDataGridViewTextBoxColumn.Name = "maNCCDataGridViewTextBoxColumn";
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "Tên SP";
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã SP";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            // 
            // HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(970, 484);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbtTenSP);
            this.Controls.Add(this.rbtMaSP);
            this.Controls.Add(this.txbTimKiemGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvHangHoa);
            this.Name = "HangHoa";
            this.Text = "Hàng Hóa";
            this.Load += new System.EventHandler(this.HangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiSieuThiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.TextBox txbTimKiemGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtTenSP;
        private System.Windows.Forms.RadioButton rbtMaSP;
        private System.Windows.Forms.Label label3;
        private QuanLiSieuThiDataSet quanLiSieuThiDataSet;
        private QuanLiSieuThiDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanSiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanLeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinh2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDonVi2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinhLeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinhSiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiSanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sanPhamBindingSource1;
    }
}