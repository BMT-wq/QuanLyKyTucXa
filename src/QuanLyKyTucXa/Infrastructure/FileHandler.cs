using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using QuanLyKyTucXa.Domain;

namespace QuanLyKyTucXa.Infrastructure
{
    /// <summary>
    /// Chịu trách nhiệm đọc và ghi dữ liệu từ các file văn bản .txt bằng StreamReader/StreamWriter mã hóa UTF-8.
    /// Đường dẫn thư mục Data được tự động xác định ổn định dù chạy từ Visual Studio hay bin/Debug.
    /// </summary>
    public static class FileHandler
    {
        private const char Delimiter = '|';
        private static readonly Encoding Utf8Encoding = new UTF8Encoding(false);

        private const string FileUsers = "users.txt";
        private const string FileToaNha = "toanha.txt";
        private const string FilePhong = "phong.txt";
        private const string FileSinhVien = "sinhvien.txt";
        private const string FileHopDong = "hopdong.txt";
        private const string FileDienNuoc = "diennuoc.txt";
        private const string FileThuPhi = "thuphi.txt";

        /// <summary>
        /// Tìm đường dẫn tuyệt đối đến thư mục Data.
        /// Quét ngược từ thư mục chứa file thực thi (bin/Debug) lên các thư mục cha để tìm thư mục Data của đồ án.
        /// </summary>
        public static string GetDataDirectoryPath()
        {
            string startDir = null;
            try
            {
                string asmLocation = typeof(FileHandler).Assembly.Location;
                if (!string.IsNullOrEmpty(asmLocation))
                {
                    startDir = Path.GetDirectoryName(asmLocation);
                }
            }
            catch
            {
                // Bỏ qua lỗi security nếu có
            }

            if (string.IsNullOrEmpty(startDir))
            {
                startDir = AppDomain.CurrentDomain.BaseDirectory;
            }

            string searchDir = startDir;
            for (int i = 0; i < 7; i++)
            {
                if (string.IsNullOrEmpty(searchDir)) break;

                string candidate = Path.Combine(searchDir, "Data");
                if (Directory.Exists(candidate))
                {
                    return candidate;
                }

                DirectoryInfo parent = Directory.GetParent(searchDir);
                if (parent == null) break;
                searchDir = parent.FullName;
            }

            // Nếu không tìm thấy ở thư mục cha, dùng Data ngay tại thư mục chứa file chạy
            string fallback = Path.Combine(startDir, "Data");
            if (!Directory.Exists(fallback))
            {
                Directory.CreateDirectory(fallback);
            }
            return fallback;
        }

        private static string GetFilePath(string fileName)
        {
            string dataDir = GetDataDirectoryPath();
            string filePath = Path.Combine(dataDir, fileName);
            if (!File.Exists(filePath))
            {
                // Tạo file rỗng nếu chưa tồn tại
                using (var stream = File.Create(filePath)) { }
            }
            return filePath;
        }

