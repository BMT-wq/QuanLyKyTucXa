using System;
using System.Windows.Forms;
using QuanLyKyTucXa.Application;
using QuanLyKyTucXa.Domain;
using QuanLyKyTucXa.Presentation.SV1_PhongToaNha;
using QuanLyKyTucXa.Presentation.SV2_SinhVienHopDong;
using QuanLyKyTucXa.Presentation.SV3_DienNuocThuPhi;

namespace QuanLyKyTucXa.Presentation
{
    public partial class FrmMain : Form
    {
        private readonly DataContext _context;
        private readonly User _currentUser;

        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(DataContext context, User currentUser) : this()
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _currentUser = currentUser;

            if (_currentUser != null)
            {
                lblStatusUser.Text = $"Người dùng: {_currentUser.FullName} ({_currentUser.Role})";
            }
        }

        /// <summary>
        /// Mở hoặc kích hoạt Form con bên trong giao diện MDI Container.
        /// Tránh mở trùng lặp nhiều form cùng một loại.
        /// </summary>
        private void ShowChildForm<T>(Func<T> createForm) where T : Form
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is T)
                {
                    child.Activate();
                    return;
                }
            }

            T form = createForm();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        #region Menu Hệ Thống
        private void MenuLuuDuLieu_Click(object sender, EventArgs e)
        {
            try
            {
                _context.SaveAll();
                MessageBox.Show("Đã lưu toàn bộ dữ liệu xuống các file .txt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                using (var frmLogin = new FrmDangNhap(_context))
                {
                    if (frmLogin.ShowDialog() == DialogResult.OK)
                    {
                        var newMain = new FrmMain(_context, frmLogin.AuthenticatedUser);
                        newMain.Show();
                    }
                    else
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                }
            }
        }

        private void MenuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show("Bạn có muốn lưu các thay đổi trước khi thoát không?", "Xác nhận đóng ứng dụng", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
                if (result == DialogResult.Yes)
                {
                    _context?.SaveAll();
                }
            }
        }
        #endregion

        #region Menu Phân hệ 1: Tòa nhà & Phòng (SV1)
        private void MenuToaNha_Click(object sender, EventArgs e)
        {
            ShowChildForm(() => new FrmToaNha(_context));
        }

        private void MenuPhong_Click(object sender, EventArgs e)
        {
            ShowChildForm(() => new FrmPhong(_context));
        }
        #endregion

        #region Menu Phân hệ 2: Sinh viên & Hợp đồng (SV2)
        private void MenuSinhVien_Click(object sender, EventArgs e)
        {
            ShowChildForm(() => new FrmSinhVien(_context));
        }

        private void MenuHopDong_Click(object sender, EventArgs e)
        {
            ShowChildForm(() => new FrmHopDong(_context));
        }
        #endregion

        #region Menu Phân hệ 3: Điện nước & Thu phí (SV3)
        private void MenuDienNuoc_Click(object sender, EventArgs e)
        {
            ShowChildForm(() => new FrmDienNuoc(_context));
        }

        private void MenuThuPhi_Click(object sender, EventArgs e)
        {
            ShowChildForm(() => new FrmThuPhi(_context));
        }
        #endregion

        #region Trợ giúp
        private void MenuThongTin_Click(object sender, EventArgs e)
        {
            string info = "ĐỒ ÁN: QUẢN LÝ KÝ TÚC XÁ\n" +
                          "Công nghệ: C# Windows Forms (.NET Framework 4.8)\n" +
                          "Lưu trữ: Flat Files (.txt) - StreamReader / StreamWriter UTF-8\n" +
                          "Phân hệ:\n" +
                          "  - SV1: Quản lý Tòa nhà & Phòng\n" +
                          "  - SV2: Quản lý Sinh viên & Hợp đồng\n" +
                          "  - SV3: Quản lý Điện nước & Thu phí";
            MessageBox.Show(info, "Thông tin đồ án", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
