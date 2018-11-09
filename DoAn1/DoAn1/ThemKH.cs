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
    public partial class ThemKH : Form
    {
        string err;
        public ThemKH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            NVKhachHang kh = new NVKhachHang();
            kh.ThemKH(txbSuaHovaTen.Text, txbSuaGmail.Text, txbSuaSdt.Text, 0, ref err);
            this.Hide();
        }
    }
}
