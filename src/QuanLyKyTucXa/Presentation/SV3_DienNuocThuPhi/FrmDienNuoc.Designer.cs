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
            this.lblMaPhong = new System.Windows.Forms.Label();
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
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.lblHeaderSub.Text = "Khung giao diện mẫu: Sinh viên 3 bổ sung controls ghi chỉ số điện, nước cũ/mới, t" +
    "ính tiền tự động và ghi nhận thanh toán.";
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
            this.lblHeaderTitle.Text = "PHÂN HỆ 3: QUẢN LÝ CHỈ SỐ ĐIỆN NƯỚC (SV3)";
            this.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpInfo
            // 
            this.grpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfo.Controls.Add(this.lblMaPhong);
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
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpInfo.Location = new System.Drawing.Point(16, 92);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInfo.Size = new System.Drawing.Size(1547, 215);
            this.grpInfo.TabIndex = 1;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông tin chỉ số điện nước";
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMaPhong.Location = new System.Drawing.Point(27, 39);
            this.lblMaPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(84, 21);
            this.lblMaPhong.TabIndex = 0;
            this.lblMaPhong.Text = "Mã phòng:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaPhong.Location = new System.Drawing.Point(147, 36);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(239, 29);
            this.txtMaPhong.TabIndex = 1;
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
            this.txtThangNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtDienCu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtDienMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtNuocCu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtNuocMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnTinhTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(133, 43);
            this.btnTinhTien.TabIndex = 12;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(293, 142);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 43);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(427, 142);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 43);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(560, 142);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 43);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(693, 142);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(133, 43);
            this.btnLamMoi.TabIndex = 16;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // dgvDienNuoc
            // 
            this.dgvDienNuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDienNuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDienNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDienNuoc.Location = new System.Drawing.Point(16, 320);
            this.dgvDienNuoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDienNuoc.Name = "dgvDienNuoc";
            this.dgvDienNuoc.RowHeadersWidth = 51;
            this.dgvDienNuoc.Size = new System.Drawing.Size(1547, 528);
            this.dgvDienNuoc.TabIndex = 2;
            // 
            // FrmDienNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 863);
            this.Controls.Add(this.dgvDienNuoc);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDienNuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Điện Nước";
                        this.btnTinhTien.Click += new System.EventHandler(this.BtnTinhTien_Click);
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            this.btnLamMoi.Click += new System.EventHandler(this.BtnLamMoi_Click);
            this.dgvDienNuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDienNuoc_CellClick);
            this.Load += new System.EventHandler(this.FrmDienNuoc_Load);
            this.pnlHeader.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienNuoc)).EndInit();
            this.ResumeLayout(false);

        }
    }
}