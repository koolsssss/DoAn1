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
    public partial class SuaNV : Form
    {
        public SuaNV()
        {
            InitializeComponent();
        }

        private void ckbSuaTenKH_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSuaTenNV.Checked == true)
            {
                txbTenNV.Enabled = true;
            }
            else
            {
                txbTenNV.Enabled = false;
            }
        }

        private void ckbSuaHoNV_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSuaHoNV.Checked == true)
            {
                txbHoNV.Enabled = true;
            }
            else
            {
                txbHoNV.Enabled = false;
            }
        }

        private void ckbNgaySinh_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNgaySinh.Checked == true)
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
            }
        }

        private void ckbGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbGioiTinh.Checked == true)
            {
                comboBox1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
            }
        }

        private void ckbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPass.Checked == true)
            {
                txbPass.Enabled = true;
            }
            else
            {
                txbPass.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ckbSuaTenNV.Enabled == true)
            {
                BienToanCuc.TenNV = txbTenNV.Text;
            }
            else
            {
                BienToanCuc.TenNV = BienToanCuc.TenNV;
            }
            if (ckbSuaHoNV.Enabled == true)
            {
                BienToanCuc.HoNV = txbHoNV.Text;
            }
            else
            {
                BienToanCuc.HoNV = BienToanCuc.HoNV;
            }
            if (ckbNgaySinh.Enabled == true)
            {
                BienToanCuc.NgaySinh = dateTimePicker1.Text;
            }
            else
            {
                BienToanCuc.NgaySinh = BienToanCuc.NgaySinh;
            }
            if (ckbGioiTinh.Enabled == true)
            {
                BienToanCuc.GioiTinh = comboBox1.Text;
            }
            else
            {
                BienToanCuc.GioiTinh = BienToanCuc.GioiTinh;
            }
            if (ckbPass.Enabled == true)
            {
                BienToanCuc.Pass = txbPass.Text;
            }
            else
            {
                BienToanCuc.Pass = BienToanCuc.Pass;
            }
            this.Hide();
        }

        private void SuaNV_Load(object sender, EventArgs e)
        {
            txbMaNV.Text = BienToanCuc.MaNV;
            txbTenNV.Text = BienToanCuc.TenNV;
            txbHoNV.Text = BienToanCuc.HoNV;
            dateTimePicker1.Text = BienToanCuc.NgaySinh;
            comboBox1.Text = BienToanCuc.GioiTinh;
            txbPass.Text = BienToanCuc.Pass;
        }
    }
}
