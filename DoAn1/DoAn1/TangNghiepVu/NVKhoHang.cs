using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DoAn1.TangDuLieu;
namespace DoAn1.TangNghiepVu
{
    class NVKhoHang
    {
        DuLieu dl = null;
        public NVKhoHang()
        {
            dl = new DuLieu();
        }
        public DataSet LayKhoHang()
        {
            return dl.ExecuteQueryDataSet("select MaSP,TenSP,NgayNhapHang,SoLuongSi,SLSPTrong1SPSi,SLSPDonTrongTongSLSPSi,Gia1SPDon from KhoNhapVe", CommandType.Text);
        }
        public bool ThemKho(string MaSP, string TenSP, string Ngay, float Thung, int SPTrongThung, int HangDon, int GiaSPDon,int Giatong, ref string err)
        {
            
            string sqlString = "Update KhoNhapVe Set MaSP=N'" + MaSP + "',TenSP='" + TenSP + "',NgayNhapHang='" + Ngay + "',SoLuongSi='" + Thung + "',SLSPTrong1SPSi='" + SPTrongThung + "',SLSPDonTrongTongSLSPSi='" + HangDon + "', Gia1SPDon='" + GiaSPDon + "',TongTienNhapVe='" + Giatong + "' Where MaSP='" + MaSP + "'";
            return dl.MyExcuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool ThemKho1(string MaSP, string TenSP, string Ngay, float Thung, int SPTrongThung, int HangDon, int GiaSPDon, int GiaSPSi, int GiaSi, int GiaLe, string DVTLe, string DVTChan, int Giatong, ref string err)
        {
            string sqlString = "Insert Into KhoNhapVe(MaSP,TenSP,NgayNhapHang,SoLuongSi,SLSPTrong1SPSi,SLSPDonTrongTongSLSPSi,Gia1SPDon,Gia1SPSi,GiaBanSi,GiaBanLe,DonViTinhLe,DonViTinhSi,TongTienNhapVe) Values(" + "'" + MaSP + "',N'" + TenSP + "',N'" + Ngay + "',N'" + Thung + "',N'"+SPTrongThung+"',N'"+HangDon+"',N'"+GiaSPDon+"',N'"+ GiaSPSi + "',N'" + GiaSi + "',N'" + GiaLe + "',N'" + DVTLe + "',N'" + DVTChan + "',N'" + Giatong + "')";
            return dl.MyExcuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool Update(string MaSP, string TenSP, string Ngay, float Thung, int SPTrongThung, int HangDon, ref string err)
        {
            string sqlString = "Update KhoNhapVe Set MaSP=N'" + MaSP + "',TenSP='" + TenSP + "',NgayNhapHang='" + Ngay + "',SoLuongSi='" + Thung + "',SLSPTrong1SPSi='" + SPTrongThung + "',SLSPDonTrongTongSLSPSi='" + HangDon + "' Where MaSP='" + MaSP + "'";
            return dl.MyExcuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet LayHangHoaDeBan()
        {
            return dl.ExecuteQueryDataSet("select MaSP,TenSP,DonViTinhLe,GiaBanLe,DonViTinhSi,Gia1SPSi from KhoNhapVe", CommandType.Text);
        }
        public object getNgayNhapKho_MaSP(string maSP)
        {
            string sqlstr = "select NgayNhapHang from KhoNhapVe where MaSP=N'" + maSP + "'";
            return dl.Executequery(sqlstr, CommandType.Text);
        }
        public object getSLThung_MaSP(string maSP)
        {
            string sqlstr = "select SoLuongSi from KhoNhapVe where MaSP=N'" + maSP + "'";
            return dl.Executequery(sqlstr, CommandType.Text);
        }
        public object getSLSPThung_MaSP(string maSP)
        {
            string sqlstr = "select SLSPTrong1SPSi from KhoNhapVe where MaSP=N'" + maSP + "'";
            return dl.Executequery(sqlstr, CommandType.Text);
        }
        public object getSLSPDonTrongTongSLSPSi_MaSP(string maSP)
        {
            string sqlstr = "select SLSPDonTrongTongSLSPSi from KhoNhapVe where MaSP=N'" + maSP + "'";
            return dl.Executequery(sqlstr, CommandType.Text);
        }
        public object getDVTL_MaSP(string maSP)
        {
            string sqlstr = "select DonViTinhLe from KhoNhapVe where MaSP=N'" + maSP + "'";
            return dl.Executequery(sqlstr, CommandType.Text);
        }
        public object getDVTC_MaSP(string maSP)
        {
            string sqlstr = "select DonViTinhSi from KhoNhapVe where MaSP=N'" + maSP + "'";
            return dl.Executequery(sqlstr, CommandType.Text);
        }
        public bool xoaSPKho(ref string err, string MaSP)
        {
            string sqlString = "Delete From KhoNhapVe Where MaSP='" + MaSP + "'";
            return dl.MyExcuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
