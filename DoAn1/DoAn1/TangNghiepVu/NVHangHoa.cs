using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DoAn1.TangDuLieu;
namespace DoAn1.TangNghiepVu
{
    class NVHangHoa
    {
        DuLieu dl = null;
        public NVHangHoa()
        {
            dl = new DuLieu();
        }
        public DataSet LayHangHoa()
        {
            return dl.ExecuteQueryDataSet("select * from SanPham", CommandType.Text);
        }
       public bool ThemHangHoa(string MaSP, string TenSP, string MaNCC, string DVT, float GiaSi, float GiaLe,string LoaiSP, ref string err)
        {
            string sqlString = "Insert Into SanPham(MaSP,TenSP,MaNCC,DonViTinh,GiaBanSi,GiaBanLe,LoaiSanPham) Values(" + "'" + MaSP + "',N'" + TenSP + "',N'" + MaNCC + "',N'"+ DVT + "',"+ GiaSi+ ","+ GiaLe + ","+"N'"+LoaiSP+"')";
            return dl.MyExcuteNonQuery(sqlString, CommandType.Text, ref err);
        }
       public bool SuaHangHoa(string MaSP, string TenSP, string MaNCC, string DVT, float GiaSi, float GiaLe, float GiaMua, string LoaiSP, ref string err)
        {
            string sqlString = "Update SanPham Set MaSP=N'" + MaSP + "',TenSP='" + TenSP + "',MaNCC='" + MaNCC + "',DonViTinh='"+DVT+ "',GiaBanSi='"+GiaSi+ "',GiaBanLe='"+GiaLe+"', GiaMuaVe='"+GiaMua+ "',LoaiSanPham='"+LoaiSP+"' Where MaSP='" + MaSP + "'";
            return dl.MyExcuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaHangHoa(ref string err, string MaSP)
        {
            string sqlString = "Delete From SanPham Where MaSP='" + MaSP + "'";
            return dl.MyExcuteNonQuery(sqlString, CommandType.Text, ref err);
        }
       
    }
}
