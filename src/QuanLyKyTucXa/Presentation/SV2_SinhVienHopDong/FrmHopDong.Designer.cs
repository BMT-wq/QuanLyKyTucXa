using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKyTucXa.Presentation.SV2_SinhVienHopDong
{
    partial class FrmHopDong
    {
        private IContainer components = null;
        private Label lblHeader;
        private Label lblPlaceholder;
        private DataGridView dgvHopDong;

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
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
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
            this.lblHeader.Text = "PHÂN HỆ 2: HỢP ĐỒNG THUÊ PHÒNG NỘI TRÚ (SV2)";
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
            this.lblPlaceholder.Text = "Khung giao diện mẫu: Sinh viên 2 bổ sung controls lập hợp đồng, chọn phòng, chọn " +
    "sinh viên, gia hạn và thanh lý hợp đồng.";
            this.lblPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHopDong.Location = new System.Drawing.Point(0, 75);
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.Size = new System.Drawing.Size(900, 425);
            this.dgvHopDong.TabIndex = 2;
            // 
            // FrmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.dgvHopDong);
            this.Controls.Add(this.lblPlaceholder);
            this.Controls.Add(this.lblHeader);
            this.Name = "FrmHopDong";
            this.Text = "Quản lý Hợp đồng";
            this.Load += new System.EventHandler(this.FrmHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
