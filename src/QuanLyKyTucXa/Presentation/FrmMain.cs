using System;
using System.Linq;
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
                lblStatusUser.Text = $"👤 {_currentUser.FullName} ({_currentUser.Role})";
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Bắt đầu đồng hồ thời gian thực
            timerClock.Start();
            UpdateClock();

            // Cập nhật thống kê nhanh trên status bar
            UpdateStatusStats();

            // Mở mặc định trang chủ Dashboard
            ShowDashboard();
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        private void UpdateClock()
        {
            lblStatusTime.Text = "🕒 " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        /// <summary>
        /// Cập nhật dải thông số tổng quan thời gian thực trên thanh trạng thái dưới cùng.
        /// </summary>
        public void UpdateStatusStats()
        {
            if (_context == null) return;

            int soToaNha = _context.DanhSachToaNha?.Count ?? 0;
            var dsPhong = _context.DanhSachPhong;
            int soPhong = dsPhong?.Count ?? 0;
            int conCho = dsPhong?.Count(p => p.SoChoHienTai < p.SoChoToiDa && p.TrangThai != "Đang sửa chữa") ?? 0;
            int soSV = _context.DanhSachSinhVien?.Count ?? 0;
            int soHD = _context.DanhSachHopDong?.Count(h => h.TrangThai.Equals("Hiệu lực", StringComparison.OrdinalIgnoreCase)) ?? 0;

            lblStatusStats.Text = $"  |  🏢 {soToaNha} Tòa nhà  |  🚪 {soPhong} Phòng ({conCho} còn chỗ)  |  👨‍🎓 {soSV} Sinh viên  |  📝 {soHD} Hợp đồng hiệu lực";
        }

        /// <summary>
        /// Mở hoặc kích hoạt Form con bên trong giao diện MDI Container.
        /// Tránh mở trùng lặp nhiều form cùng một loại.
        /// </summary>
        public void ShowChildForm<T>(Func<T> createForm) where T : Form
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is T)
                {
                    child.WindowState = FormWindowState.Maximized;
                    child.Activate();
                    return;
                }
            }

            T form = createForm();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        /// <summary>
        /// Mở màn hình Dashboard Trang Chủ.
        /// </summary>
        private void ShowDashboard()
        {
            ShowChildForm(() => new FrmDashboard(_context, OpenChildModuleForm));
        }

        /// <summary>
        /// Callback cho phép FrmDashboard mở các phân hệ tương ứng.
        /// </summary>
        private void OpenChildModuleForm(Type formType)
        {
            if (formType == typeof(FrmToaNha)) MenuToaNha_Click(null, EventArgs.Empty);
            else if (formType == typeof(FrmPhong)) MenuPhong_Click(null, EventArgs.Empty);
            else if (formType == typeof(FrmSinhVien)) MenuSinhVien_Click(null, EventArgs.Empty);
            else if (formType == typeof(FrmHopDong)) MenuHopDong_Click(null, EventArgs.Empty);
            else if (formType == typeof(FrmDienNuoc)) MenuDienNuoc_Click(null, EventArgs.Empty);
            else if (formType == typeof(FrmThuPhi)) MenuThuPhi_Click(null, EventArgs.Empty);
        }

        #region Menu Hệ Thống
        private void MenuTrangChu_Click(object sender, EventArgs e)
        {
            ShowDashboard();
            UpdateStatusStats();
        }

        private void MenuLuuDuLieu_Click(object sender, EventArgs e)
        {
            try
            {
                _context.SaveAll();
                UpdateStatusStats();
                MessageBox.Show("Đã lưu toàn bộ dữ liệu xuống các file văn bản (.txt) thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuTaiLaiDuLieu_Click(object sender, EventArgs e)
        {
            try
            {
                _context.LoadAll();
                UpdateStatusStats();

                // Làm mới Dashboard nếu đang mở
                foreach (Form child in this.MdiChildren)
                {
                    if (child is FrmDashboard dashboard)
                    {
                        dashboard.RefreshDashboard();
                    }
                }

                MessageBox.Show("Đã nạp lại toàn bộ dữ liệu từ các file text thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi nạp lại dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi hệ thống?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                timerClock.Stop();
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
                var result = MessageBox.Show("Bạn có muốn lưu các thay đổi dữ liệu trước khi thoát không?", "Xác nhận đóng ứng dụng", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
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

        #region Menu Cửa Sổ (Window Management)
        private void MenuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void MenuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void MenuTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void MenuDongTatCa_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }
        #endregion

        #region Trợ giúp
        private void MenuThongTin_Click(object sender, EventArgs e)
        {
            string info = "====================================================\n" +
                          "HỆ THỐNG QUẢN LÝ KÝ TÚC XÁ SINH VIÊN\n" +
                          "====================================================\n" +
                          "Nền tảng: C# Windows Forms (.NET Framework 4.8)\n" +
                          "Cơ chế lưu trữ: Flat Files (.txt) - StreamReader / StreamWriter UTF-8\n" +
                          "Mô hình kiến trúc: 4 tầng (Domain - Infrastructure - Application - Presentation)\n\n" +
                          "Phân công trách nhiệm:\n" +
                          "  - Trưởng nhóm (SV1): Quản trị chung & Quản lý Tòa nhà - Phòng\n" +
                          "  - SV2 (Anh Thy): Quản lý Hồ sơ Sinh viên & Hợp đồng thuê\n" +
                          "  - SV3 (Tấn Quốc): Quản lý Điện nước & Thu phí dịch vụ\n\n" +
                          "Tài khoản quản trị mặc định: admin / admin123";
            MessageBox.Show(info, "Thông tin đồ án", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
