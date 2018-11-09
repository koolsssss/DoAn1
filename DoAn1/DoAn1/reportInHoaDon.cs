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
    public partial class reportInHoaDon : Form
    {
        public reportInHoaDon()
        {
            InitializeComponent();
        }

        private void reportInHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLiSieuThiDataSet.View_InHoaDon' table. You can move, or remove it, as needed.
            this.View_InHoaDonTableAdapter.Fill(this.QuanLiSieuThiDataSet.View_InHoaDon);

            this.reportViewer1.RefreshReport();
            SetParameter(cbmahd.SelectedValue.ToString(), cbmakh.SelectedValue.ToString(), cbname.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }
        private void SetParameter(string mahd, string makh, string tennv)
        {
            ReportParameter[] rp = new ReportParameter[3];
            rp[0] = new ReportParameter("mahd");
            rp[1] = new ReportParameter("makh");
            rp[2] = new ReportParameter("tennv");

            rp[0].Values.Add(mahd.ToString());
            rp[1].Values.Add(makh.ToString());
            rp[2].Values.Add(tennv.ToString());

            reportViewer1.LocalReport.SetParameters(rp);
        }
    }
}
