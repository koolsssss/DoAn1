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
    public partial class QuanLiBanHang : Form
    {
        bool Them;
        DataTable dtHangHoa = null;
        DataTable dtKhachHang = null;
        DataTable dtNhanVien = null;
        DataTable dtKho = null;

        DataView dv;
        DataView dvKH;
        DataView dvNV;

        NVKhachHang nvkh = new NVKhachHang();
        NVNhanVien nvnv = new NVNhanVien();
        NVHangHoa nvhh = new NVHangHoa();
        NVHoaDon nvhd = new NVHoaDon();
        NVKhoHang nvkho = new NVKhoHang();

        int j, r = 0;
        double tien;
        string err;
        string masp, tensp, donvi,soluong;
        float thanhtien, gia;

        

        public QuanLiBanHang()
        {
            InitializeComponent(); 
        }

        private void QuanLiBanHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLiSieuThiDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.quanLiSieuThiDataSet.KhachHang);
            // TODO: This line of code loads data into the 'quanLiSieuThiDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLiSieuThiDataSet.NhanVien);
            LoadData();
            TuSinhHD();

        }
        public void LoadData()
        {
            dtKho = new DataTable();
            dtKho.Clear();
            DataSet ds = nvkho.LayHangHoaDeBan();
            dtKho = ds.Tables[0];
            dv = new DataView(dtKho);
            dgvHangHoa.DataSource = dv;
            dgvHangHoa.AutoResizeColumns();


            dtKhachHang = new DataTable();
            dtKhachHang.Clear();
            DataSet dskh = nvkh.LayKH();
            dtKhachHang = dskh.Tables[0];
            dvKH = new DataView(dtKhachHang);
            dgvKhachHang.DataSource = dvKH;
            dgvKhachHang.AutoResizeColumns();

            dtNhanVien = new DataTable();
            dtNhanVien.Clear();
            DataSet dsnv = nvnv.LayNV();
            dtNhanVien = dsnv.Tables[0];
            dvNV = new DataView(dtNhanVien);
            dgvNhanVien.DataSource = dvNV;
            dgvNhanVien.AutoResizeColumns();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadData();
            if (textBox1.Text == "")
            {
                dv.RowFilter = "";
            }
            else
            {
                String str = String.Format("MaSP like '%{0}%'", textBox1.Text);
                dv.RowFilter = str;
            }
            tbTenSp.DataBindings.Clear();
            tbTenSp.DataBindings.Add("text", dgvHangHoa.DataSource, "TenSP");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int i;

            string row = "";
            string row2 = "";
            r = dgvHangHoa.CurrentCell.RowIndex;
            if ((string)dgvHangHoa.Rows[r].Cells[1].Value != null)
            {

                if (ckbMuaLe.Checked == true && ckbMuaSLL.Checked == false)
                {
                    for (i = 0; i <= dgvHangHoa.SelectedRows.Count; i++)
                    {
                        row = dgvHangHoa.Rows[r].Cells[0].Value.ToString();
                        row2 = dgvHangHoa.Rows[r].Cells[2].Value.ToString();
                    }
                    int chiso = TimTenTrung(row, row2);
                    if (chiso == -1)
                    {
                        DataGridViewRow n = (DataGridViewRow)dgvSPDC.Rows[j].Clone();
                        dgvSPDC.Rows.Add(n);
                        dgvSPDC.Rows[j].Cells[0].Value = dgvHangHoa.Rows[r].Cells[0].Value.ToString();
                        dgvSPDC.Rows[j].Cells[1].Value = dgvHangHoa.Rows[r].Cells[1].Value.ToString();
                        dgvSPDC.Rows[j].Cells[2].Value = dgvHangHoa.Rows[r].Cells[2].Value.ToString();
                        dgvSPDC.Rows[j].Cells[3].Value = dgvHangHoa.Rows[r].Cells[3].Value.ToString();
                        dgvSPDC.Rows[j].Cells[4].Value = 1;
                        dgvSPDC.Rows[j].Cells[5].Value = int.Parse(dgvHangHoa.Rows[r].Cells[3].Value.ToString()) * (int)dgvSPDC.Rows[j].Cells[4].Value;
                        j++;
                    }
                    else
                    {
                        dgvSPDC.Rows[chiso].Cells[4].Value = (int)dgvSPDC.Rows[chiso].Cells[4].Value + 1;
                        dgvSPDC.Rows[chiso].Cells[5].Value = int.Parse(dgvHangHoa.Rows[r].Cells[3].Value.ToString()) * (int)dgvSPDC.Rows[chiso].Cells[4].Value;
                    }
                }
                else if (ckbMuaSLL.Checked == true && ckbMuaLe.Checked == false)
                {
                    for (i = 0; i <= dgvHangHoa.SelectedRows.Count; i++)
                    {
                        row = dgvHangHoa.Rows[r].Cells[0].Value.ToString();
                        row2 = dgvHangHoa.Rows[r].Cells[4].Value.ToString();

                    }
                    int chiso = TimTenTrung(row, row2);
                    if (chiso == -1)
                    {
                        DataGridViewRow n = (DataGridViewRow)dgvSPDC.Rows[j].Clone();
                        dgvSPDC.Rows.Add(n);
                        dgvSPDC.Rows[j].Cells[0].Value = dgvHangHoa.Rows[r].Cells[0].Value.ToString();
                        dgvSPDC.Rows[j].Cells[1].Value = dgvHangHoa.Rows[r].Cells[1].Value.ToString();
                        dgvSPDC.Rows[j].Cells[2].Value = dgvHangHoa.Rows[r].Cells[4].Value.ToString();
                        dgvSPDC.Rows[j].Cells[3].Value = dgvHangHoa.Rows[r].Cells[5].Value.ToString();
                        dgvSPDC.Rows[j].Cells[4].Value = 1;
                        dgvSPDC.Rows[j].Cells[5].Value = int.Parse(dgvHangHoa.Rows[r].Cells[5].Value.ToString()) * (int)dgvSPDC.Rows[j].Cells[4].Value;
                        j++;
                    }
                    else
                    {
                        dgvSPDC.Rows[chiso].Cells[4].Value = (int)dgvSPDC.Rows[chiso].Cells[4].Value + 1;
                        dgvSPDC.Rows[chiso].Cells[5].Value = int.Parse(dgvHangHoa.Rows[r].Cells[5].Value.ToString()) * (int)dgvSPDC.Rows[chiso].Cells[4].Value;
                    }
                }

            }
            else
                MessageBox.Show("Chưa chọn món");


            double thanhtien = 0;
            double tongtien;

            for (int k = 0; k < dgvSPDC.Rows.Count - 1; k++)
            {
                tongtien = float.Parse(dgvSPDC.Rows[k].Cells[3].Value.ToString()) * (int)dgvSPDC.Rows[k].Cells[4].Value;
                thanhtien += tongtien;
            }
            tien = thanhtien;
            txtTongTien.Text = tien.ToString();
            txtThanhTien.Text = (tien + (tien * 10 / 100)).ToString();
        }

        private void btTimKiemKH_Click(object sender, EventArgs e)
        {

        }



        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (txtSDT.Text == "")
            {
                dvKH.RowFilter = "";
            }
            else
            {
                String str = String.Format("SDT like '%{0}%'", txtSDT.Text);
                dvKH.RowFilter = str;
            }
            cbMaKH.DataBindings.Clear();
            cbMaKH.DataBindings.Add("text", dgvKhachHang.DataSource, "MaKH");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ckbMuaLe.Checked == true || ckbMuaSLL.Checked == true)
                {
                    btnThem.PerformClick();
                }
                else
                {
                    MessageBox.Show("Chưa Chọn Đơn Vị Mua");
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int i;

            string row = "";
            r = dgvSPDC.CurrentCell.RowIndex;
            if ((string)dgvSPDC.Rows[r].Cells[1].Value != null)
            {

                dgvSPDC.Rows[r].Cells[4].Value = (int)dgvSPDC.Rows[r].Cells[4].Value + 1;

            }
            else
                MessageBox.Show("Chưa chọn món");

            float thanhtien = 0;
            float tongtien;

            for (int k = 0; k < dgvSPDC.Rows.Count - 1; k++)
            {
                tongtien = float.Parse(dgvSPDC.Rows[k].Cells[3].Value.ToString()) * (int)dgvSPDC.Rows[k].Cells[4].Value;
                thanhtien += tongtien;
            }
            tien = thanhtien;
            txtTongTien.Text = tien.ToString();
            txtThanhTien.Text = (tien + (tien * 10 / 100)).ToString();
        }

        private void tbTenSp_TextChanged(object sender, EventArgs e)
        {
            LoadData();
            if (tbTenSp.Text == "")
            {
                dv.RowFilter = "";
            }
            else
            {
                String str = String.Format("TenSP like '%{0}%'", tbTenSp.Text);
                dv.RowFilter = str;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tbTenSp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ckbMuaLe.Checked == true || ckbMuaSLL.Checked == true)
                {
                    btnThem.PerformClick();
                }
                else
                {
                    MessageBox.Show("Chưa Chọn Đơn Vị Mua");
                }
            }
        }

        private void ckbMuaLe_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMuaLe.Checked == true)
            {
                ckbMuaSLL.Enabled = false;


            }
            else
            {
                ckbMuaSLL.Enabled = true;
            }
        }

        private void ckbMuaSLL_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMuaSLL.Checked == true)
            {
                ckbMuaLe.Enabled = false;
            }
            else
            {
                ckbMuaLe.Enabled = true;
            }
        }

        private void ckbMuaLe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem.PerformClick();
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btIn_Click(object sender, EventArgs e)
        {

        }

        private void BanHang_Load_1(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            reportInHoaDon rp = new reportInHoaDon();
            rp.Show();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDKKH_Click(object sender, EventArgs e)
        {
            ThemKH kh = new ThemKH();
            kh.ShowDialog();
        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch
            { }
        }

        private void txbDiemquidoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            KhoNhapVe kh = new KhoNhapVe();
            kh.ShowDialog();
        }

        private void dgvSPDC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.khachHangTableAdapter.Fill(this.quanLiSieuThiDataSet.KhachHang);
        }

        private void ckbMaKh_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMaKh.Checked == true)
            {
                cbMaKH.Enabled = true;
                checkBox2.Enabled = false;
            }
            else
            {
                cbMaKH.Enabled = false;
                checkBox2.Enabled = true;
            }
        }

        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                txtSDT.Enabled = true;
                ckbMaKh.Enabled = false;
            }
            else
            {
                txtSDT.Enabled = false;
                ckbMaKh.Enabled = true;

            }
        }

        private void ckbMuaSLL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem.PerformClick();
            }
        }

        private void btnBot_Click(object sender, EventArgs e)
        {
            int i;
            string row = "";
            string row2 = "";
            r = dgvSPDC.CurrentCell.RowIndex;
            if ((string)dgvSPDC.Rows[r].Cells[1].Value != null)
            {
                for (i = 0; i <= dgvSPDC.SelectedRows.Count; i++)
                {
                    row = dgvSPDC.Rows[r].Cells[0].Value.ToString();
                    row2 = dgvSPDC.Rows[r].Cells[2].Value.ToString();
                }
            }
            else
                MessageBox.Show("Chưa Chọn Món");
            int chiso = TimTenTrung(row, row2);
            if (chiso == -1)
            {
                MessageBox.Show("Không xóa được");
            }
            else
            {
                if ((int)dgvSPDC.Rows[chiso].Cells[4].Value > 1)
                {
                    dgvSPDC.Rows[chiso].Cells[4].Value = (int)dgvSPDC.Rows[chiso].Cells[4].Value - 1;
                    tien = tien - float.Parse(dgvSPDC.Rows[chiso].Cells[3].Value.ToString());
                }
                else
                {
                    tien = tien - float.Parse(dgvSPDC.Rows[chiso].Cells[3].Value.ToString());
                    dgvSPDC.Rows.Remove(dgvSPDC.Rows[chiso]);
                    j--;
                }
            }
            txtTongTien.Text = tien.ToString();
            txtThanhTien.Text = (tien + (tien * 10 / 100)).ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            r = dgvSPDC.CurrentCell.RowIndex;
            if ((string)dgvSPDC.Rows[r].Cells[1].Value != null)
            {
                tien = tien - (float.Parse(dgvSPDC.Rows[r].Cells[3].Value.ToString()) * (int)dgvSPDC.Rows[r].Cells[4].Value);
                dgvSPDC.Rows.Remove(dgvSPDC.Rows[r]);
                MessageBox.Show("Xóa Thành Công");
                j--;
            }
            else
                MessageBox.Show("Chưa Chọn Món");

            txtTongTien.Text = tien.ToString();
            txtThanhTien.Text = (tien + (tien * 10 / 100)).ToString();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMaHD.Text != "" && cbMaKH.Text != "" && cbMaNV.Text != "" && dtpNgayLap.Text != "" && txtThanhTien.Text != "0")
                {

                    nvhd.ThemHD(txtMaHD.Text, cbMaKH.Text, cbMaNV.Text, dtpNgayLap.Text, txtThanhTien.Text, ref err);
                    for (int i = 0; i < dgvSPDC.Rows.Count - 1; i++)
                    {
                        masp = dgvSPDC.Rows[i].Cells[0].Value.ToString();
                        tensp = dgvSPDC.Rows[i].Cells[1].Value.ToString();
                        gia =float.Parse(dgvSPDC.Rows[i].Cells[3].Value.ToString());
                        soluong =(dgvSPDC.Rows[i].Cells[4].Value.ToString());
                        donvi = dgvSPDC.Rows[i].Cells[2].Value.ToString();
                        thanhtien = float.Parse(dgvSPDC.Rows[i].Cells[5].Value.ToString());
                        nvhd.ThemHDCT(txtMaHD.Text, masp, tensp, donvi, gia, soluong, thanhtien, ref err);

                        BienToanCuc.NgapNhap = (string)nvkho.getNgayNhapKho_MaSP(masp);
                        BienToanCuc.SP1Thung = (int)nvkho.getSLSPThung_MaSP(masp);
                        BienToanCuc.Don = (int)nvkho.getSLSPDonTrongTongSLSPSi_MaSP(masp);
                        BienToanCuc.Thung = Convert.ToSingle(nvkho.getSLThung_MaSP(masp));
                        BienToanCuc.DVT = (string)nvkho.getDVTL_MaSP(masp);
                        BienToanCuc.DVT2 = (string)nvkho.getDVTC_MaSP(masp);
                        if (donvi == BienToanCuc.DVT)
                        {
                            nvkho.Update(masp, tensp, BienToanCuc.NgapNhap, (BienToanCuc.Thung - int.Parse(soluong)), BienToanCuc.SP1Thung, BienToanCuc.Don - (int.Parse(soluong) * BienToanCuc.SP1Thung), ref err);
                        }
                        if (donvi == BienToanCuc.DVT2)
                        {
                            nvkho.Update(masp, tensp, BienToanCuc.NgapNhap, (((BienToanCuc.Don - (int.Parse(soluong))) * BienToanCuc.Thung) / BienToanCuc.Don), BienToanCuc.SP1Thung, BienToanCuc.Don - (int.Parse(soluong)), ref err);
                        }
                    }
                    MessageBox.Show("Thanh Toán Thành Công!!", "Thông Báo");
                    reportInHoaDon rp = new reportInHoaDon();
                    rp.Show();
                }
                else
                {
                    MessageBox.Show("Thiếu Thông Tin");

                }
            }
            catch
            {
                MessageBox.Show("Lỗi Rồi");
            }
        }

        int TimTenTrung(string ma, string ma2)
        {
            int kq = -1;

            for (int i = 0; i < dgvSPDC.Rows.Count; i++)
            {
                string a = (string)dgvSPDC.Rows[i].Cells[0].Value;
                string b = (string)dgvSPDC.Rows[i].Cells[2].Value;
                if (a == ma && b == ma2)
                {
                    return i;
                }

            }
            return kq;
        }
        public void TuSinhHD()
        {
            DataView mahd;
            DataTable dthd = new DataTable();
            dthd.Clear();
            DataSet dsmahd = nvhd.MAHD();
            dthd = dsmahd.Tables[0];
            mahd = new DataView(dthd);
            dataGridView1.DataSource = mahd;
            dataGridView1.AutoResizeColumns();



            textBox3.DataBindings.Clear();
            textBox3.DataBindings.Add("text", dataGridView1.DataSource, "Ma");

            int so = int.Parse(textBox3.Text);
            if (so >= 1 && so < 10)
            {
                txtMaHD.Text = "HD00" + textBox3.Text;
            }
            else
            {
                txtMaHD.Text = "HD0" + textBox3.Text;
            }

            textBox3.Visible = false;

        }
    }
}
