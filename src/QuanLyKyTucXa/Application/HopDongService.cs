using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyKyTucXa.Domain;

namespace QuanLyKyTucXa.Application
{
    /// <summary>
    /// Xử lý nghiệp vụ phân hệ Quản lý Sinh viên & Hợp đồng thuê phòng (Sinh viên 2 phụ trách).
    /// </summary>
    public class HopDongService
    {
        private readonly DataContext _context;

        public HopDongService(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        #region Sinh viên
        public List<SinhVien> GetAllSinhVien() => _context.DanhSachSinhVien;

        public SinhVien GetSinhVienById(string maSV)
        {
            return _context.DanhSachSinhVien.FirstOrDefault(s => s.MaSV.Equals(maSV, StringComparison.OrdinalIgnoreCase));
        }

        public bool ThemSinhVien(SinhVien sv, out string error)
        {
            if (sv == null)
            {
                error = "Dữ liệu sinh viên không hợp lệ!";
                return false;
            }
            if (_context.DanhSachSinhVien.Any(s => s.MaSV.Equals(sv.MaSV, StringComparison.OrdinalIgnoreCase)))
            {
                error = $"Mã sinh viên '{sv.MaSV}' đã tồn tại!";
                return false;
            }

            _context.DanhSachSinhVien.Add(sv);
            _context.SaveSinhVien();
            error = string.Empty;
            return true;
        }

        public bool CapNhatSinhVien(SinhVien sv, out string error)
        {
            var existing = GetSinhVienById(sv?.MaSV);
            if (existing == null)
            {
                error = "Không tìm thấy sinh viên!";
                return false;
            }

            existing.HoTen = sv.HoTen;
            existing.NgaySinh = sv.NgaySinh;
            existing.GioiTinh = sv.GioiTinh;
            existing.SoCMND_CCCD = sv.SoCMND_CCCD;
            existing.SoDienThoai = sv.SoDienThoai;
            existing.Email = sv.Email;
            existing.Lop = sv.Lop;
            existing.Khoa = sv.Khoa;
            existing.QueQuan = sv.QueQuan;

            _context.SaveSinhVien();
            error = string.Empty;
            return true;
        }

        public bool XoaSinhVien(string maSV, out string error)
        {
            var existing = GetSinhVienById(maSV);
            if (existing == null)
            {
                error = "Sinh viên không tồn tại!";
                return false;
            }
            if (_context.DanhSachHopDong.Any(h => h.MaSV.Equals(maSV, StringComparison.OrdinalIgnoreCase) && h.TrangThai == "Hiệu lực"))
            {
                error = "Không thể xóa sinh viên đang có hợp đồng còn hiệu lực!";
                return false;
            }

            _context.DanhSachSinhVien.Remove(existing);
            _context.SaveSinhVien();
            error = string.Empty;
            return true;
        }
        #endregion

        #region Hợp đồng
        public List<HopDong> GetAllHopDong() => _context.DanhSachHopDong;

        public HopDong GetHopDongById(string maHD)
        {
            return _context.DanhSachHopDong.FirstOrDefault(h => h.MaHopDong.Equals(maHD, StringComparison.OrdinalIgnoreCase));
        }

        public bool TaoHopDong(HopDong hd, out string error)
        {
            if (hd == null)
            {
                error = "Dữ liệu hợp đồng không hợp lệ!";
                return false;
            }
            if (_context.DanhSachHopDong.Any(h => h.MaHopDong.Equals(hd.MaHopDong, StringComparison.OrdinalIgnoreCase)))
            {
                error = $"Mã hợp đồng '{hd.MaHopDong}' đã tồn tại!";
                return false;
            }

            // Kiểm tra sinh viên có hợp đồng còn hiệu lực không
            if (_context.DanhSachHopDong.Any(h => h.MaSV.Equals(hd.MaSV, StringComparison.OrdinalIgnoreCase) && h.TrangThai == "Hiệu lực"))
            {
                error = "Sinh viên này hiện đã có hợp đồng thuê phòng đang còn hiệu lực!";
                return false;
            }

            // Kiểm tra phòng có tồn tại và còn chỗ không
            var phong = _context.DanhSachPhong.FirstOrDefault(p => p.MaPhong.Equals(hd.MaPhong, StringComparison.OrdinalIgnoreCase));
            if (phong == null)
            {
                error = "Phòng không tồn tại!";
                return false;
            }
            if (phong.SoChoHienTai >= phong.SoChoToiDa)
            {
                error = "Phòng đã đầy, không thể thêm sinh viên!";
                return false;
            }

            // Cập nhật số chỗ trong phòng
            phong.SoChoHienTai++;
            if (phong.SoChoHienTai >= phong.SoChoToiDa)
            {
                phong.TrangThai = "Đã đầy";
            }

            _context.DanhSachHopDong.Add(hd);
            _context.SaveHopDong();
            _context.SavePhong();

            error = string.Empty;
            return true;
        }

        public bool ThanhLyHopDong(string maHD, out string error)
        {
            var hd = GetHopDongById(maHD);
            if (hd == null)
            {
                error = "Không tìm thấy hợp đồng!";
                return false;
            }
            if (hd.TrangThai == "Đã thanh lý")
            {
                error = "Hợp đồng này đã được thanh lý trước đó!";
                return false;
            }

            hd.TrangThai = "Đã thanh lý";

            // Giảm số người trong phòng
            var phong = _context.DanhSachPhong.FirstOrDefault(p => p.MaPhong.Equals(hd.MaPhong, StringComparison.OrdinalIgnoreCase));
            if (phong != null && phong.SoChoHienTai > 0)
            {
                phong.SoChoHienTai--;
                if (phong.TrangThai == "Đã đầy")
                {
                    phong.TrangThai = "Còn chỗ";
                }
                _context.SavePhong();
            }

            _context.SaveHopDong();
            error = string.Empty;
            return true;
        }
        #endregion
    }
}
