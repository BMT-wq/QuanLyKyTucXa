using System;

namespace QuanLyKyTucXa.Domain
{
    /// <summary>
    /// Đại diện cho hồ sơ sinh viên đăng ký nội trú.
    /// </summary>
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; } // Nam, Nữ
        public string SoCMND_CCCD { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string Lop { get; set; }
        public string Khoa { get; set; }
        public string QueQuan { get; set; }

        public SinhVien()
        {
            NgaySinh = DateTime.Today.AddYears(-18);
            GioiTinh = "Nam";
        }

        public SinhVien(string maSV, string hoTen, DateTime ngaySinh, string gioiTinh, string soCMND_CCCD, string soDienThoai, string email, string lop, string khoa, string queQuan)
        {
            MaSV = maSV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            SoCMND_CCCD = soCMND_CCCD;
            SoDienThoai = soDienThoai;
            Email = email;
            Lop = lop;
            Khoa = khoa;
            QueQuan = queQuan;
        }

        public override string ToString()
        {
            return $"{HoTen} ({MaSV}) - {Lop}";
        }
    }
}
