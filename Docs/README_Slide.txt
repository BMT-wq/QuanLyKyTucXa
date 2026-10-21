================================================================================
DỰ ÁN: PHẦN MỀM QUẢN LÝ KÝ TÚC XÁ (C# WINFORMS - .NET FRAMEWORK 4.8)
ĐỀ CƯƠNG BẢN TRÌNH CHIẾU / SLIDE THUYẾT TRÌNH (README_Slide.txt)
================================================================================

SLIDE 1: TIÊU ĐỀ & THÀNH VIÊN
- Tên đồ án: Xây dựng Phần mềm Quản lý Ký túc xá
- Giảng viên hướng dẫn: ...
- Nhóm sinh viên thực hiện:
  + SV1: Họ và tên - MSSV (Phụ trách: Tòa nhà & Phòng)
  + SV2: Họ và tên - MSSV (Phụ trách: Sinh viên & Hợp đồng)
  + SV3: Họ và tên - MSSV (Phụ trách: Điện nước & Thu phí)

SLIDE 2: ĐẶT VẤN ĐỀ & MỤC TIÊU ĐỀ TÀI
- Khó khăn trong việc quản lý ký túc xá truyền thống bằng sổ sách / excel rời rạc.
- Mục tiêu: Xây dựng ứng dụng desktop WinForms trực quan, tin cậy, lưu trữ file gọn nhẹ.

SLIDE 3: KIẾN TRÚC VÀ CÔNG NGHỆ ỨNG DỤNG
- Ngôn ngữ: C# (.NET Framework 4.8).
- Giao diện: Windows Forms (MDI Form chuyên nghiệp, phân hệ rõ ràng).
- Lưu trữ: Flat File .txt kết hợp StreamReader / StreamWriter mã hóa chuẩn UTF-8.
- Kiến trúc hướng dịch vụ nhiều tầng (Domain, Application, Infrastructure, Presentation).
- Quản lý trạng thái dữ liệu đồng bộ qua DataContext dùng chung.

SLIDE 4: PHÂN HỆ 1 - QUẢN LÝ PHÒNG & TÒA NHÀ (SV1)
- Mô hình dữ liệu: ToaNha, Phong.
- Các chức năng chính: Thêm, sửa, xóa, tìm kiếm theo tòa nhà, lọc phòng còn trống, quản lý trạng thái phòng.
- Demo giao diện và các ca sử dụng tiêu biểu.

SLIDE 5: PHÂN HỆ 2 - QUẢN LÝ SINH VIÊN & HỢP ĐỒNG (SV2)
- Mô hình dữ liệu: SinhVien, HopDong.
- Các chức năng chính: Tiếp nhận hồ sơ sinh viên, tạo hợp đồng thuê, cập nhật sĩ số phòng tự động, gia hạn & thanh lý hợp đồng.
- Xử lý ràng buộc nghiệp vụ (sinh viên chỉ ở 1 phòng còn chỗ, đúng giới tính quy định).

SLIDE 6: PHÂN HỆ 3 - QUẢN LÝ ĐIỆN NƯỚC & THU PHÍ (SV3)
- Mô hình dữ liệu: DienNuoc, ThuPhi.
- Các chức năng chính: Ghi chỉ số điện nước theo kỳ, tự động tính tiền theo đơn giá, lập phiếu thu tiền phòng/điện nước, thống kê công nợ.

SLIDE 7: DEMO ỨNG DỤNG TRỰC TIẾP
- Đăng nhập hệ thống (FrmDangNhap).
- Điều hướng menu MDI (FrmMain).
- Quy trình phối hợp: Thêm phòng -> Tiếp nhận sinh viên -> Tạo hợp đồng -> Ghi điện nước -> Thu phí.

SLIDE 8: ĐÁNH GIÁ & HƯỚNG PHÁT TRIỂN
- Kết quả đạt được: Đảm bảo đúng yêu cầu kỹ thuật, không dùng CSDL SQL mà vẫn bảo đảm tính toàn vẹn dữ liệu.
- Định hướng nâng cấp: Chuyển đổi sang CSDL quan hệ khi quy mô ký túc xá mở rộng, in ấn hóa đơn mẫu đẹp.

SLIDE 9: HỎI ĐÁP (Q&A) & CẢM ƠN
================================================================================
