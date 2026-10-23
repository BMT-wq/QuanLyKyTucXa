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
            this.components = new System.ComponentModel.Container();

            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLuuDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTaiLaiDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.sepHeThong1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();

            this.menuSV1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToaNha = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhong = new System.Windows.Forms.ToolStripMenuItem();

            this.menuSV2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHopDong = new System.Windows.Forms.ToolStripMenuItem();

            this.menuSV3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDienNuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThuPhi = new System.Windows.Forms.ToolStripMenuItem();

            this.menuCuaSo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.sepCuaSo1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuDongTatCa = new System.Windows.Forms.ToolStripMenuItem();

            this.menuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongTin = new System.Windows.Forms.ToolStripMenuItem();

            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.lblStatusUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusStats = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerClock = new System.Windows.Forms.Timer(this.components);

            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();

            // =====================================================
            // menuStripMain
            // =====================================================
            this.menuStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuHeThong,
                this.menuSV1,
                this.menuSV2,
                this.menuSV3,
                this.menuCuaSo,
                this.menuTroGiup
            });
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1100, 25);
            this.menuStripMain.TabIndex = 1;

            // --- Menu Hệ Thống ---
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuTrangChu,
                this.menuLuuDuLieu,
                this.menuTaiLaiDuLieu,
                this.sepHeThong1,
                this.menuDangXuat,
                this.menuThoat
            });
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(77, 21);
            this.menuHeThong.Text = "&Hệ Thống";

            this.menuTrangChu.Name = "menuTrangChu";
            this.menuTrangChu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.menuTrangChu.Size = new System.Drawing.Size(215, 22);
            this.menuTrangChu.Text = "📊 &Trang Chủ";
            this.menuTrangChu.Click += new System.EventHandler(this.MenuTrangChu_Click);

            this.menuLuuDuLieu.Name = "menuLuuDuLieu";
            this.menuLuuDuLieu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuLuuDuLieu.Size = new System.Drawing.Size(215, 22);
            this.menuLuuDuLieu.Text = "💾 &Lưu Toàn Bộ";
            this.menuLuuDuLieu.Click += new System.EventHandler(this.MenuLuuDuLieu_Click);

            this.menuTaiLaiDuLieu.Name = "menuTaiLaiDuLieu";
            this.menuTaiLaiDuLieu.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuTaiLaiDuLieu.Size = new System.Drawing.Size(215, 22);
            this.menuTaiLaiDuLieu.Text = "🔄 &Tải Lại Dữ Liệu";
            this.menuTaiLaiDuLieu.Click += new System.EventHandler(this.MenuTaiLaiDuLieu_Click);

            this.sepHeThong1.Name = "sepHeThong1";
            this.sepHeThong1.Size = new System.Drawing.Size(212, 6);

            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(215, 22);
            this.menuDangXuat.Text = "🚪 Đăng &Xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.MenuDangXuat_Click);

            this.menuThoat.Name = "menuThoat";
            this.menuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuThoat.Size = new System.Drawing.Size(215, 22);
            this.menuThoat.Text = "Th&oát";
            this.menuThoat.Click += new System.EventHandler(this.MenuThoat_Click);

            // --- Menu Phân Hệ 1 ---
            this.menuSV1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuToaNha,
                this.menuPhong
            });
            this.menuSV1.Name = "menuSV1";
            this.menuSV1.Size = new System.Drawing.Size(147, 21);
            this.menuSV1.Text = "&1. Phòng && Tòa Nhà";

            this.menuToaNha.Name = "menuToaNha";
            this.menuToaNha.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.menuToaNha.Size = new System.Drawing.Size(224, 22);
            this.menuToaNha.Text = "🏢 Quản lý &Tòa Nhà";
            this.menuToaNha.Click += new System.EventHandler(this.MenuToaNha_Click);

            this.menuPhong.Name = "menuPhong";
            this.menuPhong.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.menuPhong.Size = new System.Drawing.Size(224, 22);
            this.menuPhong.Text = "🚪 Quản lý &Phòng";
            this.menuPhong.Click += new System.EventHandler(this.MenuPhong_Click);

            // --- Menu Phân Hệ 2 ---
            this.menuSV2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuSinhVien,
                this.menuHopDong
            });
            this.menuSV2.Name = "menuSV2";
            this.menuSV2.Size = new System.Drawing.Size(161, 21);
            this.menuSV2.Text = "&2. Sinh Viên && Hợp Đồng";

            this.menuSinhVien.Name = "menuSinhVien";
            this.menuSinhVien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.menuSinhVien.Size = new System.Drawing.Size(256, 22);
            this.menuSinhVien.Text = "👨‍🎓 Hồ sơ &Sinh Viên";
            this.menuSinhVien.Click += new System.EventHandler(this.MenuSinhVien_Click);

            this.menuHopDong.Name = "menuHopDong";
            this.menuHopDong.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.menuHopDong.Size = new System.Drawing.Size(256, 22);
            this.menuHopDong.Text = "📝 Hợp đồng &Thuê phòng";
            this.menuHopDong.Click += new System.EventHandler(this.MenuHopDong_Click);

            // --- Menu Phân Hệ 3 ---
            this.menuSV3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuDienNuoc,
                this.menuThuPhi
            });
            this.menuSV3.Name = "menuSV3";
            this.menuSV3.Size = new System.Drawing.Size(155, 21);
            this.menuSV3.Text = "&3. Điện Nước && Thu Phí";

            this.menuDienNuoc.Name = "menuDienNuoc";
            this.menuDienNuoc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.menuDienNuoc.Size = new System.Drawing.Size(236, 22);
            this.menuDienNuoc.Text = "⚡ Quản lý &Điện Nước";
            this.menuDienNuoc.Click += new System.EventHandler(this.MenuDienNuoc_Click);

            this.menuThuPhi.Name = "menuThuPhi";
            this.menuThuPhi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.menuThuPhi.Size = new System.Drawing.Size(236, 22);
            this.menuThuPhi.Text = "💰 Quản lý &Thu Phí";
            this.menuThuPhi.Click += new System.EventHandler(this.MenuThuPhi_Click);

            // --- Menu Cửa Sổ ---
            this.menuCuaSo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuCascade,
                this.menuTileHorizontal,
                this.menuTileVertical,
                this.sepCuaSo1,
                this.menuDongTatCa
            });
            this.menuCuaSo.Name = "menuCuaSo";
            this.menuCuaSo.Size = new System.Drawing.Size(65, 21);
            this.menuCuaSo.Text = "&Cửa Sổ";

            this.menuCascade.Name = "menuCascade";
            this.menuCascade.Size = new System.Drawing.Size(159, 22);
            this.menuCascade.Text = "Xếp &Tầng";
            this.menuCascade.Click += new System.EventHandler(this.MenuCascade_Click);

            this.menuTileHorizontal.Name = "menuTileHorizontal";
            this.menuTileHorizontal.Size = new System.Drawing.Size(159, 22);
            this.menuTileHorizontal.Text = "Xếp &Ngang";
            this.menuTileHorizontal.Click += new System.EventHandler(this.MenuTileHorizontal_Click);

            this.menuTileVertical.Name = "menuTileVertical";
            this.menuTileVertical.Size = new System.Drawing.Size(159, 22);
            this.menuTileVertical.Text = "Xếp &Dọc";
            this.menuTileVertical.Click += new System.EventHandler(this.MenuTileVertical_Click);

            this.sepCuaSo1.Name = "sepCuaSo1";
            this.sepCuaSo1.Size = new System.Drawing.Size(156, 6);

            this.menuDongTatCa.Name = "menuDongTatCa";
            this.menuDongTatCa.Size = new System.Drawing.Size(159, 22);
            this.menuDongTatCa.Text = "&Đóng Tất Cả";
            this.menuDongTatCa.Click += new System.EventHandler(this.MenuDongTatCa_Click);

            // --- Menu Trợ Giúp ---
            this.menuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuThongTin
            });
            this.menuTroGiup.Name = "menuTroGiup";
            this.menuTroGiup.Size = new System.Drawing.Size(71, 21);
            this.menuTroGiup.Text = "Trợ &Giúp";

            this.menuThongTin.Name = "menuThongTin";
            this.menuThongTin.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuThongTin.Size = new System.Drawing.Size(196, 22);
            this.menuThongTin.Text = "ℹ Thông &Tin Đồ Án";
            this.menuThongTin.Click += new System.EventHandler(this.MenuThongTin_Click);

            // =====================================================
            // statusStripMain
            // =====================================================
            this.statusStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblStatusUser,
                this.lblStatusStats,
                this.lblStatusTime
            });
            this.statusStripMain.Location = new System.Drawing.Point(0, 680);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 14, 0);
            this.statusStripMain.Size = new System.Drawing.Size(1100, 24);
            this.statusStripMain.TabIndex = 2;

            // lblStatusUser
            this.lblStatusUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.lblStatusUser.Name = "lblStatusUser";
            this.lblStatusUser.Size = new System.Drawing.Size(150, 19);
            this.lblStatusUser.Text = "👤 Người dùng: Admin";

            // lblStatusStats
            this.lblStatusStats.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatusStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblStatusStats.Name = "lblStatusStats";
            this.lblStatusStats.Size = new System.Drawing.Size(735, 19);
            this.lblStatusStats.Spring = true;
            this.lblStatusStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatusStats.Text = "  |  🏢 0 Tòa nhà  |  🚪 0 Phòng  |  👨‍🎓 0 Sinh viên  |  📝 0 Hợp đồng";

            // lblStatusTime
            this.lblStatusTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblStatusTime.Name = "lblStatusTime";
            this.lblStatusTime.Size = new System.Drawing.Size(200, 19);
            this.lblStatusTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStatusTime.Text = "🕒 00:00:00";

            // timerClock
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.TimerClock_Tick);

            // =====================================================
            // FrmMain
            // =====================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1100, 704);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ KÝ TÚC XÁ - C# WINFORMS .NET 4.8";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);

            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
