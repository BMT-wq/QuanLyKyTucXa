using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKyTucXa.Presentation.SV3_DienNuocThuPhi
{
    partial class FrmDienNuoc
    {
        private IContainer components = null;
        private Label lblHeaderTitle;
        private Label lblHeaderSub;
        private Panel pnlHeader;
        private GroupBox grpInfo;
        private Label lblMaPhong;
        private TextBox txtMaPhong;
        private ComboBox cboPhong;
        private Label lblThangNam;
        private TextBox txtThangNam;
        private Label lblDienCu;
        private TextBox txtDienCu;
        private Label lblDienMoi;
        private TextBox txtDienMoi;
        private Label lblNuocCu;
        private TextBox txtNuocCu;
        private Label lblNuocMoi;
        private TextBox txtNuocMoi;
        private Button btnTinhTien;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnChiaTien;
        private Button btnTraPhong;
        private Button btnDongHoHD;
        private Label lblTimPhong;
        private TextBox txtTimPhong;
        private Button btnHienThiTatCa;
        private DataGridView dgvDienNuoc;

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
            this.btnHienThiTatCa = new System.Windows.Forms.Button();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.txtTimPhong = new System.Windows.Forms.TextBox();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.lblTimPhong = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblThangNam = new System.Windows.Forms.Label();
            this.txtThangNam = new System.Windows.Forms.TextBox();
            this.lblDienCu = new System.Windows.Forms.Label();
            this.txtDienCu = new System.Windows.Forms.TextBox();
            this.lblDienMoi = new System.Windows.Forms.Label();
            this.txtDienMoi = new System.Windows.Forms.TextBox();
            this.lblNuocCu = new System.Windows.Forms.Label();
            this.txtNuocCu = new System.Windows.Forms.TextBox();
            this.lblNuocMoi = new System.Windows.Forms.Label();
            this.txtNuocMoi = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnChiaTien = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnDongHoHD = new System.Windows.Forms.Button();
            this.dgvDienNuoc = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienNuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(205)))));
            this.pnlHeader.Controls.Add(this.lblHeaderSub);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
<<<<<<< HEAD
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(5);
=======
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> fb93b5475bb7d96c770f2bf4189f6d70247254c0
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1579, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSub
            //
            this.lblHeaderSub.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(0, 49);
            this.lblHeaderSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(1579, 31);
            this.lblHeaderSub.TabIndex = 1;
<<<<<<< HEAD
            this.lblHeaderSub.Text = "Nghiệp vụ SV3: Ghi chỉ số, tính tiền tự động, chia tiền đều SV, chốt đồng hồ trả " +
    "phòng & thanh lý cọc.";
=======
            this.lblHeaderSub.Text = "Nghiệp vụ SV3: Ghi chỉ số, tính tiền tự động, chia tiền đều SV, chốt đồng hồ trả phòng & thanh lý cọc.";
>>>>>>> fb93b5475bb7d96c770f2bf4189f6d70247254c0
            this.lblHeaderSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(1579, 47);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "QUẢN LÝ CHỈ SỐ ĐIỆN NƯỚC";
            this.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpInfo
            // 
            this.grpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfo.Controls.Add(this.btnHienThiTatCa);
            this.grpInfo.Controls.Add(this.lblMaPhong);
            this.grpInfo.Controls.Add(this.txtTimPhong);
            this.grpInfo.Controls.Add(this.cboPhong);
            this.grpInfo.Controls.Add(this.lblTimPhong);
            this.grpInfo.Controls.Add(this.txtMaPhong);
            this.grpInfo.Controls.Add(this.lblThangNam);
            this.grpInfo.Controls.Add(this.txtThangNam);
            this.grpInfo.Controls.Add(this.lblDienCu);
            this.grpInfo.Controls.Add(this.txtDienCu);
            this.grpInfo.Controls.Add(this.lblDienMoi);
            this.grpInfo.Controls.Add(this.txtDienMoi);
            this.grpInfo.Controls.Add(this.lblNuocCu);
            this.grpInfo.Controls.Add(this.txtNuocCu);
            this.grpInfo.Controls.Add(this.lblNuocMoi);
            this.grpInfo.Controls.Add(this.txtNuocMoi);
            this.grpInfo.Controls.Add(this.btnTinhTien);
            this.grpInfo.Controls.Add(this.btnLuu);
            this.grpInfo.Controls.Add(this.btnSua);
            this.grpInfo.Controls.Add(this.btnXoa);
            this.grpInfo.Controls.Add(this.btnLamMoi);
            this.grpInfo.Controls.Add(this.btnChiaTien);
            this.grpInfo.Controls.Add(this.btnTraPhong);
            this.grpInfo.Controls.Add(this.btnDongHoHD);
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpInfo.Location = new System.Drawing.Point(16, 92);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(5);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(5);
            this.grpInfo.Size = new System.Drawing.Size(1547, 215);
