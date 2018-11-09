using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn1.TangDuLieu;
using System.Data;
namespace DoAn1.TangNghiepVu
{
    class NVLSNhapHang
    {
        DuLieu dl = null;
        public NVLSNhapHang()
        {
            dl = new DuLieu();
        }
        public DataSet LayLS()
        {
            return dl.ExecuteQueryDataSet("select * from LichSuNhapHang", CommandType.Text);
        }
        public bool ThemLSS(string NgayNhap, string MaSP, float SoLuongSi, int SoLUongLe, int Tong, ref string err)
        {
            string sqlString = "Insert Into LichSuNhapHang(NgayNhap,MaSP,SoLuongSPSi,SoLuongSPLe,TongTien) Values(" + "'" + NgayNhap + "',N'" + MaSP + "',N'" + SoLuongSi + "',N'" + SoLUongLe + "','" + Tong + "')";
            return dl.MyExcuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
