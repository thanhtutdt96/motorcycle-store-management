using System;

namespace QuanLyBanXe.DTO
{
    public class HoaDonDichVuDto
    {
        public int MaHoaDon { get; set; }
        public int MaKhachHang { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayLap { get; set; }
        public int TongTien { get; set; }
    }
}