<<<<<<< HEAD
=======
            this.grpInfo.Location = new System.Drawing.Point(12, 75);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(1160, 175);
>>>>>>> fb93b5475bb7d96c770f2bf4189f6d70247254c0
            this.grpInfo.TabIndex = 1;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông tin chỉ số điện nước";
            // 
            // btnHienThiTatCa
            // 
            this.btnHienThiTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnHienThiTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThiTatCa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHienThiTatCa.ForeColor = System.Drawing.Color.White;
            this.btnHienThiTatCa.Location = new System.Drawing.Point(487, 186);
            this.btnHienThiTatCa.Margin = new System.Windows.Forms.Padding(4);
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.Size = new System.Drawing.Size(173, 29);
            this.btnHienThiTatCa.TabIndex = 5;
            this.btnHienThiTatCa.Text = "Hiện tất cả";
            this.btnHienThiTatCa.UseVisualStyleBackColor = false;
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMaPhong.Location = new System.Drawing.Point(27, 39);
            this.lblMaPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(99, 21);
<<<<<<< HEAD
=======
            this.lblMaPhong.Size = new System.Drawing.Size(72, 17);
>>>>>>> fb93b5475bb7d96c770f2bf4189f6d70247254c0
            this.lblMaPhong.TabIndex = 0;
            this.lblMaPhong.Text = "Chọn phòng:";
            // 
            // txtTimPhong
            // 
            this.txtTimPhong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTimPhong.Location = new System.Drawing.Point(147, 190);
            this.txtTimPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimPhong.Name = "txtTimPhong";
            this.txtTimPhong.Size = new System.Drawing.Size(332, 29);
            this.txtTimPhong.TabIndex = 4;
            // 
            // cboPhong
            // 
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(147, 39);
            this.cboPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(239, 29);
            this.cboPhong.TabIndex = 1;
            // 
            // lblTimPhong
            // 
            this.lblTimPhong.AutoSize = true;
            this.lblTimPhong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTimPhong.Location = new System.Drawing.Point(9, 192);
            this.lblTimPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimPhong.Name = "lblTimPhong";
            this.lblTimPhong.Size = new System.Drawing.Size(132, 23);
            this.lblTimPhong.TabIndex = 3;
            this.lblTimPhong.Text = "🔍 Tìm phòng:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaPhong.Location = new System.Drawing.Point(147, 36);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(239, 29);
            this.txtMaPhong.TabIndex = 1;
            this.txtMaPhong.Visible = false;
<<<<<<< HEAD
=======
            this.txtMaPhong.Location = new System.Drawing.Point(110, 29);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(180, 24);
            this.txtMaPhong.TabIndex = 1;
>>>>>>> fb93b5475bb7d96c770f2bf4189f6d70247254c0
            // 
            // lblThangNam
            // 
            this.lblThangNam.AutoSize = true;
            this.lblThangNam.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblThangNam.Location = new System.Drawing.Point(27, 89);
            this.lblThangNam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThangNam.Name = "lblThangNam";
            this.lblThangNam.Size = new System.Drawing.Size(96, 21);
            this.lblThangNam.TabIndex = 2;
            this.lblThangNam.Text = "Tháng/Năm:";
            // 
            // txtThangNam
            // 
            this.txtThangNam.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtThangNam.Location = new System.Drawing.Point(147, 85);
