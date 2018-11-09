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
    public partial class NhaCungCap : Form
    {
        DataTable dtNhaCC = null;
        bool Them;
        string err;
        NVNhaCC ncncc = new NVNhaCC();
        public NhaCungCap()
        {
            InitializeComponent();
        }
        public void Loaddata()
        {
            dtNhaCC = new DataTable();
            dtNhaCC.Clear();
            DataSet ds = ncncc.LayNCC();
            dtNhaCC = ds.Tables[0];
            dgvNCC.DataSource = dtNhaCC;
            dgvNCC.AutoResizeColumns();
            dgvNCC_CellContentClick(null, null);
        }
        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            this.nhaCungCapTableAdapter.Fill(this.quanLiSieuThiDataSet.NhaCungCap);
            Loaddata();
        }

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = dgvNCC.CurrentCell.RowIndex;
            BienToanCuc.MANCC = dgvNCC.Rows[x].Cells[0].Value.ToString();
            BienToanCuc.TenCongTy = dgvNCC.Rows[x].Cells[1].Value.ToString();
            BienToanCuc.DiaChiNCC = dgvNCC.Rows[x].Cells[2].Value.ToString();
            BienToanCuc.SDTNCC = (dgvNCC.Rows[x].Cells[3].Value.ToString());
            BienToanCuc.Fax = (dgvNCC.Rows[x].Cells[4].Value.ToString());
            BienToanCuc.GmailNCC =(dgvNCC.Rows[x].Cells[5].Value.ToString());
            BienToanCuc.Website = (dgvNCC.Rows[x].Cells[6].Value.ToString());
        }

        private void txbTimKiemGV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtMaSP.Checked == true)
                {
                    dtNhaCC.DefaultView.RowFilter = string.Format("MaNCC like'%{0}%'", this.txbTimKiemGV.Text);
                }
                if (rbtTenSP.Checked == true)
                {
                    dtNhaCC.DefaultView.RowFilter = string.Format("TenCongTy like'%{0}%'", this.txbTimKiemGV.Text);
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
            ThemNCC them = new ThemNCC();
            them.ShowDialog();
        }

        private void btLS_Click(object sender, EventArgs e)
        {
            SuaNCC sua = new SuaNCC();
            sua.Show();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    NVNhaCC nvcc = new NVNhaCC();
                    nvcc.ThemNCC(BienToanCuc.MANCC, BienToanCuc.TenCongTy, BienToanCuc.DiaChiNCC, BienToanCuc.SDTNCC,BienToanCuc.Fax, BienToanCuc.GmailNCC,BienToanCuc.Website, ref err);
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
                    int r = dgvNCC.CurrentCell.RowIndex;
                    string strNCC = dgvNCC.Rows[r].Cells[0].Value.ToString();
                    NVNhaCC nvkh = new NVNhaCC();
                    nvkh.Update(strNCC, BienToanCuc.TenCongTy, BienToanCuc.DiaChiNCC, BienToanCuc.SDTNCC, BienToanCuc.Fax, BienToanCuc.GmailNCC, BienToanCuc.Website, ref err);
                    Loaddata();
                }
                catch
                {
                    MessageBox.Show("Không Sửa Được");
                }
            }
        }
    }
    }
