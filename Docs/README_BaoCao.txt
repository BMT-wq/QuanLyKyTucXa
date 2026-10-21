================================================================================
DỰ ÁN: PHẦN MỀM QUẢN LÝ KÝ TÚC XÁ (C# WINFORMS - .NET FRAMEWORK 4.8)
TÀI LIỆU HƯỚNG DẪN VÀ ĐỀ CƯƠNG BÁO CÁO ĐỒ ÁN (README_BaoCao.txt)
================================================================================

I. THÔNG TIN CHUNG
- Môn học: Lập trình Windows / Công nghệ phần mềm
- Tên đề tài: Xây dựng ứng dụng Quản lý Ký túc xá
- Công nghệ: C# Windows Forms (.NET Framework 4.8), Visual Studio
- Cơ chế lưu trữ: File văn bản .txt (StreamReader, StreamWriter, UTF-8)
- Kiến trúc phần mềm: 3 tầng mở rộng (Domain - Application - Infrastructure - Presentation)

II. PHÂN CÔNG NHIỆM VỤ NHÓM (3 THÀNH VIÊN)
1. Sinh viên 1 (SV1 - Phân hệ Phòng & Tòa nhà):
   - Quản lý danh mục Tòa nhà (Mã, Tên, Số tầng, Ghi chú).
   - Quản lý danh mục Phòng (Mã phòng, Tòa nhà, Loại phòng Nam/Nữ, Sức chứa, Đơn giá, Trạng thái).
   - Tìm kiếm, lọc phòng theo tòa nhà, số chỗ trống.

2. Sinh viên 2 (SV2 - Phân hệ Sinh viên & Hợp đồng):
   - Quản lý hồ sơ Sinh viên (Mã SV, Họ tên, Ngày sinh, Giới tính, CCCD, SĐT, Email, Lớp, Quê quán).
   - Quản lý Hợp đồng thuê phòng (Mã HĐ, Mã SV, Mã phòng, Ngày bắt đầu, Ngày kết thúc, Tiền cọc, Trạng thái).
   - Xử lý nghiệp vụ đăng ký phòng, cập nhật số chỗ trong phòng, thanh lý hợp đồng.

3. Sinh viên 3 (SV3 - Phân hệ Điện nước & Thu phí):
   - Quản lý Chỉ số Điện Nước định kỳ hàng tháng theo từng phòng.
   - Tính toán tiền điện, tiền nước theo đơn giá quy định.
   - Quản lý Hóa đơn / Phiếu thu phí (Tiền phòng, Điện nước, Phí phát sinh).
   - Thống kê, báo cáo công nợ và thu chi.

III. CẤU TRÚC ĐỀ CƯƠNG BÁO CÁO CHI TIẾT
CHƯƠNG 1: TỔNG QUAN ĐỀ TÀI VÀ KHẢO SÁT HIỆN TRẠNG
  1.1. Lý do chọn đề tài và mục tiêu xây dựng hệ thống.
  1.2. Khảo sát nghiệp vụ quản lý ký túc xá thực tế.
  1.3. Yêu cầu chức năng và phi chức năng của hệ thống.

CHƯƠNG 2: PHÂN TÍCH VÀ THIẾT KẾ HỆ THỐNG
  2.1. Kiến trúc hệ thống nhiều lớp (Layered Architecture):
       - Domain Layer: Đối tượng thực thể và logic cơ bản.
       - Application Layer: Dịch vụ nghiệp vụ (Services) và DataContext tập trung.
       - Infrastructure Layer: Đọc ghi dữ liệu định dạng Text/UTF-8 (FileHandler).
       - Presentation Layer: Giao diện người dùng Windows Forms (MDI Container).
  2.2. Sơ đồ Use Case tổng quát và chi tiết cho từng phân hệ.
  2.3. Thiết kế mô hình dữ liệu (Data Dictionary cho các file .txt).

CHƯƠNG 3: CÀI ĐẶT VÀ HIỆN THỰC CHỨC NĂNG
  3.1. Môi trường phát triển: C# .NET Framework 4.8, Visual Studio 2022/2026.
  3.2. Hiện thực cơ chế lưu trữ tập trung qua DataContext và FileHandler.
  3.3. Chi tiết hiện thực 3 phân hệ (SV1, SV2, SV3).
  3.4. Giao diện và các thao tác người dùng.

CHƯƠNG 4: KIỂM THỬ VÀ ĐÁNH GIÁ KẾT QUẢ
  4.1. Kịch bản kiểm thử (Test Cases) các chức năng chính và validation.
  4.2. Đánh giá ưu điểm, hạn chế và hướng phát triển tương lai.

CHƯƠNG 5: KẾT LUẬN VÀ TÀI LIỆU THAM KHẢO
================================================================================
