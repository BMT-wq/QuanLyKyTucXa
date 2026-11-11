using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyKyTucXa.Application;
using QuanLyKyTucXa.Domain;

namespace QuanLyKyTucXa.Presentation.SV1_PhongToaNha
{
    // Form quản lý danh mục Tòa nhà (CRUD cơ bản).
    public partial class FrmToaNha : Form
    {
        // Ngữ cảnh dữ liệu dùng chung (danh sách đang nạp trong app).
        private readonly DataContext _context;
        // Service xử lý nghiệp vụ liên quan phòng/tòa nhà.
        private readonly PhongService _phongService;

        // Constructor mặc định: khởi tạo control giao diện từ Designer.
        public FrmToaNha()
        {
            InitializeComponent();
        }

        // Constructor nhận DataContext: dùng khi mở form từ luồng chính của ứng dụng.
        public FrmToaNha(DataContext context) : this()
        {
            _context = context ?? throw new ArgumentNullException(nameof(context)); // Chặn context null.
            _phongService = new PhongService(_context); // Tạo service để thao tác dữ liệu tòa nhà.
        }

        #region Load & Refresh
        // Sự kiện form load: nạp dữ liệu lên lưới và reset form nhập.
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
            // Nếu chưa có service (form mở bằng constructor mặc định) thì không làm gì.
            if (_phongService == null) return;

            var list = _phongService.GetAllToaNha(); // Lấy toàn bộ tòa nhà.
            dgvToaNha.DataSource = null;              // Reset binding để lưới refresh đúng.
            dgvToaNha.DataSource = list;              // Gán danh sách mới.

            // Đổi tên cột tiếng Việt thân thiện (chỉ đổi nếu cột tồn tại).
            if (dgvToaNha.Columns.Count > 0)
            {
                if (dgvToaNha.Columns["MaToaNha"] != null) dgvToaNha.Columns["MaToaNha"].HeaderText = "Mã Tòa Nhà";
                if (dgvToaNha.Columns["TenToaNha"] != null) dgvToaNha.Columns["TenToaNha"].HeaderText = "Tên Tòa Nhà";
                if (dgvToaNha.Columns["SoTang"] != null) dgvToaNha.Columns["SoTang"].HeaderText = "Số Tầng";
                if (dgvToaNha.Columns["GhiChu"] != null) dgvToaNha.Columns["GhiChu"].HeaderText = "Ghi Chú";
            }

            // Hiển thị tổng số bản ghi ở thanh trạng thái.
            lblTrangThai.Text = $"Tổng cộng: {list.Count} tòa nhà";
        }
        #endregion

        #region Thao tác trên DataGridView
        /// <summary>
        /// Khi click vào 1 dòng trên bảng, đổ dữ liệu lên các ô nhập.
        /// </summary>
        private void dgvToaNha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bỏ qua click header hoặc chỉ số dòng không hợp lệ.
            if (e.RowIndex < 0 || e.RowIndex >= dgvToaNha.Rows.Count) return;

            DataGridViewRow row = dgvToaNha.Rows[e.RowIndex]; // Dòng đang được chọn.
            // Đổ dữ liệu từng cột lên control nhập (null-safe).
            txtMaToaNha.Text = row.Cells["MaToaNha"].Value?.ToString() ?? "";
            txtTenToaNha.Text = row.Cells["TenToaNha"].Value?.ToString() ?? "";
            nudSoTang.Value = Convert.ToInt32(row.Cells["SoTang"].Value ?? 1);
            txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString() ?? "";

            // Khóa mã tòa nhà (khóa chính) để tránh sửa nhầm khi cập nhật/xóa.
            txtMaToaNha.ReadOnly = true;
            txtMaToaNha.BackColor = Color.FromArgb(230, 230, 230);
            // Cho phép thao tác Sửa/Xóa khi đã chọn bản ghi.
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
            // Bắt buộc nhập mã tòa nhà.
            if (string.IsNullOrWhiteSpace(txtMaToaNha.Text))
            {
                ShowWarning("Mã tòa nhà không được để trống!");
                txtMaToaNha.Focus();
                return false;
            }

