using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKyTucXa.Presentation.SV3_DienNuocThuPhi
{
    partial class FrmThuPhi
    {
        private IContainer components = null;
        private Label lblHeaderTitle;
        private Label lblHeaderSub;
        private Panel pnlHeader;
        private GroupBox grpInfo;
        private Label lblMaPhong;
        private TextBox txtMaPhong;
        private ComboBox cboPhong;
        private Label lblLoaiPhi;
        private ComboBox cboLoaiPhi;
        private Label lblSoTien;
        private TextBox txtSoTien;
        private Label lblNgayThu;
        private DateTimePicker dtpNgayThu;
        private Label lblGhiChu;
        private TextBox txtGhiChu;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnThongKe;
        private Button btnTraPhong;
        private Button btnThuPhiHDMoi;
        private Label lblTimPhong;
        private TextBox txtTimPhong;
        private Button btnHienThiTatCa;
        private DataGridView dgvThuPhi;

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
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblLoaiPhi = new System.Windows.Forms.Label();
            this.cboLoaiPhi = new System.Windows.Forms.ComboBox();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.lblNgayThu = new System.Windows.Forms.Label();
            this.dtpNgayThu = new System.Windows.Forms.DateTimePicker();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnThuPhiHDMoi = new System.Windows.Forms.Button();
            this.lblTimPhong = new System.Windows.Forms.Label();
            this.txtTimPhong = new System.Windows.Forms.TextBox();
            this.btnHienThiTatCa = new System.Windows.Forms.Button();
            this.dgvThuPhi = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(205)))));
            this.pnlHeader.Controls.Add(this.lblHeaderSub);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);

            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);

            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1184, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(0, 40);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(1184, 25);
            this.lblHeaderSub.TabIndex = 1;

            this.lblHeaderSub.Text = "Nghiệp vụ SV3: Lập phiếu thu (phòng, điện nước, cọc), quyết toán trả phòng & cọc, thống kê tài chính.";


            this.lblHeaderSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(1184, 38);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "QUẢN LÝ THU PHÍ KÝ TÚC XÁ";
            this.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpInfo
            // 
            this.grpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfo.Controls.Add(this.lblMaPhong);
            this.grpInfo.Controls.Add(this.cboPhong);
            this.grpInfo.Controls.Add(this.txtMaPhong);
            this.grpInfo.Controls.Add(this.lblLoaiPhi);
            this.grpInfo.Controls.Add(this.cboLoaiPhi);
            this.grpInfo.Controls.Add(this.lblSoTien);
            this.grpInfo.Controls.Add(this.txtSoTien);
            this.grpInfo.Controls.Add(this.lblNgayThu);
            this.grpInfo.Controls.Add(this.dtpNgayThu);
            this.grpInfo.Controls.Add(this.lblGhiChu);
            this.grpInfo.Controls.Add(this.txtGhiChu);
            this.grpInfo.Controls.Add(this.btnThem);
            this.grpInfo.Controls.Add(this.btnSua);
            this.grpInfo.Controls.Add(this.btnXoa);
            this.grpInfo.Controls.Add(this.btnLamMoi);
            this.grpInfo.Controls.Add(this.btnThongKe);
            this.grpInfo.Controls.Add(this.btnTraPhong);
            this.grpInfo.Controls.Add(this.btnThuPhiHDMoi);
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.grpInfo.Location = new System.Drawing.Point(16, 92);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpInfo.Size = new System.Drawing.Size(1547, 215);

            this.grpInfo.Location = new System.Drawing.Point(12, 75);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(1160, 175);

            this.grpInfo.TabIndex = 1;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông tin phiếu thu";
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMaPhong.Location = new System.Drawing.Point(20, 32);
            this.lblMaPhong.Name = "lblMaPhong";

            this.lblMaPhong.Size = new System.Drawing.Size(99, 21);

            this.lblMaPhong.Size = new System.Drawing.Size(72, 17);

            this.lblMaPhong.TabIndex = 0;
            this.lblMaPhong.Text = "Chọn phòng:";
            // 
            // cboPhong
            // 
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(147, 36);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(250, 29);
            this.cboPhong.TabIndex = 1;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            this.txtMaPhong.Location = new System.Drawing.Point(147, 36);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(0, 29);
            this.txtMaPhong.TabIndex = 0;
            this.txtMaPhong.Visible = false;
            this.txtMaPhong.Location = new System.Drawing.Point(110, 29);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(200, 24);
            this.txtMaPhong.TabIndex = 1;
            // 
            // lblLoaiPhi
            // 
            this.lblLoaiPhi.AutoSize = true;
            this.lblLoaiPhi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLoaiPhi.Location = new System.Drawing.Point(427, 39);
            this.lblLoaiPhi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiPhi.Location = new System.Drawing.Point(20, 72);
            this.lblLoaiPhi.Name = "lblLoaiPhi";
            this.lblLoaiPhi.Size = new System.Drawing.Size(57, 17);
            this.lblLoaiPhi.TabIndex = 2;
            this.lblLoaiPhi.Text = "Loại phí:";
            // 
            // cboLoaiPhi
            // 
            this.cboLoaiPhi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiPhi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboLoaiPhi.FormattingEnabled = true;
            this.cboLoaiPhi.Location = new System.Drawing.Point(533, 36);
            this.cboLoaiPhi.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoaiPhi.Name = "cboLoaiPhi";
            this.cboLoaiPhi.Size = new System.Drawing.Size(239, 29);
            this.cboLoaiPhi.Items.AddRange(new object[] {
            "Tiền phòng",
            "Tiền điện nước",
            "Phí dịch vụ khác"});
            this.cboLoaiPhi.Location = new System.Drawing.Point(110, 69);
            this.cboLoaiPhi.Name = "cboLoaiPhi";
            this.cboLoaiPhi.Size = new System.Drawing.Size(200, 25);
            this.cboLoaiPhi.TabIndex = 3;
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            this.lblSoTien.Location = new System.Drawing.Point(827, 39);
            this.lblSoTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);

            this.lblSoTien.Location = new System.Drawing.Point(340, 32);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(51, 17);
            this.lblSoTien.TabIndex = 4;
            this.lblSoTien.Text = "Số tiền:";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSoTien.Location = new System.Drawing.Point(933, 36);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(239, 29);
            this.txtSoTien.Location = new System.Drawing.Point(420, 29);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(200, 24);
            this.txtSoTien.TabIndex = 5;
            // 
            // lblNgayThu
            // 
            this.lblNgayThu.AutoSize = true;
            this.lblNgayThu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNgayThu.Location = new System.Drawing.Point(27, 89);
            this.lblNgayThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayThu.Name = "lblNgayThu";
            this.lblNgayThu.Size = new System.Drawing.Size(76, 21);

            this.lblNgayThu.Location = new System.Drawing.Point(340, 72);
            this.lblNgayThu.Name = "lblNgayThu";
            this.lblNgayThu.Size = new System.Drawing.Size(64, 17);

            this.lblNgayThu.TabIndex = 6;
            this.lblNgayThu.Text = "Ngày thu:";
            // 
            // dtpNgayThu
            // 
            this.dtpNgayThu.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayThu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;

            this.dtpNgayThu.Location = new System.Drawing.Point(147, 85);
            this.dtpNgayThu.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayThu.Name = "dtpNgayThu";
            this.dtpNgayThu.Size = new System.Drawing.Size(250, 29);

            this.dtpNgayThu.Location = new System.Drawing.Point(420, 69);
            this.dtpNgayThu.Name = "dtpNgayThu";
            this.dtpNgayThu.Size = new System.Drawing.Size(200, 24);

            this.dtpNgayThu.TabIndex = 7;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            this.lblGhiChu.Location = new System.Drawing.Point(427, 89);
            this.lblGhiChu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);

            this.lblGhiChu.Location = new System.Drawing.Point(650, 32);

            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(54, 17);
            this.lblGhiChu.TabIndex = 8;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            this.txtGhiChu.Location = new System.Drawing.Point(533, 85);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(639, 29);

            this.txtGhiChu.Location = new System.Drawing.Point(730, 29);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(250, 65);

            this.txtGhiChu.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;

            this.btnThem.Location = new System.Drawing.Point(147, 142);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 43);

            this.btnThem.Location = new System.Drawing.Point(110, 115);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Lập phiếu";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(280, 142);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 43);

            this.btnSua.Location = new System.Drawing.Point(220, 115);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 35);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;

            this.btnXoa.Location = new System.Drawing.Point(403, 142);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 43);
            this.btnXoa.Location = new System.Drawing.Point(320, 115);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 35);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(526, 142);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 43);

            this.btnLamMoi.Location = new System.Drawing.Point(420, 115);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 35);
            this.btnLamMoi.TabIndex = 13;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.BtnLamMoi_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(649, 142);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(130, 43);

            this.btnThongKe.Location = new System.Drawing.Point(530, 115);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(130, 35);
            this.btnThongKe.TabIndex = 14;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.BtnThongKe_Click);
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnTraPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraPhong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTraPhong.ForeColor = System.Drawing.Color.White;
            this.btnTraPhong.Location = new System.Drawing.Point(792, 142);
            this.btnTraPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(190, 43);
            this.btnTraPhong.TabIndex = 15;
            this.btnTraPhong.Text = "Quyết toán trả cọc";
            this.btnTraPhong.UseVisualStyleBackColor = false;
            // 
            // btnThuPhiHDMoi
            // 
            this.btnThuPhiHDMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(66)))), ((int)(((byte)(193)))));
            this.btnThuPhiHDMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuPhiHDMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThuPhiHDMoi.ForeColor = System.Drawing.Color.White;
            this.btnThuPhiHDMoi.Location = new System.Drawing.Point(995, 142);
            this.btnThuPhiHDMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnThuPhiHDMoi.Name = "btnThuPhiHDMoi";
            this.btnThuPhiHDMoi.Size = new System.Drawing.Size(180, 43);
            this.btnThuPhiHDMoi.TabIndex = 16;
            this.btnThuPhiHDMoi.Text = "Thu cọc & ĐH HĐ mới";
            this.btnThuPhiHDMoi.UseVisualStyleBackColor = false;
            // 
            // lblTimPhong
            // 
            this.lblTimPhong.AutoSize = true;
            this.lblTimPhong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTimPhong.Location = new System.Drawing.Point(16, 320);
            this.lblTimPhong.Name = "lblTimPhong";
            this.lblTimPhong.Size = new System.Drawing.Size(134, 23);
            this.lblTimPhong.TabIndex = 3;
            this.lblTimPhong.Text = "🔍 Tìm phòng:";
            // 
            // txtTimPhong
            // 
            this.txtTimPhong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTimPhong.Location = new System.Drawing.Point(155, 317);
            this.txtTimPhong.Name = "txtTimPhong";
            this.txtTimPhong.Size = new System.Drawing.Size(250, 29);
            this.txtTimPhong.TabIndex = 4;
            // 
            // btnHienThiTatCa
            // 
            this.btnHienThiTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnHienThiTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThiTatCa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHienThiTatCa.ForeColor = System.Drawing.Color.White;
            this.btnHienThiTatCa.Location = new System.Drawing.Point(415, 316);
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.Size = new System.Drawing.Size(130, 31);
            this.btnHienThiTatCa.TabIndex = 5;
            this.btnHienThiTatCa.Text = "Hiện tất cả";
            this.btnHienThiTatCa.UseVisualStyleBackColor = false;
            // 
            // dgvThuPhi
            // 
            this.dgvThuPhi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThuPhi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgvThuPhi.Location = new System.Drawing.Point(16, 355);
            this.dgvThuPhi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThuPhi.Name = "dgvThuPhi";
            this.dgvThuPhi.RowHeadersWidth = 51;
            this.dgvThuPhi.Size = new System.Drawing.Size(1547, 495);

            this.dgvThuPhi.Location = new System.Drawing.Point(12, 260);
            this.dgvThuPhi.Name = "dgvThuPhi";
            this.dgvThuPhi.RowHeadersWidth = 51;
            this.dgvThuPhi.Size = new System.Drawing.Size(1160, 429);

            this.dgvThuPhi.TabIndex = 2;
            this.dgvThuPhi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvThuPhi_CellClick);
            // 
            // FrmThuPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(1579, 863);
            this.Controls.Add(this.btnHienThiTatCa);
            this.Controls.Add(this.txtTimPhong);
            this.Controls.Add(this.lblTimPhong);
            this.Controls.Add(this.dgvThuPhi);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmThuPhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Thu Phí";

            this.ClientSize = new System.Drawing.Size(1184, 701);
            this.Controls.Add(this.dgvThuPhi);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmThuPhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Thu Phí";
            this.Load += new System.EventHandler(this.FrmThuPhi_Load);
 
            this.pnlHeader.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuPhi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
