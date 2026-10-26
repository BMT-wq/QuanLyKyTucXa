using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using QuanLyKyTucXa.Application;
using QuanLyKyTucXa.Domain;

namespace QuanLyKyTucXa.Presentation.SV1_PhongToaNha
{
    public partial class FrmPhong : Form
    {
        private readonly DataContext _context;
        private readonly PhongService _phongService;

        public FrmPhong()
        {
            InitializeComponent();
        }

        public FrmPhong(DataContext context) : this()
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _phongService = new PhongService(_context);
        }

        #region Load & Refresh
        private void FrmPhong_Load(object sender, EventArgs e)
        {
            LoadComboToaNha();
            LoadComboLocToaNha();
            LoadData();
            ClearInputs();
        }

        /// <summary>
        /// Nạp danh sách tòa nhà vào ComboBox nhập liệu.
        /// </summary>
        private void LoadComboToaNha()
        {
            if (_phongService == null) return;

            var danhSach = _phongService.GetAllToaNha();
            cboToaNha.DataSource = null;
            cboToaNha.DisplayMember = "TenToaNha";
            cboToaNha.ValueMember = "MaToaNha";
            cboToaNha.DataSource = new List<ToaNha>(danhSach);

            if (cboToaNha.Items.Count > 0)
                cboToaNha.SelectedIndex = 0;
        }

        /// <summary>
        /// Nạp danh sách tòa nhà vào ComboBox bộ lọc (có thêm tùy chọn "Tất cả").
        /// </summary>
        private void LoadComboLocToaNha()
        {
            if (_phongService == null) return;

            var danhSach = new List<ToaNha>();
            danhSach.Add(new ToaNha("", "-- Tất cả tòa nhà --", 0));
            danhSach.AddRange(_phongService.GetAllToaNha());

            cboLocToaNha.DataSource = null;
            cboLocToaNha.DisplayMember = "TenToaNha";
            cboLocToaNha.ValueMember = "MaToaNha";
            cboLocToaNha.DataSource = danhSach;
            cboLocToaNha.SelectedIndex = 0;
        }

        /// <summary>
        /// Nạp danh sách phòng lên DataGridView (áp dụng bộ lọc hiện tại).
        /// </summary>
        private void LoadData()
        {
            if (_phongService == null) return;

            var list = ApplyFilters();
            dgvPhong.DataSource = null;
            dgvPhong.DataSource = list;

            FormatColumns();
            lblTrangThaiBar.Text = $"Hiển thị: {list.Count} phòng  |  Tổng: {_phongService.GetAllPhong().Count} phòng";
        }

        /// <summary>
        /// Đặt tên cột tiếng Việt và ẩn cột không cần thiết.
        /// </summary>
        private void FormatColumns()
        {
            if (dgvPhong.Columns.Count == 0) return;

            if (dgvPhong.Columns["MaPhong"] != null) dgvPhong.Columns["MaPhong"].HeaderText = "Mã Phòng";
            if (dgvPhong.Columns["TenPhong"] != null) dgvPhong.Columns["TenPhong"].HeaderText = "Tên Phòng";
            if (dgvPhong.Columns["MaToaNha"] != null) dgvPhong.Columns["MaToaNha"].HeaderText = "Tòa Nhà";
            if (dgvPhong.Columns["LoaiPhong"] != null) dgvPhong.Columns["LoaiPhong"].HeaderText = "Loại";
            if (dgvPhong.Columns["SoChoToiDa"] != null) dgvPhong.Columns["SoChoToiDa"].HeaderText = "Sức Chứa";
            if (dgvPhong.Columns["SoChoHienTai"] != null) dgvPhong.Columns["SoChoHienTai"].HeaderText = "Đang Ở";
            if (dgvPhong.Columns["SoChoTrong"] != null) dgvPhong.Columns["SoChoTrong"].HeaderText = "Chỗ Trống";
            if (dgvPhong.Columns["GiaPhong"] != null)
            {
                dgvPhong.Columns["GiaPhong"].HeaderText = "Giá Phòng (VNĐ)";
                dgvPhong.Columns["GiaPhong"].DefaultCellStyle.Format = "N0";
                dgvPhong.Columns["GiaPhong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgvPhong.Columns["TrangThai"] != null) dgvPhong.Columns["TrangThai"].HeaderText = "Trạng Thái";
        }
        #endregion

        #region Bộ lọc & Tìm kiếm
        /// <summary>
        /// Áp dụng bộ lọc tòa nhà, phòng còn chỗ, và từ khóa tìm kiếm.
        /// </summary>
        private List<Phong> ApplyFilters()
        {
            // Bắt đầu với toàn bộ danh sách
            IEnumerable<Phong> query = _phongService.GetAllPhong();

            // Lọc theo tòa nhà
            string maToaNhaLoc = cboLocToaNha.SelectedValue?.ToString() ?? "";
            if (!string.IsNullOrEmpty(maToaNhaLoc))
            {
                query = query.Where(p => p.MaToaNha.Equals(maToaNhaLoc, StringComparison.OrdinalIgnoreCase));
            }

            // Lọc phòng còn chỗ
            if (chkConCho.Checked)
            {
                query = query.Where(p => p.SoChoHienTai < p.SoChoToiDa && p.TrangThai != "Đang sửa chữa");
            }

            // Tìm kiếm theo mã hoặc tên phòng
            string keyword = txtTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(p =>
                    p.MaPhong.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    p.TenPhong.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0
                );
            }

            return query.ToList();
        }

        private void cboLocToaNha_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void chkConCho_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // Tìm kiếm realtime khi gõ
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion

        #region Thao tác trên DataGridView
        /// <summary>
        /// Khi click chọn dòng trên bảng, đổ dữ liệu lên form nhập.
        /// </summary>
        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvPhong.Rows.Count) return;

