using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKyTucXa.Presentation
{
    partial class FrmMain
    {
        private IContainer components = null;

        // Menu
        private MenuStrip menuStripMain;
        private ToolStripMenuItem menuHeThong;
        private ToolStripMenuItem menuTrangChu;
        private ToolStripMenuItem menuLuuDuLieu;
        private ToolStripMenuItem menuTaiLaiDuLieu;
        private ToolStripSeparator sepHeThong1;
        private ToolStripMenuItem menuDangXuat;
        private ToolStripMenuItem menuThoat;

        private ToolStripMenuItem menuSV1;
        private ToolStripMenuItem menuToaNha;
        private ToolStripMenuItem menuPhong;

        private ToolStripMenuItem menuSV2;
        private ToolStripMenuItem menuSinhVien;
        private ToolStripMenuItem menuHopDong;

        private ToolStripMenuItem menuSV3;
        private ToolStripMenuItem menuDienNuoc;
        private ToolStripMenuItem menuThuPhi;

        private ToolStripMenuItem menuCuaSo;
        private ToolStripMenuItem menuCascade;
        private ToolStripMenuItem menuTileHorizontal;
        private ToolStripMenuItem menuTileVertical;
        private ToolStripSeparator sepCuaSo1;
        private ToolStripMenuItem menuDongTatCa;

        private ToolStripMenuItem menuTroGiup;
        private ToolStripMenuItem menuThongTin;

        // Toolbar
        private ToolStrip toolStripMain;
        private ToolStripButton btnToolTrangChu;
        private ToolStripSeparator sepTool1;
        private ToolStripButton btnToolToaNha;
        private ToolStripButton btnToolPhong;
        private ToolStripSeparator sepTool2;
        private ToolStripButton btnToolSinhVien;
        private ToolStripButton btnToolHopDong;
        private ToolStripSeparator sepTool3;
        private ToolStripButton btnToolDienNuoc;
        private ToolStripButton btnToolThuPhi;
        private ToolStripSeparator sepTool4;
        private ToolStripButton btnToolLuu;
        private ToolStripButton btnToolLamMoi;
        private ToolStripSeparator sepTool5;
        private ToolStripButton btnToolDangXuat;

        // Status Strip & Timer
        private StatusStrip statusStripMain;
        private ToolStripStatusLabel lblStatusUser;
        private ToolStripStatusLabel lblStatusStats;
        private ToolStripStatusLabel lblStatusTime;
        private Timer timerClock;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();

            this.menuStripMain = new MenuStrip();
            this.menuHeThong = new ToolStripMenuItem();
            this.menuTrangChu = new ToolStripMenuItem();
            this.menuLuuDuLieu = new ToolStripMenuItem();
            this.menuTaiLaiDuLieu = new ToolStripMenuItem();
            this.sepHeThong1 = new ToolStripSeparator();
            this.menuDangXuat = new ToolStripMenuItem();
            this.menuThoat = new ToolStripMenuItem();

            this.menuSV1 = new ToolStripMenuItem();
            this.menuToaNha = new ToolStripMenuItem();
            this.menuPhong = new ToolStripMenuItem();

            this.menuSV2 = new ToolStripMenuItem();
            this.menuSinhVien = new ToolStripMenuItem();
            this.menuHopDong = new ToolStripMenuItem();

            this.menuSV3 = new ToolStripMenuItem();
            this.menuDienNuoc = new ToolStripMenuItem();
            this.menuThuPhi = new ToolStripMenuItem();

            this.menuCuaSo = new ToolStripMenuItem();
            this.menuCascade = new ToolStripMenuItem();
            this.menuTileHorizontal = new ToolStripMenuItem();
            this.menuTileVertical = new ToolStripMenuItem();
            this.sepCuaSo1 = new ToolStripSeparator();
            this.menuDongTatCa = new ToolStripMenuItem();

            this.menuTroGiup = new ToolStripMenuItem();
            this.menuThongTin = new ToolStripMenuItem();

            this.toolStripMain = new ToolStrip();
            this.btnToolTrangChu = new ToolStripButton();
            this.sepTool1 = new ToolStripSeparator();
            this.btnToolToaNha = new ToolStripButton();
            this.btnToolPhong = new ToolStripButton();
            this.sepTool2 = new ToolStripSeparator();
            this.btnToolSinhVien = new ToolStripButton();
            this.btnToolHopDong = new ToolStripButton();
            this.sepTool3 = new ToolStripSeparator();
            this.btnToolDienNuoc = new ToolStripButton();
            this.btnToolThuPhi = new ToolStripButton();
            this.sepTool4 = new ToolStripSeparator();
            this.btnToolLuu = new ToolStripButton();
            this.btnToolLamMoi = new ToolStripButton();
            this.sepTool5 = new ToolStripSeparator();
            this.btnToolDangXuat = new ToolStripButton();

            this.statusStripMain = new StatusStrip();
            this.lblStatusUser = new ToolStripStatusLabel();
            this.lblStatusStats = new ToolStripStatusLabel();
            this.lblStatusTime = new ToolStripStatusLabel();
            this.timerClock = new Timer(this.components);

            this.menuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();

            // =====================================================
            // menuStripMain
            // =====================================================
            this.menuStripMain.BackColor = Color.FromArgb(240, 244, 250);
            this.menuStripMain.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            this.menuStripMain.Items.AddRange(new ToolStripItem[] {
                this.menuHeThong,
                this.menuSV1,
                this.menuSV2,
                this.menuSV3,
                this.menuCuaSo,
                this.menuTroGiup
            });
            this.menuStripMain.Location = new Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new Size(1100, 25);
            this.menuStripMain.TabIndex = 1;

            // --- Menu Hệ Thống ---
            this.menuHeThong.DropDownItems.AddRange(new ToolStripItem[] {
                this.menuTrangChu,
                this.menuLuuDuLieu,
                this.menuTaiLaiDuLieu,
                this.sepHeThong1,
                this.menuDangXuat,
                this.menuThoat
            });
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new Size(77, 21);
            this.menuHeThong.Text = "&Hệ Thống";

            this.menuTrangChu.Name = "menuTrangChu";
            this.menuTrangChu.ShortcutKeys = ((Keys)((Keys.Control | Keys.H)));
            this.menuTrangChu.Size = new Size(215, 22);
            this.menuTrangChu.Text = "📊 &Trang Chủ";
            this.menuTrangChu.Click += new System.EventHandler(this.MenuTrangChu_Click);

            this.menuLuuDuLieu.Name = "menuLuuDuLieu";
            this.menuLuuDuLieu.ShortcutKeys = ((Keys)((Keys.Control | Keys.S)));
            this.menuLuuDuLieu.Size = new Size(215, 22);
            this.menuLuuDuLieu.Text = "💾 &Lưu Toàn Bộ";
            this.menuLuuDuLieu.Click += new System.EventHandler(this.MenuLuuDuLieu_Click);

            this.menuTaiLaiDuLieu.Name = "menuTaiLaiDuLieu";
            this.menuTaiLaiDuLieu.ShortcutKeys = Keys.F5;
            this.menuTaiLaiDuLieu.Size = new Size(215, 22);
            this.menuTaiLaiDuLieu.Text = "🔄 &Tải Lại Dữ Liệu";
            this.menuTaiLaiDuLieu.Click += new System.EventHandler(this.MenuTaiLaiDuLieu_Click);

            this.sepHeThong1.Name = "sepHeThong1";
            this.sepHeThong1.Size = new Size(212, 6);

            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new Size(215, 22);
            this.menuDangXuat.Text = "🚪 Đăng &Xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.MenuDangXuat_Click);

            this.menuThoat.Name = "menuThoat";
            this.menuThoat.ShortcutKeys = ((Keys)((Keys.Alt | Keys.F4)));
            this.menuThoat.Size = new Size(215, 22);
            this.menuThoat.Text = "Th&oát";
            this.menuThoat.Click += new System.EventHandler(this.MenuThoat_Click);

            // --- Menu Phân Hệ 1 ---
            this.menuSV1.DropDownItems.AddRange(new ToolStripItem[] {
                this.menuToaNha,
                this.menuPhong
            });
            this.menuSV1.Name = "menuSV1";
            this.menuSV1.Size = new Size(147, 21);
            this.menuSV1.Text = "&1. Phòng && Tòa Nhà";

            this.menuToaNha.Name = "menuToaNha";
            this.menuToaNha.ShortcutKeys = ((Keys)((Keys.Control | Keys.D1)));
            this.menuToaNha.Size = new Size(224, 22);
            this.menuToaNha.Text = "🏢 Quản lý &Tòa Nhà";
            this.menuToaNha.Click += new System.EventHandler(this.MenuToaNha_Click);

            this.menuPhong.Name = "menuPhong";
            this.menuPhong.ShortcutKeys = ((Keys)((Keys.Control | Keys.D2)));
            this.menuPhong.Size = new Size(224, 22);
            this.menuPhong.Text = "🚪 Quản lý &Phòng";
            this.menuPhong.Click += new System.EventHandler(this.MenuPhong_Click);

            // --- Menu Phân Hệ 2 ---
            this.menuSV2.DropDownItems.AddRange(new ToolStripItem[] {
                this.menuSinhVien,
                this.menuHopDong
            });
            this.menuSV2.Name = "menuSV2";
            this.menuSV2.Size = new Size(161, 21);
            this.menuSV2.Text = "&2. Sinh Viên && Hợp Đồng";

            this.menuSinhVien.Name = "menuSinhVien";
            this.menuSinhVien.ShortcutKeys = ((Keys)((Keys.Control | Keys.D3)));
            this.menuSinhVien.Size = new Size(256, 22);
            this.menuSinhVien.Text = "👨‍🎓 Hồ sơ &Sinh Viên";
            this.menuSinhVien.Click += new System.EventHandler(this.MenuSinhVien_Click);

            this.menuHopDong.Name = "menuHopDong";
            this.menuHopDong.ShortcutKeys = ((Keys)((Keys.Control | Keys.D4)));
            this.menuHopDong.Size = new Size(256, 22);
            this.menuHopDong.Text = "📝 Hợp đồng &Thuê phòng";
            this.menuHopDong.Click += new System.EventHandler(this.MenuHopDong_Click);

            // --- Menu Phân Hệ 3 ---
            this.menuSV3.DropDownItems.AddRange(new ToolStripItem[] {
                this.menuDienNuoc,
                this.menuThuPhi
            });
            this.menuSV3.Name = "menuSV3";
            this.menuSV3.Size = new Size(155, 21);
            this.menuSV3.Text = "&3. Điện Nước && Thu Phí";

            this.menuDienNuoc.Name = "menuDienNuoc";
            this.menuDienNuoc.ShortcutKeys = ((Keys)((Keys.Control | Keys.D5)));
            this.menuDienNuoc.Size = new Size(236, 22);
            this.menuDienNuoc.Text = "⚡ Quản lý &Điện Nước";
            this.menuDienNuoc.Click += new System.EventHandler(this.MenuDienNuoc_Click);

            this.menuThuPhi.Name = "menuThuPhi";
            this.menuThuPhi.ShortcutKeys = ((Keys)((Keys.Control | Keys.D6)));
            this.menuThuPhi.Size = new Size(236, 22);
            this.menuThuPhi.Text = "💰 Quản lý &Thu Phí";
            this.menuThuPhi.Click += new System.EventHandler(this.MenuThuPhi_Click);

            // --- Menu Cửa Sổ ---
            this.menuCuaSo.DropDownItems.AddRange(new ToolStripItem[] {
                this.menuCascade,
                this.menuTileHorizontal,
                this.menuTileVertical,
                this.sepCuaSo1,
                this.menuDongTatCa
            });
            this.menuCuaSo.Name = "menuCuaSo";
            this.menuCuaSo.Size = new Size(65, 21);
            this.menuCuaSo.Text = "&Cửa Sổ";

            this.menuCascade.Name = "menuCascade";
            this.menuCascade.Size = new Size(159, 22);
            this.menuCascade.Text = "Xếp &Tầng";
            this.menuCascade.Click += new System.EventHandler(this.MenuCascade_Click);

            this.menuTileHorizontal.Name = "menuTileHorizontal";
            this.menuTileHorizontal.Size = new Size(159, 22);
            this.menuTileHorizontal.Text = "Xếp &Ngang";
            this.menuTileHorizontal.Click += new System.EventHandler(this.MenuTileHorizontal_Click);

            this.menuTileVertical.Name = "menuTileVertical";
            this.menuTileVertical.Size = new Size(159, 22);
            this.menuTileVertical.Text = "Xếp &Dọc";
            this.menuTileVertical.Click += new System.EventHandler(this.MenuTileVertical_Click);

            this.sepCuaSo1.Name = "sepCuaSo1";
            this.sepCuaSo1.Size = new Size(156, 6);

            this.menuDongTatCa.Name = "menuDongTatCa";
            this.menuDongTatCa.Size = new Size(159, 22);
            this.menuDongTatCa.Text = "&Đóng Tất Cả";
            this.menuDongTatCa.Click += new System.EventHandler(this.MenuDongTatCa_Click);

            // --- Menu Trợ Giúp ---
            this.menuTroGiup.DropDownItems.AddRange(new ToolStripItem[] {
                this.menuThongTin
            });
            this.menuTroGiup.Name = "menuTroGiup";
            this.menuTroGiup.Size = new Size(71, 21);
            this.menuTroGiup.Text = "Trợ &Giúp";

            this.menuThongTin.Name = "menuThongTin";
            this.menuThongTin.ShortcutKeys = Keys.F1;
            this.menuThongTin.Size = new Size(196, 22);
            this.menuThongTin.Text = "ℹ Thông &Tin Đồ Án";
            this.menuThongTin.Click += new System.EventHandler(this.MenuThongTin_Click);

            // =====================================================
            // toolStripMain (Thanh công cụ lớn, hiện đại)
            // =====================================================
            this.toolStripMain.BackColor = Color.FromArgb(250, 252, 255);
            this.toolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            this.toolStripMain.ImageScalingSize = new Size(24, 24);
            this.toolStripMain.Items.AddRange(new ToolStripItem[] {
                this.btnToolTrangChu,
                this.sepTool1,
                this.btnToolToaNha,
                this.btnToolPhong,
                this.sepTool2,
                this.btnToolSinhVien,
                this.btnToolHopDong,
                this.sepTool3,
                this.btnToolDienNuoc,
                this.btnToolThuPhi,
                this.sepTool4,
                this.btnToolLuu,
                this.btnToolLamMoi,
                this.sepTool5,
                this.btnToolDangXuat
            });
            this.toolStripMain.Location = new Point(0, 25);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Padding = new Padding(10, 4, 10, 4);
            this.toolStripMain.Size = new Size(1100, 36);
            this.toolStripMain.TabIndex = 2;

            // Styling ToolStrip buttons
            InitToolButton(this.btnToolTrangChu, "📊 Trang Chủ", Color.FromArgb(33, 50, 94), this.MenuTrangChu_Click);
            InitToolButton(this.btnToolToaNha, "🏢 Tòa Nhà", Color.FromArgb(25, 118, 210), this.MenuToaNha_Click);
            InitToolButton(this.btnToolPhong, "🚪 Phòng KTX", Color.FromArgb(46, 125, 50), this.MenuPhong_Click);
            InitToolButton(this.btnToolSinhVien, "👨‍🎓 Sinh Viên", Color.FromArgb(230, 108, 0), this.MenuSinhVien_Click);
            InitToolButton(this.btnToolHopDong, "📝 Hợp Đồng", Color.FromArgb(123, 31, 162), this.MenuHopDong_Click);
            InitToolButton(this.btnToolDienNuoc, "⚡ Điện Nước", Color.FromArgb(198, 40, 40), this.MenuDienNuoc_Click);
            InitToolButton(this.btnToolThuPhi, "💰 Thu Phí", Color.FromArgb(0, 137, 123), this.MenuThuPhi_Click);
            InitToolButton(this.btnToolLuu, "💾 Lưu Dữ Liệu", Color.FromArgb(69, 90, 100), this.MenuLuuDuLieu_Click);
            InitToolButton(this.btnToolLamMoi, "🔄 Làm Mới", Color.FromArgb(97, 97, 97), this.MenuTaiLaiDuLieu_Click);
            InitToolButton(this.btnToolDangXuat, "🚪 Đăng Xuất", Color.FromArgb(183, 28, 28), this.MenuDangXuat_Click);

            // Separators
            this.sepTool1.Name = "sepTool1";
            this.sepTool1.Size = new Size(6, 28);
            this.sepTool2.Name = "sepTool2";
            this.sepTool2.Size = new Size(6, 28);
            this.sepTool3.Name = "sepTool3";
            this.sepTool3.Size = new Size(6, 28);
            this.sepTool4.Name = "sepTool4";
            this.sepTool4.Size = new Size(6, 28);
            this.sepTool5.Name = "sepTool5";
            this.sepTool5.Size = new Size(6, 28);

            // =====================================================
            // statusStripMain
            // =====================================================
            this.statusStripMain.BackColor = Color.FromArgb(235, 240, 248);
            this.statusStripMain.Items.AddRange(new ToolStripItem[] {
                this.lblStatusUser,
                this.lblStatusStats,
                this.lblStatusTime
            });
            this.statusStripMain.Location = new Point(0, 680);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Padding = new Padding(1, 0, 14, 0);
            this.statusStripMain.Size = new Size(1100, 24);
            this.statusStripMain.TabIndex = 3;

            // lblStatusUser
            this.lblStatusUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblStatusUser.ForeColor = Color.FromArgb(33, 50, 94);
            this.lblStatusUser.Name = "lblStatusUser";
            this.lblStatusUser.Size = new Size(150, 19);
            this.lblStatusUser.Text = "👤 Người dùng: Admin";

            // lblStatusStats
            this.lblStatusStats.Font = new Font("Segoe UI", 9F);
            this.lblStatusStats.ForeColor = Color.FromArgb(60, 60, 60);
            this.lblStatusStats.Name = "lblStatusStats";
            this.lblStatusStats.Size = new Size(735, 19);
            this.lblStatusStats.Spring = true;
            this.lblStatusStats.TextAlign = ContentAlignment.MiddleLeft;
            this.lblStatusStats.Text = "  |  🏢 0 Tòa nhà  |  🚪 0 Phòng  |  👨‍🎓 0 Sinh viên  |  📝 0 Hợp đồng";

            // lblStatusTime
            this.lblStatusTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblStatusTime.ForeColor = Color.FromArgb(50, 50, 50);
            this.lblStatusTime.Name = "lblStatusTime";
            this.lblStatusTime.Size = new Size(200, 19);
            this.lblStatusTime.TextAlign = ContentAlignment.MiddleRight;
            this.lblStatusTime.Text = "🕒 00:00:00";

            // timerClock
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.TimerClock_Tick);

            // =====================================================
            // FrmMain
            // =====================================================
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(238, 242, 248);
            this.ClientSize = new Size(1100, 704);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Font = new Font("Segoe UI", 9F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new Size(950, 650);
            this.Name = "FrmMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ KÝ TÚC XÁ - C# WINFORMS .NET 4.8";
            this.WindowState = FormWindowState.Maximized;
            this.FormClosing += new FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);

            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void InitToolButton(ToolStripButton btn, string text, Color color, System.EventHandler onClick)
        {
            btn.Font = new Font("Segoe UI", 9.25F, FontStyle.Bold);
            btn.ForeColor = color;
            btn.Margin = new Padding(2, 1, 2, 2);
            btn.Padding = new Padding(4, 2, 4, 2);
            btn.Text = text;
            btn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btn.Click += onClick;
        }
    }
}
