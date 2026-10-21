using System;

namespace QuanLyKyTucXa.Domain
{
    /// <summary>
    /// Đại diện cho hóa đơn và chỉ số điện nước hàng tháng của phòng.
    /// </summary>
    public class DienNuoc
    {
        public string MaDienNuoc { get; set; }
        public string MaPhong { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public int ChiSoDienCu { get; set; }
        public int ChiSoDienMoi { get; set; }
        public int ChiSoNuocCu { get; set; }
        public int ChiSoNuocMoi { get; set; }
        public decimal DonGiaDien { get; set; }
        public decimal DonGiaNuoc { get; set; }
        public decimal TongTien { get; set; }
        public bool DaThanhToan { get; set; }

        public int SoDienTieuThu => Math.Max(0, ChiSoDienMoi - ChiSoDienCu);
        public int SoNuocTieuThu => Math.Max(0, ChiSoNuocMoi - ChiSoNuocCu);

        public DienNuoc()
        {
            Thang = DateTime.Today.Month;
            Nam = DateTime.Today.Year;
            DonGiaDien = 3000;
            DonGiaNuoc = 15000;
            DaThanhToan = false;
        }

        public DienNuoc(string maDienNuoc, string maPhong, int thang, int nam, int chiSoDienCu, int chiSoDienMoi, int chiSoNuocCu, int chiSoNuocMoi, decimal donGiaDien, decimal donGiaNuoc, decimal tongTien, bool daThanhToan)
        {
            MaDienNuoc = maDienNuoc;
            MaPhong = maPhong;
            Thang = thang;
            Nam = nam;
            ChiSoDienCu = chiSoDienCu;
            ChiSoDienMoi = chiSoDienMoi;
            ChiSoNuocCu = chiSoNuocCu;
            ChiSoNuocMoi = chiSoNuocMoi;
            DonGiaDien = donGiaDien;
            DonGiaNuoc = donGiaNuoc;
            TongTien = tongTien;
            DaThanhToan = daThanhToan;
        }

        public override string ToString()
        {
            return $"Điện Nước {MaDienNuoc} - Phòng {MaPhong} (Tháng {Thang}/{Nam})";
        }
    }
}
