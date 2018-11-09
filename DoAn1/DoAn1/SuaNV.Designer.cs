namespace DoAn1
{
    partial class SuaNV
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
            this.label1 = new System.Windows.Forms.Label();
            this.ckbSuaHoNV = new System.Windows.Forms.CheckBox();
            this.ckbSuaTenNV = new System.Windows.Forms.CheckBox();
            this.txbHoNV = new System.Windows.Forms.TextBox();
            this.txbTenNV = new System.Windows.Forms.TextBox();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.ckbGioiTinh = new System.Windows.Forms.CheckBox();
            this.ckbNgaySinh = new System.Windows.Forms.CheckBox();
            this.ckbPass = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 96;
            this.label1.Text = "Mã Nhân Viên:";
            // 
            // ckbSuaHoNV
            // 
            this.ckbSuaHoNV.AutoSize = true;
            this.ckbSuaHoNV.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSuaHoNV.Location = new System.Drawing.Point(26, 190);
            this.ckbSuaHoNV.Margin = new System.Windows.Forms.Padding(2);
            this.ckbSuaHoNV.Name = "ckbSuaHoNV";
            this.ckbSuaHoNV.Size = new System.Drawing.Size(134, 23);
            this.ckbSuaHoNV.TabIndex = 95;
            this.ckbSuaHoNV.Text = "Họ Nhân Viên: ";
            this.ckbSuaHoNV.UseVisualStyleBackColor = true;
            this.ckbSuaHoNV.CheckedChanged += new System.EventHandler(this.ckbSuaHoNV_CheckedChanged);
            // 
            // ckbSuaTenNV
            // 
            this.ckbSuaTenNV.AutoSize = true;
            this.ckbSuaTenNV.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSuaTenNV.Location = new System.Drawing.Point(26, 138);
            this.ckbSuaTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.ckbSuaTenNV.Name = "ckbSuaTenNV";
            this.ckbSuaTenNV.Size = new System.Drawing.Size(136, 23);
            this.ckbSuaTenNV.TabIndex = 94;
            this.ckbSuaTenNV.Text = "Tên Nhân Viên:";
            this.ckbSuaTenNV.UseVisualStyleBackColor = true;
            this.ckbSuaTenNV.CheckedChanged += new System.EventHandler(this.ckbSuaTenKH_CheckedChanged);
            // 
            // txbHoNV
            // 
            this.txbHoNV.Enabled = false;
            this.txbHoNV.Location = new System.Drawing.Point(191, 190);
            this.txbHoNV.Margin = new System.Windows.Forms.Padding(2);
            this.txbHoNV.Name = "txbHoNV";
            this.txbHoNV.Size = new System.Drawing.Size(121, 20);
            this.txbHoNV.TabIndex = 93;
            // 
            // txbTenNV
            // 
            this.txbTenNV.Enabled = false;
            this.txbTenNV.Location = new System.Drawing.Point(191, 138);
            this.txbTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.txbTenNV.Name = "txbTenNV";
            this.txbTenNV.Size = new System.Drawing.Size(121, 20);
            this.txbTenNV.TabIndex = 92;
            // 
            // txbMaNV
            // 
            this.txbMaNV.Enabled = false;
            this.txbMaNV.Location = new System.Drawing.Point(191, 92);
            this.txbMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(121, 20);
            this.txbMaNV.TabIndex = 91;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(505, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 37);
            this.button1.TabIndex = 90;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbPass
            // 
            this.txbPass.Enabled = false;
            this.txbPass.Location = new System.Drawing.Point(492, 193);
            this.txbPass.Margin = new System.Windows.Forms.Padding(2);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(121, 20);
            this.txbPass.TabIndex = 99;
            // 
            // ckbGioiTinh
            // 
            this.ckbGioiTinh.AutoSize = true;
            this.ckbGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGioiTinh.Location = new System.Drawing.Point(340, 147);
            this.ckbGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.ckbGioiTinh.Name = "ckbGioiTinh";
            this.ckbGioiTinh.Size = new System.Drawing.Size(101, 23);
            this.ckbGioiTinh.TabIndex = 101;
            this.ckbGioiTinh.Text = "Giới Tính:";
            this.ckbGioiTinh.UseVisualStyleBackColor = true;
            this.ckbGioiTinh.CheckedChanged += new System.EventHandler(this.ckbGioiTinh_CheckedChanged);
            // 
            // ckbNgaySinh
            // 
            this.ckbNgaySinh.AutoSize = true;
            this.ckbNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNgaySinh.Location = new System.Drawing.Point(340, 95);
            this.ckbNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.ckbNgaySinh.Name = "ckbNgaySinh";
            this.ckbNgaySinh.Size = new System.Drawing.Size(104, 23);
            this.ckbNgaySinh.TabIndex = 100;
            this.ckbNgaySinh.Text = "Ngày Sinh:";
            this.ckbNgaySinh.UseVisualStyleBackColor = true;
            this.ckbNgaySinh.CheckedChanged += new System.EventHandler(this.ckbNgaySinh_CheckedChanged);
            // 
            // ckbPass
            // 
            this.ckbPass.AutoSize = true;
            this.ckbPass.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPass.Location = new System.Drawing.Point(340, 191);
            this.ckbPass.Margin = new System.Windows.Forms.Padding(2);
            this.ckbPass.Name = "ckbPass";
            this.ckbPass.Size = new System.Drawing.Size(93, 23);
            this.ckbPass.TabIndex = 102;
            this.ckbPass.Text = "PassWord";
            this.ckbPass.UseVisualStyleBackColor = true;
            this.ckbPass.CheckedChanged += new System.EventHandler(this.ckbPass_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox1.Location = new System.Drawing.Point(492, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 103;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(492, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(213, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 31);
            this.label3.TabIndex = 105;
            this.label3.Text = "Sửa Nhân Viên";
            // 
            // SuaNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(649, 280);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ckbPass);
            this.Controls.Add(this.ckbGioiTinh);
            this.Controls.Add(this.ckbNgaySinh);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbSuaHoNV);
            this.Controls.Add(this.ckbSuaTenNV);
            this.Controls.Add(this.txbHoNV);
            this.Controls.Add(this.txbTenNV);
            this.Controls.Add(this.txbMaNV);
            this.Controls.Add(this.button1);
            this.Name = "SuaNV";
            this.Text = "Sửa Nhân Viên";
            this.Load += new System.EventHandler(this.SuaNV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbSuaHoNV;
        private System.Windows.Forms.CheckBox ckbSuaTenNV;
        private System.Windows.Forms.TextBox txbHoNV;
        private System.Windows.Forms.TextBox txbTenNV;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.CheckBox ckbGioiTinh;
        private System.Windows.Forms.CheckBox ckbNgaySinh;
        private System.Windows.Forms.CheckBox ckbPass;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
    }
}