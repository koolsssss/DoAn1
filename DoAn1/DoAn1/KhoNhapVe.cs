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
    public partial class KhoNhapVe : Form
    {
        DataTable dtKhoHang = null;
        bool Them;
        string err;
        NVKhoHang nvkh = new NVKhoHang();
        public KhoNhapVe()
        {
            InitializeComponent();
        }
        public void Loaddata()
        {
            dtKhoHang = new DataTable();
            dtKhoHang.Clear();
            DataSet ds = nvkh.LayKhoHang();
            dtKhoHang = ds.Tables[0];
            dgvKhoHang.DataSource = dtKhoHang;
           dgvKhoHang.AutoResizeColumns();
           dgvKhoHang_CellContentClick(null, null);
        }
        private void dgvKhoHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = dgvKhoHang.CurrentCell.RowIndex;
            BienToanCuc.ProID = dgvKhoHang.Rows[x].Cells[0].Value.ToString();
            BienToanCuc.ProName = dgvKhoHang.Rows[x].Cells[1].Value.ToString();
            BienToanCuc.NgapNhap = dgvKhoHang.Rows[x].Cells[2].Value.ToString();
            BienToanCuc.Thung = float.Parse( dgvKhoHang.Rows[x].Cells[3].Value.ToString());
            BienToanCuc.SP1Thung = int.Parse(dgvKhoHang.Rows[x].Cells[4].Value.ToString());
            BienToanCuc.Don = int.Parse(dgvKhoHang.Rows[x].Cells[5].Value.ToString());
            BienToanCuc.GiaDon = int.Parse(dgvKhoHang.Rows[x].Cells[6].Value.ToString());
        }
        
       

        private void KhoNhapVe_Load(object sender, EventArgs e)
        {
            this.khoNhapVeTableAdapter.Fill(this.quanLiSieuThiDataSet.KhoNhapVe);
            Loaddata();
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            Them = true;
            LuaChonNhapKho nh = new LuaChonNhapKho();
            nh.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = dgvKhoHang.CurrentCell.RowIndex;
            {
                if (Them)
                {
                    try
                    {
                        int r = dgvKhoHang.CurrentCell.RowIndex;
                        string strLH = dgvKhoHang.Rows[r].Cells[0].Value.ToString();
                        NVKhoHang nvlh = new NVKhoHang();
                        nvlh.ThemKho1(strLH, BienToanCuc.ProName, BienToanCuc.NgapNhap, BienToanCuc.Thung, BienToanCuc.SP1Thung, BienToanCuc.Don, BienToanCuc.GiaDon, BienToanCuc.GiaTong,BienToanCuc.GiaSi,BienToanCuc.GiaLe,BienToanCuc.DVT,BienToanCuc.DVT2,BienToanCuc.TongNhap, ref err);
                        Loaddata();
                        MessageBox.Show("Đã Thêm Xong");
                    }
                    catch
                    {
                        MessageBox.Show("Không Thêm Được");
                    }
                }
               if(float.Parse(dgvKhoHang.Rows[x].Cells[3].Value.ToString()) == 0 || float.Parse(dgvKhoHang.Rows[x].Cells[3].Value.ToString()) < 0)
                {
                    try
                    {
                        int r = dgvKhoHang.CurrentCell.RowIndex;
                        string strLH = dgvKhoHang.Rows[r].Cells[0].Value.ToString();
                        NVKhoHang nvlh = new NVKhoHang();
                        nvlh.xoaSPKho(ref err, strLH);
                        Loaddata();
                        MessageBox.Show("Đã Xóa Xong");
                    }
                    catch
                    {
                        MessageBox.Show("Đã Xóa Xong");
                    }
                }
                else
                {
                    try
                    { 
                    
                    }
                    catch
                    {
                        MessageBox.Show("Không Thêm Được");
                    }
                }
            }
        }

        private void btLS_Click(object sender, EventArgs e)
        {
            LichSuNhapHang ls = new LichSuNhapHang();
            ls.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbTimKiemGV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtMaSP.Checked == true)
                {
                    dtKhoHang.DefaultView.RowFilter = string.Format("MaSP like'%{0}%'", this.txbTimKiemGV.Text);
                }
                if (rbtTenSP.Checked == true)
                {
                    dtKhoHang.DefaultView.RowFilter = string.Format("TenSP like'%{0}%'", this.txbTimKiemGV.Text);
                }
                if (rbtMaSP.Checked == false && rbtTenSP.Checked == false)
                    MessageBox.Show("Vui lòng chọn phương thức tìm kiếm!!");

            }
            catch
            {
                MessageBox.Show("Vui lòng chọn phương thức tìm kiếm!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            hh.ShowDialog();
        }

        private void rbtMaSP_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
