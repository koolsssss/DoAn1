using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DoAn1.TangDuLieu;
namespace DoAn1.TangNghiepVu
{
    class NVNhaCungCap
    {
        DuLieu dl = null;
        public NVNhaCungCap()
        {
            dl = new DuLieu();
        }
        public DataSet LayNCC()
        {
            return dl.ExecuteQueryDataSet("select * from NhaCungCap", CommandType.Text);
        }
        public bool ThemNCC(string MaNCC, string TenCongTy, string DiaChi, string SDT, string Fax, string Gmail, string Website, ref string err)
        {
            string sqlString = "Insert Into NhaCungCap(MaNCC,TenCongTy,DiaChi,SDT,Fax,Gmail,Website) Values(" + "'" + MaNCC + "',N'" + TenCongTy + "',N'" + DiaChi + "',N'" + SDT + "'," + Fax + "," + Gmail +  ",N'" + Website + "')";
            return dl.MyExcuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool SuaNCC(string MaNCC, string TenCongTy, string DiaChi, string SDT, string Fax, string Gmail, string Website, ref string err)
        {
            string sqlString = "Update NhaCungCap Set MaNCC=N'" + MaNCC + "',TenCongTy='" + TenCongTy + "',DiaChi='" + DiaChi + "',SDT='" + SDT + "',Fax='" + Fax + "',Gmail='" + Gmail + "', Website='" + Website + "' Where MaNCC='" + MaNCC + "'";
            return dl.MyExcuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaNCC(ref string err, string MaNCC)
        {
            string sqlString = "Delete From NhaCungCap where [MaNCC] like '" + MaNCC + "'";
            return dl.MyExcuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
