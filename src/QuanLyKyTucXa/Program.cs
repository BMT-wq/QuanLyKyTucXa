using System;
using System.Windows.Forms;
using QuanLyKyTucXa.Application;
using QuanLyKyTucXa.Presentation;

namespace QuanLyKyTucXa
{
    static class Program
    {
        /// <summary>
        /// Điểm khởi nhập chính (Main entry point) của ứng dụng Quản lý Ký túc xá.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                // Khởi tạo DataContext dùng chung cho toàn bộ phiên làm việc của phần mềm
                DataContext context = new DataContext();
                context.LoadAll();

                // Hiển thị Form Đăng nhập
                using (FrmDangNhap frmLogin = new FrmDangNhap(context))
                {
                    if (frmLogin.ShowDialog() == DialogResult.OK)
                    {
                        // Đăng nhập thành công -> Khởi chạy Form chính MDI
                        System.Windows.Forms.Application.Run(new FrmMain(context, frmLogin.AuthenticatedUser));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi không mong muốn khi khởi động ứng dụng:\n{ex.Message}\n\nChi tiết:\n{ex.StackTrace}",
                                "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
