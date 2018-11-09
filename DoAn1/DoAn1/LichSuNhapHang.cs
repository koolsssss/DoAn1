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
    public partial class LichSuNhapHang : Form
    {
        public LichSuNhapHang()
        {
            InitializeComponent();
        }
        DataTable dtLSNhapHang = null;
        string err;
        NVLSNhapHang ls = new NVLSNhapHang();
        public void Loaddata()
        {
            dtLSNhapHang = new DataTable();
            dtLSNhapHang.Clear();
            DataSet ds = ls.LayLS();
            dtLSNhapHang = ds.Tables[0];
            dgvLS.DataSource = dtLSNhapHang;
            dgvLS.AutoResizeColumns();
            dataGridView1_CellContentClick(null, null);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = dgvLS.CurrentCell.RowIndex;
            BienToanCuc.NgapNhap = dgvLS.Rows[x].Cells[0].Value.ToString();
            BienToanCuc.ProID = dgvLS.Rows[x].Cells[1].Value.ToString();
            BienToanCuc.Thung = int.Parse(dgvLS.Rows[x].Cells[2].Value.ToString());
            BienToanCuc.Don = int.Parse(dgvLS.Rows[x].Cells[3].Value.ToString());
            BienToanCuc.GiaTong = int.Parse(dgvLS.Rows[x].Cells[4].Value.ToString());
        }

        private void LichSuNhapHang_Load(object sender, EventArgs e)
        {
            this.lichSuNhapHangTableAdapter.Fill(this.quanLiSieuThiDataSet.LichSuNhapHang);
            Loaddata();
        }

        private void btloadls_Click(object sender, EventArgs e)
        {
            int r = dgvLS.CurrentCell.RowIndex;
            string strLH = dgvLS.Rows[r].Cells[0].Value.ToString();
            NVLSNhapHang nvlh = new NVLSNhapHang();
            nvlh.ThemLSS(strLH, BienToanCuc.ProID, BienToanCuc.Thung, BienToanCuc.Don,BienToanCuc.GiaTong, ref err);
            Loaddata();
            MessageBox.Show("Đã Sửa Xong");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtLSNhapHang.DefaultView.RowFilter = string.Format("NgayNhap like '%{0}%'", this.dateTimePicker1.Text);
        }
    }
}