<<<<<<< HEAD
            this.txtThangNam.Margin = new System.Windows.Forms.Padding(5);
=======
            this.txtThangNam.Margin = new System.Windows.Forms.Padding(4);
            this.txtThangNam.Location = new System.Drawing.Point(110, 69);
>>>>>>> fb93b5475bb7d96c770f2bf4189f6d70247254c0
            this.txtThangNam.Name = "txtThangNam";
            this.txtThangNam.Size = new System.Drawing.Size(239, 29);
            this.txtThangNam.TabIndex = 3;
            // 
            // lblDienCu
            // 
            this.lblDienCu.AutoSize = true;
            this.lblDienCu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDienCu.Location = new System.Drawing.Point(427, 39);
            this.lblDienCu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDienCu.Name = "lblDienCu";
            this.lblDienCu.Size = new System.Drawing.Size(65, 21);
            this.lblDienCu.TabIndex = 4;
            this.lblDienCu.Text = "Điện cũ:";
            // 
            // txtDienCu
            // 
            this.txtDienCu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDienCu.Location = new System.Drawing.Point(533, 36);
<<<<<<< HEAD
            this.txtDienCu.Margin = new System.Windows.Forms.Padding(5);
=======
            this.txtDienCu.Margin = new System.Windows.Forms.Padding(4);
            this.txtDienCu.Location = new System.Drawing.Point(400, 29);
>>>>>>> fb93b5475bb7d96c770f2bf4189f6d70247254c0
            this.txtDienCu.Name = "txtDienCu";
            this.txtDienCu.Size = new System.Drawing.Size(239, 29);
            this.txtDienCu.TabIndex = 5;
            // 
            // lblDienMoi
            // 
            this.lblDienMoi.AutoSize = true;
            this.lblDienMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDienMoi.Location = new System.Drawing.Point(427, 89);
            this.lblDienMoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDienMoi.Name = "lblDienMoi";
            this.lblDienMoi.Size = new System.Drawing.Size(77, 21);
            this.lblDienMoi.TabIndex = 6;
            this.lblDienMoi.Text = "Điện mới:";
            // 
            // txtDienMoi
            // 
            this.txtDienMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDienMoi.Location = new System.Drawing.Point(533, 85);
<<<<<<< HEAD
            this.txtDienMoi.Margin = new System.Windows.Forms.Padding(5);
=======
            this.txtDienMoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDienMoi.Location = new System.Drawing.Point(400, 69);
>>>>>>> fb93b5475bb7d96c770f2bf4189f6d70247254c0
            this.txtDienMoi.Name = "txtDienMoi";
            this.txtDienMoi.Size = new System.Drawing.Size(239, 29);
            this.txtDienMoi.TabIndex = 7;
            // 
            // lblNuocCu
            // 
            this.lblNuocCu.AutoSize = true;
            this.lblNuocCu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNuocCu.Location = new System.Drawing.Point(827, 39);
            this.lblNuocCu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuocCu.Name = "lblNuocCu";
            this.lblNuocCu.Size = new System.Drawing.Size(71, 21);
            this.lblNuocCu.TabIndex = 8;
            this.lblNuocCu.Text = "Nước cũ:";
            // 
            // txtNuocCu
            // 
            this.txtNuocCu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNuocCu.Location = new System.Drawing.Point(933, 36);
<<<<<<< HEAD
            this.txtNuocCu.Margin = new System.Windows.Forms.Padding(5);
=======
            this.txtNuocCu.Margin = new System.Windows.Forms.Padding(4);
            this.txtNuocCu.Location = new System.Drawing.Point(700, 29);
