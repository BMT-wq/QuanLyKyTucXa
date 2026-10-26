using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKyTucXa.Presentation.SV2_SinhVienHopDong
{
    partial class FrmSinhVien
    {
        private IContainer components = null;

        private Panel pnlHeader;
        private Label lblHeader;
        private Label lblSubtitle;

        private GroupBox grpThongTin;
        private Label lblMaSV;
        private TextBox txtMaSV;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private Label lblGioiTinh;
        private ComboBox cboGioiTinh;
        private Label lblCCCD;
        private TextBox txtCCCD;
        private Label lblDienThoai;
        private TextBox txtDienThoai;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblLop;
        private TextBox txtLop;
        private Label lblKhoa;
        private TextBox txtKhoa;
        private Label lblQueQuan;
        private TextBox txtQueQuan;

        private Panel pnlButtons;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;

        private GroupBox grpTimKiem;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Label lblLocKhoa;
        private ComboBox cboLocKhoa;
        private Label lblLocGioiTinh;
        private ComboBox cboLocGioiTinh;
        private Button btnHienThiTatCa;

        private GroupBox grpDanhSach;
        private DataGridView dgvSinhVien;
        private Label lblTongSo;

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
            System.Windows.Forms.DataGridViewCellStyle dgvStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();

            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();

            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();

            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblLocKhoa = new System.Windows.Forms.Label();
            this.cboLocKhoa = new System.Windows.Forms.ComboBox();
            this.lblLocGioiTinh = new System.Windows.Forms.Label();
            this.cboLocGioiTinh = new System.Windows.Forms.ComboBox();
            this.btnHienThiTatCa = new System.Windows.Forms.Button();

            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.lblTongSo = new System.Windows.Forms.Label();

            this.pnlHeader.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(235, 248, 235);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1080, 60);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1080, 32);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "PHÂN HỆ 2: QUẢN LÝ HỒ SƠ SINH VIÊN NỘI TRÚ";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSubtitle.Location = new System.Drawing.Point(0, 32);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(1080, 24);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Tiếp nhận hồ sơ sinh viên, tra cứu, cập nhật thông tin và kiểm tra ràng buộc hợp đồng";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblMaSV);
            this.grpThongTin.Controls.Add(this.txtMaSV);
            this.grpThongTin.Controls.Add(this.lblHoTen);
            this.grpThongTin.Controls.Add(this.txtHoTen);
            this.grpThongTin.Controls.Add(this.lblNgaySinh);
            this.grpThongTin.Controls.Add(this.dtpNgaySinh);
            this.grpThongTin.Controls.Add(this.lblGioiTinh);
            this.grpThongTin.Controls.Add(this.cboGioiTinh);
            this.grpThongTin.Controls.Add(this.lblCCCD);
            this.grpThongTin.Controls.Add(this.txtCCCD);
            this.grpThongTin.Controls.Add(this.lblDienThoai);
            this.grpThongTin.Controls.Add(this.txtDienThoai);
            this.grpThongTin.Controls.Add(this.lblEmail);
            this.grpThongTin.Controls.Add(this.txtEmail);
            this.grpThongTin.Controls.Add(this.lblLop);
            this.grpThongTin.Controls.Add(this.txtLop);
            this.grpThongTin.Controls.Add(this.lblKhoa);
            this.grpThongTin.Controls.Add(this.txtKhoa);
            this.grpThongTin.Controls.Add(this.lblQueQuan);
            this.grpThongTin.Controls.Add(this.txtQueQuan);
            this.grpThongTin.Controls.Add(this.pnlButtons);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpThongTin.Location = new System.Drawing.Point(12, 68);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(370, 560);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = " Thông tin chi tiết sinh viên ";

            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblMaSV.ForeColor = System.Drawing.Color.Black;
            this.lblMaSV.Location = new System.Drawing.Point(15, 28);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(43, 15);
            this.lblMaSV.Text = "Mã SV:";

            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaSV.Location = new System.Drawing.Point(110, 25);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(240, 23);
            this.txtMaSV.TabIndex = 0;

            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHoTen.ForeColor = System.Drawing.Color.Black;
            this.lblHoTen.Location = new System.Drawing.Point(15, 63);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(61, 15);
            this.lblHoTen.Text = "Họ và tên:";

            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoTen.Location = new System.Drawing.Point(110, 60);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(240, 23);
            this.txtHoTen.TabIndex = 1;

            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.lblNgaySinh.Location = new System.Drawing.Point(15, 98);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(63, 15);
            this.lblNgaySinh.Text = "Ngày sinh:";

            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(110, 95);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(240, 23);
            this.dtpNgaySinh.TabIndex = 2;

            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.lblGioiTinh.Location = new System.Drawing.Point(15, 133);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(55, 15);
            this.lblGioiTinh.Text = "Giới tính:";

            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cboGioiTinh.Location = new System.Drawing.Point(110, 130);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(240, 23);
            this.cboGioiTinh.TabIndex = 3;

            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCCCD.ForeColor = System.Drawing.Color.Black;
            this.lblCCCD.Location = new System.Drawing.Point(15, 168);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(74, 15);
            this.lblCCCD.Text = "CCCD/CMND:";

            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCCCD.Location = new System.Drawing.Point(110, 165);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(240, 23);
            this.txtCCCD.TabIndex = 4;

            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDienThoai.ForeColor = System.Drawing.Color.Black;
            this.lblDienThoai.Location = new System.Drawing.Point(15, 203);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(64, 15);
            this.lblDienThoai.Text = "Điện thoại:";

            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDienThoai.Location = new System.Drawing.Point(110, 200);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(240, 23);
            this.txtDienThoai.TabIndex = 5;

            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(15, 238);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.Text = "Email:";

            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(110, 235);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 23);
            this.txtEmail.TabIndex = 6;

            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLop.ForeColor = System.Drawing.Color.Black;
            this.lblLop.Location = new System.Drawing.Point(15, 273);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(30, 15);
            this.lblLop.Text = "Lớp:";

            // 
            // txtLop
            // 
            this.txtLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLop.Location = new System.Drawing.Point(110, 270);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(240, 23);
            this.txtLop.TabIndex = 7;

            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKhoa.ForeColor = System.Drawing.Color.Black;
            this.lblKhoa.Location = new System.Drawing.Point(15, 308);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(37, 15);
            this.lblKhoa.Text = "Khoa:";

            // 
            // txtKhoa
            // 
            this.txtKhoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKhoa.Location = new System.Drawing.Point(110, 305);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(240, 23);
            this.txtKhoa.TabIndex = 8;

            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQueQuan.ForeColor = System.Drawing.Color.Black;
            this.lblQueQuan.Location = new System.Drawing.Point(15, 343);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(62, 15);
            this.lblQueQuan.Text = "Quê quán:";

            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQueQuan.Location = new System.Drawing.Point(110, 340);
            this.txtQueQuan.Multiline = true;
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(240, 50);
            this.txtQueQuan.TabIndex = 9;

            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.btnLamMoi);
            this.pnlButtons.Location = new System.Drawing.Point(15, 410);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(335, 135);
            this.pnlButtons.TabIndex = 10;

            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(5, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(155, 45);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "➕ Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;

            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(30, 136, 229);
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(175, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(155, 45);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "✏️ Cập nhật";
            this.btnSua.UseVisualStyleBackColor = false;

            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(5, 70);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(155, 45);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "🗑️ Xóa bỏ";
            this.btnXoa.UseVisualStyleBackColor = false;

            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(90, 100, 110);
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(175, 70);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(155, 45);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "🔄 Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;

            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTimKiem.Controls.Add(this.lblTimKiem);
            this.grpTimKiem.Controls.Add(this.txtTimKiem);
            this.grpTimKiem.Controls.Add(this.lblLocKhoa);
            this.grpTimKiem.Controls.Add(this.cboLocKhoa);
            this.grpTimKiem.Controls.Add(this.lblLocGioiTinh);
            this.grpTimKiem.Controls.Add(this.cboLocGioiTinh);
            this.grpTimKiem.Controls.Add(this.btnHienThiTatCa);
            this.grpTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpTimKiem.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpTimKiem.Location = new System.Drawing.Point(395, 68);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(670, 70);
            this.grpTimKiem.TabIndex = 2;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = " Tra cứu & Bộ lọc ";

            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTimKiem.ForeColor = System.Drawing.Color.Black;
            this.lblTimKiem.Location = new System.Drawing.Point(15, 30);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(56, 15);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm kiếm:";

            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Location = new System.Drawing.Point(75, 27);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(160, 23);
            this.txtTimKiem.TabIndex = 1;

            // 
            // lblLocKhoa
            // 
            this.lblLocKhoa.AutoSize = true;
            this.lblLocKhoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLocKhoa.ForeColor = System.Drawing.Color.Black;
            this.lblLocKhoa.Location = new System.Drawing.Point(245, 30);
            this.lblLocKhoa.Name = "lblLocKhoa";
            this.lblLocKhoa.Size = new System.Drawing.Size(37, 15);
            this.lblLocKhoa.TabIndex = 2;
            this.lblLocKhoa.Text = "Khoa:";

            // 
            // cboLocKhoa
            // 
            this.cboLocKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocKhoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLocKhoa.FormattingEnabled = true;
            this.cboLocKhoa.Location = new System.Drawing.Point(285, 27);
            this.cboLocKhoa.Name = "cboLocKhoa";
            this.cboLocKhoa.Size = new System.Drawing.Size(130, 23);
            this.cboLocKhoa.TabIndex = 3;

            // 
            // lblLocGioiTinh
            // 
            this.lblLocGioiTinh.AutoSize = true;
            this.lblLocGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLocGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.lblLocGioiTinh.Location = new System.Drawing.Point(425, 30);
            this.lblLocGioiTinh.Name = "lblLocGioiTinh";
            this.lblLocGioiTinh.Size = new System.Drawing.Size(55, 15);
            this.lblLocGioiTinh.TabIndex = 4;
            this.lblLocGioiTinh.Text = "Giới tính:";

            // 
            // cboLocGioiTinh
            // 
            this.cboLocGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLocGioiTinh.FormattingEnabled = true;
            this.cboLocGioiTinh.Items.AddRange(new object[] { "Tất cả", "Nam", "Nữ" });
            this.cboLocGioiTinh.Location = new System.Drawing.Point(485, 27);
            this.cboLocGioiTinh.Name = "cboLocGioiTinh";
            this.cboLocGioiTinh.Size = new System.Drawing.Size(75, 23);
            this.cboLocGioiTinh.TabIndex = 5;

            // 
            // btnHienThiTatCa
            // 
            this.btnHienThiTatCa.BackColor = System.Drawing.Color.FromArgb(240, 244, 248);
            this.btnHienThiTatCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHienThiTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThiTatCa.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnHienThiTatCa.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnHienThiTatCa.Location = new System.Drawing.Point(570, 25);
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.Size = new System.Drawing.Size(90, 27);
            this.btnHienThiTatCa.TabIndex = 6;
            this.btnHienThiTatCa.Text = "Hiện tất cả";
            this.btnHienThiTatCa.UseVisualStyleBackColor = false;

            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDanhSach.Controls.Add(this.dgvSinhVien);
            this.grpDanhSach.Controls.Add(this.lblTongSo);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpDanhSach.Location = new System.Drawing.Point(395, 145);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(670, 483);
            this.grpDanhSach.TabIndex = 3;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = " Danh sách hồ sơ sinh viên ";

            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.AllowUserToResizeRows = false;
            dgvStyle.BackColor = System.Drawing.Color.FromArgb(248, 253, 248);
            this.dgvSinhVien.AlternatingRowsDefaultCellStyle = dgvStyle;
            this.dgvSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSinhVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dgvHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(235, 245, 235);
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor = System.Drawing.Color.DarkGreen;
            dgvHeaderStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dgvHeaderStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dgvHeaderStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSinhVien.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvSinhVien.ColumnHeadersHeight = 32;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSinhVien.EnableHeadersVisualStyles = false;
            this.dgvSinhVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvSinhVien.GridColor = System.Drawing.Color.FromArgb(220, 235, 220);
            this.dgvSinhVien.Location = new System.Drawing.Point(10, 25);
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersVisible = false;
            this.dgvSinhVien.RowTemplate.Height = 26;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(650, 425);
            this.dgvSinhVien.TabIndex = 0;

            // 
            // lblTongSo
            // 
            this.lblTongSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblTongSo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTongSo.Location = new System.Drawing.Point(10, 458);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(126, 15);
            this.lblTongSo.TabIndex = 1;
            this.lblTongSo.Text = "Tổng số: 0 sinh viên";

            // 
            // FrmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "FrmSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý Hồ sơ Sinh viên Nội trú";
            this.Load += new System.EventHandler(this.FrmSinhVien_Load);

            this.pnlHeader.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.grpDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
