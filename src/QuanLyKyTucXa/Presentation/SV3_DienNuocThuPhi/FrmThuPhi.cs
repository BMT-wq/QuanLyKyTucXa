using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyKyTucXa.Application;
using QuanLyKyTucXa.Domain;

namespace QuanLyKyTucXa.Presentation.SV3_DienNuocThuPhi
{
    public partial class FrmThuPhi : Form
    {
        private DataContext _context;
        private ThuPhiService _thuPhiService;

        public FrmThuPhi()
        {
            InitializeComponent();
            _context = new DataContext();
            _thuPhiService = new ThuPhiService(_context);
        }

        public FrmThuPhi(DataContext context) : this()
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _thuPhiService = new ThuPhiService(_context);
        }

        private void FrmThuPhi_Load(object sender, EventArgs e)
        {
            if (cboLoaiPhi.Items.Count == 0)
            {
                cboLoaiPhi.Items.AddRange(new object[] { "Tiền phòng", "Điện nước", "Tiền đặt cọc", "Phí gửi xe", "Phí khác" });
            }
            if (cboLoaiPhi.SelectedIndex < 0 && cboLoaiPhi.Items.Count > 0)
            {
                cboLoaiPhi.SelectedIndex = 0;
            }
            LoadDataToGrid();
        }

