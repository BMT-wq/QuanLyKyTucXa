# KẾ HOẠCH & NHIỆM VỤ CHI TIẾT: ANH THY (SV2)

- **Người thực hiện:** Anh Thy (Sinh viên 2)
- **Nhánh Git:** `AnhThy`
- **Phân hệ phụ trách:** **Phân hệ 2 - Quản lý Hồ sơ Sinh viên & Hợp đồng thuê phòng** (`SV2_SinhVienHopDong`)
- **Đồ án:** Quản lý Ký túc xá (C# Windows Forms - .NET Framework 4.8)

---

## 1. Các File & Thư Mục Chịu Trách Nhiệm

| Tầng kiến trúc | Đường dẫn file | Vai trò / Mô tả |
| :--- | :--- | :--- |
| **Domain** | `src/QuanLyKyTucXa/Domain/SinhVien.cs` | Định nghĩa thực thể Sinh viên (Mã SV, Họ tên, CCCD, SĐT, Email, Lớp...) |
| **Domain** | `src/QuanLyKyTucXa/Domain/HopDong.cs` | Định nghĩa thực thể Hợp đồng (Mã HĐ, Mã SV, Mã phòng, Ngày bắt đầu/kết thúc...) |
| **Application** | `src/QuanLyKyTucXa/Application/HopDongService.cs` | Dịch vụ xử lý nghiệp vụ cho Sinh viên và Hợp đồng |
| **Presentation** | `src/QuanLyKyTucXa/Presentation/SV2_SinhVienHopDong/FrmSinhVien.cs`<br>`src/QuanLyKyTucXa/Presentation/SV2_SinhVienHopDong/FrmSinhVien.Designer.cs` | Giao diện và sự kiện quản lý hồ sơ sinh viên |
| **Presentation** | `src/QuanLyKyTucXa/Presentation/SV2_SinhVienHopDong/FrmHopDong.cs`<br>`src/QuanLyKyTucXa/Presentation/SV2_SinhVienHopDong/FrmHopDong.Designer.cs` | Giao diện và sự kiện quản lý hợp đồng thuê phòng |
| **Data liên quan** | `Data/sinhvien.txt`<br>`Data/hopdong.txt`<br>`Data/phong.txt` | Lưu trữ dữ liệu dạng text UTF-8 phân tách bởi dấu `\|` |

---

## 2. Chi Tiết Yêu Cầu Chức Năng & Quy Tắc Nghiệp Vụ

### 2.1. Phân hệ Hồ sơ Sinh viên (`FrmSinhVien`)
- [ ] **Giao diện người dùng (UI):**
  - Các trường thông tin: Mã SV, Họ và tên, Ngày sinh (`DateTimePicker`), Giới tính (`RadioButton`/`ComboBox`), Số CMND/CCCD, Số điện thoại, Email, Lớp, Khoa, Quê quán.
  - Bảng danh sách `DataGridView` hiển thị toàn bộ hồ sơ sinh viên nội trú.
  - Thanh tìm kiếm theo Mã SV hoặc Họ tên + Lọc theo Lớp/Khoa.
  - Cụm nút thao tác: *Thêm mới*, *Cập nhật*, *Xóa*, *Làm mới / Hủy chọn*.
- [ ] **Xử lý nghiệp vụ & Validation:**
  - Kiểm tra không để trống các trường bắt buộc thông qua `Validator.IsNotEmpty`.
  - Kiểm tra định dạng SĐT (10 số, bắt đầu bằng 0) thông qua `Validator.IsValidPhone`.
  - Kiểm tra định dạng CCCD/CMND (9 hoặc 12 số) thông qua `Validator.IsValidCCCD`.
  - Kiểm tra định dạng Email hợp lệ thông qua `Validator.IsValidEmail`.
  - Không cho phép thêm trùng `MaSV`.
  - Không cho phép xóa sinh viên đang có hợp đồng hiệu lực (`TrangThai == "Hiệu lực"`).
  - Đồng bộ hiển thị: Click dòng trong `DataGridView` sẽ đổ dữ liệu lên form nhập liệu.

### 2.2. Phân hệ Hợp đồng Thuê phòng (`FrmHopDong`)
- [ ] **Giao diện người dùng (UI):**
  - Các trường thông tin: Mã hợp đồng, Mã sinh viên (chọn từ danh sách SV), Mã phòng (chọn từ danh sách phòng còn trống), Ngày bắt đầu, Ngày kết thúc, Tiền đặt cọc, Trạng thái (Hiệu lực, Đã thanh lý, Hết hạn), Ghi chú.
  - Bảng danh sách `DataGridView` hiển thị các hợp đồng.
  - Thanh tìm kiếm theo Mã HĐ / Mã SV / Mã phòng + Lọc theo Trạng thái hợp đồng.
  - Cụm nút thao tác: *Tạo hợp đồng*, *Gia hạn hợp đồng*, *Thanh lý hợp đồng*, *Làm mới*.
- [ ] **Xử lý nghiệp vụ liên kết hệ thống:**
  - **Tạo hợp đồng mới:**
    - Kiểm tra sinh viên được chọn chưa có hợp đồng nào đang "Hiệu lực".
    - Kiểm tra phòng còn chỗ (`phong.SoChoHienTai < phong.SoChoToiDa`).
    - Tự động tăng `phong.SoChoHienTai++`. Nếu phòng đạt tối đa sĩ số thì chuyển trạng thái phòng sang `"Đã đầy"`.
    - Lưu dữ liệu đồng bộ xuống cả `hopdong.txt` và `phong.txt`.
  - **Gia hạn hợp đồng:**
    - Cho phép chọn hợp đồng đang hiệu lực, cập nhật lại `NgayKetThuc` mới (> `NgayBatDau` và > ngày kết thúc cũ).
  - **Thanh lý hợp đồng:**
    - Chuyển trạng thái hợp đồng sang `"Đã thanh lý"`.
    - Tự động giảm sĩ số phòng (`phong.SoChoHienTai--`), mở lại trạng thái `"Còn chỗ"` nếu phòng trước đó đang đầy.
    - Lưu cập nhật xuống file.

---

## 3. Checklist Tiến Độ Công Việc

### Giai đoạn 1: Khởi tạo & Cấu trúc (Hoàn thành)
- [x] Khởi tạo nhánh làm việc `AnhThy` từ repository nhóm.
- [x] Nắm rõ cấu trúc kiến trúc phân tầng (Domain - Application - Infrastructure - Presentation).
- [x] Nắm vững cơ chế `DataContext` dùng chung và quy chuẩn dữ liệu file `.txt`.

### Giai đoạn 2: Hoàn thiện Tầng Nghiệp vụ (`HopDongService.cs`) (Hoàn thành)
- [x] Viết các phương thức CRUD cơ bản cho Sinh viên (`GetAllSinhVien`, `GetSinhVienById`, `ThemSinhVien`, `CapNhatSinhVien`, `XoaSinhVien`).
- [x] Viết logic tạo hợp đồng có tăng số chỗ phòng (`TaoHopDong`).
- [x] Viết logic thanh lý hợp đồng có giảm số chỗ phòng (`ThanhLyHopDong`).
- [x] Bổ sung phương thức `GiaHanHopDong(string maHD, DateTime ngayKetThucMoi, out string error)`.
- [x] Bổ sung các phương thức tìm kiếm, lọc sinh viên theo từ khóa/lớp/khoa (`TimKiemSinhVien`, `LocSinhVien`, `GetDanhSachKhoa`).
- [x] Bổ sung các phương thức tìm kiếm, lọc hợp đồng theo trạng thái/phòng/sinh viên (`TimKiemHopDong`, `LocHopDong`, `GetDanhSachPhongConTrong`).
- [x] Bổ sung logic tự động sinh mã `SinhMaSinhVienTuDong()` và `SinhMaHopDongTuDong()`.

### Giai đoạn 3: Thiết kế & Hiện thực Giao diện Sinh viên (`FrmSinhVien`) (Hoàn thành)
- [x] Thiết kế form giao diện WinForms (`FrmSinhVien.Designer.cs`) đẹp mắt, bố cục cân đối.
- [x] Bổ sung các Label, TextBox, ComboBox, DateTimePicker, Button chức năng.
- [x] Xử lý sự kiện `Load` nạp danh sách sinh viên lên DataGridView.
- [x] Xử lý sự kiện `SelectionChanged` / `CellClick` binding dữ liệu lên ô nhập.
- [x] Xử lý các sự kiện click nút Thêm, Sửa, Xóa, Làm mới, Tìm kiếm kèm thông báo `MessageBox`.
- [x] Tích hợp kiểm tra validation đầy đủ (SĐT 10 số, CCCD, Email, không để trống).

### Giai đoạn 4: Thiết kế & Hiện thực Giao diện Hợp đồng (`FrmHopDong`) (Hoàn thành)
- [x] Thiết kế form giao diện WinForms (`FrmHopDong.Designer.cs`) chuẩn mực.
- [x] Bố trí ComboBox nạp danh sách Sinh viên và danh sách Phòng còn trống.
- [x] Xử lý sự kiện tạo hợp đồng mới và phản ánh ngay thay đổi số chỗ của phòng.
- [x] Xử lý sự kiện gia hạn hợp đồng (cập nhật ngày kết thúc mới).
- [x] Xử lý sự kiện thanh lý hợp đồng và hoàn trả chỗ trống cho phòng.
- [x] Xử lý tìm kiếm và lọc danh sách hợp đồng theo từ khóa, trạng thái, phòng.

### Giai đoạn 5: Kiểm thử, Báo cáo & Hợp nhất (Merge)
- [x] Thêm dữ liệu mẫu kiểm thử đầy đủ (`toanha.txt`, `phong.txt`, `sinhvien.txt`, `hopdong.txt`).
- [x] Viết script kiểm thử tự động, kiểm tra tính toàn vẹn dữ liệu và nghiệp vụ (Pass 100%).
- [x] Biên dịch toàn bộ Solution thành công (0 Warning, 0 Error).
- [ ] Mở ứng dụng trên Visual Studio kiểm tra trực quan lần cuối.
- [ ] Commit mã nguồn lên nhánh `AnhThy` và tạo Pull Request merge vào `main`.

---

## 4. Quy Tắc Kỹ Thuật Bắt Buộc

1. **Sử dụng `DataContext` tập trung:**
   - Không được tự ý mở `StreamReader` hay `StreamWriter` đọc ghi file riêng rẽ trong form.
   - Thao tác trực tiếp trên `_context.DanhSachSinhVien`, `_context.DanhSachHopDong` và gọi `_context.SaveSinhVien()`, `_context.SaveHopDong()`, `_context.SavePhong()`.
2. **Không đưa nghiệp vụ tính toán nặng vào sự kiện UI:**
   - Các Form thuộc Presentation chỉ đóng vai trò lấy dữ liệu từ giao diện, validate cơ bản và gọi Service tương ứng.
3. **Độc lập phân hệ:**
   - Chỉ chỉnh sửa các file thuộc phân hệ của mình, không sửa đổi code phân hệ 1 (SV1) hay phân hệ 3 (SV3) để tránh gây xung đột Git (conflict).
