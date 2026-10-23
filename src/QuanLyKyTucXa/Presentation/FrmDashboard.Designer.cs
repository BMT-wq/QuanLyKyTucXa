using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKyTucXa.Presentation
{
    partial class FrmDashboard
    {
        private IContainer components = null;

        private Panel pnlHeader;
        private Label lblHeaderTitle;
        private Label lblHeaderSubtitle;

        private TableLayoutPanel tblCards;
        private Panel pnlCardToaNha;
        private Label lblCardToaNhaVal;
        private Label lblCardToaNhaTitle;
        private Label lblCardToaNhaSub;

        private Panel pnlCardPhong;
        private Label lblCardPhongVal;
        private Label lblCardPhongTitle;
        private Label lblCardPhongSub;

        private Panel pnlCardSinhVien;
        private Label lblCardSinhVienVal;
        private Label lblCardSinhVienTitle;
        private Label lblCardSinhVienSub;

        private Panel pnlCardHopDong;
        private Label lblCardHopDongVal;
        private Label lblCardHopDongTitle;
        private Label lblCardHopDongSub;

        private Panel pnlCardDienNuoc;
        private Label lblCardDienNuocVal;
        private Label lblCardDienNuocTitle;
        private Label lblCardDienNuocSub;

        private Panel pnlCardThuPhi;
        private Label lblCardThuPhiVal;
        private Label lblCardThuPhiTitle;
        private Label lblCardThuPhiSub;

        private GroupBox grpQuickActions;
        private FlowLayoutPanel flowQuickActions;
        private Button btnQuickToaNha;
        private Button btnQuickPhong;
        private Button btnQuickSinhVien;
        private Button btnQuickHopDong;
        private Button btnQuickDienNuoc;
        private Button btnQuickThuPhi;
        private Button btnQuickLuuDuLieu;
        private Button btnQuickLamMoi;

        private GroupBox grpPhongTrong;
        private DataGridView dgvPhongTrong;
        private Panel pnlTableToolbar;
        private Label lblTableTitle;
        private Button btnRefreshTable;

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
            this.pnlHeader = new Panel();
            this.lblHeaderTitle = new Label();
            this.lblHeaderSubtitle = new Label();

            this.tblCards = new TableLayoutPanel();
            this.pnlCardToaNha = new Panel();
            this.lblCardToaNhaVal = new Label();
            this.lblCardToaNhaTitle = new Label();
            this.lblCardToaNhaSub = new Label();

            this.pnlCardPhong = new Panel();
            this.lblCardPhongVal = new Label();
            this.lblCardPhongTitle = new Label();
            this.lblCardPhongSub = new Label();

            this.pnlCardSinhVien = new Panel();
            this.lblCardSinhVienVal = new Label();
            this.lblCardSinhVienTitle = new Label();
            this.lblCardSinhVienSub = new Label();

            this.pnlCardHopDong = new Panel();
            this.lblCardHopDongVal = new Label();
            this.lblCardHopDongTitle = new Label();
            this.lblCardHopDongSub = new Label();

            this.pnlCardDienNuoc = new Panel();
            this.lblCardDienNuocVal = new Label();
            this.lblCardDienNuocTitle = new Label();
            this.lblCardDienNuocSub = new Label();

            this.pnlCardThuPhi = new Panel();
            this.lblCardThuPhiVal = new Label();
            this.lblCardThuPhiTitle = new Label();
            this.lblCardThuPhiSub = new Label();

            this.grpQuickActions = new GroupBox();
            this.flowQuickActions = new FlowLayoutPanel();
            this.btnQuickToaNha = new Button();
            this.btnQuickPhong = new Button();
            this.btnQuickSinhVien = new Button();
            this.btnQuickHopDong = new Button();
            this.btnQuickDienNuoc = new Button();
            this.btnQuickThuPhi = new Button();
            this.btnQuickLuuDuLieu = new Button();
            this.btnQuickLamMoi = new Button();

            this.grpPhongTrong = new GroupBox();
            this.dgvPhongTrong = new DataGridView();
            this.pnlTableToolbar = new Panel();
            this.lblTableTitle = new Label();
            this.btnRefreshTable = new Button();

            this.pnlHeader.SuspendLayout();
            this.tblCards.SuspendLayout();
            this.pnlCardToaNha.SuspendLayout();
            this.pnlCardPhong.SuspendLayout();
            this.pnlCardSinhVien.SuspendLayout();
            this.pnlCardHopDong.SuspendLayout();
            this.pnlCardDienNuoc.SuspendLayout();
            this.pnlCardThuPhi.SuspendLayout();
            this.grpQuickActions.SuspendLayout();
            this.flowQuickActions.SuspendLayout();
            this.grpPhongTrong.SuspendLayout();
            ((ISupportInitialize)(this.dgvPhongTrong)).BeginInit();
            this.pnlTableToolbar.SuspendLayout();
            this.SuspendLayout();

            // =====================================================
            // pnlHeader
            // =====================================================
            this.pnlHeader.BackColor = Color.FromArgb(33, 50, 94);
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Location = new Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new Padding(20, 10, 20, 10);
            this.pnlHeader.Size = new Size(1000, 65);
            this.pnlHeader.TabIndex = 0;

            // lblHeaderTitle
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = Color.White;
            this.lblHeaderTitle.Location = new Point(15, 10);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new Size(450, 28);
            this.lblHeaderTitle.Text = "📊 BẢNG ĐIỀU KHIỂN QUẢN TRỊ KÝ TÚC XÁ";

            // lblHeaderSubtitle
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new Font("Segoe UI", 9.5F);
            this.lblHeaderSubtitle.ForeColor = Color.FromArgb(210, 225, 255);
            this.lblHeaderSubtitle.Location = new Point(18, 38);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new Size(520, 17);
            this.lblHeaderSubtitle.Text = "Tổng quan hiện trạng cơ sở vật chất, sinh viên nội trú và tài chính ký túc xá";

            // =====================================================
            // tblCards (6 Cards KPI: 3 cột x 2 hàng)
            // =====================================================
            this.tblCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.tblCards.ColumnCount = 6;
            this.tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            this.tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            this.tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            this.tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            this.tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            this.tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            this.tblCards.Controls.Add(this.pnlCardToaNha, 0, 0);
            this.tblCards.Controls.Add(this.pnlCardPhong, 1, 0);
            this.tblCards.Controls.Add(this.pnlCardSinhVien, 2, 0);
            this.tblCards.Controls.Add(this.pnlCardHopDong, 3, 0);
            this.tblCards.Controls.Add(this.pnlCardDienNuoc, 4, 0);
            this.tblCards.Controls.Add(this.pnlCardThuPhi, 5, 0);
            this.tblCards.Location = new Point(12, 75);
            this.tblCards.Name = "tblCards";
            this.tblCards.RowCount = 1;
            this.tblCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tblCards.Size = new Size(976, 105);
            this.tblCards.TabIndex = 1;

            // --- Card 1: Tòa Nhà ---
            this.pnlCardToaNha.BackColor = Color.FromArgb(25, 118, 210);
            this.pnlCardToaNha.Controls.Add(this.lblCardToaNhaVal);
            this.pnlCardToaNha.Controls.Add(this.lblCardToaNhaTitle);
            this.pnlCardToaNha.Controls.Add(this.lblCardToaNhaSub);
            this.pnlCardToaNha.Dock = DockStyle.Fill;
            this.pnlCardToaNha.Margin = new Padding(4);
            this.pnlCardToaNha.Cursor = Cursors.Hand;
            this.pnlCardToaNha.Click += new System.EventHandler(this.pnlCardToaNha_Click);

            this.lblCardToaNhaTitle.Text = "🏢 TÒA NHÀ";
            this.lblCardToaNhaTitle.ForeColor = Color.White;
            this.lblCardToaNhaTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblCardToaNhaTitle.Location = new Point(8, 8);
            this.lblCardToaNhaTitle.AutoSize = true;

            this.lblCardToaNhaVal.Text = "0";
            this.lblCardToaNhaVal.ForeColor = Color.White;
            this.lblCardToaNhaVal.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblCardToaNhaVal.Location = new Point(6, 30);
            this.lblCardToaNhaVal.AutoSize = true;

            this.lblCardToaNhaSub.Text = "Dãy nhà quản lý";
            this.lblCardToaNhaSub.ForeColor = Color.FromArgb(220, 240, 255);
            this.lblCardToaNhaSub.Font = new Font("Segoe UI", 8F);
            this.lblCardToaNhaSub.Location = new Point(8, 75);
            this.lblCardToaNhaSub.AutoSize = true;

            // --- Card 2: Phòng ---
            this.pnlCardPhong.BackColor = Color.FromArgb(46, 125, 50);
            this.pnlCardPhong.Controls.Add(this.lblCardPhongVal);
            this.pnlCardPhong.Controls.Add(this.lblCardPhongTitle);
            this.pnlCardPhong.Controls.Add(this.lblCardPhongSub);
            this.pnlCardPhong.Dock = DockStyle.Fill;
            this.pnlCardPhong.Margin = new Padding(4);
            this.pnlCardPhong.Cursor = Cursors.Hand;
            this.pnlCardPhong.Click += new System.EventHandler(this.pnlCardPhong_Click);

            this.lblCardPhongTitle.Text = "🚪 PHÒNG KTX";
            this.lblCardPhongTitle.ForeColor = Color.White;
            this.lblCardPhongTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblCardPhongTitle.Location = new Point(8, 8);
            this.lblCardPhongTitle.AutoSize = true;

            this.lblCardPhongVal.Text = "0";
            this.lblCardPhongVal.ForeColor = Color.White;
            this.lblCardPhongVal.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblCardPhongVal.Location = new Point(6, 30);
            this.lblCardPhongVal.AutoSize = true;

            this.lblCardPhongSub.Text = "0 phòng còn chỗ";
            this.lblCardPhongSub.ForeColor = Color.FromArgb(220, 255, 230);
            this.lblCardPhongSub.Font = new Font("Segoe UI", 8F);
            this.lblCardPhongSub.Location = new Point(8, 75);
            this.lblCardPhongSub.AutoSize = true;

            // --- Card 3: Sinh Viên ---
            this.pnlCardSinhVien.BackColor = Color.FromArgb(230, 108, 0);
            this.pnlCardSinhVien.Controls.Add(this.lblCardSinhVienVal);
            this.pnlCardSinhVien.Controls.Add(this.lblCardSinhVienTitle);
            this.pnlCardSinhVien.Controls.Add(this.lblCardSinhVienSub);
            this.pnlCardSinhVien.Dock = DockStyle.Fill;
            this.pnlCardSinhVien.Margin = new Padding(4);
            this.pnlCardSinhVien.Cursor = Cursors.Hand;
            this.pnlCardSinhVien.Click += new System.EventHandler(this.pnlCardSinhVien_Click);

            this.lblCardSinhVienTitle.Text = "👨‍🎓 SINH VIÊN";
            this.lblCardSinhVienTitle.ForeColor = Color.White;
            this.lblCardSinhVienTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblCardSinhVienTitle.Location = new Point(8, 8);
            this.lblCardSinhVienTitle.AutoSize = true;

            this.lblCardSinhVienVal.Text = "0";
            this.lblCardSinhVienVal.ForeColor = Color.White;
            this.lblCardSinhVienVal.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblCardSinhVienVal.Location = new Point(6, 30);
            this.lblCardSinhVienVal.AutoSize = true;

            this.lblCardSinhVienSub.Text = "Hồ sơ đăng ký";
            this.lblCardSinhVienSub.ForeColor = Color.FromArgb(255, 240, 220);
            this.lblCardSinhVienSub.Font = new Font("Segoe UI", 8F);
            this.lblCardSinhVienSub.Location = new Point(8, 75);
            this.lblCardSinhVienSub.AutoSize = true;

            // --- Card 4: Hợp Đồng ---
            this.pnlCardHopDong.BackColor = Color.FromArgb(123, 31, 162);
            this.pnlCardHopDong.Controls.Add(this.lblCardHopDongVal);
            this.pnlCardHopDong.Controls.Add(this.lblCardHopDongTitle);
            this.pnlCardHopDong.Controls.Add(this.lblCardHopDongSub);
            this.pnlCardHopDong.Dock = DockStyle.Fill;
            this.pnlCardHopDong.Margin = new Padding(4);
            this.pnlCardHopDong.Cursor = Cursors.Hand;
            this.pnlCardHopDong.Click += new System.EventHandler(this.pnlCardHopDong_Click);

            this.lblCardHopDongTitle.Text = "📝 HỢP ĐỒNG";
            this.lblCardHopDongTitle.ForeColor = Color.White;
            this.lblCardHopDongTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblCardHopDongTitle.Location = new Point(8, 8);
            this.lblCardHopDongTitle.AutoSize = true;

            this.lblCardHopDongVal.Text = "0";
            this.lblCardHopDongVal.ForeColor = Color.White;
            this.lblCardHopDongVal.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblCardHopDongVal.Location = new Point(6, 30);
            this.lblCardHopDongVal.AutoSize = true;

            this.lblCardHopDongSub.Text = "Đang hiệu lực";
            this.lblCardHopDongSub.ForeColor = Color.FromArgb(245, 225, 255);
            this.lblCardHopDongSub.Font = new Font("Segoe UI", 8F);
            this.lblCardHopDongSub.Location = new Point(8, 75);
            this.lblCardHopDongSub.AutoSize = true;

            // --- Card 5: Điện Nước ---
            this.pnlCardDienNuoc.BackColor = Color.FromArgb(198, 40, 40);
            this.pnlCardDienNuoc.Controls.Add(this.lblCardDienNuocVal);
            this.pnlCardDienNuoc.Controls.Add(this.lblCardDienNuocTitle);
            this.pnlCardDienNuoc.Controls.Add(this.lblCardDienNuocSub);
            this.pnlCardDienNuoc.Dock = DockStyle.Fill;
            this.pnlCardDienNuoc.Margin = new Padding(4);
            this.pnlCardDienNuoc.Cursor = Cursors.Hand;
            this.pnlCardDienNuoc.Click += new System.EventHandler(this.pnlCardDienNuoc_Click);

            this.lblCardDienNuocTitle.Text = "⚡ ĐIỆN NƯỚC";
            this.lblCardDienNuocTitle.ForeColor = Color.White;
            this.lblCardDienNuocTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblCardDienNuocTitle.Location = new Point(8, 8);
            this.lblCardDienNuocTitle.AutoSize = true;

            this.lblCardDienNuocVal.Text = "0";
            this.lblCardDienNuocVal.ForeColor = Color.White;
            this.lblCardDienNuocVal.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblCardDienNuocVal.Location = new Point(6, 30);
            this.lblCardDienNuocVal.AutoSize = true;

            this.lblCardDienNuocSub.Text = "Chưa thanh toán";
            this.lblCardDienNuocSub.ForeColor = Color.FromArgb(255, 230, 230);
            this.lblCardDienNuocSub.Font = new Font("Segoe UI", 8F);
            this.lblCardDienNuocSub.Location = new Point(8, 75);
            this.lblCardDienNuocSub.AutoSize = true;

            // --- Card 6: Thu Phí ---
            this.pnlCardThuPhi.BackColor = Color.FromArgb(0, 137, 123);
            this.pnlCardThuPhi.Controls.Add(this.lblCardThuPhiVal);
            this.pnlCardThuPhi.Controls.Add(this.lblCardThuPhiTitle);
            this.pnlCardThuPhi.Controls.Add(this.lblCardThuPhiSub);
            this.pnlCardThuPhi.Dock = DockStyle.Fill;
            this.pnlCardThuPhi.Margin = new Padding(4);
            this.pnlCardThuPhi.Cursor = Cursors.Hand;
            this.pnlCardThuPhi.Click += new System.EventHandler(this.pnlCardThuPhi_Click);

            this.lblCardThuPhiTitle.Text = "💰 THU PHÍ";
            this.lblCardThuPhiTitle.ForeColor = Color.White;
            this.lblCardThuPhiTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblCardThuPhiTitle.Location = new Point(8, 8);
            this.lblCardThuPhiTitle.AutoSize = true;

            this.lblCardThuPhiVal.Text = "0 đ";
            this.lblCardThuPhiVal.ForeColor = Color.White;
            this.lblCardThuPhiVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblCardThuPhiVal.Location = new Point(6, 34);
            this.lblCardThuPhiVal.AutoSize = true;

            this.lblCardThuPhiSub.Text = "Tổng tiền đã thu";
            this.lblCardThuPhiSub.ForeColor = Color.FromArgb(220, 255, 250);
            this.lblCardThuPhiSub.Font = new Font("Segoe UI", 8F);
            this.lblCardThuPhiSub.Location = new Point(8, 75);
            this.lblCardThuPhiSub.AutoSize = true;

            // =====================================================
            // grpQuickActions (Truy Cập Nhanh)
            // =====================================================
            this.grpQuickActions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.grpQuickActions.Controls.Add(this.flowQuickActions);
            this.grpQuickActions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.grpQuickActions.ForeColor = Color.FromArgb(33, 50, 94);
            this.grpQuickActions.Location = new Point(12, 190);
            this.grpQuickActions.Name = "grpQuickActions";
            this.grpQuickActions.Size = new Size(976, 80);
            this.grpQuickActions.TabIndex = 2;
            this.grpQuickActions.TabStop = false;
            this.grpQuickActions.Text = "⚡ TRUY CẬP NHANH CÁC PHÂN HỆ";

            // flowQuickActions
            this.flowQuickActions.Dock = DockStyle.Fill;
            this.flowQuickActions.Controls.Add(this.btnQuickToaNha);
            this.flowQuickActions.Controls.Add(this.btnQuickPhong);
            this.flowQuickActions.Controls.Add(this.btnQuickSinhVien);
            this.flowQuickActions.Controls.Add(this.btnQuickHopDong);
            this.flowQuickActions.Controls.Add(this.btnQuickDienNuoc);
            this.flowQuickActions.Controls.Add(this.btnQuickThuPhi);
            this.flowQuickActions.Controls.Add(this.btnQuickLuuDuLieu);
            this.flowQuickActions.Controls.Add(this.btnQuickLamMoi);
            this.flowQuickActions.Location = new Point(3, 21);
            this.flowQuickActions.Name = "flowQuickActions";
            this.flowQuickActions.Padding = new Padding(5, 5, 5, 5);
            this.flowQuickActions.Size = new Size(970, 56);

            // Button styling helper
            InitQuickButton(this.btnQuickToaNha, "🏢 Quản lý Tòa Nhà", Color.FromArgb(25, 118, 210), this.btnQuickToaNha_Click);
            InitQuickButton(this.btnQuickPhong, "🚪 Quản lý Phòng", Color.FromArgb(46, 125, 50), this.btnQuickPhong_Click);
            InitQuickButton(this.btnQuickSinhVien, "👨‍🎓 Hồ sơ Sinh Viên", Color.FromArgb(230, 108, 0), this.btnQuickSinhVien_Click);
            InitQuickButton(this.btnQuickHopDong, "📝 Hợp Đồng Thuê", Color.FromArgb(123, 31, 162), this.btnQuickHopDong_Click);
            InitQuickButton(this.btnQuickDienNuoc, "⚡ Điện Nước", Color.FromArgb(198, 40, 40), this.btnQuickDienNuoc_Click);
            InitQuickButton(this.btnQuickThuPhi, "💰 Thu Phí", Color.FromArgb(0, 137, 123), this.btnQuickThuPhi_Click);
            InitQuickButton(this.btnQuickLuuDuLieu, "💾 Lưu Toàn Bộ", Color.FromArgb(69, 90, 100), this.btnQuickLuuDuLieu_Click);
            InitQuickButton(this.btnQuickLamMoi, "🔄 Làm Mới (F5)", Color.FromArgb(97, 97, 97), this.btnQuickLamMoi_Click);

            // =====================================================
            // grpPhongTrong (Bảng Danh Sách Phòng Còn Chỗ)
            // =====================================================
            this.grpPhongTrong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.grpPhongTrong.Controls.Add(this.dgvPhongTrong);
            this.grpPhongTrong.Controls.Add(this.pnlTableToolbar);
            this.grpPhongTrong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.grpPhongTrong.ForeColor = Color.FromArgb(33, 50, 94);
            this.grpPhongTrong.Location = new Point(12, 276);
            this.grpPhongTrong.Name = "grpPhongTrong";
            this.grpPhongTrong.Size = new Size(976, 310);
            this.grpPhongTrong.TabIndex = 3;
            this.grpPhongTrong.TabStop = false;
            this.grpPhongTrong.Text = "📋 DANH SÁCH PHÒNG CÒN CHỖ TRỐNG HIỆN TẠI";

            // pnlTableToolbar
            this.pnlTableToolbar.Controls.Add(this.btnRefreshTable);
            this.pnlTableToolbar.Controls.Add(this.lblTableTitle);
            this.pnlTableToolbar.Dock = DockStyle.Top;
            this.pnlTableToolbar.Location = new Point(3, 21);
            this.pnlTableToolbar.Name = "pnlTableToolbar";
            this.pnlTableToolbar.Size = new Size(970, 35);
            this.pnlTableToolbar.TabIndex = 0;

            // lblTableTitle
            this.lblTableTitle.AutoSize = true;
            this.lblTableTitle.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            this.lblTableTitle.ForeColor = Color.FromArgb(100, 100, 100);
            this.lblTableTitle.Location = new Point(5, 10);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Size = new Size(380, 15);
            this.lblTableTitle.Text = "Hiển thị các phòng còn chỗ trống để tiện tra cứu & xếp phòng cho sinh viên mới";

            // btnRefreshTable
            this.btnRefreshTable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnRefreshTable.BackColor = Color.FromArgb(240, 240, 240);
            this.btnRefreshTable.FlatStyle = FlatStyle.Flat;
            this.btnRefreshTable.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            this.btnRefreshTable.ForeColor = Color.FromArgb(33, 50, 94);
            this.btnRefreshTable.Location = new Point(830, 4);
            this.btnRefreshTable.Name = "btnRefreshTable";
            this.btnRefreshTable.Size = new Size(135, 28);
            this.btnRefreshTable.Text = "🔄 Cập nhật danh sách";
            this.btnRefreshTable.UseVisualStyleBackColor = false;
            this.btnRefreshTable.Cursor = Cursors.Hand;
            this.btnRefreshTable.Click += new System.EventHandler(this.btnRefreshTable_Click);

            // dgvPhongTrong
            this.dgvPhongTrong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongTrong.BackgroundColor = Color.White;
            this.dgvPhongTrong.BorderStyle = BorderStyle.None;
            this.dgvPhongTrong.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhongTrong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvPhongTrong.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(33, 50, 94),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
            this.dgvPhongTrong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPhongTrong.ColumnHeadersHeight = 35;
            this.dgvPhongTrong.DefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 9F),
                SelectionBackColor = Color.FromArgb(210, 230, 255),
                SelectionForeColor = Color.Black,
                Padding = new Padding(4, 2, 4, 2)
            };
            this.dgvPhongTrong.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(245, 248, 255)
            };
            this.dgvPhongTrong.Dock = DockStyle.Fill;
            this.dgvPhongTrong.EnableHeadersVisualStyles = false;
            this.dgvPhongTrong.GridColor = Color.FromArgb(220, 225, 235);
            this.dgvPhongTrong.Location = new Point(3, 56);
            this.dgvPhongTrong.Name = "dgvPhongTrong";
            this.dgvPhongTrong.ReadOnly = true;
            this.dgvPhongTrong.RowHeadersVisible = false;
            this.dgvPhongTrong.RowTemplate.Height = 30;
            this.dgvPhongTrong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongTrong.MultiSelect = false;
            this.dgvPhongTrong.AllowUserToAddRows = false;
            this.dgvPhongTrong.AllowUserToDeleteRows = false;
            this.dgvPhongTrong.Size = new Size(970, 251);
            this.dgvPhongTrong.TabIndex = 1;

            // =====================================================
            // FrmDashboard
            // =====================================================
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(245, 247, 252);
            this.ClientSize = new Size(1000, 598);
            this.Controls.Add(this.grpPhongTrong);
            this.Controls.Add(this.grpQuickActions);
            this.Controls.Add(this.tblCards);
            this.Controls.Add(this.pnlHeader);
            this.Font = new Font("Segoe UI", 9F);
            this.Name = "FrmDashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Bảng điều khiển";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tblCards.ResumeLayout(false);
            this.pnlCardToaNha.ResumeLayout(false);
            this.pnlCardToaNha.PerformLayout();
            this.pnlCardPhong.ResumeLayout(false);
            this.pnlCardPhong.PerformLayout();
            this.pnlCardSinhVien.ResumeLayout(false);
            this.pnlCardSinhVien.PerformLayout();
            this.pnlCardHopDong.ResumeLayout(false);
            this.pnlCardHopDong.PerformLayout();
            this.pnlCardDienNuoc.ResumeLayout(false);
            this.pnlCardDienNuoc.PerformLayout();
            this.pnlCardThuPhi.ResumeLayout(false);
            this.pnlCardThuPhi.PerformLayout();
            this.grpQuickActions.ResumeLayout(false);
            this.flowQuickActions.ResumeLayout(false);
            this.grpPhongTrong.ResumeLayout(false);
            ((ISupportInitialize)(this.dgvPhongTrong)).EndInit();
            this.pnlTableToolbar.ResumeLayout(false);
            this.pnlTableToolbar.PerformLayout();
            this.ResumeLayout(false);
        }

        private void InitQuickButton(Button btn, string text, Color color, System.EventHandler onClick)
        {
            btn.BackColor = color;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn.ForeColor = Color.White;
            btn.Size = new Size(114, 38);
            btn.Text = text;
            btn.UseVisualStyleBackColor = false;
            btn.Cursor = Cursors.Hand;
            btn.Margin = new Padding(3, 3, 3, 3);
            btn.Click += onClick;
        }
    }
}
