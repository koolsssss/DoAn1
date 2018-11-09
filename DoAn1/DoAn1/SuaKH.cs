using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class SuaKH : Form
    {
        public SuaKH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ckbSuaTenKH.Enabled == true)
            {
                BienToanCuc.TenKH = txbSuaTenKH.Text;
            }
            else
            {
                BienToanCuc.TenKH = BienToanCuc.TenKH;
            }
            if (ckbSuaSDT.Enabled == true)
            {
                BienToanCuc.SDT = txbSuaSdt.Text;
            }
            else
            {
                BienToanCuc.SDT = BienToanCuc.SDT;
            }
            this.Hide();
        }

        private void ckbSuaTenKH_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbSuaTenKH.Checked==true)
            {
                txbSuaTenKH.Enabled = true;
            }
            else
            {
                txbSuaTenKH.Enabled = false;
            }
        }

        private void ckbSuaSDT_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbSuaSDT.Checked==true)
            {
                txbSuaSdt.Enabled = true;
            }
            else
            {
                txbSuaSdt.Enabled = false;
            }
        }

        private void SuaKH_Load(object sender, EventArgs e)
        {
            txbSuaHovaTen.Text = BienToanCuc.MaKH;
            txbSuaTenKH.Text = BienToanCuc.TenKH;
            txbSuaSdt.Text = BienToanCuc.SDT;
        }

        private void txbSuaTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbSuaSdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbSuaHovaTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