            DataGridViewRow row = dgvPhong.Rows[e.RowIndex];

            txtMaPhong.Text = row.Cells["MaPhong"].Value?.ToString() ?? "";
            txtTenPhong.Text = row.Cells["TenPhong"].Value?.ToString() ?? "";

            // Chọn tòa nhà tương ứng trong ComboBox
            string maToaNha = row.Cells["MaToaNha"].Value?.ToString() ?? "";
            for (int i = 0; i < cboToaNha.Items.Count; i++)
            {
                var item = cboToaNha.Items[i] as ToaNha;
                if (item != null && item.MaToaNha.Equals(maToaNha, StringComparison.OrdinalIgnoreCase))
                {
                    cboToaNha.SelectedIndex = i;
                    break;
                }
            }

            // Chọn loại phòng
            string loaiPhong = row.Cells["LoaiPhong"].Value?.ToString() ?? "Nam";
            cboLoaiPhong.SelectedItem = loaiPhong;

            // Số chỗ tối đa
            int soChoToiDa = Convert.ToInt32(row.Cells["SoChoToiDa"].Value ?? 4);
            nudSoChoToiDa.Value = Math.Max(nudSoChoToiDa.Minimum, Math.Min(nudSoChoToiDa.Maximum, soChoToiDa));

            // Giá phòng
            txtGiaPhong.Text = row.Cells["GiaPhong"].Value?.ToString() ?? "0";

            // Trạng thái
            string trangThai = row.Cells["TrangThai"].Value?.ToString() ?? "Còn chỗ";
            cboTrangThai.SelectedItem = trangThai;

            // Khóa ô mã phòng (không cho sửa khóa chính)
            txtMaPhong.ReadOnly = true;
            txtMaPhong.BackColor = Color.FromArgb(230, 230, 230);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        #endregion

