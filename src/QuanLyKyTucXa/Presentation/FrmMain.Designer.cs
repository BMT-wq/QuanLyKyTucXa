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

            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnToolTrangChu = new System.Windows.Forms.ToolStripButton();
            this.sepTool1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnToolToaNha = new System.Windows.Forms.ToolStripButton();
            this.btnToolPhong = new System.Windows.Forms.ToolStripButton();
            this.sepTool2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnToolSinhVien = new System.Windows.Forms.ToolStripButton();
            this.btnToolHopDong = new System.Windows.Forms.ToolStripButton();
            this.sepTool3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnToolDienNuoc = new System.Windows.Forms.ToolStripButton();
            this.btnToolThuPhi = new System.Windows.Forms.ToolStripButton();
            this.sepTool4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnToolLuu = new System.Windows.Forms.ToolStripButton();
            this.btnToolLamMoi = new System.Windows.Forms.ToolStripButton();
            this.sepTool5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnToolDangXuat = new System.Windows.Forms.ToolStripButton();

            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.lblStatusUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusStats = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerClock = new System.Windows.Forms.Timer(this.components);

            this.menuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
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
            // toolStripMain (Thanh công cụ lớn, chuẩn WinForms Designer)
            // =====================================================
            this.toolStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripMain.Location = new System.Drawing.Point(0, 25);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.toolStripMain.Size = new System.Drawing.Size(1100, 36);
            this.toolStripMain.TabIndex = 2;

            // btnToolTrangChu
            this.btnToolTrangChu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnToolTrangChu.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnToolTrangChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnToolTrangChu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.btnToolTrangChu.Name = "btnToolTrangChu";
            this.btnToolTrangChu.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnToolTrangChu.Size = new System.Drawing.Size(95, 25);
            this.btnToolTrangChu.Text = "📊 Trang Chủ";
            this.btnToolTrangChu.Click += new System.EventHandler(this.MenuTrangChu_Click);

            // sepTool1
            this.sepTool1.Name = "sepTool1";
            this.sepTool1.Size = new System.Drawing.Size(6, 28);

            // btnToolToaNha
            this.btnToolToaNha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnToolToaNha.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnToolToaNha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnToolToaNha.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.btnToolToaNha.Name = "btnToolToaNha";
            this.btnToolToaNha.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnToolToaNha.Size = new System.Drawing.Size(86, 25);
            this.btnToolToaNha.Text = "🏢 Tòa Nhà";
            this.btnToolToaNha.Click += new System.EventHandler(this.MenuToaNha_Click);

            // btnToolPhong
            this.btnToolPhong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnToolPhong.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnToolPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnToolPhong.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.btnToolPhong.Name = "btnToolPhong";
            this.btnToolPhong.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnToolPhong.Size = new System.Drawing.Size(102, 25);
            this.btnToolPhong.Text = "🚪 Phòng KTX";
            this.btnToolPhong.Click += new System.EventHandler(this.MenuPhong_Click);

            // sepTool2
            this.sepTool2.Name = "sepTool2";
            this.sepTool2.Size = new System.Drawing.Size(6, 28);

            // btnToolSinhVien
            this.btnToolSinhVien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnToolSinhVien.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnToolSinhVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.btnToolSinhVien.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.btnToolSinhVien.Name = "btnToolSinhVien";
            this.btnToolSinhVien.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnToolSinhVien.Size = new System.Drawing.Size(92, 25);
            this.btnToolSinhVien.Text = "👨‍🎓 Sinh Viên";
            this.btnToolSinhVien.Click += new System.EventHandler(this.MenuSinhVien_Click);

            // btnToolHopDong
            this.btnToolHopDong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnToolHopDong.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnToolHopDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(31)))), ((int)(((byte)(162)))));
            this.btnToolHopDong.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.btnToolHopDong.Name = "btnToolHopDong";
            this.btnToolHopDong.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnToolHopDong.Size = new System.Drawing.Size(98, 25);
            this.btnToolHopDong.Text = "📝 Hợp Đồng";
            this.btnToolHopDong.Click += new System.EventHandler(this.MenuHopDong_Click);

            // sepTool3
            this.sepTool3.Name = "sepTool3";
            this.sepTool3.Size = new System.Drawing.Size(6, 28);

            // btnToolDienNuoc
            this.btnToolDienNuoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnToolDienNuoc.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnToolDienNuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnToolDienNuoc.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.btnToolDienNuoc.Name = "btnToolDienNuoc";
            this.btnToolDienNuoc.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnToolDienNuoc.Size = new System.Drawing.Size(97, 25);
            this.btnToolDienNuoc.Text = "⚡ Điện Nước";
            this.btnToolDienNuoc.Click += new System.EventHandler(this.MenuDienNuoc_Click);

            // btnToolThuPhi
            this.btnToolThuPhi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnToolThuPhi.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnToolThuPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.btnToolThuPhi.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.btnToolThuPhi.Name = "btnToolThuPhi";
            this.btnToolThuPhi.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnToolThuPhi.Size = new System.Drawing.Size(83, 25);
            this.btnToolThuPhi.Text = "💰 Thu Phí";
            this.btnToolThuPhi.Click += new System.EventHandler(this.MenuThuPhi_Click);

            // sepTool4
            this.sepTool4.Name = "sepTool4";
            this.sepTool4.Size = new System.Drawing.Size(6, 28);

            // btnToolLuu
            this.btnToolLuu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnToolLuu.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnToolLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnToolLuu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.btnToolLuu.Name = "btnToolLuu";
            this.btnToolLuu.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnToolLuu.Size = new System.Drawing.Size(110, 25);
            this.btnToolLuu.Text = "💾 Lưu Dữ Liệu";
            this.btnToolLuu.Click += new System.EventHandler(this.MenuLuuDuLieu_Click);

            // btnToolLamMoi
            this.btnToolLamMoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnToolLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnToolLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnToolLamMoi.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.btnToolLamMoi.Name = "btnToolLamMoi";
            this.btnToolLamMoi.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnToolLamMoi.Size = new System.Drawing.Size(89, 25);
            this.btnToolLamMoi.Text = "🔄 Làm Mới";
            this.btnToolLamMoi.Click += new System.EventHandler(this.MenuTaiLaiDuLieu_Click);

            // sepTool5
            this.sepTool5.Name = "sepTool5";
            this.sepTool5.Size = new System.Drawing.Size(6, 28);

            // btnToolDangXuat
            this.btnToolDangXuat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnToolDangXuat.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnToolDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnToolDangXuat.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.btnToolDangXuat.Name = "btnToolDangXuat";
            this.btnToolDangXuat.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnToolDangXuat.Size = new System.Drawing.Size(95, 25);
            this.btnToolDangXuat.Text = "🚪 Đăng Xuất";
            this.btnToolDangXuat.Click += new System.EventHandler(this.MenuDangXuat_Click);

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
            this.statusStripMain.TabIndex = 3;

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
            this.Controls.Add(this.toolStripMain);
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
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
