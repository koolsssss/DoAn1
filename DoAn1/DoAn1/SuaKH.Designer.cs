namespace DoAn1
{
    partial class SuaKH
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
            this.ckbSuaSDT = new System.Windows.Forms.CheckBox();
            this.ckbSuaTenKH = new System.Windows.Forms.CheckBox();
            this.txbSuaSdt = new System.Windows.Forms.TextBox();
            this.txbSuaTenKH = new System.Windows.Forms.TextBox();
            this.txbSuaHovaTen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 89;
            this.label1.Text = "Mã Khách Hàng:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ckbSuaSDT
            // 
            this.ckbSuaSDT.AutoSize = true;
            this.ckbSuaSDT.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSuaSDT.Location = new System.Drawing.Point(18, 190);
            this.ckbSuaSDT.Margin = new System.Windows.Forms.Padding(2);
            this.ckbSuaSDT.Name = "ckbSuaSDT";
            this.ckbSuaSDT.Size = new System.Drawing.Size(63, 23);
            this.ckbSuaSDT.TabIndex = 88;
            this.ckbSuaSDT.Text = "SĐT:";
            this.ckbSuaSDT.UseVisualStyleBackColor = true;
            this.ckbSuaSDT.CheckedChanged += new System.EventHandler(this.ckbSuaSDT_CheckedChanged);
            // 
            // ckbSuaTenKH
            // 
            this.ckbSuaTenKH.AutoSize = true;
            this.ckbSuaTenKH.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSuaTenKH.Location = new System.Drawing.Point(18, 138);
            this.ckbSuaTenKH.Margin = new System.Windows.Forms.Padding(2);
            this.ckbSuaTenKH.Name = "ckbSuaTenKH";
            this.ckbSuaTenKH.Size = new System.Drawing.Size(148, 23);
            this.ckbSuaTenKH.TabIndex = 87;
            this.ckbSuaTenKH.Text = "Tên Khách Hàng:";
            this.ckbSuaTenKH.UseVisualStyleBackColor = true;
            this.ckbSuaTenKH.CheckedChanged += new System.EventHandler(this.ckbSuaTenKH_CheckedChanged);
            // 
            // txbSuaSdt
            // 
            this.txbSuaSdt.Enabled = false;
            this.txbSuaSdt.Location = new System.Drawing.Point(183, 190);
            this.txbSuaSdt.Margin = new System.Windows.Forms.Padding(2);
            this.txbSuaSdt.Name = "txbSuaSdt";
            this.txbSuaSdt.Size = new System.Drawing.Size(121, 20);
            this.txbSuaSdt.TabIndex = 86;
            this.txbSuaSdt.TextChanged += new System.EventHandler(this.txbSuaSdt_TextChanged);
            // 
            // txbSuaTenKH
            // 
            this.txbSuaTenKH.Enabled = false;
            this.txbSuaTenKH.Location = new System.Drawing.Point(183, 138);
            this.txbSuaTenKH.Margin = new System.Windows.Forms.Padding(2);
            this.txbSuaTenKH.Name = "txbSuaTenKH";
            this.txbSuaTenKH.Size = new System.Drawing.Size(121, 20);
            this.txbSuaTenKH.TabIndex = 85;
            this.txbSuaTenKH.TextChanged += new System.EventHandler(this.txbSuaTenKH_TextChanged);
            // 
            // txbSuaHovaTen
            // 
            this.txbSuaHovaTen.Enabled = false;
            this.txbSuaHovaTen.Location = new System.Drawing.Point(183, 92);
            this.txbSuaHovaTen.Margin = new System.Windows.Forms.Padding(2);
            this.txbSuaHovaTen.Name = "txbSuaHovaTen";
            this.txbSuaHovaTen.Size = new System.Drawing.Size(121, 20);
            this.txbSuaHovaTen.TabIndex = 84;
            this.txbSuaHovaTen.TextChanged += new System.EventHandler(this.txbSuaHovaTen_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(197, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 83;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(41, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 31);
            this.label3.TabIndex = 90;
            this.label3.Text = "Sửa Khách Hàng";
            // 
            // SuaKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(327, 295);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbSuaSDT);
            this.Controls.Add(this.ckbSuaTenKH);
            this.Controls.Add(this.txbSuaSdt);
            this.Controls.Add(this.txbSuaTenKH);
            this.Controls.Add(this.txbSuaHovaTen);
            this.Controls.Add(this.button1);
            this.Name = "SuaKH";
            this.Text = "Sửa Khách Hàng";
            this.Load += new System.EventHandler(this.SuaKH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbSuaSDT;
        private System.Windows.Forms.CheckBox ckbSuaTenKH;
        private System.Windows.Forms.TextBox txbSuaSdt;
        private System.Windows.Forms.TextBox txbSuaTenKH;
        private System.Windows.Forms.TextBox txbSuaHovaTen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}