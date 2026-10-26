using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyKyTucXa.Application;
using QuanLyKyTucXa.Domain;

namespace QuanLyKyTucXa.Presentation.SV1_PhongToaNha
{
    public partial class FrmToaNha : Form
    {
        private readonly DataContext _context;
        private readonly PhongService _phongService;

        public FrmToaNha()
        {
            InitializeComponent();
        }

        public FrmToaNha(DataContext context) : this()
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _phongService = new PhongService(_context);
        }

        #region Load & Refresh
        private void FrmToaNha_Load(object sender, EventArgs e)
        {
            LoadData();
            ClearInputs();
        }

        /// <summary>
        /// Nạp danh sách tòa nhà lên DataGridView và cập nhật status bar.
        /// </summary>
        private void LoadData()
        {
            if (_phongService == null) return;

            var list = _phongService.GetAllToaNha();
            dgvToaNha.DataSource = null;
            dgvToaNha.DataSource = list;

            // Đổi tên cột tiếng Việt thân thiện
            if (dgvToaNha.Columns.Count > 0)
            {
                if (dgvToaNha.Columns["MaToaNha"] != null) dgvToaNha.Columns["MaToaNha"].HeaderText = "Mã Tòa Nhà";
                if (dgvToaNha.Columns["TenToaNha"] != null) dgvToaNha.Columns["TenToaNha"].HeaderText = "Tên Tòa Nhà";
                if (dgvToaNha.Columns["SoTang"] != null) dgvToaNha.Columns["SoTang"].HeaderText = "Số Tầng";
                if (dgvToaNha.Columns["GhiChu"] != null) dgvToaNha.Columns["GhiChu"].HeaderText = "Ghi Chú";
            }

            lblTrangThai.Text = $"Tổng cộng: {list.Count} tòa nhà";
        }
        #endregion

        #region Thao tác trên DataGridView
        /// <summary>
        /// Khi click vào 1 dòng trên bảng, đổ dữ liệu lên các ô nhập.
        /// </summary>
        private void dgvToaNha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvToaNha.Rows.Count) return;

            DataGridViewRow row = dgvToaNha.Rows[e.RowIndex];
            txtMaToaNha.Text = row.Cells["MaToaNha"].Value?.ToString() ?? "";
            txtTenToaNha.Text = row.Cells["TenToaNha"].Value?.ToString() ?? "";
            nudSoTang.Value = Convert.ToInt32(row.Cells["SoTang"].Value ?? 1);
            txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString() ?? "";

            // Khi đã chọn một tòa nhà, khóa ô mã (không cho sửa khóa chính)
            txtMaToaNha.ReadOnly = true;
            txtMaToaNha.BackColor = Color.FromArgb(230, 230, 230);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        #endregion

        #region Validation
        /// <summary>
        /// Kiểm tra dữ liệu nhập liệu trước khi thao tác CRUD.
        /// </summary>
        private bool ValidateInputs(bool isNew)
        {
            if (string.IsNullOrWhiteSpace(txtMaToaNha.Text))
            {
                ShowWarning("Mã tòa nhà không được để trống!");
                txtMaToaNha.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenToaNha.Text))
            {
                ShowWarning("Tên tòa nhà không được để trống!");
                txtTenToaNha.Focus();
                return false;
            }

            if (nudSoTang.Value <= 0)
            {
                ShowWarning("Số tầng phải lớn hơn 0!");
                nudSoTang.Focus();
                return false;
            }

            return true;
        }
        #endregion

        #region Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(isNew: true)) return;

            var toaNha = new ToaNha(
                txtMaToaNha.Text.Trim(),
                txtTenToaNha.Text.Trim(),
                (int)nudSoTang.Value,
                txtGhiChu.Text.Trim()
            );

            string error;
            if (_phongService.ThemToaNha(toaNha, out error))
            {
                LoadData();
                ClearInputs();
                lblTrangThai.Text = $"✔ Đã thêm tòa nhà '{toaNha.TenToaNha}' thành công.";
                ShowInfo($"Thêm tòa nhà '{toaNha.TenToaNha}' thành công!");
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
            if (!ValidateInputs(isNew: false)) return;

            if (dgvToaNha.CurrentRow == null)
            {
                ShowWarning("Vui lòng chọn một tòa nhà trên bảng để sửa!");
                return;
            }

            var toaNha = new ToaNha(
                txtMaToaNha.Text.Trim(),
                txtTenToaNha.Text.Trim(),
                (int)nudSoTang.Value,
                txtGhiChu.Text.Trim()
            );

            string error;
            if (_phongService.CapNhatToaNha(toaNha, out error))
            {
                LoadData();
                ClearInputs();
                lblTrangThai.Text = $"✔ Đã cập nhật tòa nhà '{toaNha.TenToaNha}' thành công.";
                ShowInfo($"Cập nhật tòa nhà '{toaNha.TenToaNha}' thành công!");
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
            if (dgvToaNha.CurrentRow == null || string.IsNullOrWhiteSpace(txtMaToaNha.Text))
            {
                ShowWarning("Vui lòng chọn một tòa nhà trên bảng để xóa!");
                return;
            }

            string ma = txtMaToaNha.Text.Trim();
            string ten = txtTenToaNha.Text.Trim();

            var confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa tòa nhà '{ten}' (Mã: {ma})?\n\nThao tác này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes) return;

            string error;
            if (_phongService.XoaToaNha(ma, out error))
            {
                LoadData();
                ClearInputs();
                lblTrangThai.Text = $"✔ Đã xóa tòa nhà '{ten}' thành công.";
                ShowInfo($"Đã xóa tòa nhà '{ten}' thành công!");
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
            LoadData();
            lblTrangThai.Text = "Đã làm mới dữ liệu.";
        }
        #endregion

        #region Helpers
        /// <summary>
        /// Xóa trắng toàn bộ ô nhập liệu và khôi phục trạng thái mặc định.
        /// </summary>
        private void ClearInputs()
        {
            txtMaToaNha.Text = string.Empty;
            txtTenToaNha.Text = string.Empty;
            nudSoTang.Value = 1;
            txtGhiChu.Text = string.Empty;

            txtMaToaNha.ReadOnly = false;
            txtMaToaNha.BackColor = Color.White;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaToaNha.Focus();

            dgvToaNha.ClearSelection();
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
