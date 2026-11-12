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
    }
}
