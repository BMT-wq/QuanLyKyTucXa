using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKyTucXa.Presentation.SV3_DienNuocThuPhi
{
    partial class FrmDienNuoc
    {
        private IContainer components = null;
        private Label lblHeader;
        private Label lblPlaceholder;
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblPlaceholder = new System.Windows.Forms.Label();
            this.dgvDienNuoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienNuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(230)))));
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(900, 45);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "PHÂN HỆ 3: QUẢN LÝ CHỈ SỐ ĐIỆN NƯỚC (SV3)";
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
            this.lblPlaceholder.Text = "Khung giao diện mẫu: Sinh viên 3 bổ sung controls ghi chỉ số điện, nước cũ/mới, " +
    "tính tiền tự động và ghi nhận thanh toán.";
            this.lblPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDienNuoc
            // 
            this.dgvDienNuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDienNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDienNuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDienNuoc.Location = new System.Drawing.Point(0, 75);
            this.dgvDienNuoc.Name = "dgvDienNuoc";
            this.dgvDienNuoc.Size = new System.Drawing.Size(900, 425);
            this.dgvDienNuoc.TabIndex = 2;
            // 
            // FrmDienNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.dgvDienNuoc);
            this.Controls.Add(this.lblPlaceholder);
            this.Controls.Add(this.lblHeader);
            this.Name = "FrmDienNuoc";
            this.Text = "Quản lý Điện Nước";
            this.Load += new System.EventHandler(this.FrmDienNuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienNuoc)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
