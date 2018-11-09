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
    public partial class HoaDon : Form
    {
        DataTable dtdsHD=null;
        DataTable dtdsHDCT = null;
        DataTable dtdsTim = null;

        DataView dvdsHD;
        DataView dvdsHDCT;
        DataView dvTim;

        NVHoaDon nvdsHD = new NVHoaDon();
        string mahd, err;
        public HoaDon()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            dtdsHD = new DataTable();
            dtdsHD.Clear();
            DataSet ds = nvdsHD.LayHD();
            dtdsHD = ds.Tables[0];
            dvdsHD = new DataView(dtdsHD);

            dtdsTim = new DataTable();
            dtdsTim.Clear();
            DataSet dsTim = nvdsHD.LayHD();
            dtdsTim = dsTim.Tables[0];
            dvTim = new DataView(dtdsTim);
            dataGridView1.DataSource = dvTim;
            dataGridView1.AutoResizeColumns();

            lbdsHD.DataSource = dvTim;
            lbdsHD.DisplayMember = "MaHD";
            lbdsHD.ValueMember = "MaHD";


        }
        void LoadHDChiTiet(string mahd)
        {
            try
            {
                dtdsHDCT = new DataTable();
                dtdsHDCT.Clear();
                DataSet dshdct = nvdsHD.LayMaHDCT(mahd, ref err);
                dtdsHDCT = dshdct.Tables[0];
                dvdsHDCT = new DataView(dtdsHDCT);
                dgvdsDHCT.DataSource = dvdsHDCT;
                dgvdsDHCT.AutoResizeColumns();
            }
            catch 
            {
                MessageBox.Show("Không lấy được nội dung trong bạng!!!!");
            }
        }
        void LoadHD(string mahd)
        {
            try
            {
                dtdsHD = new DataTable();
                dtdsHD.Clear();
                DataSet ds = nvdsHD.LayMaHD(mahd, ref err);
                dtdsHD = ds.Tables[0];
                dvdsHD = new DataView(dtdsHD);
                dgvdsHD.DataSource = dvdsHD;
                dgvdsHD.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong bạng!!!!");
            }
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            this.hoaDonChiTietTableAdapter.Fill(this.quanLiSieuThiDataSet.HoaDonChiTiet);
            LoadData();
        }

        private void lbdsHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaHD = lbdsHD.SelectedValue.ToString();
            LoadHDChiTiet(MaHD);
            LoadHD(MaHD);
            tbMaKH.DataBindings.Clear();
            tbMaKH.DataBindings.Add("text", dataGridView1.DataSource, "MaKH");
            tbMaNV.DataBindings.Clear();
            tbMaNV.DataBindings.Add("text", dataGridView1.DataSource, "MaNV");
            tbNgay.DataBindings.Clear();
            tbNgay.DataBindings.Add("text", dataGridView1.DataSource, "NgayOrder");
            tbTien.DataBindings.Clear();
            tbTien.DataBindings.Add("text", dataGridView1.DataSource, "TongTien");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadData();
            if (textBox1.Text == "")
            {
                dvTim.RowFilter = "";
            }
            else
            {
                String str = String.Format("MaHD like '%{0}%'", textBox1.Text);
                dvTim.RowFilter = str;
            }
        }

        



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbdsHD_Click(object sender, EventArgs e)
        {
           
        }
    }
}
