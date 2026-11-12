# NHÁNH LÀM VIỆC: TẤN QUỐC (SV3)

- **Người thực hiện:** Tấn Quốc (Sinh viên 3)
- **Nhiệm vụ chính:** Phân hệ 3 - Quản lý Chỉ số Điện Nước & Thu phí Ký túc xá.
- **Các file và thư mục phụ trách:**
  - `src/QuanLyKyTucXa/Presentation/SV3_DienNuocThuPhi/`
    - `FrmDienNuoc.cs` & `FrmDienNuoc.Designer.cs`
    - `FrmThuPhi.cs` & `FrmThuPhi.Designer.cs`
    - `FrmQuyetToanTraPhong.cs` & `FrmQuyetToanTraPhong.Designer.cs`
  - `src/QuanLyKyTucXa/Application/ThuPhiService.cs`
  - `src/QuanLyKyTucXa/Domain/DienNuoc.cs` & `Domain/ThuPhi.cs`

---

## 1. Danh sách các Nghiệp vụ Mới đã Hoàn Thiện

1. **Tìm kiếm & Chọn phòng nhanh (`FrmDienNuoc`, `FrmThuPhi`):**
   - Bổ sung `ComboBox` chọn phòng hiển thị rõ mã phòng, tên phòng và số người hiện đang ở.
   - Khi chọn phòng, hệ thống tự động tra cứu chỉ số điện nước mới nhất của phòng đó để làm chỉ số cũ, không cần nhập thủ công.
   - Thêm ô tìm kiếm lọc nhanh danh sách hóa đơn điện nước và phiếu thu theo mã phòng/hợp đồng.

2. **Chia tiền điện nước đều cho các sinh viên trong phòng:**
   - Tự động lấy danh sách sinh viên có hợp đồng "Hiệu lực" đang cùng ở phòng đó.
   - Tính toán: `Tiền mỗi sinh viên = Tổng tiền điện nước phòng / Sĩ số sinh viên đang ở`.
   - Cung cấp nút *"Chia tiền SV"* hiển thị chi tiết số tiền từng sinh viên và cho phép 1-click tự động lập phiếu thu điện nước cho từng sinh viên trong phòng.

3. **Gắn đồng hồ điện nước ban đầu với Hợp đồng mới & Lập thu phí cọc:**
   - Ghi nhận chỉ số đồng hồ điện (kWh) và nước (m³) bàn giao tại ngày bắt đầu hợp đồng.
   - Tự động lập phiếu thu *"Tiền đặt cọc"* vào đúng ngày ký hợp đồng của sinh viên.
   - Lưu thông tin mốc đồng hồ vào hợp đồng để làm căn cứ tính tiền khi ở và khi thanh lý.

4. **Tính tiền điện nước riêng cho sinh viên trả phòng trước hạn:**
   - Khi sinh viên trả phòng trước thời hạn hợp đồng hoặc giữa kỳ:
     + Chốt chỉ số đồng hồ điện nước tại thời điểm trả phòng.
     + Tính tiền điện nước tiêu thụ trong giai đoạn sinh viên ở: `(Δ Điện x 3.000 + Δ Nước x 15.000) / Sĩ số phòng`.
     + Mốc chỉ số chốt này được lưu lại để **điện nước tiếp tục tính cho các sinh viên còn ở** trong phòng cho giai đoạn tiếp theo mà không bị tính trùng lặp.

5. **Quyết toán trả cọc & Kết thúc hợp đồng khi sinh viên trả phòng (`FrmQuyetToanTraPhong`):**
   - Tự động tính toán:
     `Tiền cọc thực trả = Tiền cọc gốc - Tiền điện nước SV - Tiền phòng nợ - Phí phạt phát sinh`.
   - Tự động lập các phiếu thu khấu trừ và phiếu hoàn cọc trong hệ thống thu phí.
   - Kết thúc hợp đồng: Chuyển trạng thái hợp đồng sang *"Đã thanh lý"*.
   - Hoàn trả chỗ ở cho phòng: `phong.SoChoHienTai--`, mở lại trạng thái *"Còn chỗ"*.
