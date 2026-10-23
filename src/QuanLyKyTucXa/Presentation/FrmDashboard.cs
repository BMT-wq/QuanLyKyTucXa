using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using QuanLyKyTucXa.Application;
using QuanLyKyTucXa.Domain;
using QuanLyKyTucXa.Presentation.SV1_PhongToaNha;
using QuanLyKyTucXa.Presentation.SV2_SinhVienHopDong;
using QuanLyKyTucXa.Presentation.SV3_DienNuocThuPhi;

namespace QuanLyKyTucXa.Presentation
{
    public partial class FrmDashboard : Form
    {
        private readonly DataContext _context;
        private readonly Action<Type> _openFormCallback;

        public FrmDashboard()
        {
            InitializeComponent();
        }

        public FrmDashboard(DataContext context, Action<Type> openFormCallback = null) : this()
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _openFormCallback = openFormCallback;
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            RefreshDashboard();
        }

        /// <summary>
        /// Làm mới toàn bộ thẻ thống kê số liệu và bảng danh sách phòng còn chỗ.
        /// </summary>
        public void RefreshDashboard()
        {
            if (_context == null) return;

            // 1. Thống kê Tòa Nhà
            int soToaNha = _context.DanhSachToaNha?.Count ?? 0;
            lblCardToaNhaVal.Text = soToaNha.ToString();
            lblCardToaNhaSub.Text = $"{soToaNha} dãy nhà quản lý";

            // 2. Thống kê Phòng KTX
            var danhSachPhong = _context.DanhSachPhong ?? new List<Phong>();
            int tongPhong = danhSachPhong.Count;
            int phongConCho = danhSachPhong.Count(p => p.SoChoHienTai < p.SoChoToiDa && p.TrangThai != "Đang sửa chữa");
            int phongDay = danhSachPhong.Count(p => p.SoChoHienTai >= p.SoChoToiDa && p.SoChoToiDa > 0);
            lblCardPhongVal.Text = tongPhong.ToString();
            lblCardPhongSub.Text = $"{phongConCho} còn chỗ | {phongDay} đầy";

            // 3. Thống kê Sinh Viên
            int soSinhVien = _context.DanhSachSinhVien?.Count ?? 0;
            lblCardSinhVienVal.Text = soSinhVien.ToString();
            lblCardSinhVienSub.Text = $"{soSinhVien} hồ sơ sinh viên";

            // 4. Thống kê Hợp Đồng
            var danhSachHopDong = _context.DanhSachHopDong ?? new List<HopDong>();
            int hopDongHieuLuc = danhSachHopDong.Count(h => h.TrangThai.Equals("Hiệu lực", StringComparison.OrdinalIgnoreCase));
            lblCardHopDongVal.Text = hopDongHieuLuc.ToString();
            lblCardHopDongSub.Text = $"{hopDongHieuLuc}/{danhSachHopDong.Count} đang hiệu lực";

            // 5. Thống kê Điện Nước
            var danhSachDienNuoc = _context.DanhSachDienNuoc ?? new List<DienNuoc>();
            int chuaThanhToan = danhSachDienNuoc.Count(d => !d.DaThanhToan);
            lblCardDienNuocVal.Text = chuaThanhToan.ToString();
            lblCardDienNuocSub.Text = $"{chuaThanhToan} phòng chưa nộp";

            // 6. Thống kê Thu Phí
            var danhSachThuPhi = _context.DanhSachThuPhi ?? new List<ThuPhi>();
            decimal tongTienThu = danhSachThuPhi.Sum(t => t.SoTien);
            lblCardThuPhiVal.Text = $"{tongTienThu:N0} đ";
            lblCardThuPhiSub.Text = $"{danhSachThuPhi.Count} phiếu đã thu";

            // 7. Nạp bảng phòng còn chỗ
            LoadPhongConChoTable();
        }

