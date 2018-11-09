namespace DoAn1
{
    partial class KhachHang
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
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.rbtTenSP = new System.Windows.Forms.RadioButton();
            this.rbtMaSP = new System.Windows.Forms.RadioButton();
            this.txbTimKiemGV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btLS = new System.Windows.Forms.Button();
            this.btNhap = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.quanLiSieuThiDataSet = new DoAn1.QuanLiSieuThiDataSet();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new DoAn1.QuanLiSieuThiDataSetTableAdapters.KhachHangTableAdapter();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiSieuThiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKH
            // 
            this.dgvKH.AutoGenerateColumns = false;
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKHDataGridViewTextBoxColumn,
            this.tenKHDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn});
            this.dgvKH.DataSource = this.khachHangBindingSource;
            this.dgvKH.Location = new System.Drawing.Point(12, 120);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.Size = new System.Drawing.Size(501, 177);
            this.dgvKH.TabIndex = 0;
            this.dgvKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rbtTenSP
            // 
            this.rbtTenSP.AutoSize = true;
            this.rbtTenSP.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTenSP.Location = new System.Drawing.Point(371, 75);
            this.rbtTenSP.Name = "rbtTenSP";
            this.rbtTenSP.Size = new System.Drawing.Size(142, 23);
            this.rbtTenSP.TabIndex = 14;
            this.rbtTenSP.TabStop = true;
            this.rbtTenSP.Text = "Tên Khách Hàng";
            this.rbtTenSP.UseVisualStyleBackColor = true;
            // 
            // rbtMaSP
            // 
            this.rbtMaSP.AutoSize = true;
            this.rbtMaSP.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMaSP.Location = new System.Drawing.Point(228, 73);
            this.rbtMaSP.Name = "rbtMaSP";
            this.rbtMaSP.Size = new System.Drawing.Size(137, 23);
            this.rbtMaSP.TabIndex = 13;
            this.rbtMaSP.TabStop = true;
            this.rbtMaSP.Text = "Mã Khách Hàng";
            this.rbtMaSP.UseVisualStyleBackColor = true;
            // 
            // txbTimKiemGV
            // 
            this.txbTimKiemGV.Location = new System.Drawing.Point(89, 73);
            this.txbTimKiemGV.Multiline = true;
            this.txbTimKiemGV.Name = "txbTimKiemGV";
            this.txbTimKiemGV.Size = new System.Drawing.Size(133, 21);
            this.txbTimKiemGV.TabIndex = 12;
            this.txbTimKiemGV.TextChanged += new System.EventHandler(this.txbTimKiemGV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tìm kiếm :";
            // 
            // btLS
            // 
            this.btLS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btLS.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLS.ForeColor = System.Drawing.Color.Maroon;
            this.btLS.Location = new System.Drawing.Point(541, 197);
            this.btLS.Name = "btLS";
            this.btLS.Size = new System.Drawing.Size(105, 50);
            this.btLS.TabIndex = 16;
            this.btLS.Text = "Sửa";
            this.btLS.UseVisualStyleBackColor = false;
            this.btLS.Click += new System.EventHandler(this.btLS_Click);
            // 
            // btNhap
            // 
            this.btNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btNhap.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btNhap.ForeColor = System.Drawing.Color.Maroon;
            this.btNhap.Location = new System.Drawing.Point(541, 120);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(105, 52);
            this.btNhap.TabIndex = 15;
            this.btNhap.Text = "Thêm ";
            this.btNhap.UseVisualStyleBackColor = false;
            this.btNhap.Click += new System.EventHandler(this.btNhap_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btUpdate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btUpdate.ForeColor = System.Drawing.Color.Maroon;
            this.btUpdate.Location = new System.Drawing.Point(541, 253);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(105, 44);
            this.btUpdate.TabIndex = 17;
            this.btUpdate.Text = "Cập Nhật ";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(169, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 31);
            this.label3.TabIndex = 76;
            this.label3.Text = "Danh Sách Khách Hàng";
            // 
            // quanLiSieuThiDataSet
            // 
            this.quanLiSieuThiDataSet.DataSetName = "QuanLiSieuThiDataSet";
            this.quanLiSieuThiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.quanLiSieuThiDataSet;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "Mã KH";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            // 
            // tenKHDataGridViewTextBoxColumn
            // 
            this.tenKHDataGridViewTextBoxColumn.DataPropertyName = "TenKH";
            this.tenKHDataGridViewTextBoxColumn.HeaderText = "Tên KH";
            this.tenKHDataGridViewTextBoxColumn.Name = "tenKHDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SĐT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(666, 320);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btLS);
            this.Controls.Add(this.btNhap);
            this.Controls.Add(this.rbtTenSP);
            this.Controls.Add(this.rbtMaSP);
            this.Controls.Add(this.txbTimKiemGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvKH);
            this.Name = "KhachHang";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiSieuThiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.RadioButton rbtTenSP;
        private System.Windows.Forms.RadioButton rbtMaSP;
        private System.Windows.Forms.TextBox txbTimKiemGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLS;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label label3;
        private QuanLiSieuThiDataSet quanLiSieuThiDataSet;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private QuanLiSieuThiDataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
    }
}