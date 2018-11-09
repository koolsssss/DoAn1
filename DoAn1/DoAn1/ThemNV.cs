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
    public partial class ThemNV : Form
    {
        string err;
        public ThemNV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NVNhanVien nv = new NVNhanVien();
            nv.ThemNV(txbMaNV.Text,txbTenNV.Text,txbHoNV.Text,dateTimePicker1.Text,cbGender.Text,txbPassword.Text, ref err);
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
