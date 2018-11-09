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
    public partial class ThemNCC : Form
    {
        string err;
        public ThemNCC()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            NVNhaCC ncc = new NVNhaCC();
            ncc.ThemNCC(txbMaNCC.Text, txbTenCT.Text, txbDiaChi.Text, txbSDT.Text, txbFax.Text, txbGmail.Text, txbGmail.Text, ref err);
            this.Hide();
        }
    }
}
