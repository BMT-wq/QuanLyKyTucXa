using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKyTucXa.Presentation.SV1_PhongToaNha
{
    partial class FrmToaNha
    {
        private IContainer components = null;

        // --- Header ---
        private Label lblHeader;

        // --- Panel nhập liệu ---
        private GroupBox grpNhapLieu;
        private Label lblMaToaNha;
        private TextBox txtMaToaNha;
        private Label lblTenToaNha;
        private TextBox txtTenToaNha;
        private Label lblSoTang;
        private NumericUpDown nudSoTang;
        private Label lblGhiChu;
        private TextBox txtGhiChu;

        // --- Các nút hành động ---
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;

        // --- Bảng dữ liệu ---
        private DataGridView dgvToaNha;

        // --- Status bar ---
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblTrangThai;

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
            this.lblHeader = new Label();
            this.grpNhapLieu = new GroupBox();
            this.lblMaToaNha = new Label();
            this.txtMaToaNha = new TextBox();
            this.lblTenToaNha = new Label();
            this.txtTenToaNha = new TextBox();
            this.lblSoTang = new Label();
            this.nudSoTang = new NumericUpDown();
            this.lblGhiChu = new Label();
            this.txtGhiChu = new TextBox();
            this.btnThem = new Button();
            this.btnSua = new Button();
            this.btnXoa = new Button();
            this.btnLamMoi = new Button();
            this.dgvToaNha = new DataGridView();
            this.statusStrip = new StatusStrip();
            this.lblTrangThai = new ToolStripStatusLabel();

            this.grpNhapLieu.SuspendLayout();
            ((ISupportInitialize)(this.nudSoTang)).BeginInit();
            ((ISupportInitialize)(this.dgvToaNha)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // =====================================================
            // lblHeader
            // =====================================================
            this.lblHeader.BackColor = Color.FromArgb(40, 60, 120);
            this.lblHeader.Dock = DockStyle.Top;
            this.lblHeader.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            this.lblHeader.ForeColor = Color.White;
            this.lblHeader.Location = new Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new Size(880, 50);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "  🏢  QUẢN LÝ DANH MỤC TÒA NHÀ";
            this.lblHeader.TextAlign = ContentAlignment.MiddleLeft;

            // =====================================================
            // grpNhapLieu
            // =====================================================
            this.grpNhapLieu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.grpNhapLieu.Controls.Add(this.lblMaToaNha);
            this.grpNhapLieu.Controls.Add(this.txtMaToaNha);
            this.grpNhapLieu.Controls.Add(this.lblTenToaNha);
            this.grpNhapLieu.Controls.Add(this.txtTenToaNha);
            this.grpNhapLieu.Controls.Add(this.lblSoTang);
            this.grpNhapLieu.Controls.Add(this.nudSoTang);
            this.grpNhapLieu.Controls.Add(this.lblGhiChu);
            this.grpNhapLieu.Controls.Add(this.txtGhiChu);
            this.grpNhapLieu.Controls.Add(this.btnThem);
            this.grpNhapLieu.Controls.Add(this.btnSua);
            this.grpNhapLieu.Controls.Add(this.btnXoa);
            this.grpNhapLieu.Controls.Add(this.btnLamMoi);
            this.grpNhapLieu.Font = new Font("Segoe UI", 10F);
            this.grpNhapLieu.ForeColor = Color.FromArgb(40, 60, 120);
            this.grpNhapLieu.Location = new Point(12, 58);
            this.grpNhapLieu.Name = "grpNhapLieu";
            this.grpNhapLieu.Size = new Size(856, 155);
            this.grpNhapLieu.TabIndex = 1;
            this.grpNhapLieu.TabStop = false;
            this.grpNhapLieu.Text = "Thông tin Tòa nhà";

            // --- Hàng 1: Mã tòa nhà, Tên tòa nhà, Số tầng ---
            // lblMaToaNha
            this.lblMaToaNha.AutoSize = true;
            this.lblMaToaNha.ForeColor = Color.Black;
            this.lblMaToaNha.Location = new Point(15, 32);
            this.lblMaToaNha.Name = "lblMaToaNha";
            this.lblMaToaNha.Size = new Size(90, 19);
            this.lblMaToaNha.Text = "Mã tòa nhà:";

            // txtMaToaNha
            this.txtMaToaNha.Location = new Point(115, 29);
            this.txtMaToaNha.Name = "txtMaToaNha";
            this.txtMaToaNha.Size = new Size(140, 25);
            this.txtMaToaNha.CharacterCasing = CharacterCasing.Upper;

            // lblTenToaNha
            this.lblTenToaNha.AutoSize = true;
            this.lblTenToaNha.ForeColor = Color.Black;
            this.lblTenToaNha.Location = new Point(275, 32);
            this.lblTenToaNha.Name = "lblTenToaNha";
            this.lblTenToaNha.Size = new Size(90, 19);
            this.lblTenToaNha.Text = "Tên tòa nhà:";

            // txtTenToaNha
            this.txtTenToaNha.Location = new Point(375, 29);
            this.txtTenToaNha.Name = "txtTenToaNha";
            this.txtTenToaNha.Size = new Size(220, 25);

            // lblSoTang
            this.lblSoTang.AutoSize = true;
            this.lblSoTang.ForeColor = Color.Black;
            this.lblSoTang.Location = new Point(615, 32);
            this.lblSoTang.Name = "lblSoTang";
            this.lblSoTang.Size = new Size(60, 19);
            this.lblSoTang.Text = "Số tầng:";

            // nudSoTang
            this.nudSoTang.Location = new Point(685, 29);
            this.nudSoTang.Name = "nudSoTang";
            this.nudSoTang.Size = new Size(80, 25);
            this.nudSoTang.Minimum = 1;
            this.nudSoTang.Maximum = 100;
            this.nudSoTang.Value = 1;

            // --- Hàng 2: Ghi chú ---
            // lblGhiChu
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.ForeColor = Color.Black;
            this.lblGhiChu.Location = new Point(15, 68);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new Size(60, 19);
            this.lblGhiChu.Text = "Ghi chú:";

            // txtGhiChu
            this.txtGhiChu.Location = new Point(115, 65);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new Size(480, 25);

            // --- Hàng 3: Các nút hành động ---
            // btnThem
            this.btnThem.BackColor = Color.FromArgb(46, 139, 87);
            this.btnThem.FlatStyle = FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnThem.ForeColor = Color.White;
            this.btnThem.Location = new Point(115, 105);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new Size(110, 35);
            this.btnThem.Text = "✚  Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Cursor = Cursors.Hand;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.BackColor = Color.FromArgb(30, 120, 200);
            this.btnSua.FlatStyle = FlatStyle.Flat;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnSua.ForeColor = Color.White;
            this.btnSua.Location = new Point(240, 105);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new Size(110, 35);
            this.btnSua.Text = "✏  Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Cursor = Cursors.Hand;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.BackColor = Color.FromArgb(200, 50, 50);
            this.btnXoa.FlatStyle = FlatStyle.Flat;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnXoa.ForeColor = Color.White;
            this.btnXoa.Location = new Point(365, 105);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new Size(110, 35);
            this.btnXoa.Text = "✖  Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Cursor = Cursors.Hand;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnLamMoi
            this.btnLamMoi.BackColor = Color.FromArgb(100, 100, 100);
            this.btnLamMoi.FlatStyle = FlatStyle.Flat;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnLamMoi.ForeColor = Color.White;
            this.btnLamMoi.Location = new Point(490, 105);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new Size(110, 35);
            this.btnLamMoi.Text = "🔄  Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Cursor = Cursors.Hand;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // =====================================================
            // dgvToaNha
            // =====================================================
            this.dgvToaNha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvToaNha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvToaNha.BackgroundColor = Color.White;
            this.dgvToaNha.BorderStyle = BorderStyle.None;
            this.dgvToaNha.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvToaNha.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvToaNha.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(40, 60, 120),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                SelectionBackColor = Color.FromArgb(40, 60, 120),
                SelectionForeColor = Color.White,
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
            this.dgvToaNha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvToaNha.ColumnHeadersHeight = 38;
            this.dgvToaNha.DefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 9.5F),
                SelectionBackColor = Color.FromArgb(200, 220, 255),
                SelectionForeColor = Color.Black,
                Padding = new Padding(4, 2, 4, 2)
            };
            this.dgvToaNha.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(240, 245, 255)
            };
            this.dgvToaNha.EnableHeadersVisualStyles = false;
            this.dgvToaNha.GridColor = Color.FromArgb(220, 225, 235);
            this.dgvToaNha.Location = new Point(12, 220);
            this.dgvToaNha.Name = "dgvToaNha";
            this.dgvToaNha.ReadOnly = true;
            this.dgvToaNha.RowHeadersVisible = false;
            this.dgvToaNha.RowTemplate.Height = 32;
            this.dgvToaNha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvToaNha.MultiSelect = false;
            this.dgvToaNha.AllowUserToAddRows = false;
            this.dgvToaNha.AllowUserToDeleteRows = false;
            this.dgvToaNha.Size = new Size(856, 290);
            this.dgvToaNha.TabIndex = 2;
            this.dgvToaNha.CellClick += new DataGridViewCellEventHandler(this.dgvToaNha_CellClick);

            // =====================================================
            // statusStrip
            // =====================================================
            this.statusStrip.Items.AddRange(new ToolStripItem[] { this.lblTrangThai });
            this.statusStrip.Location = new Point(0, 518);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new Size(880, 22);
            this.statusStrip.TabIndex = 3;

            // lblTrangThai
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Text = "Sẵn sàng";

            // =====================================================
            // FrmToaNha
            // =====================================================
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(245, 247, 252);
            this.ClientSize = new Size(880, 540);
            this.Controls.Add(this.dgvToaNha);
            this.Controls.Add(this.grpNhapLieu);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.statusStrip);
            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(750, 500);
            this.Name = "FrmToaNha";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản lý Tòa nhà";
            this.Load += new System.EventHandler(this.FrmToaNha_Load);

            this.grpNhapLieu.ResumeLayout(false);
            this.grpNhapLieu.PerformLayout();
            ((ISupportInitialize)(this.nudSoTang)).EndInit();
            ((ISupportInitialize)(this.dgvToaNha)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