>>>>>>> fb93b5475bb7d96c770f2bf4189f6d70247254c0
            this.txtNuocCu.Name = "txtNuocCu";
            this.txtNuocCu.Size = new System.Drawing.Size(239, 29);
            this.txtNuocCu.TabIndex = 9;
            // 
            // lblNuocMoi
            // 
            this.lblNuocMoi.AutoSize = true;
            this.lblNuocMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNuocMoi.Location = new System.Drawing.Point(827, 89);
            this.lblNuocMoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuocMoi.Name = "lblNuocMoi";
            this.lblNuocMoi.Size = new System.Drawing.Size(83, 21);
            this.lblNuocMoi.TabIndex = 10;
            this.lblNuocMoi.Text = "Nước mới:";
            // 
            // txtNuocMoi
            // 
            this.txtNuocMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNuocMoi.Location = new System.Drawing.Point(933, 85);
<<<<<<< HEAD
            this.txtNuocMoi.Margin = new System.Windows.Forms.Padding(5);
=======
            this.txtNuocMoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtNuocMoi.Location = new System.Drawing.Point(700, 69);
>>>>>>> fb93b5475bb7d96c770f2bf4189f6d70247254c0
            this.txtNuocMoi.Name = "txtNuocMoi";
            this.txtNuocMoi.Size = new System.Drawing.Size(239, 29);
            this.txtNuocMoi.TabIndex = 11;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.btnTinhTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhTien.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTinhTien.ForeColor = System.Drawing.Color.White;
            this.btnTinhTien.Location = new System.Drawing.Point(147, 142);
            this.btnTinhTien.Margin = new System.Windows.Forms.Padding(5);
            this.btnTinhTien.Name = "btnTinhTien";
<<<<<<< HEAD
            this.btnTinhTien.Size = new System.Drawing.Size(133, 43);
=======
            this.btnTinhTien.Size = new System.Drawing.Size(105, 43);
            this.btnTinhTien.Location = new System.Drawing.Point(110, 115);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(100, 35);
>>>>>>> fb93b5475bb7d96c770f2bf4189f6d70247254c0
            this.btnTinhTien.TabIndex = 12;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = false;
            this.btnTinhTien.Click += new System.EventHandler(this.BtnTinhTien_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.btnLuu.Location = new System.Drawing.Point(293, 142);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 43);
=======
            this.btnLuu.Location = new System.Drawing.Point(260, 142);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(95, 43);
            this.btnLuu.Location = new System.Drawing.Point(220, 115);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 35);
>>>>>>> fb93b5475bb7d96c770f2bf4189f6d70247254c0
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.btnSua.Location = new System.Drawing.Point(427, 142);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 43);
=======
            this.btnSua.Location = new System.Drawing.Point(363, 142);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 43);
            this.btnSua.Location = new System.Drawing.Point(320, 115);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 35);
>>>>>>> fb93b5475bb7d96c770f2bf4189f6d70247254c0
            this.btnSua.TabIndex = 14;
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
<<<<<<< HEAD
            this.btnXoa.Location = new System.Drawing.Point(560, 142);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 43);
=======
            this.btnXoa.Location = new System.Drawing.Point(466, 142);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 43);
            this.btnXoa.Location = new System.Drawing.Point(420, 115);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 35);
>>>>>>> fb93b5475bb7d96c770f2bf4189f6d70247254c0
            this.btnXoa.TabIndex = 15;
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
<<<<<<< HEAD
            this.btnLamMoi.Location = new System.Drawing.Point(693, 142);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(133, 43);
=======
            this.btnLamMoi.Location = new System.Drawing.Point(569, 142);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 43);
            this.btnLamMoi.Location = new System.Drawing.Point(520, 115);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 35);
