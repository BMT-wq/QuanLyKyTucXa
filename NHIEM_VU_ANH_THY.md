# NHÁNH LÀM VIỆC: ANH THY (SV2)

- **Người thực hiện:** Anh Thy
- **Nhiệm vụ chính:** Phân hệ 2 (Quản lý Hồ sơ Sinh viên & Hợp đồng thuê phòng).
- **Các file và thư mục phụ trách:**
  - `src/QuanLyKyTucXa/Presentation/SV2_SinhVienHopDong/`
    - `FrmSinhVien.cs` & `FrmSinhVien.Designer.cs`
    - `FrmHopDong.cs` & `FrmHopDong.Designer.cs`
  - `src/QuanLyKyTucXa/Application/HopDongService.cs`
  - `src/QuanLyKyTucXa/Domain/SinhVien.cs` & `Domain/HopDong.cs`
- **Quy tắc làm việc:**
  - Phát triển các chức năng tiếp nhận sinh viên, tạo hợp đồng, gia hạn và thanh lý hợp đồng.
  - Sử dụng chung `DataContext`, không tạo cơ chế đọc ghi file riêng rẽ.
  - Sau khi hoàn thành và test kỹ, tạo Pull Request để merge vào nhánh `main`.
