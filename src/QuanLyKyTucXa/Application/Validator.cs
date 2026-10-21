using System;
using System.Text.RegularExpressions;

namespace QuanLyKyTucXa.Application
{
    /// <summary>
    /// Cung cấp các hàm kiểm tra hợp lệ dữ liệu (Validation) dùng chung cho toàn bộ ứng dụng.
    /// </summary>
    public static class Validator
    {
        public static bool IsNotEmpty(string text, string fieldName, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                errorMessage = $"{fieldName} không được để trống!";
                return false;
            }
            errorMessage = string.Empty;
            return true;
        }

        public static bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone)) return false;
            // Số điện thoại Việt Nam 10 chữ số bắt đầu bằng 0
            return Regex.IsMatch(phone.Trim(), @"^0\d{9}$");
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            return Regex.IsMatch(email.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool IsValidCCCD(string cccd)
        {
            if (string.IsNullOrWhiteSpace(cccd)) return false;
            // CCCD 12 số hoặc CMND 9 số
            return Regex.IsMatch(cccd.Trim(), @"^\d{9}(\d{3})?$");
        }

        public static bool IsPositiveNumber(decimal value)
        {
            return value > 0;
        }

        public static bool IsValidDateRange(DateTime startDate, DateTime endDate)
        {
            return endDate > startDate;
        }
    }
}
