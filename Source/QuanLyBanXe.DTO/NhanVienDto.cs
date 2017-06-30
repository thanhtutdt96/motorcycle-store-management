using System;

namespace QuanLyBanXe.DTO
{
    public class NhanVienDto
    {
        public int MaNhanVien { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Cmnd { get; set; }
        public string ChucVu { get; set; }
        public int Luong { get; set; }
        public DateTime NgayTuyen { get; set; }
    }
}
