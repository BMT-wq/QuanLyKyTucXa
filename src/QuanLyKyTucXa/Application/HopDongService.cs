using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
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
            if (string.IsNullOrWhiteSpace(maSV)) return null;
            return _context.DanhSachSinhVien.FirstOrDefault(s => s.MaSV.Equals(maSV.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public bool ThemSinhVien(SinhVien sv, out string error)
        {
            if (sv == null)
            {
                error = "Dữ liệu sinh viên không hợp lệ!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(sv.MaSV))
            {
                error = "Mã sinh viên không được để trống!";
                return false;
            }
            if (_context.DanhSachSinhVien.Any(s => s.MaSV.Equals(sv.MaSV.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                error = $"Mã sinh viên '{sv.MaSV}' đã tồn tại trong hệ thống!";
                return false;
            }

            _context.DanhSachSinhVien.Add(sv);
            _context.SaveSinhVien();
            error = string.Empty;
            return true;
        }

        public bool CapNhatSinhVien(SinhVien sv, out string error)
        {
            if (sv == null || string.IsNullOrWhiteSpace(sv.MaSV))
            {
                error = "Dữ liệu sinh viên không hợp lệ!";
                return false;
            }

            var existing = GetSinhVienById(sv.MaSV);
            if (existing == null)
            {
                error = "Không tìm thấy sinh viên cần cập nhật!";
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
                error = "Không thể xóa sinh viên đang có hợp đồng thuê phòng còn hiệu lực!";
                return false;
            }

            _context.DanhSachSinhVien.Remove(existing);
            _context.SaveSinhVien();
            error = string.Empty;
            return true;
        }

        public List<SinhVien> TimKiemSinhVien(string keyword)
        {
            string kw = ChuanHoaTimKiem(keyword);
            if (kw.Length == 0)
            {
                return _context.DanhSachSinhVien;
            }

            return _context.DanhSachSinhVien.Where(s =>
                ChuanHoaTimKiem(s.MaSV).Contains(kw) ||
                ChuanHoaTimKiem(s.HoTen).Contains(kw) ||
                ChuanHoaTimKiem(s.SoCMND_CCCD).Contains(kw) ||
                ChuanHoaTimKiem(s.Lop).Contains(kw) ||
                ChuanHoaTimKiem(s.Khoa).Contains(kw) ||
                ChuanHoaTimKiem(s.QueQuan).Contains(kw)
            ).ToList();
        }

        public List<SinhVien> LocSinhVien(string khoa, string gioiTinh)
        {
            var query = _context.DanhSachSinhVien.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(khoa) && khoa != "Tất cả")
            {
                query = query.Where(s => s.Khoa != null && s.Khoa.Equals(khoa, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(gioiTinh) && gioiTinh != "Tất cả")
            {
                query = query.Where(s => s.GioiTinh != null && s.GioiTinh.Equals(gioiTinh, StringComparison.OrdinalIgnoreCase));
            }

            return query.ToList();
        }

        public string SinhMaSinhVienTuDong()
        {
            int maxId = 0;
            foreach (var sv in _context.DanhSachSinhVien)
            {
                if (!string.IsNullOrEmpty(sv.MaSV) && sv.MaSV.StartsWith("SV", StringComparison.OrdinalIgnoreCase))
                {
                    string numPart = sv.MaSV.Substring(2);
                    if (int.TryParse(numPart, out int val) && val > maxId)
                    {
                        maxId = val;
                    }
                }
            }
            return $"SV{(maxId + 1):D3}";
        }

        public List<string> GetDanhSachKhoa()
        {
            return _context.DanhSachSinhVien
                .Where(s => !string.IsNullOrWhiteSpace(s.Khoa))
                .Select(s => s.Khoa.Trim())
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(k => k)
                .ToList();
        }
        #endregion

        #region Hợp đồng
        public List<HopDong> GetAllHopDong() => _context.DanhSachHopDong;

        public HopDong GetHopDongById(string maHD)
        {
            if (string.IsNullOrWhiteSpace(maHD)) return null;
            return _context.DanhSachHopDong.FirstOrDefault(h => h.MaHopDong.Equals(maHD.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public bool KiemTraSinhVienCoHopDongHieuLuc(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV)) return false;
            return _context.DanhSachHopDong.Any(h => h.MaSV.Equals(maSV.Trim(), StringComparison.OrdinalIgnoreCase) && h.TrangThai == "Hiệu lực");
        }

        public List<Phong> GetDanhSachPhongConTrong(string gioiTinh = null)
        {
            var phongConTrong = _context.DanhSachPhong
                .Where(p => p.SoChoHienTai < p.SoChoToiDa && p.TrangThai != "Đang sửa chữa");

            string gt = ChuanHoaGioiTinh(gioiTinh);
            if (gt.Length > 0)
            {
                phongConTrong = phongConTrong.Where(p => ChuanHoaGioiTinh(p.LoaiPhong) == gt);
            }

            return phongConTrong.ToList();
        }

        /// <summary>
        /// Kiểm tra giới tính sinh viên có phù hợp với loại phòng (Nam/Nữ) hay không.
        /// </summary>
        public static bool KiemTraGioiTinhPhuHop(SinhVien sv, Phong phong)
        {
            if (sv == null || phong == null) return false;

            string gioiTinh = ChuanHoaGioiTinh(sv.GioiTinh);
            string loaiPhong = ChuanHoaGioiTinh(phong.LoaiPhong);

            // Nếu dữ liệu giới tính/loại phòng không xác định thì không chặn,
            // các kiểm tra khác (sức chứa, trạng thái) vẫn được áp dụng.
            if (gioiTinh.Length == 0 || loaiPhong.Length == 0) return true;

            return gioiTinh == loaiPhong;
        }

        /// <summary>
        /// Chuẩn hóa giới tính về "nam"/"nu" để so sánh.
        /// </summary>
        public static string ChuanHoaGioiTinh(string value)
        {
            string v = ChuanHoaTimKiem(value);
            if (v == "nam" || v == "male" || v == "m") return "nam";
            if (v == "nu" || v == "female" || v == "f") return "nu";
            return v;
        }

        /// <summary>
        /// Chuẩn hóa chuỗi tìm kiếm: bỏ dấu tiếng Việt, chuyển chữ thường để tìm gần đúng.
        /// </summary>
        public static string ChuanHoaTimKiem(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return string.Empty;

            string lower = value.Trim().ToLowerInvariant().Replace('đ', 'd');
            string normalized = lower.Normalize(NormalizationForm.FormD);

            var builder = new StringBuilder(normalized.Length);
            foreach (char c in normalized)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    builder.Append(c);
                }
            }

            return builder.ToString().Normalize(NormalizationForm.FormC);
        }

        public bool TaoHopDong(HopDong hd, out string error)
        {
            if (hd == null)
            {
                error = "Dữ liệu hợp đồng không hợp lệ!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(hd.MaHopDong))
            {
                error = "Mã hợp đồng không được để trống!";
                return false;
            }
            if (_context.DanhSachHopDong.Any(h => h.MaHopDong.Equals(hd.MaHopDong.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                error = $"Mã hợp đồng '{hd.MaHopDong}' đã tồn tại trong hệ thống!";
                return false;
            }

            // Kiểm tra sinh viên có tồn tại không
            var sv = GetSinhVienById(hd.MaSV);
            if (sv == null)
            {
                error = "Sinh viên không tồn tại trong danh sách hồ sơ!";
                return false;
            }

            // Kiểm tra sinh viên có hợp đồng còn hiệu lực không
            if (_context.DanhSachHopDong.Any(h => h.MaSV.Equals(hd.MaSV, StringComparison.OrdinalIgnoreCase) && h.TrangThai == "Hiệu lực"))
            {
                error = $"Sinh viên '{sv.HoTen} ({sv.MaSV})' hiện đã có hợp đồng thuê phòng đang còn hiệu lực!";
                return false;
            }

            // Kiểm tra phòng có tồn tại và còn chỗ không
            var phong = _context.DanhSachPhong.FirstOrDefault(p => p.MaPhong.Equals(hd.MaPhong, StringComparison.OrdinalIgnoreCase));
            if (phong == null)
            {
                error = "Phòng được chọn không tồn tại!";
                return false;
            }
            if (!KiemTraGioiTinhPhuHop(sv, phong))
            {
                error = $"Không thể xếp sinh viên '{sv.HoTen} ({sv.MaSV})' là {(ChuanHoaGioiTinh(sv.GioiTinh) == "nu" ? "Nữ" : "Nam")} " +
                        $"vào phòng '{phong.TenPhong}' dành cho {phong.LoaiPhong}. " +
                        "Vui lòng chọn phòng phù hợp với giới tính của sinh viên!";
                return false;
            }
            if (phong.TrangThai == "Đang sửa chữa")
            {
                error = $"Phòng '{phong.TenPhong}' đang trong trạng thái sửa chữa, không thể xếp phòng!";
                return false;
            }
            if (phong.SoChoHienTai >= phong.SoChoToiDa)
            {
                error = $"Phòng '{phong.TenPhong}' đã đầy ({phong.SoChoHienTai}/{phong.SoChoToiDa}), không thể thêm sinh viên!";
                return false;
            }

            // Kiểm tra ngày tháng
            if (hd.NgayKetThuc <= hd.NgayBatDau)
            {
                error = "Ngày kết thúc hợp đồng phải sau ngày bắt đầu!";
                return false;
            }

            // Cập nhật số chỗ trong phòng
            phong.SoChoHienTai++;
            if (phong.SoChoHienTai >= phong.SoChoToiDa)
            {
                phong.TrangThai = "Đã đầy";
            }
            else
            {
                phong.TrangThai = "Còn chỗ";
            }

            hd.TrangThai = "Hiệu lực";
            _context.DanhSachHopDong.Add(hd);
            _context.SaveHopDong();
            _context.SavePhong();

            error = string.Empty;
            return true;
        }

        public bool GiaHanHopDong(string maHD, DateTime ngayKetThucMoi, out string error)
        {
            var hd = GetHopDongById(maHD);
            if (hd == null)
            {
                error = "Không tìm thấy hợp đồng!";
                return false;
            }
            if (hd.TrangThai != "Hiệu lực")
            {
                error = $"Chỉ có thể gia hạn hợp đồng đang trong trạng thái 'Hiệu lực'! (Trạng thái hiện tại: {hd.TrangThai})";
                return false;
            }
            if (ngayKetThucMoi <= hd.NgayBatDau)
            {
                error = "Ngày kết thúc gia hạn mới phải sau ngày bắt đầu hợp đồng!";
                return false;
            }
            if (ngayKetThucMoi <= hd.NgayKetThuc)
            {
                error = $"Ngày kết thúc gia hạn ({ngayKetThucMoi:dd/MM/yyyy}) phải sau ngày kết thúc hiện tại ({hd.NgayKetThuc:dd/MM/yyyy})!";
                return false;
            }

            hd.NgayKetThuc = ngayKetThucMoi;
            _context.SaveHopDong();

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
                if (phong.TrangThai == "Đã đầy" && phong.SoChoHienTai < phong.SoChoToiDa)
                {
                    phong.TrangThai = "Còn chỗ";
                }
                _context.SavePhong();
            }

            _context.SaveHopDong();
            error = string.Empty;
            return true;
        }

        public List<HopDong> TimKiemHopDong(string keyword)
        {
            string kw = ChuanHoaTimKiem(keyword);
            if (kw.Length == 0)
            {
                return _context.DanhSachHopDong;
            }

            // Tìm theo tên, mã sinh viên hoặc lớp của sinh viên trong hợp đồng
            var maSinhVienKhop = new HashSet<string>(
                _context.DanhSachSinhVien
                    .Where(s => ChuanHoaTimKiem(s.MaSV).Contains(kw) ||
                                ChuanHoaTimKiem(s.HoTen).Contains(kw) ||
                                ChuanHoaTimKiem(s.Lop).Contains(kw))
                    .Select(s => s.MaSV),
                StringComparer.OrdinalIgnoreCase);

            return _context.DanhSachHopDong.Where(h =>
                ChuanHoaTimKiem(h.MaHopDong).Contains(kw) ||
                ChuanHoaTimKiem(h.MaSV).Contains(kw) ||
                ChuanHoaTimKiem(h.MaPhong).Contains(kw) ||
                ChuanHoaTimKiem(h.TrangThai).Contains(kw) ||
                ChuanHoaTimKiem(h.GhiChu).Contains(kw) ||
                maSinhVienKhop.Contains(h.MaSV)
            ).ToList();
        }

        public List<HopDong> LocHopDong(string trangThai, string maPhong)
        {
            var query = _context.DanhSachHopDong.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(trangThai) && trangThai != "Tất cả")
            {
                query = query.Where(h => h.TrangThai != null && h.TrangThai.Equals(trangThai, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(maPhong) && maPhong != "Tất cả")
            {
                query = query.Where(h => h.MaPhong != null && h.MaPhong.Equals(maPhong, StringComparison.OrdinalIgnoreCase));
            }

            return query.ToList();
        }

        public string SinhMaHopDongTuDong()
        {
            int maxId = 0;
            foreach (var hd in _context.DanhSachHopDong)
            {
                if (!string.IsNullOrEmpty(hd.MaHopDong) && hd.MaHopDong.StartsWith("HD", StringComparison.OrdinalIgnoreCase))
                {
                    string numPart = hd.MaHopDong.Substring(2);
                    if (int.TryParse(numPart, out int val) && val > maxId)
                    {
                        maxId = val;
                    }
                }
            }
            return $"HD{(maxId + 1):D3}";
        }
        #endregion
    }
}
