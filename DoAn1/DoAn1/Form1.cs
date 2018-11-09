using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn1.TangNghiepVu;

namespace DoAn1
{
    public partial class Form1 : Form
    {
        DataTable dtMK = null;
        NVNhanVien nvnv = new NVNhanVien();
        public Form1()
        {
            InitializeComponent();
        }
        public void Loaddata()
        {
            dtMK = new DataTable();
            dtMK.Clear();
            DataSet ds = nvnv.LayTK();
            dtMK = ds.Tables[0];
            dgvTK.DataSource = dtMK;
            dgvTK.AutoResizeColumns();
            dgvTK_CellContentClick(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn Chắc Không", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void dgvTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = dgvTK.CurrentCell.RowIndex;
            BienToanCuc.MaNV = dgvTK.Rows[x].Cells[0].Value.ToString();
            BienToanCuc.Pass = (dgvTK.Rows[x].Cells[1].Value.ToString());
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                Loaddata();
                for (int i = 0; i < dgvTK.RowCount; i++)
                {
                    if (txbMatKhau.Text == "" && txbTaiKhoan.Text == "")
                    {
                        MessageBox.Show("Nhập tài khoản mật khẩu");
                        break;
                    }
                    else if (txbTaiKhoan.Text == dgvTK.Rows[i].Cells[0].Value.ToString().Trim() && txbMatKhau.Text == dgvTK.Rows[i].Cells[1].Value.ToString().Trim())
                    {
                        HOME.bIslogin = true;
                        this.Hide();
                        break;
                    }
                    else if (i == dgvTK.RowCount - 1)
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!!");
            }
        }

        private void cbAnHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAnHienMK.Checked == true)
            {
                txbMatKhau.UseSystemPasswordChar = false;
            }
            else
                txbMatKhau.UseSystemPasswordChar = true;
        }
    }
}