        #region Validation
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtMaPhong.Text))
            {
                ShowWarning("Mã phòng không được để trống!");
                txtMaPhong.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenPhong.Text))
            {
                ShowWarning("Tên phòng không được để trống!");
                txtTenPhong.Focus();
                return false;
            }

            if (cboToaNha.SelectedValue == null || string.IsNullOrEmpty(cboToaNha.SelectedValue.ToString()))
            {
                ShowWarning("Vui lòng chọn tòa nhà!");
                cboToaNha.Focus();
                return false;
            }

            if (nudSoChoToiDa.Value <= 0)
            {
                ShowWarning("Sức chứa tối đa phải lớn hơn 0!");
                nudSoChoToiDa.Focus();
                return false;
            }

            // Kiểm tra giá phòng
            decimal giaPhong;
            if (!decimal.TryParse(txtGiaPhong.Text.Trim(), NumberStyles.Any, CultureInfo.CurrentCulture, out giaPhong) || giaPhong < 0)
            {
                ShowWarning("Giá phòng phải là số hợp lệ và không âm!");
                txtGiaPhong.Focus();
                return false;
            }

            return true;
        }
        #endregion

        #region Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            decimal giaPhong = decimal.Parse(txtGiaPhong.Text.Trim(), NumberStyles.Any, CultureInfo.CurrentCulture);

            var phong = new Phong(
                txtMaPhong.Text.Trim(),
                txtTenPhong.Text.Trim(),
                cboToaNha.SelectedValue.ToString(),
                cboLoaiPhong.SelectedItem.ToString(),
                (int)nudSoChoToiDa.Value,
                0, // Phòng mới -> chưa có ai ở
                giaPhong,
                cboTrangThai.SelectedItem.ToString()
            );

            string error;
            if (_phongService.ThemPhong(phong, out error))
            {
                LoadData();
                ClearInputs();
                lblTrangThaiBar.Text = $"✔ Đã thêm phòng '{phong.TenPhong}' thành công.";
                ShowInfo($"Thêm phòng '{phong.TenPhong}' thành công!");
            }
            else
            {
                ShowWarning(error);
            }
        }
        #endregion

        #region Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            if (dgvPhong.CurrentRow == null)
            {
                ShowWarning("Vui lòng chọn một phòng trên bảng để sửa!");
                return;
            }

            decimal giaPhong = decimal.Parse(txtGiaPhong.Text.Trim(), NumberStyles.Any, CultureInfo.CurrentCulture);

            var phong = new Phong(
                txtMaPhong.Text.Trim(),
                txtTenPhong.Text.Trim(),
                cboToaNha.SelectedValue.ToString(),
                cboLoaiPhong.SelectedItem.ToString(),
                (int)nudSoChoToiDa.Value,
                0, // SoChoHienTai không được sửa trực tiếp từ form này
                giaPhong,
                cboTrangThai.SelectedItem.ToString()
            );

            string error;
            if (_phongService.CapNhatPhong(phong, out error))
            {
                LoadData();
                ClearInputs();
                lblTrangThaiBar.Text = $"✔ Đã cập nhật phòng '{phong.TenPhong}' thành công.";
                ShowInfo($"Cập nhật phòng '{phong.TenPhong}' thành công!");
            }
            else
            {
                ShowWarning(error);
            }
        }
        #endregion

        #region Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhong.CurrentRow == null || string.IsNullOrWhiteSpace(txtMaPhong.Text))
            {
                ShowWarning("Vui lòng chọn một phòng trên bảng để xóa!");
                return;
            }

            string ma = txtMaPhong.Text.Trim();
            string ten = txtTenPhong.Text.Trim();

            var confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa phòng '{ten}' (Mã: {ma})?\n\nThao tác này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes) return;

            string error;
            if (_phongService.XoaPhong(ma, out error))
            {
                LoadData();
                ClearInputs();
                lblTrangThaiBar.Text = $"✔ Đã xóa phòng '{ten}' thành công.";
                ShowInfo($"Đã xóa phòng '{ten}' thành công!");
            }
            else
            {
                ShowWarning(error);
            }
        }
        #endregion

        #region Nút Làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadComboToaNha();
            LoadComboLocToaNha();
            LoadData();
            lblTrangThaiBar.Text = "Đã làm mới dữ liệu.";
        }
        #endregion

        #region Helpers
        /// <summary>
        /// Xóa trắng toàn bộ ô nhập liệu và khôi phục trạng thái mặc định.
        /// </summary>
        private void ClearInputs()
        {
            txtMaPhong.Text = string.Empty;
            txtTenPhong.Text = string.Empty;
            if (cboToaNha.Items.Count > 0) cboToaNha.SelectedIndex = 0;
            cboLoaiPhong.SelectedIndex = 0;
            nudSoChoToiDa.Value = 4;
            txtGiaPhong.Text = "0";
            cboTrangThai.SelectedIndex = 0;

            txtMaPhong.ReadOnly = false;
            txtMaPhong.BackColor = Color.White;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaPhong.Focus();

            dgvPhong.ClearSelection();
        }

        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowInfo(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
