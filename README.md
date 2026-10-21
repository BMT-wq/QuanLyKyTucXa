# ĐỒ ÁN QUẢN LÝ KÝ TÚC XÁ (C# WINDOWS FORMS - .NET FRAMEWORK 4.8)

Hệ thống phần mềm quản lý nội trú ký túc xá sinh viên được phát triển bằng ngôn ngữ **C# Windows Forms trên nền tảng .NET Framework 4.8**, tương thích đầy đủ với Visual Studio (2019, 2022, 2026).

---

## 1. Cấu Trúc Thư Mục Toàn Dự Án

```text
QuanLyKyTucXa/
├── Data/                             # Thư mục lưu trữ các file dữ liệu phẳng (.txt)
│   ├── users.txt                     # Tài khoản đăng nhập hệ thống
│   ├── toanha.txt                    # Danh mục tòa nhà
│   ├── phong.txt                     # Danh mục phòng ký túc xá
│   ├── sinhvien.txt                  # Hồ sơ thông tin sinh viên nội trú
│   ├── hopdong.txt                   # Hợp đồng thuê phòng
│   ├── diennuoc.txt                  # Chỉ số điện nước hàng tháng
│   └── thuphi.txt                    # Phiếu thu các loại phí
├── Docs/                             # Tài liệu hướng dẫn đồ án
│   ├── README_BaoCao.txt             # Đề cương chi tiết báo cáo đồ án
│   └── README_Slide.txt              # Đề cương slide thuyết trình bảo vệ đồ án
├── src/
│   └── QuanLyKyTucXa/                # Thư mục mã nguồn chính của ứng dụng WinForms
│       ├── QuanLyKyTucXa.sln         # Solution file trong thư mục src
│       ├── QuanLyKyTucXa.csproj      # Project file C# WinForms (.NET Framework 4.8)
│       ├── Program.cs                # Điểm khởi chạy ứng dụng
│       ├── App.config                # Cấu hình runtime .NET 4.8
│       ├── Domain/                   # Lớp thực thể dữ liệu (Data Entities)
│       │   ├── User.cs               # Thực thể người dùng
│       │   ├── ToaNha.cs             # Thực thể tòa nhà
│       │   ├── Phong.cs              # Thực thể phòng
│       │   ├── SinhVien.cs           # Thực thể sinh viên
│       │   ├── HopDong.cs            # Thực thể hợp đồng
│       │   ├── DienNuoc.cs           # Thực thể điện nước
│       │   └── ThuPhi.cs             # Thực thể phiếu thu
│       ├── Application/              # Tầng xử lý nghiệp vụ & dịch vụ
│       │   ├── DataContext.cs        # Quản lý bộ nhớ tập trung List<T>
│       │   ├── Validator.cs          # Kiểm tra tính hợp lệ của dữ liệu nhập
│       │   ├── PhongService.cs       # Nghiệp vụ quản lý phòng & tòa nhà (SV1)
│       │   ├── HopDongService.cs     # Nghiệp vụ sinh viên & hợp đồng (SV2)
│       │   └── ThuPhiService.cs      # Nghiệp vụ điện nước & thu phí (SV3)
│       ├── Infrastructure/           # Tầng hạ tầng đọc/ghi file văn bản
│       │   └── FileHandler.cs        # Đọc ghi file .txt bằng StreamReader/StreamWriter UTF-8
│       └── Presentation/             # Tầng giao diện người dùng Windows Forms
│           ├── FrmDangNhap.cs        # Form đăng nhập hệ thống
│           ├── FrmMain.cs            # Form chính MDI Container điều hướng
│           ├── SV1_PhongToaNha/      # Phân hệ 1: Phòng & Tòa nhà
│           │   ├── FrmToaNha.cs      # Giao diện quản lý tòa nhà
│           │   └── FrmPhong.cs       # Giao diện quản lý phòng
│           ├── SV2_SinhVienHopDong/  # Phân hệ 2: Sinh viên & Hợp đồng
│           │   ├── FrmSinhVien.cs    # Giao diện quản lý hồ sơ sinh viên
│           │   └── FrmHopDong.cs     # Giao diện quản lý hợp đồng
│           └── SV3_DienNuocThuPhi/   # Phân hệ 3: Điện nước & Thu phí
│               ├── FrmDienNuoc.cs    # Giao diện quản lý điện nước
│               └── FrmThuPhi.cs      # Giao diện quản lý thu phí
├── QuanLyKyTucXa.sln                 # Solution file tại thư mục gốc (tiện mở nhanh)
└── README.md                         # Tài liệu hướng dẫn tổng quan này
```

---

## 2. Kiến Trúc & Nguyên Tắc Kỹ Thuật

1. **Chuẩn .NET Framework 4.8**: Đảm bảo đúng phiên bản yêu cầu môn học, tương thích hoàn toàn với WinForms Designer trong Visual Studio.
2. **Cơ chế lưu trữ Không dùng SQL**:
   - Dữ liệu được lưu trong các file `.txt` đặt tại thư mục `Data/`.
   - Đọc bằng `StreamReader`, ghi bằng `StreamWriter`, định dạng mã hóa `UTF-8`.
   - Dấu phân cách trường dữ liệu là ký tự gạch đứng `|`.
   - `FileHandler.cs` tự động quét ngược thư mục từ `bin/Debug` lên thư mục gốc đồ án để xác định vị trí `Data/`, bảo đảm ứng dụng luôn tìm thấy dữ liệu ổn định ở mọi môi trường chạy.
