using System;

namespace QuanLyKyTucXa.Domain
{
    /// <summary>
    /// Đại diện cho tài khoản người dùng đăng nhập hệ thống.
    /// </summary>
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; } // Admin, CanBo, NhanVien
        public bool IsActive { get; set; }

        public User()
        {
            IsActive = true;
        }

        public User(string username, string password, string fullName, string role, bool isActive = true)
        {
            Username = username;
            Password = password;
            FullName = fullName;
            Role = role;
            IsActive = isActive;
        }

        public override string ToString()
        {
            return $"{FullName} ({Username}) - {Role}";
        }
    }
}
