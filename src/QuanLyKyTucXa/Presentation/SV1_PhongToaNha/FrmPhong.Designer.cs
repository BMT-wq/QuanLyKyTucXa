namespace QuanLyKyTucXa.Presentation.SV1_PhongToaNha
{
    partial class FrmPhong
    {
        private System.ComponentModel.IContainer components = null;

        // --- Header ---
        private System.Windows.Forms.Label lblHeader;

        // --- Panel nhập liệu ---
        private System.Windows.Forms.GroupBox grpNhapLieu;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label lblToaNha;
        private System.Windows.Forms.ComboBox cboToaNha;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.Label lblSoChoToiDa;
        private System.Windows.Forms.NumericUpDown nudSoChoToiDa;
        private System.Windows.Forms.Label lblGiaPhong;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;

        // --- Nút hành động ---
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;

        // --- Panel tìm kiếm & lọc ---
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Label lblLocToaNha;
        private System.Windows.Forms.ComboBox cboLocToaNha;
        private System.Windows.Forms.CheckBox chkConCho;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;

        // --- Bảng dữ liệu ---
        private System.Windows.Forms.DataGridView dgvPhong;

        // --- Status bar ---
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThaiBar;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpNhapLieu = new System.Windows.Forms.GroupBox();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.lblToaNha = new System.Windows.Forms.Label();
            this.cboToaNha = new System.Windows.Forms.ComboBox();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lblSoChoToiDa = new System.Windows.Forms.Label();
            this.nudSoChoToiDa = new System.Windows.Forms.NumericUpDown();
            this.lblGiaPhong = new System.Windows.Forms.Label();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.lblLocToaNha = new System.Windows.Forms.Label();
            this.cboLocToaNha = new System.Windows.Forms.ComboBox();
            this.chkConCho = new System.Windows.Forms.CheckBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblTrangThaiBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpNhapLieu.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoChoToiDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(960, 50);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "  🚪  QUẢN LÝ DANH MỤC PHÒNG KÝ TÚC XÁ";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpNhapLieu
            // 
            this.grpNhapLieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.grpNhapLieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpNhapLieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.grpNhapLieu.Location = new System.Drawing.Point(12, 58);
            this.grpNhapLieu.Name = "grpNhapLieu";
            this.grpNhapLieu.Size = new System.Drawing.Size(936, 190);
            this.grpNhapLieu.TabIndex = 1;
            this.grpNhapLieu.TabStop = false;
            this.grpNhapLieu.Text = "Thông tin Phòng";
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.ForeColor = System.Drawing.Color.Black;
            this.lblMaPhong.Location = new System.Drawing.Point(15, 32);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(76, 19);
            this.lblMaPhong.TabIndex = 0;
            this.lblMaPhong.Text = "Mã phòng:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaPhong.Location = new System.Drawing.Point(115, 29);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(120, 25);
            this.txtMaPhong.TabIndex = 1;
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.ForeColor = System.Drawing.Color.Black;
            this.lblTenPhong.Location = new System.Drawing.Point(255, 32);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(77, 19);
            this.lblTenPhong.TabIndex = 2;
            this.lblTenPhong.Text = "Tên phòng:";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(345, 29);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(160, 25);
            this.txtTenPhong.TabIndex = 3;
            // 
            // lblToaNha
            // 
            this.lblToaNha.AutoSize = true;
            this.lblToaNha.ForeColor = System.Drawing.Color.Black;
            this.lblToaNha.Location = new System.Drawing.Point(525, 32);
            this.lblToaNha.Name = "lblToaNha";
            this.lblToaNha.Size = new System.Drawing.Size(60, 19);
            this.lblToaNha.TabIndex = 4;
            this.lblToaNha.Text = "Tòa nhà:";
            // 
            // cboToaNha
            // 
            this.cboToaNha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboToaNha.Location = new System.Drawing.Point(605, 29);
            this.cboToaNha.Name = "cboToaNha";
            this.cboToaNha.Size = new System.Drawing.Size(200, 25);
            this.cboToaNha.TabIndex = 5;
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.ForeColor = System.Drawing.Color.Black;
            this.lblLoaiPhong.Location = new System.Drawing.Point(15, 68);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(81, 19);
            this.lblLoaiPhong.TabIndex = 6;
            this.lblLoaiPhong.Text = "Loại phòng:";
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiPhong.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboLoaiPhong.Location = new System.Drawing.Point(115, 65);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(120, 25);
            this.cboLoaiPhong.TabIndex = 7;
            // 
            // lblSoChoToiDa
            // 
            this.lblSoChoToiDa.AutoSize = true;
            this.lblSoChoToiDa.ForeColor = System.Drawing.Color.Black;
            this.lblSoChoToiDa.Location = new System.Drawing.Point(255, 68);
            this.lblSoChoToiDa.Name = "lblSoChoToiDa";
            this.lblSoChoToiDa.Size = new System.Drawing.Size(69, 19);
            this.lblSoChoToiDa.TabIndex = 8;
            this.lblSoChoToiDa.Text = "Sức chứa:";
            // 
            // nudSoChoToiDa
            // 
            this.nudSoChoToiDa.Location = new System.Drawing.Point(345, 65);
            this.nudSoChoToiDa.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudSoChoToiDa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoChoToiDa.Name = "nudSoChoToiDa";
            this.nudSoChoToiDa.Size = new System.Drawing.Size(80, 25);
            this.nudSoChoToiDa.TabIndex = 9;
            this.nudSoChoToiDa.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // lblGiaPhong
            // 
            this.lblGiaPhong.AutoSize = true;
            this.lblGiaPhong.ForeColor = System.Drawing.Color.Black;
            this.lblGiaPhong.Location = new System.Drawing.Point(445, 68);
            this.lblGiaPhong.Name = "lblGiaPhong";
            this.lblGiaPhong.Size = new System.Drawing.Size(75, 19);
            this.lblGiaPhong.TabIndex = 10;
            this.lblGiaPhong.Text = "Giá phòng:";
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Location = new System.Drawing.Point(535, 65);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(130, 25);
            this.txtGiaPhong.TabIndex = 11;
            this.txtGiaPhong.Text = "0";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.ForeColor = System.Drawing.Color.Black;
            this.lblTrangThai.Location = new System.Drawing.Point(685, 68);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(73, 19);
            this.lblTrangThai.TabIndex = 12;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Còn chỗ",
            "Đầy",
            "Đang sửa chữa"});
            this.cboTrangThai.Location = new System.Drawing.Point(775, 65);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(145, 25);
            this.cboTrangThai.TabIndex = 13;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(115, 108);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 35);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "✚  Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(240, 108);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 35);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "✏  Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(365, 108);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 35);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "✖  Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(490, 108);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 35);
            this.btnLamMoi.TabIndex = 17;
            this.btnLamMoi.Text = "🔄  Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTimKiem.Controls.Add(this.lblLocToaNha);
            this.grpTimKiem.Controls.Add(this.cboLocToaNha);
            this.grpTimKiem.Controls.Add(this.chkConCho);
            this.grpTimKiem.Controls.Add(this.lblTimKiem);
            this.grpTimKiem.Controls.Add(this.txtTimKiem);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.grpTimKiem.Location = new System.Drawing.Point(12, 255);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(936, 55);
            this.grpTimKiem.TabIndex = 2;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm & Lọc";
            // 
            // lblLocToaNha
            // 
            this.lblLocToaNha.AutoSize = true;
            this.lblLocToaNha.ForeColor = System.Drawing.Color.Black;
            this.lblLocToaNha.Location = new System.Drawing.Point(15, 25);
            this.lblLocToaNha.Name = "lblLocToaNha";
            this.lblLocToaNha.Size = new System.Drawing.Size(60, 19);
            this.lblLocToaNha.TabIndex = 0;
            this.lblLocToaNha.Text = "Tòa nhà:";
            // 
            // cboLocToaNha
            // 
            this.cboLocToaNha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocToaNha.Location = new System.Drawing.Point(85, 22);
            this.cboLocToaNha.Name = "cboLocToaNha";
            this.cboLocToaNha.Size = new System.Drawing.Size(180, 25);
            this.cboLocToaNha.TabIndex = 1;
            this.cboLocToaNha.SelectedIndexChanged += new System.EventHandler(this.cboLocToaNha_SelectedIndexChanged);
            // 
            // chkConCho
            // 
            this.chkConCho.AutoSize = true;
            this.chkConCho.ForeColor = System.Drawing.Color.Black;
            this.chkConCho.Location = new System.Drawing.Point(290, 25);
            this.chkConCho.Name = "chkConCho";
            this.chkConCho.Size = new System.Drawing.Size(142, 23);
            this.chkConCho.TabIndex = 2;
            this.chkConCho.Text = "Chỉ phòng còn chỗ";
            this.chkConCho.UseVisualStyleBackColor = true;
            this.chkConCho.CheckedChanged += new System.EventHandler(this.chkConCho_CheckedChanged);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.ForeColor = System.Drawing.Color.Black;
            this.lblTimKiem.Location = new System.Drawing.Point(480, 25);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(35, 19);
            this.lblTimKiem.TabIndex = 3;
            this.lblTimKiem.Text = "Tìm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(520, 22);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(250, 25);
            this.txtTimKiem.TabIndex = 4;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(785, 19);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 30);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "🔍 Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            this.dgvPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhong.ColumnHeadersHeight = 38;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhong.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dgvPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhong.EnableHeadersVisualStyles = false;
            this.dgvPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.dgvPhong.Location = new System.Drawing.Point(12, 318);
            this.dgvPhong.MultiSelect = false;
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersVisible = false;
            this.dgvPhong.RowTemplate.Height = 32;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(936, 270);
            this.dgvPhong.TabIndex = 3;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTrangThaiBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 598);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(960, 22);
            this.statusStrip.TabIndex = 4;
            // 
            // lblTrangThaiBar
            // 
            this.lblTrangThaiBar.Name = "lblTrangThaiBar";
            this.lblTrangThaiBar.Size = new System.Drawing.Size(55, 17);
            this.lblTrangThaiBar.Text = "Sẵn sàng";
            // 
            // FrmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(960, 620);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.grpNhapLieu);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "FrmPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Phòng";
            this.Load += new System.EventHandler(this.FrmPhong_Load);
            this.grpNhapLieu.ResumeLayout(false);
            this.grpNhapLieu.PerformLayout();
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoChoToiDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
