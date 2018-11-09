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
    public partial class HangHoa : Form
    {
        DataTable dtHangHoa = null;
        bool Them;
        string err;
        NVHangHoa nvhh = new NVHangHoa();
        public HangHoa()
        {
            InitializeComponent();
        }
        public void Loaddata()
        {
            dtHangHoa = new DataTable();
            dtHangHoa.Clear();
            DataSet ds = nvhh.LayHangHoa();
            dtHangHoa = ds.Tables[0];
            dgvHangHoa.DataSource = dtHangHoa;
            dgvHangHoa.AutoResizeColumns();
            dgvHangHoa_CellContentClick(null, null);
        }

        private void HangHoa_Load(object sender, EventArgs e)
        {
            this.sanPhamTableAdapter.Fill(this.quanLiSieuThiDataSet.SanPham);
            Loaddata();
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txbTimKiemGV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtMaSP.Checked == true)
                {
                    dtHangHoa.DefaultView.RowFilter = string.Format("MaSP like'%{0}%'", this.txbTimKiemGV.Text);
                }
                if (rbtTenSP.Checked == true)
                {
                    dtHangHoa.DefaultView.RowFilter = string.Format("TenSP like'%{0}%'", this.txbTimKiemGV.Text);
                }
                if(rbtMaSP.Checked==false && rbtTenSP.Checked==false)
                    MessageBox.Show("Vui lòng chọn phương thức tìm kiếm!!");

            }
            catch
            {
                MessageBox.Show("Vui lòng chọn phương thức tìm kiếm!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    NVHangHoa nvlh = new NVHangHoa();
                    nvlh.ThemHangHoa(BienToanCuc.ProID, BienToanCuc.ProName, BienToanCuc.SupID,BienToanCuc.DVT, BienToanCuc.GiaSi,BienToanCuc.GiaLe,BienToanCuc.Loai, ref err);
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
                    int r = dgvHangHoa.CurrentCell.RowIndex;
                    string strLH = dgvHangHoa.Rows[r].Cells[0].Value.ToString();
                    NVHangHoa nvlh = new NVHangHoa();
                    nvlh.SuaHangHoa(strLH,BienToanCuc.ProName, BienToanCuc.SupID, BienToanCuc.DVT, BienToanCuc.GiaSi, BienToanCuc.GiaLe, BienToanCuc.GiaMua, BienToanCuc.Loai, ref err);
                    Loaddata();
                    MessageBox.Show("Đã Sửa Xong");
                }
                catch
                {
                    MessageBox.Show("Không Sửa Được");
                }
            }
        }

        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = dgvHangHoa.CurrentCell.RowIndex;
            BienToanCuc.ProID = dgvHangHoa.Rows[x].Cells[0].Value.ToString();
            BienToanCuc.ProName = dgvHangHoa.Rows[x].Cells[1].Value.ToString();
            BienToanCuc.SupID = dgvHangHoa.Rows[x].Cells[2].Value.ToString();
            BienToanCuc.DVT = dgvHangHoa.Rows[x].Cells[3].Value.ToString();
            BienToanCuc.DVT2=dgvHangHoa.Rows[x].Cells[4].Value.ToString();
            BienToanCuc.Loai = dgvHangHoa.Rows[x].Cells[5].Value.ToString();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvHangHoa.CurrentCell.RowIndex;
                string strk = dgvHangHoa.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc muốn xóa lớp này không", "Trả Lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    nvhh.XoaHangHoa(ref err, strk);
                    Loaddata();
                    MessageBox.Show("Đã xóa");
                }
                else
                {
                    MessageBox.Show("Xóa không được");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi xóa không được");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbtMaSP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtTenSP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
