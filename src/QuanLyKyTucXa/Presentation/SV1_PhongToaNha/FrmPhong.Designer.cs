using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKyTucXa.Presentation.SV1_PhongToaNha
{
    partial class FrmPhong
    {
        private IContainer components = null;

        // --- Header ---
        private Label lblHeader;

        // --- Panel nhập liệu ---
        private GroupBox grpNhapLieu;
        private Label lblMaPhong;
        private TextBox txtMaPhong;
        private Label lblTenPhong;
        private TextBox txtTenPhong;
        private Label lblToaNha;
        private ComboBox cboToaNha;
        private Label lblLoaiPhong;
        private ComboBox cboLoaiPhong;
        private Label lblSoChoToiDa;
        private NumericUpDown nudSoChoToiDa;
        private Label lblGiaPhong;
        private TextBox txtGiaPhong;
        private Label lblTrangThai;
        private ComboBox cboTrangThai;

        // --- Nút hành động ---
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;

        // --- Panel tìm kiếm & lọc ---
        private GroupBox grpTimKiem;
        private Label lblLocToaNha;
        private ComboBox cboLocToaNha;
        private CheckBox chkConCho;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;

        // --- Bảng dữ liệu ---
        private DataGridView dgvPhong;

        // --- Status bar ---
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblTrangThaiBar;

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
            this.lblMaPhong = new Label();
            this.txtMaPhong = new TextBox();
            this.lblTenPhong = new Label();
            this.txtTenPhong = new TextBox();
            this.lblToaNha = new Label();
            this.cboToaNha = new ComboBox();
            this.lblLoaiPhong = new Label();
            this.cboLoaiPhong = new ComboBox();
            this.lblSoChoToiDa = new Label();
            this.nudSoChoToiDa = new NumericUpDown();
            this.lblGiaPhong = new Label();
            this.txtGiaPhong = new TextBox();
            this.lblTrangThai = new Label();
            this.cboTrangThai = new ComboBox();
            this.btnThem = new Button();
            this.btnSua = new Button();
            this.btnXoa = new Button();
            this.btnLamMoi = new Button();
            this.grpTimKiem = new GroupBox();
            this.lblLocToaNha = new Label();
            this.cboLocToaNha = new ComboBox();
            this.chkConCho = new CheckBox();
            this.lblTimKiem = new Label();
            this.txtTimKiem = new TextBox();
            this.btnTimKiem = new Button();
            this.dgvPhong = new DataGridView();
            this.statusStrip = new StatusStrip();
            this.lblTrangThaiBar = new ToolStripStatusLabel();

            this.grpNhapLieu.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            ((ISupportInitialize)(this.nudSoChoToiDa)).BeginInit();
            ((ISupportInitialize)(this.dgvPhong)).BeginInit();
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
            this.lblHeader.Size = new Size(960, 50);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "  🚪  QUẢN LÝ DANH MỤC PHÒNG KÝ TÚC XÁ";
            this.lblHeader.TextAlign = ContentAlignment.MiddleLeft;

            // =====================================================
            // grpNhapLieu
            // =====================================================
            this.grpNhapLieu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.grpNhapLieu.Controls.Add(this.lblMaPhong);
            this.grpNhapLieu.Controls.Add(this.txtMaPhong);
            this.grpNhapLieu.Controls.Add(this.lblTenPhong);
            this.grpNhapLieu.Controls.Add(this.txtTenPhong);
            this.grpNhapLieu.Controls.Add(this.lblToaNha);
            this.grpNhapLieu.Controls.Add(this.cboToaNha);
            this.grpNhapLieu.Controls.Add(this.lblLoaiPhong);
            this.grpNhapLieu.Controls.Add(this.cboLoaiPhong);
            this.grpNhapLieu.Controls.Add(this.lblSoChoToiDa);
            this.grpNhapLieu.Controls.Add(this.nudSoChoToiDa);
            this.grpNhapLieu.Controls.Add(this.lblGiaPhong);
            this.grpNhapLieu.Controls.Add(this.txtGiaPhong);
            this.grpNhapLieu.Controls.Add(this.lblTrangThai);
            this.grpNhapLieu.Controls.Add(this.cboTrangThai);
            this.grpNhapLieu.Controls.Add(this.btnThem);
            this.grpNhapLieu.Controls.Add(this.btnSua);
            this.grpNhapLieu.Controls.Add(this.btnXoa);
            this.grpNhapLieu.Controls.Add(this.btnLamMoi);
            this.grpNhapLieu.Font = new Font("Segoe UI", 10F);
            this.grpNhapLieu.ForeColor = Color.FromArgb(40, 60, 120);
            this.grpNhapLieu.Location = new Point(12, 58);
            this.grpNhapLieu.Name = "grpNhapLieu";
            this.grpNhapLieu.Size = new Size(936, 190);
            this.grpNhapLieu.TabIndex = 1;
            this.grpNhapLieu.TabStop = false;
            this.grpNhapLieu.Text = "Thông tin Phòng";

            // --- Hàng 1 ---
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.ForeColor = Color.Black;
            this.lblMaPhong.Location = new Point(15, 32);
            this.lblMaPhong.Text = "Mã phòng:";

            this.txtMaPhong.Location = new Point(115, 29);
            this.txtMaPhong.Size = new Size(120, 25);
            this.txtMaPhong.CharacterCasing = CharacterCasing.Upper;

            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.ForeColor = Color.Black;
            this.lblTenPhong.Location = new Point(255, 32);
            this.lblTenPhong.Text = "Tên phòng:";

            this.txtTenPhong.Location = new Point(345, 29);
            this.txtTenPhong.Size = new Size(160, 25);

            this.lblToaNha.AutoSize = true;
            this.lblToaNha.ForeColor = Color.Black;
            this.lblToaNha.Location = new Point(525, 32);
            this.lblToaNha.Text = "Tòa nhà:";

            this.cboToaNha.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboToaNha.Location = new Point(605, 29);
            this.cboToaNha.Size = new Size(200, 25);

            // --- Hàng 2 ---
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.ForeColor = Color.Black;
            this.lblLoaiPhong.Location = new Point(15, 68);
            this.lblLoaiPhong.Text = "Loại phòng:";

            this.cboLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboLoaiPhong.Location = new Point(115, 65);
            this.cboLoaiPhong.Size = new Size(120, 25);
            this.cboLoaiPhong.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cboLoaiPhong.SelectedIndex = 0;

            this.lblSoChoToiDa.AutoSize = true;
            this.lblSoChoToiDa.ForeColor = Color.Black;
            this.lblSoChoToiDa.Location = new Point(255, 68);
            this.lblSoChoToiDa.Text = "Sức chứa:";

            this.nudSoChoToiDa.Location = new Point(345, 65);
            this.nudSoChoToiDa.Size = new Size(80, 25);
            this.nudSoChoToiDa.Minimum = 1;
            this.nudSoChoToiDa.Maximum = 20;
            this.nudSoChoToiDa.Value = 4;

            this.lblGiaPhong.AutoSize = true;
            this.lblGiaPhong.ForeColor = Color.Black;
            this.lblGiaPhong.Location = new Point(445, 68);
            this.lblGiaPhong.Text = "Giá phòng:";

            this.txtGiaPhong.Location = new Point(535, 65);
            this.txtGiaPhong.Size = new Size(130, 25);
            this.txtGiaPhong.Text = "0";

            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.ForeColor = Color.Black;
            this.lblTrangThai.Location = new Point(685, 68);
            this.lblTrangThai.Text = "Trạng thái:";

            this.cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboTrangThai.Location = new Point(775, 65);
            this.cboTrangThai.Size = new Size(145, 25);
            this.cboTrangThai.Items.AddRange(new object[] { "Còn chỗ", "Đầy", "Đang sửa chữa" });
            this.cboTrangThai.SelectedIndex = 0;

            // --- Hàng 3: Nút ---
            this.btnThem.BackColor = Color.FromArgb(46, 139, 87);
            this.btnThem.FlatStyle = FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnThem.ForeColor = Color.White;
            this.btnThem.Location = new Point(115, 108);
            this.btnThem.Size = new Size(110, 35);
            this.btnThem.Text = "✚  Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Cursor = Cursors.Hand;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.BackColor = Color.FromArgb(30, 120, 200);
            this.btnSua.FlatStyle = FlatStyle.Flat;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnSua.ForeColor = Color.White;
            this.btnSua.Location = new Point(240, 108);
            this.btnSua.Size = new Size(110, 35);
            this.btnSua.Text = "✏  Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Cursor = Cursors.Hand;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.BackColor = Color.FromArgb(200, 50, 50);
            this.btnXoa.FlatStyle = FlatStyle.Flat;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnXoa.ForeColor = Color.White;
            this.btnXoa.Location = new Point(365, 108);
            this.btnXoa.Size = new Size(110, 35);
            this.btnXoa.Text = "✖  Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Cursor = Cursors.Hand;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnLamMoi.BackColor = Color.FromArgb(100, 100, 100);
            this.btnLamMoi.FlatStyle = FlatStyle.Flat;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnLamMoi.ForeColor = Color.White;
            this.btnLamMoi.Location = new Point(490, 108);
            this.btnLamMoi.Size = new Size(110, 35);
            this.btnLamMoi.Text = "🔄  Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Cursor = Cursors.Hand;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // =====================================================
            // grpTimKiem - Bộ lọc & Tìm kiếm
            // =====================================================
            this.grpTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.grpTimKiem.Controls.Add(this.lblLocToaNha);
            this.grpTimKiem.Controls.Add(this.cboLocToaNha);
            this.grpTimKiem.Controls.Add(this.chkConCho);
            this.grpTimKiem.Controls.Add(this.lblTimKiem);
            this.grpTimKiem.Controls.Add(this.txtTimKiem);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Font = new Font("Segoe UI", 10F);
            this.grpTimKiem.ForeColor = Color.FromArgb(120, 80, 0);
            this.grpTimKiem.Location = new Point(12, 255);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new Size(936, 55);
            this.grpTimKiem.TabIndex = 2;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm & Lọc";

            this.lblLocToaNha.AutoSize = true;
            this.lblLocToaNha.ForeColor = Color.Black;
            this.lblLocToaNha.Location = new Point(15, 25);
            this.lblLocToaNha.Text = "Tòa nhà:";

            this.cboLocToaNha.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboLocToaNha.Location = new Point(85, 22);
            this.cboLocToaNha.Size = new Size(180, 25);
            this.cboLocToaNha.SelectedIndexChanged += new System.EventHandler(this.cboLocToaNha_SelectedIndexChanged);

            this.chkConCho.AutoSize = true;
            this.chkConCho.ForeColor = Color.Black;
            this.chkConCho.Location = new Point(290, 25);
            this.chkConCho.Text = "Chỉ phòng còn chỗ";
            this.chkConCho.CheckedChanged += new System.EventHandler(this.chkConCho_CheckedChanged);

            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.ForeColor = Color.Black;
            this.lblTimKiem.Location = new Point(480, 25);
            this.lblTimKiem.Text = "Tìm:";

            this.txtTimKiem.Location = new Point(520, 22);
            this.txtTimKiem.Size = new Size(250, 25);
            // PlaceholderText không hỗ trợ trên .NET Framework 4.8, dùng ForeColor + event thay thế
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);

            this.btnTimKiem.BackColor = Color.FromArgb(120, 80, 0);
            this.btnTimKiem.FlatStyle = FlatStyle.Flat;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnTimKiem.ForeColor = Color.White;
            this.btnTimKiem.Location = new Point(785, 19);
            this.btnTimKiem.Size = new Size(100, 30);
            this.btnTimKiem.Text = "🔍 Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Cursor = Cursors.Hand;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);

            // =====================================================
            // dgvPhong
            // =====================================================
            this.dgvPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = Color.White;
            this.dgvPhong.BorderStyle = BorderStyle.None;
            this.dgvPhong.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvPhong.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(40, 60, 120),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                SelectionBackColor = Color.FromArgb(40, 60, 120),
                SelectionForeColor = Color.White,
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
            this.dgvPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPhong.ColumnHeadersHeight = 38;
            this.dgvPhong.DefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 9.5F),
                SelectionBackColor = Color.FromArgb(200, 220, 255),
                SelectionForeColor = Color.Black,
                Padding = new Padding(4, 2, 4, 2)
            };
            this.dgvPhong.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(240, 245, 255)
            };
            this.dgvPhong.EnableHeadersVisualStyles = false;
            this.dgvPhong.GridColor = Color.FromArgb(220, 225, 235);
            this.dgvPhong.Location = new Point(12, 318);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersVisible = false;
            this.dgvPhong.RowTemplate.Height = 32;
            this.dgvPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.MultiSelect = false;
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            this.dgvPhong.Size = new Size(936, 270);
            this.dgvPhong.TabIndex = 3;
            this.dgvPhong.CellClick += new DataGridViewCellEventHandler(this.dgvPhong_CellClick);

            // =====================================================
            // statusStrip
            // =====================================================
            this.statusStrip.Items.AddRange(new ToolStripItem[] { this.lblTrangThaiBar });
            this.statusStrip.Location = new Point(0, 598);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new Size(960, 22);

            this.lblTrangThaiBar.Name = "lblTrangThaiBar";
            this.lblTrangThaiBar.Text = "Sẵn sàng";

            // =====================================================
            // FrmPhong
            // =====================================================
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(245, 247, 252);
            this.ClientSize = new Size(960, 620);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.grpNhapLieu);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.statusStrip);
            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(850, 600);
            this.Name = "FrmPhong";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản lý Phòng";
            this.Load += new System.EventHandler(this.FrmPhong_Load);

            this.grpNhapLieu.ResumeLayout(false);
            this.grpNhapLieu.PerformLayout();
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((ISupportInitialize)(this.nudSoChoToiDa)).EndInit();
            ((ISupportInitialize)(this.dgvPhong)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
