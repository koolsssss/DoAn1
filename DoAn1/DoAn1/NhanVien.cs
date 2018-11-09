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
    public partial class NhanVien : Form
    {
        DataTable dtNV = null;
        bool Them;
        string err;
        NVNhanVien nvnv = new NVNhanVien();
        public NhanVien()
        {
            InitializeComponent();
        }
        public void Loaddata()
        {
            dtNV = new DataTable();
            dtNV.Clear();
            DataSet ds = nvnv.LayNV();
            dtNV = ds.Tables[0];
            dgvNV.DataSource = dtNV;
            dgvNV.AutoResizeColumns();
            dgvNV_CellContentClick(null, null);
        }
        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = dgvNV.CurrentCell.RowIndex;
            BienToanCuc.MaNV = dgvNV.Rows[x].Cells[0].Value.ToString();
            BienToanCuc.HoNV = dgvNV.Rows[x].Cells[1].Value.ToString();
            BienToanCuc.TenNV = dgvNV.Rows[x].Cells[2].Value.ToString();
            BienToanCuc.NgaySinh = dgvNV.Rows[x].Cells[3].Value.ToString();
            BienToanCuc.GioiTinh = (dgvNV.Rows[x].Cells[4].Value.ToString());
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            this.nhanVienTableAdapter.Fill(this.quanLiSieuThiDataSet.NhanVien);
            Loaddata();
        }

        private void txbTimKiemGV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtMaSP.Checked == true)
                {
                    dtNV.DefaultView.RowFilter = string.Format("MaNV like'%{0}%'", this.txbTimKiemGV.Text);
                }
                if (rbtTenSP.Checked == true)
                {
                    dtNV.DefaultView.RowFilter = string.Format("TenNV like'%{0}%'", this.txbTimKiemGV.Text);
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
            ThemNV nv = new ThemNV();
            nv.ShowDialog();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    NVNhanVien nvnv = new NVNhanVien();
                    nvnv.ThemNV(BienToanCuc.MaNV, BienToanCuc.TenNV, BienToanCuc.HoNV, BienToanCuc.NgaySinh, BienToanCuc.GioiTinh, BienToanCuc.Pass, ref err);
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
                    int r = dgvNV.CurrentCell.RowIndex;
                    string strGV = dgvNV.Rows[r].Cells[0].Value.ToString();
                    NVNhanVien nvkh = new NVNhanVien();
                    nvkh.CapNhatKH(strGV, BienToanCuc.TenNV, BienToanCuc.HoNV, BienToanCuc.NgaySinh, BienToanCuc.GioiTinh, BienToanCuc.Pass, ref err);
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
            SuaNV sv = new SuaNV();
            sv.ShowDialog();
        }
    }

}
