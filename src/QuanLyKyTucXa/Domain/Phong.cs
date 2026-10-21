using System;

namespace QuanLyKyTucXa.Domain
{
    /// <summary>
    /// Đại diện cho phòng ký túc xá.
    /// </summary>
    public class Phong
    {
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public string MaToaNha { get; set; }
        public string LoaiPhong { get; set; } // Nam, Nữ
        public int SoChoToiDa { get; set; }
        public int SoChoHienTai { get; set; }
        public decimal GiaPhong { get; set; }
        public string TrangThai { get; set; } // Còn chỗ, Đầy, Đang sửa chữa

        public int SoChoTrong => Math.Max(0, SoChoToiDa - SoChoHienTai);

        public Phong()
        {
            SoChoToiDa = 4;
            SoChoHienTai = 0;
            TrangThai = "Còn chỗ";
            LoaiPhong = "Nam";
        }

        public Phong(string maPhong, string tenPhong, string maToaNha, string loaiPhong, int soChoToiDa, int soChoHienTai, decimal giaPhong, string trangThai)
        {
            MaPhong = maPhong;
            TenPhong = tenPhong;
            MaToaNha = maToaNha;
            LoaiPhong = loaiPhong;
            SoChoToiDa = soChoToiDa;
            SoChoHienTai = soChoHienTai;
            GiaPhong = giaPhong;
            TrangThai = trangThai;
        }

        public override string ToString()
        {
            return $"{TenPhong} ({MaPhong}) - {LoaiPhong} [{SoChoHienTai}/{SoChoToiDa}]";
        }
    }
}
