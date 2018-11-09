using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn1.TangDuLieu;
using System.Data;

namespace DoAn1.TangNghiepVu
{
    class NVNhanVien
    {
        DuLieu dl = null;
        public NVNhanVien()
        {
            dl = new DuLieu();
        }
        public DataSet LayNV()
        {
            return dl.ExecuteQueryDataSet("select MaNV,HoNV,TenNV,NgaySinh,GioiTinh from NhanVien", CommandType.Text);
        }
        public DataSet LayTK()
        {
            return dl.ExecuteQueryDataSet("select MaNV,Password from NhanVien", CommandType.Text);
        }
        public bool ThemNV(string MaNV, string TenNV, string HoNV, string NgaySinh, string GioiTinh, string Password, ref string err)
        {
            string sqlString = "Insert Into NhanVien(MaNV,TenNV,HoNV,NgaySinh,GioiTinh,Password) Values(" + "'" + MaNV + "',N'" + TenNV + "',N'" + HoNV+ "',N'" + NgaySinh+ "',N'" + GioiTinh + "',N'" +  Password + "')";
            return dl.MyExcuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatKH(string MaNV, string TenNV, string HoNV,string NgaySinh, string GioiTinh, string Pass, ref string err)
        {
            string sqlString = "Update NhanVien Set TenNV=N'" + TenNV + "',HoNV='" + HoNV + "',NgaySinh='" + NgaySinh + "' ,GioiTinh='" + GioiTinh + "',Password='" + Pass + "' Where MaNV='" + MaNV + "'";
            return dl.MyExcuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
