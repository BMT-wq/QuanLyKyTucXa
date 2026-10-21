using System;
using System.Collections.Generic;
using QuanLyKyTucXa.Domain;
using QuanLyKyTucXa.Infrastructure;

namespace QuanLyKyTucXa.Application
{
    /// <summary>
    /// Lưu trữ tập trung toàn bộ danh sách dữ liệu trong bộ nhớ (In-memory) trong suốt phiên làm việc.
    /// Tất cả các Form và Service đều dùng chung instance DataContext này để bảo đảm tính nhất quán dữ liệu.
    /// </summary>
    public class DataContext
    {
        public List<User> Users { get; set; }
        public List<ToaNha> DanhSachToaNha { get; set; }
        public List<Phong> DanhSachPhong { get; set; }
        public List<SinhVien> DanhSachSinhVien { get; set; }
        public List<HopDong> DanhSachHopDong { get; set; }
        public List<DienNuoc> DanhSachDienNuoc { get; set; }
        public List<ThuPhi> DanhSachThuPhi { get; set; }

        public DataContext()
        {
            Users = new List<User>();
            DanhSachToaNha = new List<ToaNha>();
            DanhSachPhong = new List<Phong>();
            DanhSachSinhVien = new List<SinhVien>();
            DanhSachHopDong = new List<HopDong>();
            DanhSachDienNuoc = new List<DienNuoc>();
            DanhSachThuPhi = new List<ThuPhi>();
        }

        /// <summary>
        /// Nạp toàn bộ dữ liệu từ các file .txt vào bộ nhớ.
        /// </summary>
        public void LoadAll()
        {
            Users = FileHandler.LoadUsers();
            DanhSachToaNha = FileHandler.LoadToaNha();
            DanhSachPhong = FileHandler.LoadPhong();
            DanhSachSinhVien = FileHandler.LoadSinhVien();
            DanhSachHopDong = FileHandler.LoadHopDong();
            DanhSachDienNuoc = FileHandler.LoadDienNuoc();
            DanhSachThuPhi = FileHandler.LoadThuPhi();

            // Khởi tạo tài khoản quản trị mặc định nếu danh sách user chưa có
            if (Users.Count == 0)
            {
                Users.Add(new User("admin", "admin123", "Quản trị viên", "Admin", true));
                FileHandler.SaveUsers(Users);
            }
        }

        /// <summary>
        /// Ghi toàn bộ dữ liệu từ bộ nhớ xuống các file .txt.
        /// </summary>
        public void SaveAll()
        {
            FileHandler.SaveUsers(Users);
            FileHandler.SaveToaNha(DanhSachToaNha);
            FileHandler.SavePhong(DanhSachPhong);
            FileHandler.SaveSinhVien(DanhSachSinhVien);
            FileHandler.SaveHopDong(DanhSachHopDong);
            FileHandler.SaveDienNuoc(DanhSachDienNuoc);
            FileHandler.SaveThuPhi(DanhSachThuPhi);
        }

        public void SaveUsers() => FileHandler.SaveUsers(Users);
        public void SaveToaNha() => FileHandler.SaveToaNha(DanhSachToaNha);
        public void SavePhong() => FileHandler.SavePhong(DanhSachPhong);
        public void SaveSinhVien() => FileHandler.SaveSinhVien(DanhSachSinhVien);
        public void SaveHopDong() => FileHandler.SaveHopDong(DanhSachHopDong);
        public void SaveDienNuoc() => FileHandler.SaveDienNuoc(DanhSachDienNuoc);
        public void SaveThuPhi() => FileHandler.SaveThuPhi(DanhSachThuPhi);
    }
}
