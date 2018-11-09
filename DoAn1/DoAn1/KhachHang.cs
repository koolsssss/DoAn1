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
    public partial class KhachHang : Form
    {
        DataTable dtKH = null;
        bool Them;
        string err;
        NVKhachHang nvkh = new NVKhachHang();
        public KhachHang()
        {
            InitializeComponent();
        }
        public void Loaddata()
        {
            dtKH = new DataTable();
            dtKH.Clear();
            DataSet ds = nvkh.LayKH();
            dtKH = ds.Tables[0];
            dgvKH.DataSource = dtKH;
            dgvKH.AutoResizeColumns();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = dgvKH.CurrentCell.RowIndex;
            BienToanCuc.MaKH = dgvKH.Rows[x].Cells[0].Value.ToString();
            BienToanCuc.TenKH = dgvKH.Rows[x].Cells[1].Value.ToString();
            BienToanCuc.SDT =(dgvKH.Rows[x].Cells[2].Value.ToString());       
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            this.khachHangTableAdapter.Fill(this.quanLiSieuThiDataSet.KhachHang);
            Loaddata();
        }

        private void txbTimKiemGV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtMaSP.Checked == true)
                {
                    dtKH.DefaultView.RowFilter = string.Format("MaKH like'%{0}%'", this.txbTimKiemGV.Text);
                }
                if (rbtTenSP.Checked == true)
                {
                    dtKH.DefaultView.RowFilter = string.Format("TenKH like'%{0}%'", this.txbTimKiemGV.Text);
                }
                if (rbtMaSP.Checked == false && rbtTenSP.Checked == false)
                    MessageBox.Show("Vui lòng chọn phương thức tìm kiếm!!");

            }
            catch
            {
                MessageBox.Show("Vui lòng chọn phương thức tìm kiếm!!");
            }
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            ThemKH them = new ThemKH();
            them.ShowDialog();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    NVKhachHang nvgv = new NVKhachHang();
                    nvgv.ThemKH(BienToanCuc.MaKH, BienToanCuc.TenKH, BienToanCuc.SDT, BienToanCuc.DiemThuong, ref err);
                    Loaddata();
                    MessageBox.Show("Đã Thêm Xong");
                }
                catch
                {
                    MessageBox.Show("Không Thêm Được");
                }
            }
            else
            {
                try
                {
                    int r = dgvKH.CurrentCell.RowIndex;
                    string strGV = dgvKH.Rows[r].Cells[0].Value.ToString();
                    NVKhachHang nvkh = new NVKhachHang();
                    nvkh.CapNhatKH(strGV, BienToanCuc.TenKH, BienToanCuc.SDT, ref err);
                    Loaddata();
                }
                catch
                {
                    MessageBox.Show("Không Sửa Được");
                }
            }
        }

        private void btLS_Click(object sender, EventArgs e)
        {
            SuaKH sua = new SuaKH();
            sua.ShowDialog();
        }
    }
}
