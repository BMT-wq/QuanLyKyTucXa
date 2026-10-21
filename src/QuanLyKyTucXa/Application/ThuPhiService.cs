using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyKyTucXa.Domain;

namespace QuanLyKyTucXa.Application
{
    /// <summary>
    /// Xử lý nghiệp vụ phân hệ Quản lý Điện nước & Thu phí (Sinh viên 3 phụ trách).
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
        #endregion
    }
}
