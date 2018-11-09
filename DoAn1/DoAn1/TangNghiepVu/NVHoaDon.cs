using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DoAn1.TangDuLieu;

namespace DoAn1.TangNghiepVu
{
    class NVHoaDon
    {
        DuLieu dl = null;

        public NVHoaDon()
        {
            dl = new DuLieu();
        }
        public DataSet LayHD()
        {
            return dl.ExecuteQueryDataSet("select * from HoaDon", CommandType.Text);
        }
        public bool ThemHD(string MaHD, string MaKH, string MaNV, string NgayOrder, string TongTien, ref string err)
        {
            string sqlString = "Insert Into HoaDon(MaHD,MaKH,MaNV,NgayOrder,TongTien) Values('" + MaHD + "',N'" + MaKH + "',N'" + MaNV + "',N'" + NgayOrder + "',N'" + TongTien +  "')";
            return dl.MyExcuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet LayHDCT()
        {
            return dl.ExecuteQueryDataSet("select * from HoaDonChiTiet", CommandType.Text);
        }
        public bool ThemHDCT(string OrderID, string ProductID, string ProductName, string DonVi, float UnitPrice, string Discount,float Sum, ref string err)
        {
            string sqlString = "Insert Into HoaDonChiTiet(MaHDCT, MaSP ,TenSP,DonVi, Gia,SoLuong,ThanhTien) Values('" + OrderID + "',N'" + ProductID + "',N'" + ProductName + "',N'" + DonVi + "',N'" + UnitPrice + "','" + Discount + "','" + Sum + "')";
            return dl.MyExcuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet LayMaHD(string ma, ref string err)
        {
            return dl.ExecuteQueryDataSet("select MaKH,MaNV,NgayOrder,TongTien from HoaDon where [MaHD]='" + ma + "'", CommandType.Text);
        }
        public DataSet LayMaHDCT(string ma, ref string err)
        {
            return dl.ExecuteQueryDataSet("select MaSP,TenSP,DonVi,Gia,SoLuong,ThanhTien from HoaDonChiTiet where [MaHDCT]='" + ma + "'", CommandType.Text);
        }
        public DataSet MAHD()
        {
            return dl.ExecuteQueryDataSet("select Top(1)Cast(Right(MaHD,3)+1 as int)as Ma from HoaDon order by MaHD DESC ", CommandType.Text);
        }
    }
}
