using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyKyTucXa.Domain;

namespace QuanLyKyTucXa.Application
{
    /// <summary>
    /// Xử lý nghiệp vụ phân hệ Quản lý Tòa nhà & Phòng (Sinh viên 1 phụ trách).
    /// </summary>
    public class PhongService
    {
        private readonly DataContext _context;

        public PhongService(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        #region Tòa nhà
        public List<ToaNha> GetAllToaNha() => _context.DanhSachToaNha;

        public ToaNha GetToaNhaById(string maToaNha)
        {
            return _context.DanhSachToaNha.FirstOrDefault(t => t.MaToaNha.Equals(maToaNha, StringComparison.OrdinalIgnoreCase));
        }

        public bool ThemToaNha(ToaNha toaNha, out string error)
        {
            if (toaNha == null)
            {
                error = "Dữ liệu tòa nhà không hợp lệ!";
                return false;
            }
            if (_context.DanhSachToaNha.Any(t => t.MaToaNha.Equals(toaNha.MaToaNha, StringComparison.OrdinalIgnoreCase)))
            {
                error = $"Mã tòa nhà '{toaNha.MaToaNha}' đã tồn tại!";
                return false;
            }

            _context.DanhSachToaNha.Add(toaNha);
            _context.SaveToaNha();
            error = string.Empty;
            return true;
        }

        public bool CapNhatToaNha(ToaNha toaNha, out string error)
        {
            var existing = GetToaNhaById(toaNha?.MaToaNha);
            if (existing == null)
            {
                error = "Không tìm thấy tòa nhà cần cập nhật!";
                return false;
            }

            existing.TenToaNha = toaNha.TenToaNha;
            existing.SoTang = toaNha.SoTang;
            existing.GhiChu = toaNha.GhiChu;

            _context.SaveToaNha();
            error = string.Empty;
            return true;
        }

        public bool XoaToaNha(string maToaNha, out string error)
        {
            var existing = GetToaNhaById(maToaNha);
            if (existing == null)
            {
                error = "Tòa nhà không tồn tại!";
                return false;
            }
            // Không xóa nếu tòa nhà còn phòng
            if (_context.DanhSachPhong.Any(p => p.MaToaNha.Equals(maToaNha, StringComparison.OrdinalIgnoreCase)))
            {
                error = "Không thể xóa tòa nhà đang có phòng trực thuộc!";
                return false;
            }

            _context.DanhSachToaNha.Remove(existing);
            _context.SaveToaNha();
            error = string.Empty;
            return true;
        }
        #endregion

        #region Phòng
        public List<Phong> GetAllPhong() => _context.DanhSachPhong;

        public Phong GetPhongById(string maPhong)
        {
            return _context.DanhSachPhong.FirstOrDefault(p => p.MaPhong.Equals(maPhong, StringComparison.OrdinalIgnoreCase));
        }

        public List<Phong> GetPhongByToaNha(string maToaNha)
        {
            if (string.IsNullOrEmpty(maToaNha)) return GetAllPhong();
            return _context.DanhSachPhong.Where(p => p.MaToaNha.Equals(maToaNha, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Phong> GetPhongConCho(string loaiPhong = null)
        {
            var query = _context.DanhSachPhong.Where(p => p.SoChoHienTai < p.SoChoToiDa && p.TrangThai != "Đang sửa chữa");
            if (!string.IsNullOrEmpty(loaiPhong))
            {
                query = query.Where(p => p.LoaiPhong.Equals(loaiPhong, StringComparison.OrdinalIgnoreCase));
            }
            return query.ToList();
        }

        public bool ThemPhong(Phong phong, out string error)
        {
            if (phong == null)
            {
                error = "Dữ liệu phòng không hợp lệ!";
                return false;
            }
            if (_context.DanhSachPhong.Any(p => p.MaPhong.Equals(phong.MaPhong, StringComparison.OrdinalIgnoreCase)))
            {
                error = $"Mã phòng '{phong.MaPhong}' đã tồn tại!";
                return false;
            }

            _context.DanhSachPhong.Add(phong);
            _context.SavePhong();
            error = string.Empty;
            return true;
        }

        public bool CapNhatPhong(Phong phong, out string error)
        {
            var existing = GetPhongById(phong?.MaPhong);
            if (existing == null)
            {
                error = "Không tìm thấy phòng cần cập nhật!";
                return false;
            }

            existing.TenPhong = phong.TenPhong;
            existing.MaToaNha = phong.MaToaNha;
            existing.LoaiPhong = phong.LoaiPhong;
            existing.SoChoToiDa = phong.SoChoToiDa;
            existing.GiaPhong = phong.GiaPhong;
            existing.TrangThai = phong.TrangThai;

            _context.SavePhong();
            error = string.Empty;
            return true;
        }

        public bool XoaPhong(string maPhong, out string error)
        {
            var existing = GetPhongById(maPhong);
            if (existing == null)
            {
                error = "Phòng không tồn tại!";
                return false;
            }
            if (existing.SoChoHienTai > 0)
            {
                error = "Không thể xóa phòng đang có sinh viên cư trú!";
                return false;
            }

            _context.DanhSachPhong.Remove(existing);
            _context.SavePhong();
            error = string.Empty;
            return true;
        }
        #endregion
    }
}
