# NHÁNH LÀM VIỆC: TẤN QUỐC (SV3)

- **Người thực hiện:** Tấn Quốc
- **Nhiệm vụ chính:** Phân hệ 3 (Quản lý Chỉ số Điện Nước & Thu phí Ký túc xá).
- **Các file và thư mục phụ trách:**
  - `src/QuanLyKyTucXa/Presentation/SV3_DienNuocThuPhi/`
    - `FrmDienNuoc.cs` & `FrmDienNuoc.Designer.cs`
    - `FrmThuPhi.cs` & `FrmThuPhi.Designer.cs`
  - `src/QuanLyKyTucXa/Application/ThuPhiService.cs`
  - `src/QuanLyKyTucXa/Domain/DienNuoc.cs` & `Domain/ThuPhi.cs`
- **Quy tắc làm việc:**
  - Phát triển các chức năng ghi chỉ số điện nước, tính tiền tự động, lập phiếu thu và thống kê công nợ.
  - Sử dụng chung `DataContext`, không tạo cơ chế đọc ghi file riêng rẽ.
  - Sau khi hoàn thành và test kỹ, tạo Pull Request để merge vào nhánh `main`.
