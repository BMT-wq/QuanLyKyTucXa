using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKyTucXa.Presentation
{
    partial class FrmMain
    {
        private IContainer components = null;
        private MenuStrip menuStripMain;
        private ToolStripMenuItem menuHeThong;
        private ToolStripMenuItem menuLuuDuLieu;
        private ToolStripSeparator toolStripSeparator1;
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
        private ToolStripMenuItem menuTroGiup;
        private ToolStripMenuItem menuThongTin;
        private StatusStrip statusStripMain;
        private ToolStripStatusLabel lblStatusUser;
        private ToolStripStatusLabel lblStatusTime;

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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLuuDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
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
            this.menuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.lblStatusUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.menuSV1,
            this.menuSV2,
            this.menuSV3,
            this.menuTroGiup});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1008, 25);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // menuHeThong
            // 
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLuuDuLieu,
            this.toolStripSeparator1,
            this.menuDangXuat,
            this.menuThoat});
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(75, 21);
            this.menuHeThong.Text = "&Hệ Thống";
            // 
            // menuLuuDuLieu
            // 
            this.menuLuuDuLieu.Name = "menuLuuDuLieu";
            this.menuLuuDuLieu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuLuuDuLieu.Size = new System.Drawing.Size(193, 22);
            this.menuLuuDuLieu.Text = "&Lưu Toàn Bộ";
            this.menuLuuDuLieu.Click += new System.EventHandler(this.MenuLuuDuLieu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(193, 22);
            this.menuDangXuat.Text = "Đăng &Xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.MenuDangXuat_Click);
            // 
            // menuThoat
            // 
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuThoat.Size = new System.Drawing.Size(193, 22);
            this.menuThoat.Text = "Th&oát";
            this.menuThoat.Click += new System.EventHandler(this.MenuThoat_Click);
            // 
            // menuSV1
            // 
            this.menuSV1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToaNha,
            this.menuPhong});
            this.menuSV1.Name = "menuSV1";
            this.menuSV1.Size = new System.Drawing.Size(147, 21);
            this.menuSV1.Text = "&1. Phòng && Tòa Nhà";
            // 
            // menuToaNha
            // 
            this.menuToaNha.Name = "menuToaNha";
            this.menuToaNha.Size = new System.Drawing.Size(182, 22);
            this.menuToaNha.Text = "Quản lý &Tòa Nhà";
            this.menuToaNha.Click += new System.EventHandler(this.MenuToaNha_Click);
            // 
            // menuPhong
            // 
            this.menuPhong.Name = "menuPhong";
            this.menuPhong.Size = new System.Drawing.Size(182, 22);
            this.menuPhong.Text = "Quản lý &Phòng";
            this.menuPhong.Click += new System.EventHandler(this.MenuPhong_Click);
            // 
            // menuSV2
            // 
            this.menuSV2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSinhVien,
            this.menuHopDong});
            this.menuSV2.Name = "menuSV2";
            this.menuSV2.Size = new System.Drawing.Size(161, 21);
            this.menuSV2.Text = "&2. Sinh Viên && Hợp Đồng";
            // 
            // menuSinhVien
            // 
            this.menuSinhVien.Name = "menuSinhVien";
            this.menuSinhVien.Size = new System.Drawing.Size(193, 22);
            this.menuSinhVien.Text = "Hồ sơ &Sinh Viên";
            this.menuSinhVien.Click += new System.EventHandler(this.MenuSinhVien_Click);
            // 
            // menuHopDong
            // 
            this.menuHopDong.Name = "menuHopDong";
            this.menuHopDong.Size = new System.Drawing.Size(193, 22);
            this.menuHopDong.Text = "Hợp đồng &Thuê phòng";
            this.menuHopDong.Click += new System.EventHandler(this.MenuHopDong_Click);
            // 
            // menuSV3
            // 
            this.menuSV3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDienNuoc,
            this.menuThuPhi});
            this.menuSV3.Name = "menuSV3";
            this.menuSV3.Size = new System.Drawing.Size(155, 21);
            this.menuSV3.Text = "&3. Điện Nước && Thu Phí";
            // 
            // menuDienNuoc
            // 
            this.menuDienNuoc.Name = "menuDienNuoc";
            this.menuDienNuoc.Size = new System.Drawing.Size(184, 22);
            this.menuDienNuoc.Text = "Quản lý &Điện Nước";
            this.menuDienNuoc.Click += new System.EventHandler(this.MenuDienNuoc_Click);
            // 
            // menuThuPhi
            // 
            this.menuThuPhi.Name = "menuThuPhi";
            this.menuThuPhi.Size = new System.Drawing.Size(184, 22);
            this.menuThuPhi.Text = "Quản lý &Thu Phí";
            this.menuThuPhi.Click += new System.EventHandler(this.MenuThuPhi_Click);
            // 
            // menuTroGiup
            // 
            this.menuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThongTin});
            this.menuTroGiup.Name = "menuTroGiup";
            this.menuTroGiup.Size = new System.Drawing.Size(71, 21);
            this.menuTroGiup.Text = "Trợ &Giúp";
            // 
            // menuThongTin
            // 
            this.menuThongTin.Name = "menuThongTin";
            this.menuThongTin.Size = new System.Drawing.Size(176, 22);
            this.menuThongTin.Text = "Thông &Tin Đồ Án";
            this.menuThongTin.Click += new System.EventHandler(this.MenuThongTin_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusUser,
            this.lblStatusTime});
            this.statusStripMain.Location = new System.Drawing.Point(0, 659);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1008, 22);
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // lblStatusUser
            // 
            this.lblStatusUser.Name = "lblStatusUser";
            this.lblStatusUser.Size = new System.Drawing.Size(107, 17);
            this.lblStatusUser.Text = "Người dùng: Admin";
            // 
            // lblStatusTime
            // 
            this.lblStatusTime.Name = "lblStatusTime";
            this.lblStatusTime.Size = new System.Drawing.Size(886, 17);
            this.lblStatusTime.Spring = true;
            this.lblStatusTime.Text = "Hệ thống Quản lý Ký túc xá";
            this.lblStatusTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ KÝ TÚC XÁ - C# WINFORMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