        #region User
        public static List<User> LoadUsers()
        {
            var list = new List<User>();
            string path = GetFilePath(FileUsers);

            using (var reader = new StreamReader(path, Utf8Encoding))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#")) continue;
                    var parts = line.Split(Delimiter);
                    if (parts.Length >= 5)
                    {
                        list.Add(new User(
                            parts[0].Trim(),
                            parts[1].Trim(),
                            parts[2].Trim(),
                            parts[3].Trim(),
                            bool.TryParse(parts[4].Trim(), out bool active) ? active : true
                        ));
                    }
                }
            }
            return list;
        }

        public static void SaveUsers(List<User> list)
        {
            string path = GetFilePath(FileUsers);
            using (var writer = new StreamWriter(path, false, Utf8Encoding))
            {
                foreach (var item in list)
                {
                    writer.WriteLine($"{item.Username}|{item.Password}|{item.FullName}|{item.Role}|{item.IsActive}");
                }
            }
        }
        #endregion

        #region ToaNha
        public static List<ToaNha> LoadToaNha()
        {
            var list = new List<ToaNha>();
            string path = GetFilePath(FileToaNha);

            using (var reader = new StreamReader(path, Utf8Encoding))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#")) continue;
                    var parts = line.Split(Delimiter);
                    if (parts.Length >= 3)
                    {
                        int.TryParse(parts[2].Trim(), out int soTang);
                        string ghiChu = parts.Length > 3 ? parts[3].Trim() : "";
                        list.Add(new ToaNha(parts[0].Trim(), parts[1].Trim(), soTang, ghiChu));
                    }
                }
            }
            return list;
        }

        public static void SaveToaNha(List<ToaNha> list)
        {
            string path = GetFilePath(FileToaNha);
            using (var writer = new StreamWriter(path, false, Utf8Encoding))
            {
                foreach (var item in list)
                {
                    writer.WriteLine($"{item.MaToaNha}|{item.TenToaNha}|{item.SoTang}|{item.GhiChu}");
                }
            }
        }
        #endregion

        #region Phong
        public static List<Phong> LoadPhong()
        {
            var list = new List<Phong>();
            string path = GetFilePath(FilePhong);

            using (var reader = new StreamReader(path, Utf8Encoding))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#")) continue;
                    var parts = line.Split(Delimiter);
                    if (parts.Length >= 8)
                    {
                        int.TryParse(parts[4].Trim(), out int toiDa);
                        int.TryParse(parts[5].Trim(), out int hienTai);
                        decimal.TryParse(parts[6].Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal giaPhong);

                        list.Add(new Phong(
                            parts[0].Trim(),
                            parts[1].Trim(),
                            parts[2].Trim(),
                            parts[3].Trim(),
                            toiDa,
                            hienTai,
                            giaPhong,
                            parts[7].Trim()
                        ));
                    }
                }
            }
            return list;
        }

        public static void SavePhong(List<Phong> list)
        {
            string path = GetFilePath(FilePhong);
            using (var writer = new StreamWriter(path, false, Utf8Encoding))
            {
                foreach (var item in list)
                {
                    writer.WriteLine($"{item.MaPhong}|{item.TenPhong}|{item.MaToaNha}|{item.LoaiPhong}|{item.SoChoToiDa}|{item.SoChoHienTai}|{item.GiaPhong.ToString(CultureInfo.InvariantCulture)}|{item.TrangThai}");
                }
            }
        }
        #endregion

        #region SinhVien
        public static List<SinhVien> LoadSinhVien()
        {
            var list = new List<SinhVien>();
            string path = GetFilePath(FileSinhVien);

            using (var reader = new StreamReader(path, Utf8Encoding))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#")) continue;
                    var parts = line.Split(Delimiter);
                    if (parts.Length >= 10)
                    {
                        DateTime.TryParseExact(parts[2].Trim(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngaySinh);
                        list.Add(new SinhVien(
                            parts[0].Trim(),
                            parts[1].Trim(),
                            ngaySinh,
                            parts[3].Trim(),
                            parts[4].Trim(),
                            parts[5].Trim(),
                            parts[6].Trim(),
                            parts[7].Trim(),
                            parts[8].Trim(),
                            parts[9].Trim()
                        ));
                    }
                }
            }
            return list;
        }

        public static void SaveSinhVien(List<SinhVien> list)
        {
            string path = GetFilePath(FileSinhVien);
            using (var writer = new StreamWriter(path, false, Utf8Encoding))
            {
                foreach (var item in list)
                {
                    writer.WriteLine($"{item.MaSV}|{item.HoTen}|{item.NgaySinh:yyyy-MM-dd}|{item.GioiTinh}|{item.SoCMND_CCCD}|{item.SoDienThoai}|{item.Email}|{item.Lop}|{item.Khoa}|{item.QueQuan}");
                }
            }
        }
        #endregion

        #region HopDong
        public static List<HopDong> LoadHopDong()
        {
            var list = new List<HopDong>();
            string path = GetFilePath(FileHopDong);

            using (var reader = new StreamReader(path, Utf8Encoding))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#")) continue;
                    var parts = line.Split(Delimiter);
                    if (parts.Length >= 7)
                    {
                        DateTime.TryParseExact(parts[3].Trim(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime batDau);
                        DateTime.TryParseExact(parts[4].Trim(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ketThuc);
                        decimal.TryParse(parts[5].Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal datCoc);
                        string ghiChu = parts.Length > 7 ? parts[7].Trim() : "";

                        list.Add(new HopDong(
                            parts[0].Trim(),
                            parts[1].Trim(),
                            parts[2].Trim(),
                            batDau,
                            ketThuc,
                            datCoc,
                            parts[6].Trim(),
                            ghiChu
                        ));
                    }
                }
            }
            return list;
        }

        public static void SaveHopDong(List<HopDong> list)
        {
            string path = GetFilePath(FileHopDong);
            using (var writer = new StreamWriter(path, false, Utf8Encoding))
            {
                foreach (var item in list)
                {
                    writer.WriteLine($"{item.MaHopDong}|{item.MaSV}|{item.MaPhong}|{item.NgayBatDau:yyyy-MM-dd}|{item.NgayKetThuc:yyyy-MM-dd}|{item.TienDatCoc.ToString(CultureInfo.InvariantCulture)}|{item.TrangThai}|{item.GhiChu}");
                }
            }
        }
        #endregion

        #region DienNuoc
        public static List<DienNuoc> LoadDienNuoc()
        {
            var list = new List<DienNuoc>();
            string path = GetFilePath(FileDienNuoc);

            using (var reader = new StreamReader(path, Utf8Encoding))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#")) continue;
                    var parts = line.Split(Delimiter);
                    if (parts.Length >= 12)
                    {
                        int.TryParse(parts[2].Trim(), out int thang);
                        int.TryParse(parts[3].Trim(), out int nam);
                        int.TryParse(parts[4].Trim(), out int dienCu);
                        int.TryParse(parts[5].Trim(), out int dienMoi);
                        int.TryParse(parts[6].Trim(), out int nuocCu);
                        int.TryParse(parts[7].Trim(), out int nuocMoi);
                        decimal.TryParse(parts[8].Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal donGiaDien);
                        decimal.TryParse(parts[9].Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal donGiaNuoc);
                        decimal.TryParse(parts[10].Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal donGiaTong);
                        bool.TryParse(parts[11].Trim(), out bool daThanhToan);

                        list.Add(new DienNuoc(
                            parts[0].Trim(),
                            parts[1].Trim(),
                            thang,
                            nam,
                            dienCu,
                            dienMoi,
                            nuocCu,
                            nuocMoi,
                            donGiaDien,
                            donGiaNuoc,
                            donGiaTong,
                            daThanhToan
                        ));
                    }
                }
            }
            return list;
        }

        public static void SaveDienNuoc(List<DienNuoc> list)
        {
            string path = GetFilePath(FileDienNuoc);
            using (var writer = new StreamWriter(path, false, Utf8Encoding))
            {
                foreach (var item in list)
                {
                    writer.WriteLine($"{item.MaDienNuoc}|{item.MaPhong}|{item.Thang}|{item.Nam}|{item.ChiSoDienCu}|{item.ChiSoDienMoi}|{item.ChiSoNuocCu}|{item.ChiSoNuocMoi}|{item.DonGiaDien.ToString(CultureInfo.InvariantCulture)}|{item.DonGiaNuoc.ToString(CultureInfo.InvariantCulture)}|{item.TongTien.ToString(CultureInfo.InvariantCulture)}|{item.DaThanhToan}");
                }
            }
        }
        #endregion

        #region ThuPhi
        public static List<ThuPhi> LoadThuPhi()
        {
            var list = new List<ThuPhi>();
            string path = GetFilePath(FileThuPhi);

            using (var reader = new StreamReader(path, Utf8Encoding))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#")) continue;
                    var parts = line.Split(Delimiter);
                    if (parts.Length >= 9)
                    {
                        int.TryParse(parts[4].Trim(), out int thang);
                        int.TryParse(parts[5].Trim(), out int nam);
                        decimal.TryParse(parts[6].Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal soTien);
                        DateTime.TryParseExact(parts[7].Trim(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayThu);
                        string ghiChu = parts.Length > 9 ? parts[9].Trim() : "";

                        list.Add(new ThuPhi(
                            parts[0].Trim(),
                            parts[1].Trim(),
                            parts[2].Trim(),
                            parts[3].Trim(),
                            thang,
                            nam,
                            soTien,
                            ngayThu,
                            parts[8].Trim(),
                            ghiChu
                        ));
                    }
                }
            }
            return list;
        }

        public static void SaveThuPhi(List<ThuPhi> list)
        {
            string path = GetFilePath(FileThuPhi);
            using (var writer = new StreamWriter(path, false, Utf8Encoding))
            {
                foreach (var item in list)
                {
                    writer.WriteLine($"{item.MaPhieuThu}|{item.MaHopDong}|{item.MaPhong}|{item.LoaiPhi}|{item.Thang}|{item.Nam}|{item.SoTien.ToString(CultureInfo.InvariantCulture)}|{item.NgayThu:yyyy-MM-dd}|{item.NguoiThu}|{item.GhiChu}");
                }
            }
        }
        #endregion
    }
}
