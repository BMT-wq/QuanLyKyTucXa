using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKyTucXa.Presentation.SV1_PhongToaNha
{
    partial class FrmPhong
    {
        private IContainer components = null;
        private Label lblHeader;
        private Label lblPlaceholder;
        private DataGridView dgvPhong;

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
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(850, 45);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "PHÂN HỆ 1: QUẢN LÝ DANH MỤC PHÒNG KÝ TÚC XÁ (SV1)";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlaceholder
            // 
            this.lblPlaceholder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPlaceholder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblPlaceholder.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPlaceholder.Location = new System.Drawing.Point(0, 45);
            this.lblPlaceholder.Name = "lblPlaceholder";
            this.lblPlaceholder.Size = new System.Drawing.Size(850, 30);
            this.lblPlaceholder.TabIndex = 1;
            this.lblPlaceholder.Text = "Khung giao diện mẫu: Sinh viên 1 bổ sung các controls quản lý phòng (Mã, Tên, Tò" +
    "a, Loại phòng, Sức chứa, Đơn giá) và tìm kiếm lọc theo tòa nhà.";
            this.lblPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhong.Location = new System.Drawing.Point(0, 75);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.Size = new System.Drawing.Size(850, 425);
            this.dgvPhong.TabIndex = 2;
            // 
            // FrmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.lblPlaceholder);
            this.Controls.Add(this.lblHeader);
            this.Name = "FrmPhong";
            this.Text = "Quản lý Phòng";
            this.Load += new System.EventHandler(this.FrmPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