            // Bắt buộc nhập tên tòa nhà.
            if (string.IsNullOrWhiteSpace(txtTenToaNha.Text))
            {
                ShowWarning("Tên tòa nhà không được để trống!");
                txtTenToaNha.Focus();
                return false;
            }

            // Số tầng phải hợp lệ (> 0).
            if (nudSoTang.Value <= 0)
            {
                ShowWarning("Số tầng phải lớn hơn 0!");
                nudSoTang.Focus();
                return false;
            }

            return true; // Dữ liệu hợp lệ.
        }
        #endregion

        #region Nút Thêm
        // Xử lý thêm tòa nhà mới.
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(isNew: true)) return; // Dừng nếu dữ liệu không hợp lệ.

            // Tạo đối tượng tòa nhà từ dữ liệu form (đã trim).
            var toaNha = new ToaNha(
                txtMaToaNha.Text.Trim(),
                txtTenToaNha.Text.Trim(),
                (int)nudSoTang.Value,
                txtGhiChu.Text.Trim()
            );

            string error;
            // Gọi service thêm; service trả về false + thông báo nếu lỗi nghiệp vụ (trùng mã...).
            if (_phongService.ThemToaNha(toaNha, out error))
            {
                LoadData();    // Tải lại danh sách.
                ClearInputs(); // Reset form.
                lblTrangThai.Text = $"✔ Đã thêm tòa nhà '{toaNha.TenToaNha}' thành công.";
                ShowInfo($"Thêm tòa nhà '{toaNha.TenToaNha}' thành công!");
            }
            else
            {
                ShowWarning(error); // Hiển thị lỗi nghiệp vụ.
            }
        }
        #endregion

        #region Nút Sửa
        // Xử lý cập nhật tòa nhà đang chọn.
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(isNew: false)) return; // Kiểm tra dữ liệu.

            // Cần có dòng đang chọn trên lưới trước khi sửa.
            if (dgvToaNha.CurrentRow == null)
            {
                ShowWarning("Vui lòng chọn một tòa nhà trên bảng để sửa!");
                return;
            }

            // Tạo object chứa thông tin mới.
            var toaNha = new ToaNha(
                txtMaToaNha.Text.Trim(),
                txtTenToaNha.Text.Trim(),
                (int)nudSoTang.Value,
                txtGhiChu.Text.Trim()
            );

            string error;
            // Gọi service cập nhật theo mã tòa nhà.
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
        // Xử lý xóa tòa nhà đang chọn (có xác nhận).
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Chặn xóa nếu chưa chọn bản ghi hợp lệ.
            if (dgvToaNha.CurrentRow == null || string.IsNullOrWhiteSpace(txtMaToaNha.Text))
            {
                ShowWarning("Vui lòng chọn một tòa nhà trên bảng để xóa!");
                return;
            }

            string ma = txtMaToaNha.Text.Trim();
            string ten = txtTenToaNha.Text.Trim();

            // Hỏi xác nhận trước khi xóa.
            var confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa tòa nhà '{ten}' (Mã: {ma})?\n\nThao tác này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes) return; // Người dùng hủy.

            string error;
            // Gọi service xóa; service có thể chặn nếu còn ràng buộc dữ liệu.
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
        // Làm mới: reset form và tải lại dữ liệu mới nhất.
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
            // Reset giá trị nhập.
            txtMaToaNha.Text = string.Empty;
            txtTenToaNha.Text = string.Empty;
            nudSoTang.Value = 1;
            txtGhiChu.Text = string.Empty;

            // Mở khóa mã để cho phép thêm mới, trả màu nền bình thường.
            txtMaToaNha.ReadOnly = false;
            txtMaToaNha.BackColor = Color.White;
            // Tắt Sửa/Xóa vì chưa chọn bản ghi.
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaToaNha.Focus(); // Đưa con trỏ về ô mã.

            dgvToaNha.ClearSelection(); // Bỏ chọn trên lưới.
        }

        // Hiển thị hộp thoại cảnh báo.
        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Hiển thị hộp thoại thông báo thành công/thông tin.
        private void ShowInfo(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
