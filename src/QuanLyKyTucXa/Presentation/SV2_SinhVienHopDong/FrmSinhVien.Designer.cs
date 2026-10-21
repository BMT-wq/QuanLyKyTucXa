using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKyTucXa.Presentation.SV2_SinhVienHopDong
{
    partial class FrmSinhVien
    {
        private IContainer components = null;
        private Label lblHeader;
        private Label lblPlaceholder;
        private DataGridView dgvSinhVien;

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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblPlaceholder = new System.Windows.Forms.Label();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(900, 45);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "PHÂN HỆ 2: HỒ SƠ SINH VIÊN NỘI TRÚ (SV2)";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlaceholder
            // 
            this.lblPlaceholder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPlaceholder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblPlaceholder.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPlaceholder.Location = new System.Drawing.Point(0, 45);
            this.lblPlaceholder.Name = "lblPlaceholder";
            this.lblPlaceholder.Size = new System.Drawing.Size(900, 30);
            this.lblPlaceholder.TabIndex = 1;
            this.lblPlaceholder.Text = "Khung giao diện mẫu: Sinh viên 2 bổ sung các controls tiếp nhận hồ sơ (Mã SV, Họ" +
    " tên, CCCD, Lớp, Quê quán) và các nút thao tác CRUD.";
            this.lblPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSinhVien.Location = new System.Drawing.Point(0, 75);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.Size = new System.Drawing.Size(900, 425);
            this.dgvSinhVien.TabIndex = 2;
            // 
            // FrmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.lblPlaceholder);
            this.Controls.Add(this.lblHeader);
            this.Name = "FrmSinhVien";
            this.Text = "Quản lý Sinh viên";
            this.Load += new System.EventHandler(this.FrmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
