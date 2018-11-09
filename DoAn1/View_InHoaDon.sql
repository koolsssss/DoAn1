create view View_InHoaDon
AS
select hd.MaHD, MaKH, nv.TenNV, NgayOrder, TenSP, DonVi, Gia, SoLuong,ThanhTien
from HoaDon hd, HoaDonChiTiet ct, NhanVien nv
where hd.MaHD = ct.MaHDCT and hd.MaNV = nv.MaNV and 
	  hd.MaHD = (select Top(1)hd.MaHD 
				 from HoaDon hd
				 order by hd.MaHD DESC)
