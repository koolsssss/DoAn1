using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn1.TangDuLieu;
using System.Data;

namespace DoAn1.TangNghiepVu
{
    class NVKhachHang
    {
        DuLieu dl = null;
        public NVKhachHang()
        {
            dl = new DuLieu();
        }
        public DataSet LayKH()
        {
            return dl.ExecuteQueryDataSet("select * from KhachHang", CommandType.Text);
        }
        public bool ThemKH(string MaKH, string TenKH, string SDT, int Diem, ref string err)
        {
            string sqlString = "Insert Into KhachHang(MaKH,TenKH,SDT,DiemThuong) Values(" + "'" + MaKH + "',N'" + TenKH + "',N'" + SDT + "',N'" + Diem + "')";
            return dl.MyExcuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatKH(string MaKH, string TenKH, string SDT, ref string err)
        {
            string sqlString = "Update KhachHang Set TenKH=N'" + TenKH + "',SDT='" + SDT + "' Where MaKH='" + MaKH + "'";
            return dl.MyExcuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
