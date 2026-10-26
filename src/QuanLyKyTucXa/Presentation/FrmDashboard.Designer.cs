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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.tblCards = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCardToaNha = new System.Windows.Forms.Panel();
            this.lblCardToaNhaVal = new System.Windows.Forms.Label();
            this.lblCardToaNhaTitle = new System.Windows.Forms.Label();
            this.lblCardToaNhaSub = new System.Windows.Forms.Label();
            this.pnlCardPhong = new System.Windows.Forms.Panel();
            this.lblCardPhongVal = new System.Windows.Forms.Label();
            this.lblCardPhongTitle = new System.Windows.Forms.Label();
            this.lblCardPhongSub = new System.Windows.Forms.Label();
            this.pnlCardSinhVien = new System.Windows.Forms.Panel();
            this.lblCardSinhVienVal = new System.Windows.Forms.Label();
            this.lblCardSinhVienTitle = new System.Windows.Forms.Label();
            this.lblCardSinhVienSub = new System.Windows.Forms.Label();
            this.pnlCardHopDong = new System.Windows.Forms.Panel();
            this.lblCardHopDongVal = new System.Windows.Forms.Label();
            this.lblCardHopDongTitle = new System.Windows.Forms.Label();
            this.lblCardHopDongSub = new System.Windows.Forms.Label();
            this.pnlCardDienNuoc = new System.Windows.Forms.Panel();
            this.lblCardDienNuocVal = new System.Windows.Forms.Label();
            this.lblCardDienNuocTitle = new System.Windows.Forms.Label();
            this.lblCardDienNuocSub = new System.Windows.Forms.Label();
            this.pnlCardThuPhi = new System.Windows.Forms.Panel();
            this.lblCardThuPhiVal = new System.Windows.Forms.Label();
            this.lblCardThuPhiTitle = new System.Windows.Forms.Label();
            this.lblCardThuPhiSub = new System.Windows.Forms.Label();
            this.grpQuickActions = new System.Windows.Forms.GroupBox();
            this.flowQuickActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQuickToaNha = new System.Windows.Forms.Button();
            this.btnQuickPhong = new System.Windows.Forms.Button();
            this.btnQuickSinhVien = new System.Windows.Forms.Button();
            this.btnQuickHopDong = new System.Windows.Forms.Button();
            this.btnQuickDienNuoc = new System.Windows.Forms.Button();
            this.btnQuickThuPhi = new System.Windows.Forms.Button();
            this.btnQuickLuuDuLieu = new System.Windows.Forms.Button();
            this.btnQuickLamMoi = new System.Windows.Forms.Button();
            this.grpPhongTrong = new System.Windows.Forms.GroupBox();
            this.dgvPhongTrong = new System.Windows.Forms.DataGridView();
            this.pnlTableToolbar = new System.Windows.Forms.Panel();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            this.lblTableTitle = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTrong)).BeginInit();
            this.pnlTableToolbar.SuspendLayout();
            this.SuspendLayout();

            // =====================================================
            // pnlHeader
            // =====================================================
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlHeader.Size = new System.Drawing.Size(1000, 65);
            this.pnlHeader.TabIndex = 0;

            // lblHeaderTitle
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(15, 10);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(447, 28);
            this.lblHeaderTitle.Text = "📊 BẢNG ĐIỀU KHIỂN QUẢN TRỊ KÝ TÚC XÁ";

            // lblHeaderSubtitle
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(18, 38);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(485, 17);
            this.lblHeaderSubtitle.Text = "Tổng quan hiện trạng cơ sở vật chất, sinh viên nội trú và tài chính ký túc xá";

            // =====================================================
            // tblCards (6 Cards KPI)
            // =====================================================
            this.tblCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tblCards.ColumnCount = 6;
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCards.Controls.Add(this.pnlCardToaNha, 0, 0);
            this.tblCards.Controls.Add(this.pnlCardPhong, 1, 0);
            this.tblCards.Controls.Add(this.pnlCardSinhVien, 2, 0);
            this.tblCards.Controls.Add(this.pnlCardHopDong, 3, 0);
            this.tblCards.Controls.Add(this.pnlCardDienNuoc, 4, 0);
            this.tblCards.Controls.Add(this.pnlCardThuPhi, 5, 0);
            this.tblCards.Location = new System.Drawing.Point(12, 75);
            this.tblCards.Name = "tblCards";
            this.tblCards.RowCount = 1;
            this.tblCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCards.Size = new System.Drawing.Size(976, 105);
            this.tblCards.TabIndex = 1;

            // --- Card 1: Tòa Nhà ---
            this.pnlCardToaNha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.pnlCardToaNha.Controls.Add(this.lblCardToaNhaVal);
            this.pnlCardToaNha.Controls.Add(this.lblCardToaNhaTitle);
            this.pnlCardToaNha.Controls.Add(this.lblCardToaNhaSub);
            this.pnlCardToaNha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardToaNha.Location = new System.Drawing.Point(4, 4);
            this.pnlCardToaNha.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCardToaNha.Name = "pnlCardToaNha";
            this.pnlCardToaNha.Size = new System.Drawing.Size(154, 97);
            this.pnlCardToaNha.TabIndex = 0;
            this.pnlCardToaNha.Click += new System.EventHandler(this.pnlCardToaNha_Click);

            this.lblCardToaNhaTitle.AutoSize = true;
            this.lblCardToaNhaTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCardToaNhaTitle.ForeColor = System.Drawing.Color.White;
            this.lblCardToaNhaTitle.Location = new System.Drawing.Point(8, 8);
            this.lblCardToaNhaTitle.Name = "lblCardToaNhaTitle";
            this.lblCardToaNhaTitle.Size = new System.Drawing.Size(89, 17);
            this.lblCardToaNhaTitle.Text = "🏢 TÒA NHÀ";

            this.lblCardToaNhaVal.AutoSize = true;
            this.lblCardToaNhaVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCardToaNhaVal.ForeColor = System.Drawing.Color.White;
            this.lblCardToaNhaVal.Location = new System.Drawing.Point(6, 30);
            this.lblCardToaNhaVal.Name = "lblCardToaNhaVal";
            this.lblCardToaNhaVal.Size = new System.Drawing.Size(32, 37);
            this.lblCardToaNhaVal.Text = "0";

            this.lblCardToaNhaSub.AutoSize = true;
            this.lblCardToaNhaSub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCardToaNhaSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblCardToaNhaSub.Location = new System.Drawing.Point(8, 75);
            this.lblCardToaNhaSub.Name = "lblCardToaNhaSub";
            this.lblCardToaNhaSub.Size = new System.Drawing.Size(89, 13);
            this.lblCardToaNhaSub.Text = "Dãy nhà quản lý";

            // --- Card 2: Phòng ---
            this.pnlCardPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.pnlCardPhong.Controls.Add(this.lblCardPhongVal);
            this.pnlCardPhong.Controls.Add(this.lblCardPhongTitle);
            this.pnlCardPhong.Controls.Add(this.lblCardPhongSub);
            this.pnlCardPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardPhong.Location = new System.Drawing.Point(166, 4);
            this.pnlCardPhong.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCardPhong.Name = "pnlCardPhong";
            this.pnlCardPhong.Size = new System.Drawing.Size(154, 97);
            this.pnlCardPhong.TabIndex = 1;
            this.pnlCardPhong.Click += new System.EventHandler(this.pnlCardPhong_Click);

            this.lblCardPhongTitle.AutoSize = true;
            this.lblCardPhongTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCardPhongTitle.ForeColor = System.Drawing.Color.White;
            this.lblCardPhongTitle.Location = new System.Drawing.Point(8, 8);
            this.lblCardPhongTitle.Name = "lblCardPhongTitle";
            this.lblCardPhongTitle.Size = new System.Drawing.Size(107, 17);
            this.lblCardPhongTitle.Text = "🚪 PHÒNG KTX";

            this.lblCardPhongVal.AutoSize = true;
            this.lblCardPhongVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCardPhongVal.ForeColor = System.Drawing.Color.White;
            this.lblCardPhongVal.Location = new System.Drawing.Point(6, 30);
            this.lblCardPhongVal.Name = "lblCardPhongVal";
            this.lblCardPhongVal.Size = new System.Drawing.Size(32, 37);
            this.lblCardPhongVal.Text = "0";

            this.lblCardPhongSub.AutoSize = true;
            this.lblCardPhongSub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCardPhongSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.lblCardPhongSub.Location = new System.Drawing.Point(8, 75);
            this.lblCardPhongSub.Name = "lblCardPhongSub";
            this.lblCardPhongSub.Size = new System.Drawing.Size(90, 13);
            this.lblCardPhongSub.Text = "0 phòng còn chỗ";

            // --- Card 3: Sinh Viên ---
            this.pnlCardSinhVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.pnlCardSinhVien.Controls.Add(this.lblCardSinhVienVal);
            this.pnlCardSinhVien.Controls.Add(this.lblCardSinhVienTitle);
            this.pnlCardSinhVien.Controls.Add(this.lblCardSinhVienSub);
            this.pnlCardSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardSinhVien.Location = new System.Drawing.Point(328, 4);
            this.pnlCardSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCardSinhVien.Name = "pnlCardSinhVien";
            this.pnlCardSinhVien.Size = new System.Drawing.Size(154, 97);
            this.pnlCardSinhVien.TabIndex = 2;
            this.pnlCardSinhVien.Click += new System.EventHandler(this.pnlCardSinhVien_Click);

            this.lblCardSinhVienTitle.AutoSize = true;
            this.lblCardSinhVienTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCardSinhVienTitle.ForeColor = System.Drawing.Color.White;
            this.lblCardSinhVienTitle.Location = new System.Drawing.Point(8, 8);
            this.lblCardSinhVienTitle.Name = "lblCardSinhVienTitle";
            this.lblCardSinhVienTitle.Size = new System.Drawing.Size(95, 17);
            this.lblCardSinhVienTitle.Text = "👨‍🎓 SINH VIÊN";

            this.lblCardSinhVienVal.AutoSize = true;
            this.lblCardSinhVienVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCardSinhVienVal.ForeColor = System.Drawing.Color.White;
            this.lblCardSinhVienVal.Location = new System.Drawing.Point(6, 30);
            this.lblCardSinhVienVal.Name = "lblCardSinhVienVal";
            this.lblCardSinhVienVal.Size = new System.Drawing.Size(32, 37);
            this.lblCardSinhVienVal.Text = "0";

            this.lblCardSinhVienSub.AutoSize = true;
            this.lblCardSinhVienSub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCardSinhVienSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.lblCardSinhVienSub.Location = new System.Drawing.Point(8, 75);
            this.lblCardSinhVienSub.Name = "lblCardSinhVienSub";
            this.lblCardSinhVienSub.Size = new System.Drawing.Size(81, 13);
            this.lblCardSinhVienSub.Text = "Hồ sơ đăng ký";

            // --- Card 4: Hợp Đồng ---
            this.pnlCardHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(31)))), ((int)(((byte)(162)))));
            this.pnlCardHopDong.Controls.Add(this.lblCardHopDongVal);
            this.pnlCardHopDong.Controls.Add(this.lblCardHopDongTitle);
            this.pnlCardHopDong.Controls.Add(this.lblCardHopDongSub);
            this.pnlCardHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardHopDong.Location = new System.Drawing.Point(490, 4);
            this.pnlCardHopDong.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCardHopDong.Name = "pnlCardHopDong";
            this.pnlCardHopDong.Size = new System.Drawing.Size(154, 97);
            this.pnlCardHopDong.TabIndex = 3;
            this.pnlCardHopDong.Click += new System.EventHandler(this.pnlCardHopDong_Click);

            this.lblCardHopDongTitle.AutoSize = true;
            this.lblCardHopDongTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCardHopDongTitle.ForeColor = System.Drawing.Color.White;
            this.lblCardHopDongTitle.Location = new System.Drawing.Point(8, 8);
            this.lblCardHopDongTitle.Name = "lblCardHopDongTitle";
            this.lblCardHopDongTitle.Size = new System.Drawing.Size(100, 17);
            this.lblCardHopDongTitle.Text = "📝 HỢP ĐỒNG";

            this.lblCardHopDongVal.AutoSize = true;
            this.lblCardHopDongVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCardHopDongVal.ForeColor = System.Drawing.Color.White;
            this.lblCardHopDongVal.Location = new System.Drawing.Point(6, 30);
            this.lblCardHopDongVal.Name = "lblCardHopDongVal";
            this.lblCardHopDongVal.Size = new System.Drawing.Size(32, 37);
            this.lblCardHopDongVal.Text = "0";

            this.lblCardHopDongSub.AutoSize = true;
            this.lblCardHopDongSub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCardHopDongSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.lblCardHopDongSub.Location = new System.Drawing.Point(8, 75);
            this.lblCardHopDongSub.Name = "lblCardHopDongSub";
            this.lblCardHopDongSub.Size = new System.Drawing.Size(78, 13);
            this.lblCardHopDongSub.Text = "Đang hiệu lực";

            // --- Card 5: Điện Nước ---
            this.pnlCardDienNuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlCardDienNuoc.Controls.Add(this.lblCardDienNuocVal);
            this.pnlCardDienNuoc.Controls.Add(this.lblCardDienNuocTitle);
            this.pnlCardDienNuoc.Controls.Add(this.lblCardDienNuocSub);
            this.pnlCardDienNuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardDienNuoc.Location = new System.Drawing.Point(652, 4);
            this.pnlCardDienNuoc.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCardDienNuoc.Name = "pnlCardDienNuoc";
            this.pnlCardDienNuoc.Size = new System.Drawing.Size(154, 97);
            this.pnlCardDienNuoc.TabIndex = 4;
            this.pnlCardDienNuoc.Click += new System.EventHandler(this.pnlCardDienNuoc_Click);

            this.lblCardDienNuocTitle.AutoSize = true;
            this.lblCardDienNuocTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCardDienNuocTitle.ForeColor = System.Drawing.Color.White;
            this.lblCardDienNuocTitle.Location = new System.Drawing.Point(8, 8);
            this.lblCardDienNuocTitle.Name = "lblCardDienNuocTitle";
            this.lblCardDienNuocTitle.Size = new System.Drawing.Size(98, 17);
            this.lblCardDienNuocTitle.Text = "⚡ ĐIỆN NƯỚC";

            this.lblCardDienNuocVal.AutoSize = true;
            this.lblCardDienNuocVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCardDienNuocVal.ForeColor = System.Drawing.Color.White;
            this.lblCardDienNuocVal.Location = new System.Drawing.Point(6, 30);
            this.lblCardDienNuocVal.Name = "lblCardDienNuocVal";
            this.lblCardDienNuocVal.Size = new System.Drawing.Size(32, 37);
            this.lblCardDienNuocVal.Text = "0";

            this.lblCardDienNuocSub.AutoSize = true;
            this.lblCardDienNuocSub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCardDienNuocSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblCardDienNuocSub.Location = new System.Drawing.Point(8, 75);
            this.lblCardDienNuocSub.Name = "lblCardDienNuocSub";
            this.lblCardDienNuocSub.Size = new System.Drawing.Size(94, 13);
            this.lblCardDienNuocSub.Text = "Chưa thanh toán";

            // --- Card 6: Thu Phí ---
            this.pnlCardThuPhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.pnlCardThuPhi.Controls.Add(this.lblCardThuPhiVal);
            this.pnlCardThuPhi.Controls.Add(this.lblCardThuPhiTitle);
            this.pnlCardThuPhi.Controls.Add(this.lblCardThuPhiSub);
            this.pnlCardThuPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardThuPhi.Location = new System.Drawing.Point(814, 4);
            this.pnlCardThuPhi.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCardThuPhi.Name = "pnlCardThuPhi";
            this.pnlCardThuPhi.Size = new System.Drawing.Size(158, 97);
            this.pnlCardThuPhi.TabIndex = 5;
            this.pnlCardThuPhi.Click += new System.EventHandler(this.pnlCardThuPhi_Click);

            this.lblCardThuPhiTitle.AutoSize = true;
            this.lblCardThuPhiTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCardThuPhiTitle.ForeColor = System.Drawing.Color.White;
            this.lblCardThuPhiTitle.Location = new System.Drawing.Point(8, 8);
            this.lblCardThuPhiTitle.Name = "lblCardThuPhiTitle";
            this.lblCardThuPhiTitle.Size = new System.Drawing.Size(86, 17);
            this.lblCardThuPhiTitle.Text = "💰 THU PHÍ";

            this.lblCardThuPhiVal.AutoSize = true;
            this.lblCardThuPhiVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCardThuPhiVal.ForeColor = System.Drawing.Color.White;
            this.lblCardThuPhiVal.Location = new System.Drawing.Point(6, 34);
            this.lblCardThuPhiVal.Name = "lblCardThuPhiVal";
            this.lblCardThuPhiVal.Size = new System.Drawing.Size(46, 30);
            this.lblCardThuPhiVal.Text = "0 đ";

            this.lblCardThuPhiSub.AutoSize = true;
            this.lblCardThuPhiSub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCardThuPhiSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.lblCardThuPhiSub.Location = new System.Drawing.Point(8, 75);
            this.lblCardThuPhiSub.Name = "lblCardThuPhiSub";
            this.lblCardThuPhiSub.Size = new System.Drawing.Size(92, 13);
            this.lblCardThuPhiSub.Text = "Tổng tiền đã thu";

            // =====================================================
            // grpQuickActions (Truy Cập Nhanh)
            // =====================================================
            this.grpQuickActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.grpQuickActions.Controls.Add(this.flowQuickActions);
            this.grpQuickActions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpQuickActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.grpQuickActions.Location = new System.Drawing.Point(12, 190);
            this.grpQuickActions.Name = "grpQuickActions";
            this.grpQuickActions.Size = new System.Drawing.Size(976, 80);
            this.grpQuickActions.TabIndex = 2;
            this.grpQuickActions.TabStop = false;
            this.grpQuickActions.Text = "⚡ TRUY CẬP NHANH CÁC PHÂN HỆ";

            // flowQuickActions
            this.flowQuickActions.Controls.Add(this.btnQuickToaNha);
            this.flowQuickActions.Controls.Add(this.btnQuickPhong);
            this.flowQuickActions.Controls.Add(this.btnQuickSinhVien);
            this.flowQuickActions.Controls.Add(this.btnQuickHopDong);
            this.flowQuickActions.Controls.Add(this.btnQuickDienNuoc);
            this.flowQuickActions.Controls.Add(this.btnQuickThuPhi);
            this.flowQuickActions.Controls.Add(this.btnQuickLuuDuLieu);
            this.flowQuickActions.Controls.Add(this.btnQuickLamMoi);
            this.flowQuickActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowQuickActions.Location = new System.Drawing.Point(3, 21);
            this.flowQuickActions.Name = "flowQuickActions";
            this.flowQuickActions.Padding = new System.Windows.Forms.Padding(5);
            this.flowQuickActions.Size = new System.Drawing.Size(970, 56);
            this.flowQuickActions.TabIndex = 0;

            // btnQuickToaNha
            this.btnQuickToaNha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnQuickToaNha.FlatAppearance.BorderSize = 0;
            this.btnQuickToaNha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickToaNha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickToaNha.ForeColor = System.Drawing.Color.White;
            this.btnQuickToaNha.Location = new System.Drawing.Point(8, 8);
            this.btnQuickToaNha.Name = "btnQuickToaNha";
            this.btnQuickToaNha.Size = new System.Drawing.Size(114, 38);
            this.btnQuickToaNha.TabIndex = 0;
            this.btnQuickToaNha.Text = "🏢 Quản lý Tòa Nhà";
            this.btnQuickToaNha.UseVisualStyleBackColor = false;
            this.btnQuickToaNha.Click += new System.EventHandler(this.btnQuickToaNha_Click);

            // btnQuickPhong
            this.btnQuickPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnQuickPhong.FlatAppearance.BorderSize = 0;
            this.btnQuickPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickPhong.ForeColor = System.Drawing.Color.White;
            this.btnQuickPhong.Location = new System.Drawing.Point(128, 8);
            this.btnQuickPhong.Name = "btnQuickPhong";
            this.btnQuickPhong.Size = new System.Drawing.Size(114, 38);
            this.btnQuickPhong.TabIndex = 1;
            this.btnQuickPhong.Text = "🚪 Quản lý Phòng";
            this.btnQuickPhong.UseVisualStyleBackColor = false;
            this.btnQuickPhong.Click += new System.EventHandler(this.btnQuickPhong_Click);

            // btnQuickSinhVien
            this.btnQuickSinhVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.btnQuickSinhVien.FlatAppearance.BorderSize = 0;
            this.btnQuickSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickSinhVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickSinhVien.ForeColor = System.Drawing.Color.White;
            this.btnQuickSinhVien.Location = new System.Drawing.Point(248, 8);
            this.btnQuickSinhVien.Name = "btnQuickSinhVien";
            this.btnQuickSinhVien.Size = new System.Drawing.Size(114, 38);
            this.btnQuickSinhVien.TabIndex = 2;
            this.btnQuickSinhVien.Text = "👨‍🎓 Hồ sơ Sinh Viên";
            this.btnQuickSinhVien.UseVisualStyleBackColor = false;
            this.btnQuickSinhVien.Click += new System.EventHandler(this.btnQuickSinhVien_Click);

            // btnQuickHopDong
            this.btnQuickHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(31)))), ((int)(((byte)(162)))));
            this.btnQuickHopDong.FlatAppearance.BorderSize = 0;
            this.btnQuickHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickHopDong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickHopDong.ForeColor = System.Drawing.Color.White;
            this.btnQuickHopDong.Location = new System.Drawing.Point(368, 8);
            this.btnQuickHopDong.Name = "btnQuickHopDong";
            this.btnQuickHopDong.Size = new System.Drawing.Size(114, 38);
            this.btnQuickHopDong.TabIndex = 3;
            this.btnQuickHopDong.Text = "📝 Hợp Đồng Thuê";
            this.btnQuickHopDong.UseVisualStyleBackColor = false;
            this.btnQuickHopDong.Click += new System.EventHandler(this.btnQuickHopDong_Click);

            // btnQuickDienNuoc
            this.btnQuickDienNuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnQuickDienNuoc.FlatAppearance.BorderSize = 0;
            this.btnQuickDienNuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickDienNuoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickDienNuoc.ForeColor = System.Drawing.Color.White;
            this.btnQuickDienNuoc.Location = new System.Drawing.Point(488, 8);
            this.btnQuickDienNuoc.Name = "btnQuickDienNuoc";
            this.btnQuickDienNuoc.Size = new System.Drawing.Size(114, 38);
            this.btnQuickDienNuoc.TabIndex = 4;
            this.btnQuickDienNuoc.Text = "⚡ Điện Nước";
            this.btnQuickDienNuoc.UseVisualStyleBackColor = false;
            this.btnQuickDienNuoc.Click += new System.EventHandler(this.btnQuickDienNuoc_Click);

            // btnQuickThuPhi
            this.btnQuickThuPhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.btnQuickThuPhi.FlatAppearance.BorderSize = 0;
            this.btnQuickThuPhi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickThuPhi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickThuPhi.ForeColor = System.Drawing.Color.White;
            this.btnQuickThuPhi.Location = new System.Drawing.Point(608, 8);
            this.btnQuickThuPhi.Name = "btnQuickThuPhi";
            this.btnQuickThuPhi.Size = new System.Drawing.Size(114, 38);
            this.btnQuickThuPhi.TabIndex = 5;
            this.btnQuickThuPhi.Text = "💰 Thu Phí";
            this.btnQuickThuPhi.UseVisualStyleBackColor = false;
            this.btnQuickThuPhi.Click += new System.EventHandler(this.btnQuickThuPhi_Click);

            // btnQuickLuuDuLieu
            this.btnQuickLuuDuLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnQuickLuuDuLieu.FlatAppearance.BorderSize = 0;
            this.btnQuickLuuDuLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickLuuDuLieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickLuuDuLieu.ForeColor = System.Drawing.Color.White;
            this.btnQuickLuuDuLieu.Location = new System.Drawing.Point(728, 8);
            this.btnQuickLuuDuLieu.Name = "btnQuickLuuDuLieu";
            this.btnQuickLuuDuLieu.Size = new System.Drawing.Size(114, 38);
            this.btnQuickLuuDuLieu.TabIndex = 6;
            this.btnQuickLuuDuLieu.Text = "💾 Lưu Toàn Bộ";
            this.btnQuickLuuDuLieu.UseVisualStyleBackColor = false;
            this.btnQuickLuuDuLieu.Click += new System.EventHandler(this.btnQuickLuuDuLieu_Click);

            // btnQuickLamMoi
            this.btnQuickLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnQuickLamMoi.FlatAppearance.BorderSize = 0;
            this.btnQuickLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnQuickLamMoi.Location = new System.Drawing.Point(848, 8);
            this.btnQuickLamMoi.Name = "btnQuickLamMoi";
            this.btnQuickLamMoi.Size = new System.Drawing.Size(114, 38);
            this.btnQuickLamMoi.TabIndex = 7;
            this.btnQuickLamMoi.Text = "🔄 Làm Mới (F5)";
            this.btnQuickLamMoi.UseVisualStyleBackColor = false;
            this.btnQuickLamMoi.Click += new System.EventHandler(this.btnQuickLamMoi_Click);

            // =====================================================
            // grpPhongTrong (Bảng Danh Sách Phòng Còn Chỗ)
            // =====================================================
            this.grpPhongTrong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPhongTrong.Controls.Add(this.dgvPhongTrong);
            this.grpPhongTrong.Controls.Add(this.pnlTableToolbar);
            this.grpPhongTrong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpPhongTrong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.grpPhongTrong.Location = new System.Drawing.Point(12, 276);
            this.grpPhongTrong.Name = "grpPhongTrong";
            this.grpPhongTrong.Size = new System.Drawing.Size(976, 310);
            this.grpPhongTrong.TabIndex = 3;
            this.grpPhongTrong.TabStop = false;
            this.grpPhongTrong.Text = "📋 DANH SÁCH PHÒNG CÒN CHỖ TRỐNG HIỆN TẠI";

            // pnlTableToolbar
            this.pnlTableToolbar.Controls.Add(this.btnRefreshTable);
            this.pnlTableToolbar.Controls.Add(this.lblTableTitle);
            this.pnlTableToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTableToolbar.Location = new System.Drawing.Point(3, 21);
            this.pnlTableToolbar.Name = "pnlTableToolbar";
            this.pnlTableToolbar.Size = new System.Drawing.Size(970, 35);
            this.pnlTableToolbar.TabIndex = 0;

            // lblTableTitle
            this.lblTableTitle.AutoSize = true;
            this.lblTableTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblTableTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTableTitle.Location = new System.Drawing.Point(5, 10);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Size = new System.Drawing.Size(437, 15);
            this.lblTableTitle.TabIndex = 0;
            this.lblTableTitle.Text = "Hiển thị các phòng còn chỗ trống để tiện tra cứu & xếp phòng cho sinh viên mới";

            // btnRefreshTable
            this.btnRefreshTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnRefreshTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshTable.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnRefreshTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnRefreshTable.Location = new System.Drawing.Point(830, 4);
            this.btnRefreshTable.Name = "btnRefreshTable";
            this.btnRefreshTable.Size = new System.Drawing.Size(135, 28);
            this.btnRefreshTable.TabIndex = 1;
            this.btnRefreshTable.Text = "🔄 Cập nhật danh sách";
            this.btnRefreshTable.UseVisualStyleBackColor = false;
            this.btnRefreshTable.Click += new System.EventHandler(this.btnRefreshTable_Click);

            // dgvPhongTrong
            this.dgvPhongTrong.AllowUserToAddRows = false;
            this.dgvPhongTrong.AllowUserToDeleteRows = false;
            this.dgvPhongTrong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongTrong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhongTrong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhongTrong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhongTrong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPhongTrong.ColumnHeadersHeight = 35;
            this.dgvPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPhongTrong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhongTrong.EnableHeadersVisualStyles = false;
            this.dgvPhongTrong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.dgvPhongTrong.Location = new System.Drawing.Point(3, 56);
            this.dgvPhongTrong.MultiSelect = false;
            this.dgvPhongTrong.Name = "dgvPhongTrong";
            this.dgvPhongTrong.ReadOnly = true;
            this.dgvPhongTrong.RowHeadersVisible = false;
            this.dgvPhongTrong.RowTemplate.Height = 30;
            this.dgvPhongTrong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongTrong.Size = new System.Drawing.Size(970, 251);
            this.dgvPhongTrong.TabIndex = 1;

            // =====================================================
            // FrmDashboard
            // =====================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1000, 598);
            this.Controls.Add(this.grpPhongTrong);
            this.Controls.Add(this.grpQuickActions);
            this.Controls.Add(this.tblCards);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTrong)).EndInit();
            this.pnlTableToolbar.ResumeLayout(false);
            this.pnlTableToolbar.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
