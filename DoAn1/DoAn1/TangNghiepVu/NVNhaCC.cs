using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DoAn1.TangDuLieu;
namespace DoAn1.TangNghiepVu
{
    class NVNhaCC
    {
        DuLieu dl = null;
        public NVNhaCC()
        {
            dl = new DuLieu();
        }
        public DataSet LayNCC()
        {
            return dl.ExecuteQueryDataSet("select * from NhaCungCap", CommandType.Text);
        }
        public bool ThemNCC(string MaNCC, string TenCT, string DiaChi, string SDT, string Fax,string Gmail, string Web, ref string err)
        {
            string sqlString = "Insert Into NhaCungCap(MaNCC,TenCongTy,DiaChi,SDT,Fax,Gmail,Website) Values('" + MaNCC + "',N'" + TenCT + "',N'" + DiaChi + "',N'" + SDT + "',N'" + Fax + "',N'" + Gmail + "',N'" + Web + "')";
            return dl.MyExcuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool Update(string MaNCC, string TenCT, string DiaChi, string SDT, string Fax, string Gmail, string Web, ref string err)
        {
            string sqlString = "Update NhaCungCap Set MaNCC=N'" + MaNCC + "',TenCongTy='" + TenCT + "',DiaChi='" + DiaChi + "',SDT='" + SDT + "',Fax='" + Fax + "',Gmail='" + Gmail + "',Website='" + Web + "' Where MaNCC='" + MaNCC + "'";
            return dl.MyExcuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
