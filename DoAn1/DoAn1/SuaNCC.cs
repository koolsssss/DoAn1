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
    public partial class SuaNCC : Form
    {
        public SuaNCC()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (ckbTenCT.Enabled == true)
            {
                BienToanCuc.TenCongTy = txbTenCT.Text;
            }
            else
            {
                BienToanCuc.TenCongTy = BienToanCuc.TenCongTy;
            }
            if (ckbDC.Enabled == true)
            {
                BienToanCuc.DiaChiNCC = txbDiaChi.Text;
            }
            else
            {
                BienToanCuc.DiaChiNCC = BienToanCuc.DiaChiNCC;
            }
            if (ckbSDT.Enabled == true)
            {
                BienToanCuc.SDTNCC = txbSDT.Text;
            }
            else
            {
                BienToanCuc.SDTNCC = BienToanCuc.SDTNCC;
            }
            if (ckbFax.Enabled == true)
            {
                BienToanCuc.Fax = txbFax.Text;
            }
            else
            {
                BienToanCuc.Fax = BienToanCuc.Fax;
            }
            if (ckbGmail.Enabled == true)
            {
                BienToanCuc.GmailNCC = txbGmail.Text;
            }
            else
            {
                BienToanCuc.GmailNCC = BienToanCuc.GmailNCC;
            }
            if (ckbWeb.Enabled == true)
            {
                BienToanCuc.Website = txbWeb.Text;
            }
            else
            {
                BienToanCuc.Website = BienToanCuc.Website;
            }
            this.Hide();
        }

        private void ckbTenCT_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTenCT.Checked == true)
            {
                txbTenCT.Enabled = true;
            }
            else
            {
                txbTenCT.Enabled = false;
            }
        }

        private void ckbDC_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDC.Checked == true)
            {
                txbDiaChi.Enabled = true;
            }
            else
            {
                txbDiaChi.Enabled = false;
            }
        }

        private void ckbSDT_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSDT.Checked == true)
            {
                txbSDT.Enabled = true;
            }
            else
            {
                txbSDT.Enabled = false;
            }
        }

        private void ckbFax_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFax.Checked == true)
            {
                txbFax.Enabled = true;
            }
            else
            {
                txbFax.Enabled = false;
            }
        }

        private void ckbGmail_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbGmail.Checked == true)
            {
                txbGmail.Enabled = true;
            }
            else
            {
                txbGmail.Enabled = false;
            }
        }

        private void ckbWeb_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbWeb.Checked == true)
            {
                txbWeb.Enabled = true;
            }
            else
            {
                txbWeb.Enabled = false;
            }
        }

        private void SuaNCC_Load(object sender, EventArgs e)
        {
            txbMaNCC.Text = BienToanCuc.MANCC;
            txbTenCT.Text = BienToanCuc.TenCongTy;
            txbDiaChi.Text = BienToanCuc.DiaChiNCC;
            txbSDT.Text = BienToanCuc.SDTNCC;
            txbFax.Text = BienToanCuc.Fax;
            txbGmail.Text = BienToanCuc.GmailNCC;
            txbWeb.Text = BienToanCuc.Website;
        }
    }
}