3. **Quản lý dữ liệu đồng bộ qua `DataContext`**:
   - `DataContext` nạp toàn bộ danh sách `List<T>` vào bộ nhớ lúc khởi động.
   - Mọi Form và Service dùng chung một `DataContext` duy nhất được truyền từ `Program.cs`. Không form nào tự tạo danh sách riêng biệt.
4. **Phân tách trách nhiệm (Separation of Concerns)**:
   - Các Form thuộc tầng `Presentation` chỉ đón nhận sự kiện UI và gọi các phương thức tương ứng trong `Service`.
   - Không đặt các thuật toán tính toán hay thao tác I/O phức tạp bên trong sự kiện click nút bấm.

---

## 3. Quy Ước Dữ Liệu File Text (Data/*.txt)

| File | Định dạng các cột dữ liệu (phân cách bằng `\|`) |
| :--- | :--- |
| `users.txt` | `Username\|Password\|FullName\|Role\|IsActive` |
| `toanha.txt` | `MaToaNha\|TenToaNha\|SoTang\|GhiChu` |
| `phong.txt` | `MaPhong\|TenPhong\|MaToaNha\|LoaiPhong\|SoChoToiDa\|SoChoHienTai\|GiaPhong\|TrangThai` |
| `sinhvien.txt` | `MaSV\|HoTen\|NgaySinh (yyyy-MM-dd)\|GioiTinh\|SoCMND_CCCD\|SoDienThoai\|Email\|Lop\|Khoa\|QueQuan` |
| `hopdong.txt` | `MaHopDong\|MaSV\|MaPhong\|NgayBatDau (yyyy-MM-dd)\|NgayKetThuc (yyyy-MM-dd)\|TienDatCoc\|TrangThai\|GhiChu` |
| `diennuoc.txt` | `MaDienNuoc\|MaPhong\|Thang\|Nam\|ChiSoDienCu\|ChiSoDienMoi\|ChiSoNuocCu\|ChiSoNuocMoi\|DonGiaDien\|DonGiaNuoc\|TongTien\|DaThanhToan` |
| `thuphi.txt` | `MaPhieuThu\|MaHopDong\|MaPhong\|LoaiPhi\|Thang\|Nam\|SoTien\|NgayThu (yyyy-MM-dd)\|NguoiThu\|GhiChu` |

---

## 4. Hướng Dẫn Mở & Chạy Dự Án Trên Visual Studio

1. Khởi động **Visual Studio** (bản 2019, 2022 hoặc 2026).
2. Chọn **Open a project or solution**.
3. Chọn một trong hai file sau:
   - File tại thư mục gốc: `d:\LapTrinhWindow\QuanLyKyTucXa\QuanLyKyTucXa.sln`
   - Hoặc file trong thư mục src: `d:\LapTrinhWindow\QuanLyKyTucXa\src\QuanLyKyTucXa\QuanLyKyTucXa.sln`
4. Nhấn phím **F5** (hoặc `Ctrl + F5`) để biên dịch và khởi chạy ứng dụng.
5. Thông tin đăng nhập mặc định:
   - **Tên đăng nhập:** `admin`
   - **Mật khẩu:** `admin123`
6. Sau khi đăng nhập thành công, giao diện chính MDI Form xuất hiện cho phép mở các màn hình phân hệ 1, 2, 3 từ thanh menu phía trên.

---

## 5. Hướng Dẫn Nhóm Phát Triển Tiếp Tục Hoàn Thiện

| Phân hệ | Thành viên | Thư mục & File cần bổ sung | Nhiệm vụ chính |
| :--- | :--- | :--- | :--- |
| **Phân hệ 1** | Sinh viên 1 | `Presentation/SV1_PhongToaNha/`<br>- `FrmToaNha.cs`<br>- `FrmPhong.cs` | Bổ sung TextBox, ComboBox, DataGridView cho Tòa nhà và Phòng; xử lý các thao tác Thêm, Sửa, Xóa, Lọc phòng còn chỗ qua `PhongService`. |
| **Phân hệ 2** | Sinh viên 2 | `Presentation/SV2_SinhVienHopDong/`<br>- `FrmSinhVien.cs`<br>- `FrmHopDong.cs` | Thiết kế giao diện tiếp nhận hồ sơ sinh viên; tạo hợp đồng nội trú, tự động tăng/giảm sĩ số phòng, thanh lý hợp đồng qua `HopDongService`. |
| **Phân hệ 3** | Sinh viên 3 | `Presentation/SV3_DienNuocThuPhi/`<br>- `FrmDienNuoc.cs`<br>- `FrmThuPhi.cs` | Bổ sung giao diện ghi số điện nước cũ/mới, tự động tính tổng tiền; lập hóa đơn thu phí, thống kê công nợ qua `ThuPhiService`. |
