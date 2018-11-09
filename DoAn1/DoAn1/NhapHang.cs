using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DoAn1.TangNghiepVu;

namespace DoAn1
{
    public partial class NhapHang : Form
    {
        
        string err;
        public NhapHang()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            NVKhoHang kh = new NVKhoHang();
            kh.ThemKho(txbThemMaHH.Text, txbThemTenMH.Text, dateTimePicker1.Text, int.Parse(txbSLThung.Text), int.Parse(txbSp1Thung.Text),int.Parse(txbTongSLSPthung.Text), int.Parse(txbGiaDon.Text), int.Parse(txbGiaTong.Text), ref err);
            NVLSNhapHang ls = new NVLSNhapHang();
            ls.ThemLSS(dateTimePicker1.Text, txbThemMaHH.Text, int.Parse(txbNhapSL.Text), int.Parse(txbSp1Thung.Text), int.Parse(txbGiaTong.Text), ref err);
            this.Hide();
            
        }
        private void txbSLThung_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txbTongSLSPthung.Text = Convert.ToSingle((float.Parse(txbSLThung.Text) * int.Parse(txbSp1Thung.Text))).ToString();
            }
            catch { }
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            txbThemMaHH.Text= BienToanCuc.ProID;
            txbThemTenMH.Text = BienToanCuc.ProName;
           txbSLThung.Text = BienToanCuc.Thung.ToString();
            txbSp1Thung.Text = BienToanCuc.SP1Thung.ToString();
            txbTongSLSPthung.Text = BienToanCuc.Don.ToString();
            txbGiaDon.Text = BienToanCuc.GiaDon.ToString();
            txbGiaTong.Text = BienToanCuc.GiaTong.ToString();
        }

        private void txbGiaTong_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txbGiaTong_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void txbTongSLSPthung_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbSLThung_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txbNhapSL_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txbNhapSL.Text != "")
                {
                    int k = int.Parse(txbNhapSL.Text);
                    if (k < 0)
                    {
                        MessageBox.Show("Không hợp lệ!");
                        txbNhapSL.Text = "";
                    }
                    else
                    {
                        txbSLThung.Text = (BienToanCuc.Thung + k).ToString();
                        txbGiaTong.Text = Convert.ToSingle(int.Parse(txbNhapSL.Text) * int.Parse(txbGiaDon.Text)).ToString();
                    }
                }
                else
                {
                    txbSLThung.Text = BienToanCuc.Thung.ToString();
                    txbGiaTong.Text = BienToanCuc.GiaTong.ToString();

                }
            }
            catch { }
        }

        private void txbThemNgayNhapHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbSp1Thung_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbThemMaHH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
