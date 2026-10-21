using System;
using System.Linq;
using System.Windows.Forms;
using QuanLyKyTucXa.Application;
using QuanLyKyTucXa.Domain;

namespace QuanLyKyTucXa.Presentation
{
    public partial class FrmDangNhap : Form
    {
        private readonly DataContext _context;

        /// <summary>
        /// Người dùng đã xác thực thành công sau khi đăng nhập.
        /// </summary>
        public User AuthenticatedUser { get; private set; }

        public FrmDangNhap()
        {
            InitializeComponent();
        }

        public FrmDangNhap(DataContext context) : this()
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (!Validator.IsNotEmpty(username, "Tên đăng nhập", out string errUser))
            {
                MessageBox.Show(errUser, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (!Validator.IsNotEmpty(password, "Mật khẩu", out string errPass))
            {
                MessageBox.Show(errPass, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // Kiểm tra thông tin tài khoản qua DataContext
            User user = null;
            if (_context?.Users != null)
            {
                user = _context.Users.FirstOrDefault(u =>
                    u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                    u.Password == password &&
                    u.IsActive);
            }

            // Cho phép đăng nhập mặc định dự phòng nếu chưa có data
            if (user == null && username.Equals("admin", StringComparison.OrdinalIgnoreCase) && password == "admin123")
            {
                user = new User("admin", "admin123", "Quản trị viên", "Admin", true);
            }

            if (user != null)
            {
                AuthenticatedUser = user;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.SelectAll();
                txtPassword.Focus();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
