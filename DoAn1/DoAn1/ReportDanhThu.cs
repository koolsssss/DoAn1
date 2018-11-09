using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace DoAn1
{
    public partial class ReportDanhThu : Form
    {
        public ReportDanhThu()
        {
            InitializeComponent();
        }

        private void ReportDanhThu_Load(object sender, EventArgs e)
        {
            this.HoaDonTableAdapter.Fill(this.QuanLiSieuThiDataSet.HoaDon);
            this.reportViewer1.RefreshReport();
    
        }
        private void SetParameters(DateTime fromYear, DateTime toYear)
        {
            ReportParameter[] rp = new ReportParameter[2];
            rp[0] = new ReportParameter("fromYear");
            rp[1] = new ReportParameter("toYear");
            rp[0].Values.Add(fromYear.ToString());
            rp[1].Values.Add(toYear.ToString());
            reportViewer1.LocalReport.SetParameters(rp);
        }
        private void btThongKe_Click(object sender, EventArgs e)
        {
            SetParameters(dtpfromYear.Value, dtptoYear.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
