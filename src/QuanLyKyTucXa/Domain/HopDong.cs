using System;

namespace QuanLyKyTucXa.Domain
{
    /// <summary>
    /// Đại diện cho hợp đồng thuê phòng của sinh viên.
    /// </summary>
    public class HopDong
    {
        public string MaHopDong { get; set; }
        public string MaSV { get; set; }
        public string MaPhong { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public decimal TienDatCoc { get; set; }
        public string TrangThai { get; set; } // Hiệu lực, Đã thanh lý, Hết hạn
        public string GhiChu { get; set; }

        public HopDong()
        {
            NgayBatDau = DateTime.Today;
            NgayKetThuc = DateTime.Today.AddMonths(5);
            TrangThai = "Hiệu lực";
        }

        public HopDong(string maHopDong, string maSV, string maPhong, DateTime ngayBatDau, DateTime ngayKetThuc, decimal tienDatCoc, string trangThai, string ghiChu = "")
        {
            MaHopDong = maHopDong;
            MaSV = maSV;
            MaPhong = maPhong;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            TienDatCoc = tienDatCoc;
            TrangThai = trangThai;
            GhiChu = ghiChu;
        }

        public override string ToString()
        {
            return $"HĐ {MaHopDong}: SV {MaSV} - Phòng {MaPhong} [{TrangThai}]";
        }
    }
}