        private void LoadPhongConChoTable()
        {
            if (_context?.DanhSachPhong == null) return;

            var listConCho = _context.DanhSachPhong
                .Where(p => p.SoChoHienTai < p.SoChoToiDa && p.TrangThai != "Đang sửa chữa")
                .ToList();

            dgvPhongTrong.DataSource = null;
            dgvPhongTrong.DataSource = listConCho;

            if (dgvPhongTrong.Columns.Count > 0)
            {
                if (dgvPhongTrong.Columns["MaPhong"] != null) dgvPhongTrong.Columns["MaPhong"].HeaderText = "Mã Phòng";
                if (dgvPhongTrong.Columns["TenPhong"] != null) dgvPhongTrong.Columns["TenPhong"].HeaderText = "Tên Phòng";
                if (dgvPhongTrong.Columns["MaToaNha"] != null) dgvPhongTrong.Columns["MaToaNha"].HeaderText = "Mã Tòa";
                if (dgvPhongTrong.Columns["LoaiPhong"] != null) dgvPhongTrong.Columns["LoaiPhong"].HeaderText = "Loại";
                if (dgvPhongTrong.Columns["SoChoToiDa"] != null) dgvPhongTrong.Columns["SoChoToiDa"].HeaderText = "Sức Chứa";
                if (dgvPhongTrong.Columns["SoChoHienTai"] != null) dgvPhongTrong.Columns["SoChoHienTai"].HeaderText = "Đang Ở";
                if (dgvPhongTrong.Columns["SoChoTrong"] != null) dgvPhongTrong.Columns["SoChoTrong"].HeaderText = "Chỗ Trống";
                if (dgvPhongTrong.Columns["GiaPhong"] != null)
                {
                    dgvPhongTrong.Columns["GiaPhong"].HeaderText = "Đơn Giá (VNĐ)";
                    dgvPhongTrong.Columns["GiaPhong"].DefaultCellStyle.Format = "N0";
                    dgvPhongTrong.Columns["GiaPhong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvPhongTrong.Columns["TrangThai"] != null) dgvPhongTrong.Columns["TrangThai"].HeaderText = "Trạng Thái";
            }
        }

        #region Card & Button Event Handlers
        private void pnlCardToaNha_Click(object sender, EventArgs e) => OpenForm(typeof(FrmToaNha));
        private void pnlCardPhong_Click(object sender, EventArgs e) => OpenForm(typeof(FrmPhong));
        private void pnlCardSinhVien_Click(object sender, EventArgs e) => OpenForm(typeof(FrmSinhVien));
        private void pnlCardHopDong_Click(object sender, EventArgs e) => OpenForm(typeof(FrmHopDong));
        private void pnlCardDienNuoc_Click(object sender, EventArgs e) => OpenForm(typeof(FrmDienNuoc));
        private void pnlCardThuPhi_Click(object sender, EventArgs e) => OpenForm(typeof(FrmThuPhi));

        private void btnQuickToaNha_Click(object sender, EventArgs e) => OpenForm(typeof(FrmToaNha));
        private void btnQuickPhong_Click(object sender, EventArgs e) => OpenForm(typeof(FrmPhong));
        private void btnQuickSinhVien_Click(object sender, EventArgs e) => OpenForm(typeof(FrmSinhVien));
        private void btnQuickHopDong_Click(object sender, EventArgs e) => OpenForm(typeof(FrmHopDong));
        private void btnQuickDienNuoc_Click(object sender, EventArgs e) => OpenForm(typeof(FrmDienNuoc));
        private void btnQuickThuPhi_Click(object sender, EventArgs e) => OpenForm(typeof(FrmThuPhi));

        private void btnQuickLuuDuLieu_Click(object sender, EventArgs e)
        {
            try
            {
                _context.SaveAll();
                MessageBox.Show("Đã lưu toàn bộ dữ liệu xuống các file văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuickLamMoi_Click(object sender, EventArgs e)
        {
            RefreshDashboard();
        }

        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            LoadPhongConChoTable();
        }

        private void OpenForm(Type formType)
        {
            _openFormCallback?.Invoke(formType);
        }
        #endregion
    }
}
