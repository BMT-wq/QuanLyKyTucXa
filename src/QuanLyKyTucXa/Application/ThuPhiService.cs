using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyKyTucXa.Domain;

namespace QuanLyKyTucXa.Application
{
    /// <summary>
    /// Xử lý nghiệp vụ phân hệ Quản lý Điện nước & Thu phí (Sinh viên 3 phụ trách - Tấn Quốc).
    /// </summary>
    public class ThuPhiService
    {
        private readonly DataContext _context;

        public ThuPhiService(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        #region Điện Nước
        public List<DienNuoc> GetAllDienNuoc() => _context.DanhSachDienNuoc;

        public DienNuoc GetDienNuocById(string maDienNuoc)
        {
            return _context.DanhSachDienNuoc.FirstOrDefault(d => d.MaDienNuoc.Equals(maDienNuoc, StringComparison.OrdinalIgnoreCase));
        }

        public List<DienNuoc> GetDienNuocByPhong(string maPhong)
        {
            return _context.DanhSachDienNuoc.Where(d => d.MaPhong.Equals(maPhong, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public decimal TinhTongTien(int dienCu, int dienMoi, int nuocCu, int nuocMoi, decimal donGiaDien, decimal donGiaNuoc)
        {
            int soDien = Math.Max(0, dienMoi - dienCu);
            int soNuoc = Math.Max(0, nuocMoi - nuocCu);
            return (soDien * donGiaDien) + (soNuoc * donGiaNuoc);
        }

        public bool GhiChiSoDienNuoc(DienNuoc dn, out string error)
        {
            if (dn == null)
            {
                error = "Dữ liệu điện nước không hợp lệ!";
                return false;
            }
            if (_context.DanhSachDienNuoc.Any(d => d.MaDienNuoc.Equals(dn.MaDienNuoc, StringComparison.OrdinalIgnoreCase)))
            {
                error = $"Mã bản ghi điện nước '{dn.MaDienNuoc}' đã tồn tại!";
                return false;
            }
            if (dn.ChiSoDienMoi < dn.ChiSoDienCu)
            {
                error = "Chỉ số điện mới không được nhỏ hơn chỉ số điện cũ!";
                return false;
            }
            if (dn.ChiSoNuocMoi < dn.ChiSoNuocCu)
            {
                error = "Chỉ số nước mới không được nhỏ hơn chỉ số nước cũ!";
                return false;
            }

            dn.TongTien = TinhTongTien(dn.ChiSoDienCu, dn.ChiSoDienMoi, dn.ChiSoNuocCu, dn.ChiSoNuocMoi, dn.DonGiaDien, dn.DonGiaNuoc);

            _context.DanhSachDienNuoc.Add(dn);
            _context.SaveDienNuoc();
            error = string.Empty;
            return true;
        }

        public bool CapNhatChiSoDienNuoc(DienNuoc dn, out string error)
        {
            if (dn == null)
            {
                error = "Dữ liệu điện nước không hợp lệ!";
                return false;
            }

            var existing = GetDienNuocById(dn.MaDienNuoc);
            if (existing == null)
            {
                error = "Không tìm thấy bản ghi điện nước cần cập nhật!";
                return false;
            }

            if (dn.ChiSoDienMoi < dn.ChiSoDienCu)
            {
                error = "Chỉ số điện mới không được nhỏ hơn chỉ số điện cũ!";
                return false;
            }
            if (dn.ChiSoNuocMoi < dn.ChiSoNuocCu)
            {
                error = "Chỉ số nước mới không được nhỏ hơn chỉ số nước cũ!";
                return false;
            }

            existing.MaPhong = dn.MaPhong;
            existing.Thang = dn.Thang;
            existing.Nam = dn.Nam;
            existing.ChiSoDienCu = dn.ChiSoDienCu;
            existing.ChiSoDienMoi = dn.ChiSoDienMoi;
            existing.ChiSoNuocCu = dn.ChiSoNuocCu;
            existing.ChiSoNuocMoi = dn.ChiSoNuocMoi;
            existing.DonGiaDien = dn.DonGiaDien;
            existing.DonGiaNuoc = dn.DonGiaNuoc;
            existing.TongTien = TinhTongTien(dn.ChiSoDienCu, dn.ChiSoDienMoi, dn.ChiSoNuocCu, dn.ChiSoNuocMoi, dn.DonGiaDien, dn.DonGiaNuoc);
            existing.DaThanhToan = dn.DaThanhToan;

            _context.SaveDienNuoc();
            error = string.Empty;
            return true;
        }

        public bool XoaChiSoDienNuoc(string maDienNuoc, out string error)
        {
            var dn = GetDienNuocById(maDienNuoc);
            if (dn == null)
            {
                error = "Bản ghi điện nước không tồn tại!";
                return false;
            }

            _context.DanhSachDienNuoc.Remove(dn);
            _context.SaveDienNuoc();
            error = string.Empty;
            return true;
        }

        public bool XacNhanThanhToanDienNuoc(string maDienNuoc, out string error)
        {
            var dn = GetDienNuocById(maDienNuoc);
            if (dn == null)
            {
                error = "Không tìm thấy bản ghi điện nước!";
                return false;
            }

            dn.DaThanhToan = true;
            _context.SaveDienNuoc();
            error = string.Empty;
            return true;
        }

        public List<DienNuoc> LocDienNuoc(string maPhong = null, int? thang = null, int? nam = null, bool? daThanhToan = null)
        {
            var query = _context.DanhSachDienNuoc.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(maPhong) && !maPhong.Equals("Tất cả", StringComparison.OrdinalIgnoreCase))
            {
                query = query.Where(d => d.MaPhong.IndexOf(maPhong.Trim(), StringComparison.OrdinalIgnoreCase) >= 0);
            }
            if (thang.HasValue && thang.Value > 0)
            {
                query = query.Where(d => d.Thang == thang.Value);
            }
            if (nam.HasValue && nam.Value > 0)
            {
                query = query.Where(d => d.Nam == nam.Value);
            }
            if (daThanhToan.HasValue)
            {
                query = query.Where(d => d.DaThanhToan == daThanhToan.Value);
            }

            return query.OrderByDescending(d => d.Nam).ThenByDescending(d => d.Thang).ToList();
        }

        public string SinhMaDienNuocTuDong(string maPhong, int thang, int nam)
        {
            string cleanPhong = string.IsNullOrWhiteSpace(maPhong) ? "P" : maPhong.Trim().Replace(" ", "");
            string prefix = $"DN-{cleanPhong}-{thang:D2}{nam % 100:D2}";
            if (!_context.DanhSachDienNuoc.Any(d => d.MaDienNuoc.Equals(prefix, StringComparison.OrdinalIgnoreCase)))
            {
                return prefix;
            }

            int count = 1;
            while (_context.DanhSachDienNuoc.Any(d => d.MaDienNuoc.Equals($"{prefix}-{count}", StringComparison.OrdinalIgnoreCase)))
            {
                count++;
            }
            return $"{prefix}-{count}";
        }
        #endregion

        #region Thu Phí
        public List<ThuPhi> GetAllThuPhi() => _context.DanhSachThuPhi;

        public ThuPhi GetThuPhiById(string maPhieuThu)
        {
            return _context.DanhSachThuPhi.FirstOrDefault(t => t.MaPhieuThu.Equals(maPhieuThu, StringComparison.OrdinalIgnoreCase));
        }

        public bool LapPhieuThu(ThuPhi tp, out string error)
        {
            if (tp == null)
            {
                error = "Dữ liệu phiếu thu không hợp lệ!";
                return false;
            }
            if (_context.DanhSachThuPhi.Any(t => t.MaPhieuThu.Equals(tp.MaPhieuThu, StringComparison.OrdinalIgnoreCase)))
            {
                error = $"Mã phiếu thu '{tp.MaPhieuThu}' đã tồn tại!";
                return false;
            }
            if (tp.SoTien <= 0)
            {
                error = "Số tiền thu phải lớn hơn 0!";
                return false;
            }

            _context.DanhSachThuPhi.Add(tp);
            _context.SaveThuPhi();
            error = string.Empty;
            return true;
        }

        public bool CapNhatPhieuThu(ThuPhi tp, out string error)
        {
            if (tp == null)
            {
                error = "Dữ liệu phiếu thu không hợp lệ!";
                return false;
            }

            var existing = GetThuPhiById(tp.MaPhieuThu);
            if (existing == null)
            {
                error = "Không tìm thấy phiếu thu cần cập nhật!";
                return false;
            }
            if (tp.SoTien <= 0)
            {
                error = "Số tiền thu phải lớn hơn 0!";
                return false;
            }

            existing.MaHopDong = tp.MaHopDong;
            existing.MaPhong = tp.MaPhong;
            existing.LoaiPhi = tp.LoaiPhi;
            existing.Thang = tp.Thang;
            existing.Nam = tp.Nam;
            existing.SoTien = tp.SoTien;
            existing.NgayThu = tp.NgayThu;
            existing.NguoiThu = tp.NguoiThu;
            existing.GhiChu = tp.GhiChu;

            _context.SaveThuPhi();
            error = string.Empty;
            return true;
        }

        public bool XoaPhieuThu(string maPhieuThu, out string error)
        {
            var tp = GetThuPhiById(maPhieuThu);
            if (tp == null)
            {
                error = "Phiếu thu không tồn tại!";
                return false;
            }

            _context.DanhSachThuPhi.Remove(tp);
            _context.SaveThuPhi();
            error = string.Empty;
            return true;
        }

        public List<ThuPhi> LocThuPhi(string maPhong = null, string loaiPhi = null, int? thang = null, int? nam = null)
        {
            var query = _context.DanhSachThuPhi.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(maPhong) && !maPhong.Equals("Tất cả", StringComparison.OrdinalIgnoreCase))
            {
                query = query.Where(t => t.MaPhong.IndexOf(maPhong.Trim(), StringComparison.OrdinalIgnoreCase) >= 0);
            }
            if (!string.IsNullOrWhiteSpace(loaiPhi) && !loaiPhi.Equals("Tất cả", StringComparison.OrdinalIgnoreCase))
            {
                query = query.Where(t => t.LoaiPhi.Equals(loaiPhi.Trim(), StringComparison.OrdinalIgnoreCase));
            }
            if (thang.HasValue && thang.Value > 0)
            {
                query = query.Where(t => t.Thang == thang.Value);
            }
            if (nam.HasValue && nam.Value > 0)
            {
                query = query.Where(t => t.Nam == nam.Value);
            }

            return query.OrderByDescending(t => t.NgayThu).ToList();
        }

        public decimal ThongKeDoanhThu(int? thang = null, int? nam = null, string loaiPhi = null)
        {
            var list = LocThuPhi(null, loaiPhi, thang, nam);
            return list.Sum(t => t.SoTien);
        }

        public List<DienNuoc> ThongKeCongNoDienNuoc(out decimal tongTienNo)
        {
            var list = _context.DanhSachDienNuoc.Where(d => !d.DaThanhToan).ToList();
            tongTienNo = list.Sum(d => d.TongTien);
            return list;
        }

        public string SinhMaPhieuThuTuDong()
        {
            string prefix = $"PT{DateTime.Today:yyMM}";
            int maxId = 0;
            foreach (var tp in _context.DanhSachThuPhi)
            {
                if (tp.MaPhieuThu != null && tp.MaPhieuThu.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                {
                    string suffix = tp.MaPhieuThu.Substring(prefix.Length);
                    if (int.TryParse(suffix, out int id) && id > maxId)
                    {
                        maxId = id;
                    }
                }
            }
            return $"{prefix}{(maxId + 1):D3}";
        }
        #endregion

        #region Nghiệp vụ Mở rộng (SV3: Tìm phòng, Chia tiền đều, Trả phòng trước hạn, Đồng hồ hợp đồng, Quyết toán trả cọc)
        /// <summary>
        /// Lấy danh sách phòng duy nhất theo MaPhong và tự động đồng bộ sĩ số thực tế theo hợp đồng hiệu lực.
        /// </summary>
        public List<Phong> GetAllPhong()
        {
            var distinctPhongList = new List<Phong>();
            var seenMaPhong = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            // Duyệt từ cuối danh sách lên để ưu tiên thông tin mới nhất
            for (int i = _context.DanhSachPhong.Count - 1; i >= 0; i--)
            {
                var p = _context.DanhSachPhong[i];
                if (!string.IsNullOrWhiteSpace(p.MaPhong) && seenMaPhong.Add(p.MaPhong.Trim()))
                {
                    // Tự động đồng bộ số chỗ hiện tại theo số sinh viên có hợp đồng hiệu lực thực tế
                    p.SoChoHienTai = GetSoNguoiDangOPhong(p.MaPhong);
                    if (p.SoChoHienTai >= p.SoChoToiDa)
                    {
                        p.TrangThai = "Đã đầy";
                    }
                    else if (p.TrangThai != "Đang sửa chữa")
                    {
                        p.TrangThai = "Còn chỗ";
                    }
                    distinctPhongList.Add(p);
                }
            }
            distinctPhongList.Reverse();
            return distinctPhongList;
        }

        public Phong GetPhongById(string maPhong)
        {
            if (string.IsNullOrWhiteSpace(maPhong)) return null;
            return GetAllPhong().FirstOrDefault(p => p.MaPhong.Equals(maPhong.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public SinhVien GetSinhVienById(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV)) return null;
            return _context.DanhSachSinhVien.FirstOrDefault(s => s.MaSV.Equals(maSV.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public HopDong GetHopDongById(string maHD)
        {
            if (string.IsNullOrWhiteSpace(maHD)) return null;
            return _context.DanhSachHopDong.FirstOrDefault(h => h.MaHopDong.Equals(maHD.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Lấy danh sách hợp đồng đang có hiệu lực tại một phòng cụ thể (đã loại bỏ trùng lặp sinh viên).
        /// </summary>
        public List<HopDong> GetDanhSachHopDongHieuLucCuaPhong(string maPhong)
        {
            if (string.IsNullOrWhiteSpace(maPhong)) return new List<HopDong>();

            var rawList = _context.DanhSachHopDong
                .Where(h => h.MaPhong.Equals(maPhong.Trim(), StringComparison.OrdinalIgnoreCase) &&
                            h.TrangThai.Equals("Hiệu lực", StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Loại bỏ bản ghi trùng lặp: Mỗi sinh viên trong phòng chỉ tính tối đa 1 hợp đồng
            var distinctList = new List<HopDong>();
            var seenSV = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (var hd in rawList)
            {
                string svKey = hd.MaSV?.Trim() ?? "";
                if (!string.IsNullOrEmpty(svKey) && seenSV.Add(svKey))
                {
                    distinctList.Add(hd);
                }
            }
            return distinctList;
        }

        /// <summary>
        /// Lấy số người thực tế đang ở trong phòng (theo số lượng sinh viên có hợp đồng hiệu lực).
        /// </summary>
        public int GetSoNguoiDangOPhong(string maPhong)
        {
            return GetDanhSachHopDongHieuLucCuaPhong(maPhong).Count;
        }

        /// <summary>
        /// Lấy chỉ số điện nước mới nhất của phòng để làm chỉ số cũ cho lần ghi tiếp theo.
        /// </summary>
        public void GetChiSoDienNuocMoiNhatCuaPhong(string maPhong, out int dienMoi, out int nuocMoi)
        {
            dienMoi = 0;
            nuocMoi = 0;
            if (string.IsNullOrWhiteSpace(maPhong)) return;

            var list = _context.DanhSachDienNuoc
                .Where(d => d.MaPhong.Equals(maPhong.Trim(), StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(d => d.Nam)
                .ThenByDescending(d => d.Thang)
                .ToList();

            if (list.Count > 0)
            {
                dienMoi = list[0].ChiSoDienMoi;
                nuocMoi = list[0].ChiSoNuocMoi;
            }
        }

        /// <summary>
        /// Tính logic chia tiền điện nước đều cho các sinh viên đang ở trong phòng.
        /// </summary>
        public bool TinhChiaTienDienNuoc(string maDienNuoc, out int soSV, out decimal tienMoiSV, out List<HopDong> dsHopDong, out string thongTin)
        {
            soSV = 0;
            tienMoiSV = 0;
            dsHopDong = new List<HopDong>();
            thongTin = string.Empty;

            var dn = GetDienNuocById(maDienNuoc);
            if (dn == null)
            {
                thongTin = "Không tìm thấy hóa đơn điện nước!";
                return false;
            }

            dsHopDong = GetDanhSachHopDongHieuLucCuaPhong(dn.MaPhong);
            soSV = dsHopDong.Count;

            if (soSV == 0)
            {
                tienMoiSV = dn.TongTien;
                thongTin = $"Phòng '{dn.MaPhong}' hiện không có sinh viên nào có hợp đồng 'Hiệu lực'. Tổng tiền {dn.TongTien:N0} đ.";
                return true;
            }

            tienMoiSV = Math.Round(dn.TongTien / soSV, 0);
            thongTin = $"Phòng {dn.MaPhong} có {soSV} sinh viên đang ở. Tổng tiền: {dn.TongTien:N0} đ => Chia đều: {tienMoiSV:N0} đ/sinh viên.";
            return true;
        }

        /// <summary>
        /// Tự động lập các phiếu thu tiền điện nước chia đều cho từng sinh viên trong phòng.
        /// </summary>
        public bool LapPhieuThuChiaDeuDienNuoc(string maDienNuoc, string nguoiThu, out string error)
        {
            if (!TinhChiaTienDienNuoc(maDienNuoc, out int soSV, out decimal tienMoiSV, out List<HopDong> dsHopDong, out string thongTin))
            {
                error = thongTin;
                return false;
            }

            if (soSV == 0)
            {
                error = "Phòng không có sinh viên đang ở, không thể lập phiếu thu chia đều!";
                return false;
            }

            var dn = GetDienNuocById(maDienNuoc);
            DateTime ngayThu = DateTime.Today;

            foreach (var hd in dsHopDong)
            {
                string maPhieu = SinhMaPhieuThuTuDong();
                var sv = GetSinhVienById(hd.MaSV);
                string tenSV = sv != null ? sv.HoTen : hd.MaSV;

                var tp = new ThuPhi(
                    maPhieu,
                    hd.MaHopDong,
                    dn.MaPhong,
                    "Điện nước",
                    dn.Thang,
                    dn.Nam,
                    tienMoiSV,
                    ngayThu,
                    string.IsNullOrWhiteSpace(nguoiThu) ? "Admin" : nguoiThu,
                    $"Tiền điện nước T{dn.Thang}/{dn.Nam} chia đều ({soSV} người) cho {tenSV} ({hd.MaSV})"
                );

                _context.DanhSachThuPhi.Add(tp);
            }

            dn.DaThanhToan = true;
            _context.SaveThuPhi();
            _context.SaveDienNuoc();

            error = string.Empty;
            return true;
        }

        /// <summary>
        /// Kèm đồng hồ với hợp đồng: Khi sinh viên lập hợp đồng ngày nào thì điện nước và thu phí tiền cọc sẽ lập vào ngày đó.
        /// </summary>
        public bool LapThuPhiBanDauHopDong(string maHD, int chiSoDienBanDau, int chiSoNuocBanDau, string nguoiThu, out string error)
        {
            var hd = GetHopDongById(maHD);
            if (hd == null)
            {
                error = "Hợp đồng không tồn tại!";
                return false;
            }

            var sv = GetSinhVienById(hd.MaSV);
            string tenSV = sv != null ? sv.HoTen : hd.MaSV;

            // 1. Lập phiếu thu tiền đặt cọc vào đúng ngày lập/bắt đầu hợp đồng
            string maPhieuThu = SinhMaPhieuThuTuDong();
            var tp = new ThuPhi(
                maPhieuThu,
                hd.MaHopDong,
                hd.MaPhong,
                "Tiền đặt cọc",
                hd.NgayBatDau.Month,
                hd.NgayBatDau.Year,
                hd.TienDatCoc,
                hd.NgayBatDau,
                string.IsNullOrWhiteSpace(nguoiThu) ? "Admin" : nguoiThu,
                $"Thu tiền cọc khi ký HĐ {hd.MaHopDong} ({tenSV}). Đồng hồ bàn giao: Điện {chiSoDienBanDau} kWh, Nước {chiSoNuocBanDau} m³"
            );
            _context.DanhSachThuPhi.Add(tp);

            // 2. Cập nhật thông tin đồng hồ bàn giao vào Hợp đồng
            string tagDongHo = $"[Đồng hồ bàn giao: Điện={chiSoDienBanDau}, Nước={chiSoNuocBanDau}]";
            if (string.IsNullOrEmpty(hd.GhiChu))
            {
                hd.GhiChu = tagDongHo;
            }
            else if (!hd.GhiChu.Contains("Đồng hồ bàn giao"))
            {
                hd.GhiChu += " " + tagDongHo;
            }

            // 3. Ghi nhận mốc điện nước ban đầu cho phòng nếu chưa có
            string maDN = SinhMaDienNuocTuDong(hd.MaPhong, hd.NgayBatDau.Month, hd.NgayBatDau.Year);
            var dnTonTai = _context.DanhSachDienNuoc.FirstOrDefault(d => d.MaPhong.Equals(hd.MaPhong, StringComparison.OrdinalIgnoreCase) &&
                                                                       d.Thang == hd.NgayBatDau.Month && d.Nam == hd.NgayBatDau.Year);
            if (dnTonTai == null)
            {
                var dnMoi = new DienNuoc(
                    maDN,
                    hd.MaPhong,
                    hd.NgayBatDau.Month,
                    hd.NgayBatDau.Year,
                    chiSoDienBanDau,
                    chiSoDienBanDau,
                    chiSoNuocBanDau,
                    chiSoNuocBanDau,
                    3000,
                    15000,
                    0,
                    true
                );
                _context.DanhSachDienNuoc.Add(dnMoi);
                _context.SaveDienNuoc();
            }

            _context.SaveHopDong();
            _context.SaveThuPhi();

            error = string.Empty;
            return true;
        }

        /// <summary>
        /// Tính tiền điện nước riêng cho sinh viên trả phòng trước hạn (dựa trên đồng hồ chốt và số ngày thực tế ở).
        /// </summary>
        public bool TinhTienDienNuocTraPhong(string maHD, DateTime ngayTraPhong, int chiSoDienTra, int chiSoNuocTra,
                                            out decimal tienDienNuocSV, out string chiTiet, out string error)
        {
            tienDienNuocSV = 0;
            chiTiet = string.Empty;
            error = string.Empty;

            var hd = GetHopDongById(maHD);
            if (hd == null)
            {
                error = "Không tìm thấy hợp đồng!";
                return false;
            }

            var dsHD = GetDanhSachHopDongHieuLucCuaPhong(hd.MaPhong);
            int soNguoi = Math.Max(1, dsHD.Count);

            GetChiSoDienNuocMoiNhatCuaPhong(hd.MaPhong, out int dienCu, out int nuocCu);

            if (chiSoDienTra < dienCu)
            {
                error = $"Chỉ số điện chốt trả phòng ({chiSoDienTra}) không được nhỏ hơn chỉ số cũ gần nhất ({dienCu})!";
                return false;
            }
            if (chiSoNuocTra < nuocCu)
            {
                error = $"Chỉ số nước chốt trả phòng ({chiSoNuocTra}) không được nhỏ hơn chỉ số cũ gần nhất ({nuocCu})!";
                return false;
            }

            int soDien = chiSoDienTra - dienCu;
            int soNuoc = chiSoNuocTra - nuocCu;
            decimal tongTienDienNuocPhong = (soDien * 3000) + (soNuoc * 15000);

            // Kiểm tra trả phòng trước hạn
            bool traTruocHan = ngayTraPhong.Date < hd.NgayKetThuc.Date;
            string ghiChuHan = traTruocHan
                ? $"[TRẢ PHÒNG TRƯỚC HẠN {hd.NgayKetThuc:dd/MM/yyyy}]"
                : "[Trả phòng đúng hạn]";

            // Chia tiền điện nước cho sinh viên trả phòng dựa trên số người đang ở tại thời điểm chốt
            tienDienNuocSV = Math.Round(tongTienDienNuocPhong / soNguoi, 0);

            chiTiet = $"{ghiChuHan} Phòng {hd.MaPhong} (Sĩ số: {soNguoi} người)\n" +
                      $"- Điện chốt: {dienCu} -> {chiSoDienTra} ({soDien} kWh x 3.000đ = {soDien * 3000:N0}đ)\n" +
                      $"- Nước chốt: {nuocCu} -> {chiSoNuocTra} ({soNuoc} m³ x 15.000đ = {soNuoc * 15000:N0}đ)\n" +
                      $"- Tổng tiền điện nước giai đoạn: {tongTienDienNuocPhong:N0}đ\n" +
                      $"- Phần tiền điện nước SV phải chịu: {tongTienDienNuocPhong:N0} / {soNguoi} = {tienDienNuocSV:N0} VNĐ";

            return true;
        }

        /// <summary>
        /// Quyết toán trả phòng & Trả cọc:
        /// - Tính tiền điện nước cho sinh viên trả phòng
        /// - Tính logic hoàn trả tiền cọc (Tiền cọc - Tiền điện nước - Tiền nợ khác)
        /// - Kết thúc hợp đồng (Đã thanh lý)
        /// - Giảm sĩ số phòng (Còn chỗ)
        /// - Chốt mốc đồng hồ để điện nước tiếp tục tính cho các sinh viên còn ở
        /// </summary>
        public bool QuyetToanTraPhongVaTraCoc(string maHD, DateTime ngayTraPhong, int chiSoDienTra, int chiSoNuocTra,
                                            decimal tienPhongNo, decimal phiPhatKhac, string lyDoPhat, string nguoiThu,
                                            out decimal tienCocThucTra, out string thongBaoChiTiet, out string error)
        {
            tienCocThucTra = 0;
            thongBaoChiTiet = string.Empty;
            error = string.Empty;

            var hd = GetHopDongById(maHD);
            if (hd == null)
            {
                error = "Không tìm thấy hợp đồng!";
                return false;
            }
            if (hd.TrangThai.Equals("Đã thanh lý", StringComparison.OrdinalIgnoreCase))
            {
                error = "Hợp đồng này đã được thanh lý trước đó!";
                return false;
            }

            var sv = GetSinhVienById(hd.MaSV);
            string tenSV = sv != null ? sv.HoTen : hd.MaSV;

            // 1. Tính tiền điện nước cho SV trả phòng
            if (!TinhTienDienNuocTraPhong(maHD, ngayTraPhong, chiSoDienTra, chiSoNuocTra, out decimal tienDienNuocSV, out string chiTietDienNuoc, out error))
            {
                return false;
            }

            // 2. Tính logic hoàn tiền cọc
            decimal tienCocGoc = hd.TienDatCoc;
            decimal tongKhauTru = tienDienNuocSV + tienPhongNo + phiPhatKhac;
            tienCocThucTra = tienCocGoc - tongKhauTru;

            // 3. Cập nhật mốc đồng hồ điện nước để tiếp tục tính cho các sinh viên còn ở
            GetChiSoDienNuocMoiNhatCuaPhong(hd.MaPhong, out int dienCu, out int nuocCu);
            if (chiSoDienTra > dienCu || chiSoNuocTra > nuocCu)
            {
                string maDNTmp = SinhMaDienNuocTuDong(hd.MaPhong, ngayTraPhong.Month, ngayTraPhong.Year);
                var dnChot = new DienNuoc(
                    maDNTmp,
                    hd.MaPhong,
                    ngayTraPhong.Month,
                    ngayTraPhong.Year,
                    dienCu,
                    chiSoDienTra,
                    nuocCu,
                    chiSoNuocTra,
                    3000,
                    15000,
                    (chiSoDienTra - dienCu) * 3000 + (chiSoNuocTra - nuocCu) * 15000,
                    true // Đã quyết toán chốt đợt
                );
                _context.DanhSachDienNuoc.Add(dnChot);
                _context.SaveDienNuoc();
            }

            // 4. Lập phiếu thu/phiếu hoàn tiền trong hệ thống
            string nguoiThucHien = string.IsNullOrWhiteSpace(nguoiThu) ? "Admin" : nguoiThu;
            if (tienDienNuocSV > 0)
            {
                // Phiếu thu tiền điện nước đã trừ vào cọc
                string maPTDN = SinhMaPhieuThuTuDong();
                _context.DanhSachThuPhi.Add(new ThuPhi(
                    maPTDN,
                    hd.MaHopDong,
                    hd.MaPhong,
                    "Điện nước",
                    ngayTraPhong.Month,
                    ngayTraPhong.Year,
                    tienDienNuocSV,
                    ngayTraPhong,
                    nguoiThucHien,
                    $"Khấu trừ tiền điện nước trả phòng cho SV {tenSV} ({hd.MaSV})"
                ));
            }

            if (tienPhongNo > 0)
            {
                string maPTP = SinhMaPhieuThuTuDong();
                _context.DanhSachThuPhi.Add(new ThuPhi(
                    maPTP,
                    hd.MaHopDong,
                    hd.MaPhong,
                    "Tiền phòng",
                    ngayTraPhong.Month,
                    ngayTraPhong.Year,
                    tienPhongNo,
                    ngayTraPhong,
                    nguoiThucHien,
                    $"Khấu trừ tiền phòng nợ khi trả phòng cho SV {tenSV} ({hd.MaSV})"
                ));
            }

            if (phiPhatKhac > 0)
            {
                string maPTKhac = SinhMaPhieuThuTuDong();
                _context.DanhSachThuPhi.Add(new ThuPhi(
                    maPTKhac,
                    hd.MaHopDong,
                    hd.MaPhong,
                    "Phí khác",
                    ngayTraPhong.Month,
                    ngayTraPhong.Year,
                    phiPhatKhac,
                    ngayTraPhong,
                    nguoiThucHien,
                    $"Phí phạt trả phòng trước hạn/hư hại: {lyDoPhat}"
                ));
            }

            // Lập phiếu quyết toán cọc
            string maPTCoc = SinhMaPhieuThuTuDong();
            string loaiPhiCoc = tienCocThucTra >= 0 ? "Hoàn tiền cọc" : "Thu thêm quyết toán";
            decimal soTienGhiPhieu = Math.Abs(tienCocThucTra);

            _context.DanhSachThuPhi.Add(new ThuPhi(
                maPTCoc,
                hd.MaHopDong,
                hd.MaPhong,
                loaiPhiCoc,
                ngayTraPhong.Month,
                ngayTraPhong.Year,
                soTienGhiPhieu,
                ngayTraPhong,
                nguoiThucHien,
                tienCocThucTra >= 0
                    ? $"Hoàn trả cọc cho {tenSV} ({hd.MaSV}) sau khi trừ điện nước ({tienDienNuocSV:N0}đ), phòng ({tienPhongNo:N0}đ)"
                    : $"Thu bổ sung quyết toán từ {tenSV} ({hd.MaSV}) do cọc không đủ bù trừ"
            ));

            // 5. Kết thúc hợp đồng với sinh viên đã trả phòng
            hd.TrangThai = "Đã thanh lý";
            hd.GhiChu = (hd.GhiChu ?? "") + $" | [Đã trả phòng {ngayTraPhong:dd/MM/yyyy}: cọc gốc {tienCocGoc:N0}đ, trả lại {tienCocThucTra:N0}đ]";

            // 6. Giảm sĩ số phòng và mở lại Còn chỗ
            var phong = GetPhongById(hd.MaPhong);
            if (phong != null)
            {
                phong.SoChoHienTai = Math.Max(0, phong.SoChoHienTai - 1);
                if (phong.TrangThai.Equals("Đã đầy", StringComparison.OrdinalIgnoreCase) && phong.SoChoHienTai < phong.SoChoToiDa)
                {
                    phong.TrangThai = "Còn chỗ";
                }
            }

            // Lưu toàn bộ dữ liệu
            _context.SaveHopDong();
            _context.SavePhong();
            _context.SaveThuPhi();
            _context.SaveDienNuoc();

            thongBaoChiTiet = $"=== BÁO CÁO QUYẾT TOÁN TRẢ PHÒNG & TRẢ CỌC ===\n\n" +
                              $"- Sinh viên: {tenSV} ({hd.MaSV})\n" +
                              $"- Phòng: {hd.MaPhong}\n" +
                              $"- Ngày trả phòng: {ngayTraPhong:dd/MM/yyyy}\n" +
                              $"{chiTietDienNuoc}\n\n" +
                              $"--- QUYẾT TOÁN CỌC ---\n" +
                              $"+ Tiền đặt cọc ban đầu: {tienCocGoc:N0} VNĐ\n" +
                              $"- Khấu trừ tiền điện nước: {tienDienNuocSV:N0} VNĐ\n" +
                              $"- Khấu trừ tiền phòng nợ: {tienPhongNo:N0} VNĐ\n" +
                              $"- Khấu trừ phí phát sinh/phạt: {phiPhatKhac:N0} VNĐ\n" +
                              $"----------------------------------------------\n" +
                              $"= TIỀN CỌC THỰC TRẢ LẠI: {tienCocThucTra:N0} VNĐ\n\n" +
                              $"* Trạng thái hợp đồng '{hd.MaHopDong}' đã chuyển sang: ĐÃ THANH LÝ.\n" +
                              $"* Chỗ ở phòng '{hd.MaPhong}' đã được hoàn trả (Sĩ số hiện tại: {phong?.SoChoHienTai}/{phong?.SoChoToiDa}).\n" +
                              $"* Chỉ số đồng hồ (Điện: {chiSoDienTra}, Nước: {chiSoNuocTra}) sẽ được tiếp tục tính cho các sinh viên còn ở!";

            return true;
        }
        #endregion
    }
}
