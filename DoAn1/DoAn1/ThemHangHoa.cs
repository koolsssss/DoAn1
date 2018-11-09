using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DoAn1.TangNghiepVu;

namespace DoAn1
{
    public partial class ThemHangHoa : Form
    {
        NVNhaCC ncc = new NVNhaCC();
        NVLoaiSP sp = new NVLoaiSP();
        string err;
        public ThemHangHoa()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (txbThemMaHH.Text == "" || txbThemTenMH.Text == "" || cbNCC.Text == "" || txbDVTle.Text == "" || txbSLThung.Text == "" || txbSLHangTrong1Thung.Text == "" || cbLoaiSP.Text == "" || txbSLThung.Text == "" || txbSLHangTrong1Thung.Text == "" || txbGiaCho1SP.Text == "")
            {
                MessageBox.Show("Không được để trống nội dung nào!");
            }
            else
            {
                try
                {
                    NVHangHoa nvhh = new NVHangHoa();
                    nvhh.ThemHangHoa(txbThemMaHH.Text, txbThemTenMH.Text, cbNCC.Text, txbDVTle.Text, float.Parse(txbGiabansi.Text), float.Parse(txbGiabanle.Text), cbLoaiSP.Text, ref err);
                    NVKhoHang kh = new NVKhoHang();
                    kh.ThemKho1(txbThemMaHH.Text, txbThemTenMH.Text, dateTimePicker1.Text, int.Parse(txbSLThung.Text), int.Parse(txbSLHangTrong1Thung.Text), int.Parse(txbTongSPDon.Text), int.Parse(txbGiaCho1SP.Text), int.Parse(txbGiaBanHangSi.Text), int.Parse(txbGiabansi.Text), int.Parse(txbGiabanle.Text), txbDVTle.Text, txbDVTsi.Text,int.Parse(txbTongTien.Text), ref err);
                    NVLSNhapHang ls = new NVLSNhapHang();
                    ls.ThemLSS(dateTimePicker1.Text, txbThemMaHH.Text, int.Parse(txbSLThung.Text), int.Parse(txbTongSPDon.Text), int.Parse(txbTongTien.Text), ref err);
                    this.Hide();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi rồi!");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txbSoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThemHangHoa_Load(object sender, EventArgs e)
        {
            cbNCC.DataSource = ncc.LayNCC().Tables[0];
            cbNCC.DisplayMember = "MaNCC";
            cbNCC.ValueMember = "MaNCC";

            cbLoaiSP.DataSource = sp.LaySP().Tables[0];
            cbLoaiSP.DisplayMember = "LoaiSPID";
            cbLoaiSP.ValueMember = "LoaiSPID";
        }

        private void txbThemMaHH_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbSLThung_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txbSLThung.Text != "" || txbSLHangTrong1Thung.Text != "" )
                {
                    if (int.Parse(txbSLThung.Text) < 0)
                    {
                        MessageBox.Show("Không hợp lệ");
                        txbSLThung.Text = "";
                    }
                  

                    else
                    {
                        txbTongSPDon.Text = (int.Parse(txbSLHangTrong1Thung.Text) * int.Parse(txbSLThung.Text)).ToString();
                        txbTongTien.Text = (int.Parse(txbGiaCho1SP.Text) * int.Parse(txbTongSPDon.Text)).ToString();
                    }
                }
                else
                {
                    txbTongSPDon.Text = BienToanCuc.Don.ToString();
                   
                }
            
            }
            catch { }
        }

        private void txbSLHangTrong1Thung_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txbSLThung.Text != "" || txbSLHangTrong1Thung.Text != "")
                {

                    if (int.Parse(txbSLHangTrong1Thung.Text) < 0)
                    {
                        MessageBox.Show("Không hợp lệ");
                        txbSLHangTrong1Thung.Text = "";
                    }
                    else
                    {

                        txbTongSPDon.Text = (int.Parse(txbSLHangTrong1Thung.Text) * int.Parse(txbSLThung.Text)).ToString();
                        txbTongTien.Text = (int.Parse(txbGiaCho1SP.Text) * int.Parse(txbTongSPDon.Text)).ToString();
                    }
                }
                else
                {
                    txbTongSPDon.Text = BienToanCuc.Don.ToString();
                    
                }
            }
            catch { }
        }

        private void txbGiaCho1SP_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                if (int.Parse(txbGiaCho1SP.Text) < 0)
                {
                    MessageBox.Show("Không hợp lệ");
                    txbGiaCho1SP.Text = "";
                }
                else
                {
                        txbTongTien.Text = (int.Parse(txbGiaCho1SP.Text) * int.Parse(txbTongSPDon.Text)).ToString();
                }
             
            }
            catch { }
        }

        private void txbTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbGiabansi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txbGiabansi.Text!=""&& txbSLThung.Text!="")
                {
                    txbGiaBanHangSi.Text = (int.Parse(txbGiabansi.Text) * int.Parse(txbSLThung.Text)).ToString();
                }
            }
            catch { }
        }
    }
}