        private void LoadDataToGrid()
        {
            try
            {
                dgvThuPhi.DataSource = null;
                dgvThuPhi.DataSource = _thuPhiService.GetAllThuPhi();

                if (dgvThuPhi.Columns["MaPhieuThu"] != null)
                {
                    dgvThuPhi.Columns["MaPhieuThu"].HeaderText = "Mã Phiếu Thu";
                    dgvThuPhi.Columns["MaHopDong"].HeaderText = "Mã Hợp Đồng";
                    dgvThuPhi.Columns["MaPhong"].HeaderText = "Mã Phòng";
                    dgvThuPhi.Columns["LoaiPhi"].HeaderText = "Loại Phí";
                    dgvThuPhi.Columns["Thang"].HeaderText = "Tháng";
                    dgvThuPhi.Columns["Nam"].HeaderText = "Năm";
                    dgvThuPhi.Columns["SoTien"].HeaderText = "Số Tiền (VNĐ)";
                    dgvThuPhi.Columns["NgayThu"].HeaderText = "Ngày Thu";
                    dgvThuPhi.Columns["NguoiThu"].HeaderText = "Người Thu";
                    dgvThuPhi.Columns["GhiChu"].HeaderText = "Ghi Chú";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhong = txtMaPhong.Text.Trim();
                string loaiPhi = cboLoaiPhi.SelectedItem?.ToString() ?? cboLoaiPhi.Text.Trim();
                if (string.IsNullOrEmpty(loaiPhi)) loaiPhi = "Tiền phòng";

                if (string.IsNullOrEmpty(maPhong))
                {
                    MessageBox.Show("Vui lòng nhập mã phòng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaPhong.Focus();
                    return;
                }

                if (!decimal.TryParse(txtSoTien.Text.Trim(), out decimal soTien) || soTien <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số tiền hợp lệ lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoTien.Focus();
                    return;
                }

                string maPhieuThu = _thuPhiService.SinhMaPhieuThuTuDong();
                string maHopDong = "HD_" + maPhong;
                int thang = dtpNgayThu.Value.Month;
                int nam = dtpNgayThu.Value.Year;
                DateTime ngayThu = dtpNgayThu.Value;
                string nguoiThu = "Admin";
                string ghiChu = txtGhiChu.Text.Trim();

                ThuPhi tp = new ThuPhi(maPhieuThu, maHopDong, maPhong, loaiPhi, thang, nam, soTien, ngayThu, nguoiThu, ghiChu);

                if (_thuPhiService.LapPhieuThu(tp, out string error))
                {
                    if (loaiPhi.Equals("Điện nước", StringComparison.OrdinalIgnoreCase))
                    {
                        var dn = _thuPhiService.GetAllDienNuoc()
                                               .FirstOrDefault(d => d.MaPhong.Equals(maPhong, StringComparison.OrdinalIgnoreCase) && d.Thang == thang && d.Nam == nam);
                        if (dn != null)
                        {
                            dn.DaThanhToan = true;
                            _context.SaveDienNuoc();
                        }
                    }

                    MessageBox.Show($"Lập phiếu thu thành công! Mã: {maPhieuThu}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataToGrid();
                    BtnLamMoi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lập phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvThuPhi.CurrentRow == null || !(dgvThuPhi.CurrentRow.DataBoundItem is ThuPhi selected))
                {
                    MessageBox.Show("Vui lòng chọn phiếu thu cần sửa trên bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maPhong = txtMaPhong.Text.Trim();
                string loaiPhi = cboLoaiPhi.SelectedItem?.ToString() ?? cboLoaiPhi.Text.Trim();

                if (string.IsNullOrEmpty(maPhong))
                {
                    MessageBox.Show("Mã phòng không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtSoTien.Text.Trim(), out decimal soTien) || soTien <= 0)
                {
                    MessageBox.Show("Số tiền phải lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ThuPhi updated = new ThuPhi(
                    selected.MaPhieuThu,
                    selected.MaHopDong,
                    maPhong,
                    loaiPhi,
                    dtpNgayThu.Value.Month,
                    dtpNgayThu.Value.Year,
                    soTien,
                    dtpNgayThu.Value,
                    selected.NguoiThu,
                    txtGhiChu.Text.Trim()
                );

                if (_thuPhiService.CapNhatPhieuThu(updated, out string error))
                {
                    MessageBox.Show("Cập nhật phiếu thu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataToGrid();
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvThuPhi.CurrentRow != null && dgvThuPhi.CurrentRow.DataBoundItem is ThuPhi tp)
                {
                    var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa phiếu thu '{tp.MaPhieuThu}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        if (_thuPhiService.XoaPhieuThu(tp.MaPhieuThu, out string error))
                        {
                            MessageBox.Show("Xóa phiếu thu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataToGrid();
                            BtnLamMoi_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng cần xóa trên bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaPhong.Clear();
            txtSoTien.Clear();
            txtGhiChu.Clear();
            cboLoaiPhi.SelectedIndex = 0;
            dtpNgayThu.Value = DateTime.Now;
            txtMaPhong.Focus();
        }

        private void BtnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                decimal tongDoanhThu = _thuPhiService.ThongKeDoanhThu();
                var dsNo = _thuPhiService.ThongKeCongNoDienNuoc(out decimal tongNoDienNuoc);

                string msg = $"=== BÁO CÁO THỐNG KÊ DOANH THU & CÔNG NỢ ===\n\n" +
                             $"1. TỔNG THU:\n" +
                             $"   - Tổng số phiếu thu đã lập: {_thuPhiService.GetAllThuPhi().Count} phiếu\n" +
                             $"   - Tổng số tiền đã thu: {tongDoanhThu:N0} VNĐ\n\n" +
                             $"2. CÔNG NỢ ĐIỆN NƯỚC CHƯA THANH TOÁN:\n" +
                             $"   - Số hóa đơn chưa đóng: {dsNo.Count} hóa đơn\n" +
                             $"   - Tổng tiền điện nước còn nợ: {tongNoDienNuoc:N0} VNĐ\n";

                if (dsNo.Count > 0)
                {
                    msg += "   - Danh sách phòng nợ: " + string.Join(", ", dsNo.Select(d => $"{d.MaPhong} (tháng {d.Thang}/{d.Nam}: {d.TongTien:N0}đ)")) + "\n";
                }

                MessageBox.Show(msg, "Thống kê tài chính ký túc xá", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvThuPhi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvThuPhi.Rows[e.RowIndex].DataBoundItem is ThuPhi tp)
            {
                txtMaPhong.Text = tp.MaPhong;
                txtSoTien.Text = tp.SoTien.ToString("0");
                cboLoaiPhi.SelectedItem = tp.LoaiPhi;
                txtGhiChu.Text = tp.GhiChu;
                if (tp.NgayThu != default)
                {
                    dtpNgayThu.Value = tp.NgayThu;
                }
            }
        }
    }
}