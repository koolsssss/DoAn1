using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class HOME : Form
    {
        public static bool bIslogin = false;
        public HOME()
        {
            InitializeComponent();
            thốngKêToolStripMenuItem.Enabled = false;
            danhMụcToolStripMenuItem.Enabled = false;
            giớiThiệuToolStripMenuItem.Enabled = true;
            bánHàngToolStripMenuItem.Enabled = false;

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HOME_Load(object sender, EventArgs e)
        {

        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.Show();
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhoNhapVe kh = new KhoNhapVe();
            kh.ShowDialog();
        }

        private void tínhTiềnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLiBanHang ql = new QuanLiBanHang();
            ql.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KhachHang KH = new KhachHang();
            KH.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.ShowDialog();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportDanhThu dt = new ReportDanhThu();
            dt.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
            if(HOME.bIslogin==true)
            {
                this.thốngKêToolStripMenuItem.Enabled = true;
                this.danhMụcToolStripMenuItem.Enabled = true;
                this.giớiThiệuToolStripMenuItem.Enabled = true;
                this.ngườiDùngToolStripMenuItem.Enabled = false;
                this.bánHàngToolStripMenuItem.Enabled = true;
                
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GioiThieu gt = new GioiThieu();
            gt.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.ShowDialog();
        }
    }
}
