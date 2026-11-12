using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKyTucXa.Presentation.SV3_DienNuocThuPhi
{
    partial class FrmQuyetToanTraPhong
    {
        private IContainer components = null;
        private Panel pnlHeader;
        private Label lblHeaderTitle;
        private Label lblHeaderSub;
        private GroupBox grpHopDong;
        private Label lblChonHD;
        private ComboBox cboHopDong;
        private Label lblMaPhong;
        private TextBox txtMaPhong;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblTienCoc;
        private TextBox txtTienCoc;
        private Label lblNgayBatDau;
        private TextBox txtNgayBatDau;
        private Label lblNgayKetThuc;
        private TextBox txtNgayKetThuc;
        private Label lblCanhBaoTraTruoc;
        private GroupBox grpDienNuoc;
        private Label lblNgayTraPhong;
        private DateTimePicker dtpNgayTraPhong;
        private Label lblDienCu;
        private TextBox txtDienCu;
        private Label lblDienTra;
        private TextBox txtDienTra;
        private Label lblNuocCu;
        private TextBox txtNuocCu;
        private Label lblNuocTra;
        private TextBox txtNuocTra;
        private Label lblTienDienNuocSV;
        private TextBox txtTienDienNuocSV;
        private Label lblTienPhongNo;
        private TextBox txtTienPhongNo;
        private Label lblPhiPhat;
        private TextBox txtPhiPhat;
        private Label lblLyDoPhat;
        private TextBox txtLyDoPhat;
        private GroupBox grpKetQua;
        private Label lblTienCocThucNhan;
        private TextBox txtTienCocThucNhan;
        private Label lblGiaiThich;
        private Button btnTinhToan;
        private Button btnXacNhan;
        private Button btnDong;

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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.grpHopDong = new System.Windows.Forms.GroupBox();
            this.lblChonHD = new System.Windows.Forms.Label();
            this.cboHopDong = new System.Windows.Forms.ComboBox();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblTienCoc = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.txtNgayBatDau = new System.Windows.Forms.TextBox();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.txtNgayKetThuc = new System.Windows.Forms.TextBox();
            this.lblCanhBaoTraTruoc = new System.Windows.Forms.Label();
            this.grpDienNuoc = new System.Windows.Forms.GroupBox();
            this.lblNgayTraPhong = new System.Windows.Forms.Label();
            this.dtpNgayTraPhong = new System.Windows.Forms.DateTimePicker();
            this.lblDienCu = new System.Windows.Forms.Label();
            this.txtDienCu = new System.Windows.Forms.TextBox();
            this.lblDienTra = new System.Windows.Forms.Label();
            this.txtDienTra = new System.Windows.Forms.TextBox();
            this.lblNuocCu = new System.Windows.Forms.Label();
            this.txtNuocCu = new System.Windows.Forms.TextBox();
            this.lblNuocTra = new System.Windows.Forms.Label();
            this.txtNuocTra = new System.Windows.Forms.TextBox();
            this.lblTienDienNuocSV = new System.Windows.Forms.Label();
            this.txtTienDienNuocSV = new System.Windows.Forms.TextBox();
            this.lblTienPhongNo = new System.Windows.Forms.Label();
            this.txtTienPhongNo = new System.Windows.Forms.TextBox();
            this.lblPhiPhat = new System.Windows.Forms.Label();
            this.txtPhiPhat = new System.Windows.Forms.TextBox();
            this.lblLyDoPhat = new System.Windows.Forms.Label();
            this.txtLyDoPhat = new System.Windows.Forms.TextBox();
            this.grpKetQua = new System.Windows.Forms.GroupBox();
            this.lblTienCocThucNhan = new System.Windows.Forms.Label();
            this.txtTienCocThucNhan = new System.Windows.Forms.TextBox();
            this.lblGiaiThich = new System.Windows.Forms.Label();
            this.btnTinhToan = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.grpHopDong.SuspendLayout();
            this.grpDienNuoc.SuspendLayout();
            this.grpKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(205)))));
            this.pnlHeader.Controls.Add(this.lblHeaderSub);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(860, 75);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(0, 45);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(860, 30);
            this.lblHeaderSub.TabIndex = 1;
            this.lblHeaderSub.Text = "Nghiệp vụ: Chốt đồng hồ điện nước, tính tiền trả phòng trước hạn, quyết toán cọc & kết thúc hợp đồng.";
            this.lblHeaderSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(860, 45);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "QUYẾT TOÁN TRẢ PHÒNG & TRẢ CỌC KÝ TÚC XÁ";
            this.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpHopDong
            // 
            this.grpHopDong.Controls.Add(this.lblChonHD);
            this.grpHopDong.Controls.Add(this.cboHopDong);
            this.grpHopDong.Controls.Add(this.lblMaPhong);
            this.grpHopDong.Controls.Add(this.txtMaPhong);
            this.grpHopDong.Controls.Add(this.lblHoTen);
            this.grpHopDong.Controls.Add(this.txtHoTen);
            this.grpHopDong.Controls.Add(this.lblTienCoc);
            this.grpHopDong.Controls.Add(this.txtTienCoc);
            this.grpHopDong.Controls.Add(this.lblNgayBatDau);
            this.grpHopDong.Controls.Add(this.txtNgayBatDau);
            this.grpHopDong.Controls.Add(this.lblNgayKetThuc);
            this.grpHopDong.Controls.Add(this.txtNgayKetThuc);
            this.grpHopDong.Controls.Add(this.lblCanhBaoTraTruoc);
            this.grpHopDong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpHopDong.Location = new System.Drawing.Point(15, 85);
            this.grpHopDong.Name = "grpHopDong";
            this.grpHopDong.Size = new System.Drawing.Size(830, 150);
            this.grpHopDong.TabIndex = 1;
            this.grpHopDong.TabStop = false;
            this.grpHopDong.Text = "1. Thông tin sinh viên & Hợp đồng thuê phòng";
            // 
            // lblChonHD
            // 
            this.lblChonHD.AutoSize = true;
            this.lblChonHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblChonHD.Location = new System.Drawing.Point(15, 30);
            this.lblChonHD.Name = "lblChonHD";
            this.lblChonHD.Size = new System.Drawing.Size(95, 20);
            this.lblChonHD.TabIndex = 0;
            this.lblChonHD.Text = "Chọn HĐ (SV):";
            // 
            // cboHopDong
            // 
            this.cboHopDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHopDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboHopDong.FormattingEnabled = true;
            this.cboHopDong.Location = new System.Drawing.Point(120, 26);
            this.cboHopDong.Name = "cboHopDong";
            this.cboHopDong.Size = new System.Drawing.Size(380, 28);
            this.cboHopDong.TabIndex = 1;
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaPhong.Location = new System.Drawing.Point(520, 30);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(80, 20);
            this.lblMaPhong.TabIndex = 2;
            this.lblMaPhong.Text = "Mã phòng:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtMaPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtMaPhong.Location = new System.Drawing.Point(605, 26);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.ReadOnly = true;
            this.txtMaPhong.Size = new System.Drawing.Size(205, 27);
            this.txtMaPhong.TabIndex = 3;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHoTen.Location = new System.Drawing.Point(15, 70);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(76, 20);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Họ tên SV:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoTen.Location = new System.Drawing.Point(120, 66);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(200, 27);
            this.txtHoTen.TabIndex = 5;
            // 
            // lblTienCoc
            // 
            this.lblTienCoc.AutoSize = true;
            this.lblTienCoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTienCoc.Location = new System.Drawing.Point(335, 70);
            this.lblTienCoc.Name = "lblTienCoc";
            this.lblTienCoc.Size = new System.Drawing.Size(95, 20);
            this.lblTienCoc.TabIndex = 6;
            this.lblTienCoc.Text = "Tiền cọc gốc:";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtTienCoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtTienCoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtTienCoc.Location = new System.Drawing.Point(435, 66);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.ReadOnly = true;
            this.txtTienCoc.Size = new System.Drawing.Size(150, 27);
            this.txtTienCoc.TabIndex = 7;
            this.txtTienCoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayBatDau.Location = new System.Drawing.Point(600, 70);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(64, 20);
            this.lblNgayBatDau.TabIndex = 8;
            this.lblNgayBatDau.Text = "Bắt đầu:";
            // 
            // txtNgayBatDau
            // 
            this.txtNgayBatDau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNgayBatDau.Location = new System.Drawing.Point(670, 66);
            this.txtNgayBatDau.Name = "txtNgayBatDau";
            this.txtNgayBatDau.ReadOnly = true;
            this.txtNgayBatDau.Size = new System.Drawing.Size(140, 27);
            this.txtNgayBatDau.TabIndex = 9;
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayKetThuc.Location = new System.Drawing.Point(15, 110);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(89, 20);
            this.lblNgayKetThuc.TabIndex = 10;
            this.lblNgayKetThuc.Text = "Hạn hợp đồng:";
            // 
            // txtNgayKetThuc
            // 
            this.txtNgayKetThuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNgayKetThuc.Location = new System.Drawing.Point(120, 106);
            this.txtNgayKetThuc.Name = "txtNgayKetThuc";
            this.txtNgayKetThuc.ReadOnly = true;
            this.txtNgayKetThuc.Size = new System.Drawing.Size(200, 27);
            this.txtNgayKetThuc.TabIndex = 11;
            // 
            // lblCanhBaoTraTruoc
            // 
            this.lblCanhBaoTraTruoc.AutoSize = true;
            this.lblCanhBaoTraTruoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCanhBaoTraTruoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.lblCanhBaoTraTruoc.Location = new System.Drawing.Point(335, 110);
            this.lblCanhBaoTraTruoc.Name = "lblCanhBaoTraTruoc";
            this.lblCanhBaoTraTruoc.Size = new System.Drawing.Size(262, 20);
            this.lblCanhBaoTraTruoc.TabIndex = 12;
            this.lblCanhBaoTraTruoc.Text = "⚠️ Phát hiện: Trả phòng trước hạn!";
            this.lblCanhBaoTraTruoc.Visible = false;
            // 
            // grpDienNuoc
            // 
            this.grpDienNuoc.Controls.Add(this.lblNgayTraPhong);
            this.grpDienNuoc.Controls.Add(this.dtpNgayTraPhong);
            this.grpDienNuoc.Controls.Add(this.lblDienCu);
            this.grpDienNuoc.Controls.Add(this.txtDienCu);
            this.grpDienNuoc.Controls.Add(this.lblDienTra);
            this.grpDienNuoc.Controls.Add(this.txtDienTra);
            this.grpDienNuoc.Controls.Add(this.lblNuocCu);
            this.grpDienNuoc.Controls.Add(this.txtNuocCu);
            this.grpDienNuoc.Controls.Add(this.lblNuocTra);
            this.grpDienNuoc.Controls.Add(this.txtNuocTra);
            this.grpDienNuoc.Controls.Add(this.lblTienDienNuocSV);
            this.grpDienNuoc.Controls.Add(this.txtTienDienNuocSV);
            this.grpDienNuoc.Controls.Add(this.lblTienPhongNo);
            this.grpDienNuoc.Controls.Add(this.txtTienPhongNo);
            this.grpDienNuoc.Controls.Add(this.lblPhiPhat);
            this.grpDienNuoc.Controls.Add(this.txtPhiPhat);
            this.grpDienNuoc.Controls.Add(this.lblLyDoPhat);
            this.grpDienNuoc.Controls.Add(this.txtLyDoPhat);
            this.grpDienNuoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpDienNuoc.Location = new System.Drawing.Point(15, 245);
            this.grpDienNuoc.Name = "grpDienNuoc";
            this.grpDienNuoc.Size = new System.Drawing.Size(830, 195);
            this.grpDienNuoc.TabIndex = 2;
            this.grpDienNuoc.TabStop = false;
            this.grpDienNuoc.Text = "2. Chốt chỉ số đồng hồ điện nước & Khấu trừ nợ khi trả phòng";
            // 
            // lblNgayTraPhong
            // 
            this.lblNgayTraPhong.AutoSize = true;
            this.lblNgayTraPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayTraPhong.Location = new System.Drawing.Point(15, 30);
            this.lblNgayTraPhong.Name = "lblNgayTraPhong";
            this.lblNgayTraPhong.Size = new System.Drawing.Size(107, 20);
            this.lblNgayTraPhong.TabIndex = 0;
            this.lblNgayTraPhong.Text = "Ngày trả phòng:";
            // 
            // dtpNgayTraPhong
            // 
            this.dtpNgayTraPhong.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTraPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTraPhong.Location = new System.Drawing.Point(135, 26);
            this.dtpNgayTraPhong.Name = "dtpNgayTraPhong";
            this.dtpNgayTraPhong.Size = new System.Drawing.Size(150, 27);
            this.dtpNgayTraPhong.TabIndex = 1;
            // 
            // lblDienCu
            // 
            this.lblDienCu.AutoSize = true;
            this.lblDienCu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDienCu.Location = new System.Drawing.Point(310, 30);
            this.lblDienCu.Name = "lblDienCu";
            this.lblDienCu.Size = new System.Drawing.Size(62, 20);
            this.lblDienCu.TabIndex = 2;
            this.lblDienCu.Text = "Điện cũ:";
            // 
            // txtDienCu
            // 
            this.txtDienCu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtDienCu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDienCu.Location = new System.Drawing.Point(380, 26);
            this.txtDienCu.Name = "txtDienCu";
            this.txtDienCu.ReadOnly = true;
            this.txtDienCu.Size = new System.Drawing.Size(80, 27);
            this.txtDienCu.TabIndex = 3;
            this.txtDienCu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDienTra
            // 
            this.lblDienTra.AutoSize = true;
            this.lblDienTra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDienTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.lblDienTra.Location = new System.Drawing.Point(475, 30);
            this.lblDienTra.Name = "lblDienTra";
            this.lblDienTra.Size = new System.Drawing.Size(81, 20);
            this.lblDienTra.TabIndex = 4;
            this.lblDienTra.Text = "Điện chốt:";
            // 
            // txtDienTra
            // 
            this.txtDienTra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtDienTra.Location = new System.Drawing.Point(565, 26);
            this.txtDienTra.Name = "txtDienTra";
            this.txtDienTra.Size = new System.Drawing.Size(90, 27);
            this.txtDienTra.TabIndex = 5;
            this.txtDienTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNuocCu
            // 
            this.lblNuocCu.AutoSize = true;
            this.lblNuocCu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNuocCu.Location = new System.Drawing.Point(665, 30);
            this.lblNuocCu.Name = "lblNuocCu";
            this.lblNuocCu.Size = new System.Drawing.Size(67, 20);
            this.lblNuocCu.TabIndex = 6;
            this.lblNuocCu.Text = "Nước cũ:";
            // 
            // txtNuocCu
            // 
            this.txtNuocCu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtNuocCu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNuocCu.Location = new System.Drawing.Point(740, 26);
            this.txtNuocCu.Name = "txtNuocCu";
            this.txtNuocCu.ReadOnly = true;
            this.txtNuocCu.Size = new System.Drawing.Size(70, 27);
            this.txtNuocCu.TabIndex = 7;
            this.txtNuocCu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNuocTra
            // 
            this.lblNuocTra.AutoSize = true;
            this.lblNuocTra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNuocTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.lblNuocTra.Location = new System.Drawing.Point(15, 70);
            this.lblNuocTra.Name = "lblNuocTra";
            this.lblNuocTra.Size = new System.Drawing.Size(86, 20);
            this.lblNuocTra.TabIndex = 8;
            this.lblNuocTra.Text = "Nước chốt:";
            // 
            // txtNuocTra
            // 
            this.txtNuocTra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtNuocTra.Location = new System.Drawing.Point(135, 66);
            this.txtNuocTra.Name = "txtNuocTra";
            this.txtNuocTra.Size = new System.Drawing.Size(150, 27);
            this.txtNuocTra.TabIndex = 9;
            this.txtNuocTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTienDienNuocSV
            // 
            this.lblTienDienNuocSV.AutoSize = true;
            this.lblTienDienNuocSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTienDienNuocSV.Location = new System.Drawing.Point(310, 70);
            this.lblTienDienNuocSV.Name = "lblTienDienNuocSV";
            this.lblTienDienNuocSV.Size = new System.Drawing.Size(130, 20);
            this.lblTienDienNuocSV.TabIndex = 10;
            this.lblTienDienNuocSV.Text = "Tiền ĐN của SV trả:";
            // 
            // txtTienDienNuocSV
            // 
            this.txtTienDienNuocSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(205)))));
            this.txtTienDienNuocSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtTienDienNuocSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.txtTienDienNuocSV.Location = new System.Drawing.Point(445, 66);
            this.txtTienDienNuocSV.Name = "txtTienDienNuocSV";
            this.txtTienDienNuocSV.ReadOnly = true;
            this.txtTienDienNuocSV.Size = new System.Drawing.Size(210, 27);
            this.txtTienDienNuocSV.TabIndex = 11;
            this.txtTienDienNuocSV.Text = "0";
            this.txtTienDienNuocSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTienPhongNo
            // 
            this.lblTienPhongNo.AutoSize = true;
            this.lblTienPhongNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTienPhongNo.Location = new System.Drawing.Point(15, 110);
            this.lblTienPhongNo.Name = "lblTienPhongNo";
            this.lblTienPhongNo.Size = new System.Drawing.Size(107, 20);
            this.lblTienPhongNo.TabIndex = 12;
            this.lblTienPhongNo.Text = "Tiền phòng nợ:";
            // 
            // txtTienPhongNo
            // 
            this.txtTienPhongNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTienPhongNo.Location = new System.Drawing.Point(135, 106);
            this.txtTienPhongNo.Name = "txtTienPhongNo";
            this.txtTienPhongNo.Size = new System.Drawing.Size(150, 27);
            this.txtTienPhongNo.TabIndex = 13;
            this.txtTienPhongNo.Text = "0";
            this.txtTienPhongNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPhiPhat
            // 
            this.lblPhiPhat.AutoSize = true;
            this.lblPhiPhat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhiPhat.Location = new System.Drawing.Point(310, 110);
            this.lblPhiPhat.Name = "lblPhiPhat";
            this.lblPhiPhat.Size = new System.Drawing.Size(95, 20);
            this.lblPhiPhat.TabIndex = 14;
            this.lblPhiPhat.Text = "Phí phạt/khác:";
            // 
            // txtPhiPhat
            // 
            this.txtPhiPhat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhiPhat.Location = new System.Drawing.Point(445, 106);
            this.txtPhiPhat.Name = "txtPhiPhat";
            this.txtPhiPhat.Size = new System.Drawing.Size(210, 27);
            this.txtPhiPhat.TabIndex = 15;
            this.txtPhiPhat.Text = "0";
            this.txtPhiPhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLyDoPhat
            // 
            this.lblLyDoPhat.AutoSize = true;
            this.lblLyDoPhat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLyDoPhat.Location = new System.Drawing.Point(15, 150);
            this.lblLyDoPhat.Name = "lblLyDoPhat";
            this.lblLyDoPhat.Size = new System.Drawing.Size(117, 20);
            this.lblLyDoPhat.TabIndex = 16;
            this.lblLyDoPhat.Text = "Lý do khấu trừ:";
            // 
            // txtLyDoPhat
            // 
            this.txtLyDoPhat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLyDoPhat.Location = new System.Drawing.Point(135, 146);
            this.txtLyDoPhat.Name = "txtLyDoPhat";
            this.txtLyDoPhat.Size = new System.Drawing.Size(675, 27);
            this.txtLyDoPhat.TabIndex = 17;
            this.txtLyDoPhat.Text = "Không có vi phạm";
            // 
            // grpKetQua
            // 
            this.grpKetQua.Controls.Add(this.lblTienCocThucNhan);
            this.grpKetQua.Controls.Add(this.txtTienCocThucNhan);
            this.grpKetQua.Controls.Add(this.lblGiaiThich);
            this.grpKetQua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpKetQua.Location = new System.Drawing.Point(15, 450);
            this.grpKetQua.Name = "grpKetQua";
            this.grpKetQua.Size = new System.Drawing.Size(830, 95);
            this.grpKetQua.TabIndex = 3;
            this.grpKetQua.TabStop = false;
            this.grpKetQua.Text = "3. Kết quả quyết toán tiền đặt cọc hoàn trả";
            // 
            // lblTienCocThucNhan
            // 
            this.lblTienCocThucNhan.AutoSize = true;
            this.lblTienCocThucNhan.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTienCocThucNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblTienCocThucNhan.Location = new System.Drawing.Point(15, 30);
            this.lblTienCocThucNhan.Name = "lblTienCocThucNhan";
            this.lblTienCocThucNhan.Size = new System.Drawing.Size(225, 25);
            this.lblTienCocThucNhan.TabIndex = 0;
            this.lblTienCocThucNhan.Text = "TIỀN CỌC THỰC TRẢ LẠI:";
            // 
            // txtTienCocThucNhan
            // 
            this.txtTienCocThucNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(237)))), ((int)(((byte)(218)))));
            this.txtTienCocThucNhan.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.txtTienCocThucNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(87)))), ((int)(((byte)(36)))));
            this.txtTienCocThucNhan.Location = new System.Drawing.Point(250, 25);
            this.txtTienCocThucNhan.Name = "txtTienCocThucNhan";
            this.txtTienCocThucNhan.ReadOnly = true;
            this.txtTienCocThucNhan.Size = new System.Drawing.Size(300, 36);
            this.txtTienCocThucNhan.TabIndex = 1;
            this.txtTienCocThucNhan.Text = "0 VNĐ";
            this.txtTienCocThucNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGiaiThich
            // 
            this.lblGiaiThich.AutoSize = true;
            this.lblGiaiThich.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblGiaiThich.ForeColor = System.Drawing.Color.DimGray;
            this.lblGiaiThich.Location = new System.Drawing.Point(250, 68);
            this.lblGiaiThich.Name = "lblGiaiThich";
            this.lblGiaiThich.Size = new System.Drawing.Size(434, 20);
            this.lblGiaiThich.TabIndex = 2;
            this.lblGiaiThich.Text = "(Công thức: Tiền cọc gốc - Tiền điện nước SV - Tiền phòng nợ - Phí phạt)";
            // 
            // btnTinhToan
            // 
            this.btnTinhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnTinhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhToan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTinhToan.ForeColor = System.Drawing.Color.White;
            this.btnTinhToan.Location = new System.Drawing.Point(145, 555);
            this.btnTinhToan.Name = "btnTinhToan";
            this.btnTinhToan.Size = new System.Drawing.Size(160, 42);
            this.btnTinhToan.TabIndex = 4;
            this.btnTinhToan.Text = "Tính toán trước";
            this.btnTinhToan.UseVisualStyleBackColor = false;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(320, 555);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(260, 42);
            this.btnXacNhan.TabIndex = 5;
            this.btnXacNhan.Text = "Xác nhận trả phòng & Trả cọc";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(595, 555);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 42);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // FrmQuyetToanTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 615);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnTinhToan);
            this.Controls.Add(this.grpKetQua);
            this.Controls.Add(this.grpDienNuoc);
            this.Controls.Add(this.grpHopDong);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQuyetToanTraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quyết toán trả phòng & Trả cọc";
            this.pnlHeader.ResumeLayout(false);
            this.grpHopDong.ResumeLayout(false);
            this.grpHopDong.PerformLayout();
            this.grpDienNuoc.ResumeLayout(false);
            this.grpDienNuoc.PerformLayout();
            this.grpKetQua.ResumeLayout(false);
            this.grpKetQua.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
