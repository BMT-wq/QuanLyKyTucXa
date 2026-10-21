using System;

namespace QuanLyKyTucXa.Domain
{
    /// <summary>
    /// Đại diện cho phiếu thu tiền phòng, điện nước hoặc các khoản phí phát sinh.
    /// </summary>
    public class ThuPhi
    {
        public string MaPhieuThu { get; set; }
        public string MaHopDong { get; set; }
        public string MaPhong { get; set; }
        public string LoaiPhi { get; set; } // Tiền phòng, Điện nước, Phí gửi xe, Phí khác
        public int Thang { get; set; }
        public int Nam { get; set; }
        public decimal SoTien { get; set; }
        public DateTime NgayThu { get; set; }
        public string NguoiThu { get; set; }
        public string GhiChu { get; set; }

        public ThuPhi()
        {
            Thang = DateTime.Today.Month;
            Nam = DateTime.Today.Year;
            NgayThu = DateTime.Today;
            LoaiPhi = "Tiền phòng";
        }

        public ThuPhi(string maPhieuThu, string maHopDong, string maPhong, string loaiPhi, int thang, int nam, decimal soTien, DateTime ngayThu, string nguoiThu, string ghiChu = "")
        {
            MaPhieuThu = maPhieuThu;
            MaHopDong = maHopDong;
            MaPhong = maPhong;
            LoaiPhi = loaiPhi;
            Thang = thang;
            Nam = nam;
            SoTien = soTien;
            NgayThu = ngayThu;
            NguoiThu = nguoiThu;
            GhiChu = ghiChu;
        }

        public override string ToString()
        {
            return $"Phiếu {MaPhieuThu} - {LoaiPhi} ({SoTien:N0} đ)";
        }
    }
}