>>>>>>> fb93b5475bb7d96c770f2bf4189f6d70247254c0
            this.btnLamMoi.TabIndex = 16;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.BtnLamMoi_Click);
            // 
            // btnChiaTien
            // 
            this.btnChiaTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(201)))), ((int)(((byte)(151)))));
            this.btnChiaTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiaTien.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnChiaTien.ForeColor = System.Drawing.Color.White;
            this.btnChiaTien.Location = new System.Drawing.Point(836, 142);
            this.btnChiaTien.Margin = new System.Windows.Forms.Padding(5);
            this.btnChiaTien.Name = "btnChiaTien";
            this.btnChiaTien.Size = new System.Drawing.Size(193, 43);
            this.btnChiaTien.TabIndex = 17;
            this.btnChiaTien.Text = "Chia tiền SV";
            this.btnChiaTien.UseVisualStyleBackColor = false;
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnTraPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraPhong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTraPhong.ForeColor = System.Drawing.Color.White;
            this.btnTraPhong.Location = new System.Drawing.Point(1039, 142);
            this.btnTraPhong.Margin = new System.Windows.Forms.Padding(5);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(247, 43);
            this.btnTraPhong.TabIndex = 18;
            this.btnTraPhong.Text = "Quyết toán trả cọc";
            this.btnTraPhong.UseVisualStyleBackColor = false;
            // 
            // btnDongHoHD
            // 
            this.btnDongHoHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(66)))), ((int)(((byte)(193)))));
            this.btnDongHoHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDongHoHD.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDongHoHD.ForeColor = System.Drawing.Color.White;
            this.btnDongHoHD.Location = new System.Drawing.Point(1296, 142);
            this.btnDongHoHD.Margin = new System.Windows.Forms.Padding(5);
            this.btnDongHoHD.Name = "btnDongHoHD";
            this.btnDongHoHD.Size = new System.Drawing.Size(233, 43);
            this.btnDongHoHD.TabIndex = 19;
            this.btnDongHoHD.Text = "Đồng hồ HĐ mới";
            this.btnDongHoHD.UseVisualStyleBackColor = false;
            // 
            // dgvDienNuoc
            // 
            this.dgvDienNuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDienNuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDienNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            this.dgvDienNuoc.Location = new System.Drawing.Point(16, 320);
            this.dgvDienNuoc.Margin = new System.Windows.Forms.Padding(5);
            this.dgvDienNuoc.Name = "dgvDienNuoc";
            this.dgvDienNuoc.RowHeadersWidth = 51;
            this.dgvDienNuoc.Size = new System.Drawing.Size(1547, 528);
=======
            this.dgvDienNuoc.Location = new System.Drawing.Point(16, 355);
            this.dgvDienNuoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDienNuoc.Name = "dgvDienNuoc";
            this.dgvDienNuoc.RowHeadersWidth = 51;
            this.dgvDienNuoc.Size = new System.Drawing.Size(1547, 495);
            this.dgvDienNuoc.Location = new System.Drawing.Point(12, 260);
            this.dgvDienNuoc.Name = "dgvDienNuoc";
            this.dgvDienNuoc.RowHeadersWidth = 51;
            this.dgvDienNuoc.Size = new System.Drawing.Size(1160, 429);
>>>>>>> fb93b5475bb7d96c770f2bf4189f6d70247254c0
            this.dgvDienNuoc.TabIndex = 2;
            this.dgvDienNuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDienNuoc_CellClick);
            // 
            // FrmDienNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1579, 863);
            this.Controls.Add(this.dgvDienNuoc);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(5);
=======

            this.ClientSize = new System.Drawing.Size(1579, 863);
            this.Controls.Add(this.btnHienThiTatCa);
            this.Controls.Add(this.txtTimPhong);
            this.Controls.Add(this.lblTimPhong);
            this.Controls.Add(this.dgvDienNuoc);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDienNuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Điện Nước";

            this.ClientSize = new System.Drawing.Size(1184, 701);
            this.Controls.Add(this.dgvDienNuoc);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.pnlHeader);
>>>>>>> fb93b5475bb7d96c770f2bf4189f6d70247254c0
            this.Name = "FrmDienNuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Điện Nước";
            this.Load += new System.EventHandler(this.FrmDienNuoc_Load);
<<<<<<< HEAD
=======

>>>>>>> fb93b5475bb7d96c770f2bf4189f6d70247254c0
            this.pnlHeader.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienNuoc)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
