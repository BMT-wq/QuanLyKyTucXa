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
    // Form quản lý danh mục Phòng: CRUD + tìm kiếm/lọc.
    public partial class FrmPhong : Form
    {
        // Ngữ cảnh dữ liệu dùng chung của ứng dụng.
        private readonly DataContext _context;
        // Service xử lý nghiệp vụ phòng/tòa nhà.
        private readonly PhongService _phongService;

        // Constructor mặc định: dựng UI từ Designer.
        public FrmPhong()
        {
            InitializeComponent();
        }

        // Constructor nhận DataContext: gán context và khởi tạo service.
        public FrmPhong(DataContext context) : this()
        {
            _context = context ?? throw new ArgumentNullException(nameof(context)); // Bắt buộc có context.
            _phongService = new PhongService(_context);
        }

        #region Load & Refresh
        // Khi form load: nạp combobox tòa nhà, combobox lọc, dữ liệu lưới và reset form.
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
            if (_phongService == null) return; // An toàn nếu chưa có service.

            var danhSach = _phongService.GetAllToaNha();
            cboToaNha.DataSource = null;          // Reset để tránh lỗi bind lại.
            cboToaNha.DisplayMember = "TenToaNha"; // Hiển thị tên tòa nhà.
            cboToaNha.ValueMember = "MaToaNha";    // Giá trị thực là mã tòa nhà.
            cboToaNha.DataSource = new List<ToaNha>(danhSach); // Bind bản sao danh sách.

            if (cboToaNha.Items.Count > 0)
                cboToaNha.SelectedIndex = 0; // Chọn mặc định phần tử đầu.
        }

        /// <summary>
        /// Nạp danh sách tòa nhà vào ComboBox bộ lọc (có thêm tùy chọn "Tất cả").
        /// </summary>
        private void LoadComboLocToaNha()
        {
            if (_phongService == null) return;

            var danhSach = new List<ToaNha>();
            danhSach.Add(new ToaNha("", "-- Tất cả tòa nhà --", 0)); // Mục giả đại diện "tất cả".
            danhSach.AddRange(_phongService.GetAllToaNha());         // Thêm các tòa nhà thực.

            cboLocToaNha.DataSource = null;
            cboLocToaNha.DisplayMember = "TenToaNha";
            cboLocToaNha.ValueMember = "MaToaNha";
            cboLocToaNha.DataSource = danhSach;
            cboLocToaNha.SelectedIndex = 0; // Mặc định lọc tất cả.
        }

        /// <summary>
        /// Nạp danh sách phòng lên DataGridView (áp dụng bộ lọc hiện tại).
        /// </summary>
        private void LoadData()
        {
            if (_phongService == null) return;

            var list = ApplyFilters(); // Lấy danh sách đã qua filter/tìm kiếm.
            dgvPhong.DataSource = null;
            dgvPhong.DataSource = list;

            FormatColumns(); // Định dạng tiêu đề/cột hiển thị.
            // Cập nhật status: số phòng đang hiển thị và tổng số phòng.
            lblTrangThaiBar.Text = $"Hiển thị: {list.Count} phòng  |  Tổng: {_phongService.GetAllPhong().Count} phòng";
        }

        /// <summary>
        /// Đặt tên cột tiếng Việt và ẩn cột không cần thiết.
        /// </summary>
        private void FormatColumns()
        {
            if (dgvPhong.Columns.Count == 0) return;

            // Đổi header sang tiếng Việt cho từng cột nếu có.
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
                dgvPhong.Columns["GiaPhong"].DefaultCellStyle.Format = "N0"; // Định dạng số có phân tách hàng nghìn.
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
            // Bắt đầu với toàn bộ danh sách phòng.
            IEnumerable<Phong> query = _phongService.GetAllPhong();

            // Lọc theo tòa nhà được chọn (bỏ qua nếu chọn "Tất cả" => mã rỗng).
            string maToaNhaLoc = cboLocToaNha.SelectedValue?.ToString() ?? "";
            if (!string.IsNullOrEmpty(maToaNhaLoc))
            {
                query = query.Where(p => p.MaToaNha.Equals(maToaNhaLoc, StringComparison.OrdinalIgnoreCase));
            }

            // Nếu tick "chỉ phòng còn chỗ": còn chỗ trống và không ở trạng thái đang sửa chữa.
            if (chkConCho.Checked)
            {
                query = query.Where(p => p.SoChoHienTai < p.SoChoToiDa && p.TrangThai != "Đang sửa chữa");
            }

            // Tìm kiếm theo mã hoặc tên phòng (không phân biệt hoa thường).
            string keyword = txtTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(p =>
                    p.MaPhong.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    p.TenPhong.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0
                );
            }

            return query.ToList(); // Trả về kết quả sau lọc.
        }

        // Đổi tòa nhà lọc -> tải lại lưới theo filter mới.
        private void cboLocToaNha_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        // Bật/tắt "chỉ phòng còn chỗ" -> tải lại lưới.
        private void chkConCho_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        // Gõ từ khóa -> tìm kiếm realtime bằng cách tải lại lưới.
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // Tìm kiếm realtime khi gõ
            LoadData();
        }

        // Nút tìm kiếm (chức năng tương đương reload theo filter hiện tại).
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
            // Bỏ qua click không hợp lệ.
            if (e.RowIndex < 0 || e.RowIndex >= dgvPhong.Rows.Count) return;

            DataGridViewRow row = dgvPhong.Rows[e.RowIndex];

            // Đổ mã/tên phòng lên textbox.
            txtMaPhong.Text = row.Cells["MaPhong"].Value?.ToString() ?? "";
            txtTenPhong.Text = row.Cells["TenPhong"].Value?.ToString() ?? "";

            // Tìm và chọn tòa nhà tương ứng trong ComboBox nhập liệu theo MaToaNha.
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

            // Chọn loại phòng (Nam/Nữ) theo giá trị dòng.
            string loaiPhong = row.Cells["LoaiPhong"].Value?.ToString() ?? "Nam";
            cboLoaiPhong.SelectedItem = loaiPhong;

            // Đổ sức chứa tối đa, giới hạn trong min/max của NumericUpDown để tránh lỗi.
            int soChoToiDa = Convert.ToInt32(row.Cells["SoChoToiDa"].Value ?? 4);
            nudSoChoToiDa.Value = Math.Max(nudSoChoToiDa.Minimum, Math.Min(nudSoChoToiDa.Maximum, soChoToiDa));

            // Đổ giá phòng (giữ dạng chuỗi từ cell).
            txtGiaPhong.Text = row.Cells["GiaPhong"].Value?.ToString() ?? "0";

            // Chọn trạng thái phòng tương ứng.
            string trangThai = row.Cells["TrangThai"].Value?.ToString() ?? "Còn chỗ";
            cboTrangThai.SelectedItem = trangThai;

            // Khóa mã phòng (khóa chính) khi đang chọn để sửa/xóa.
            txtMaPhong.ReadOnly = true;
            txtMaPhong.BackColor = Color.FromArgb(230, 230, 230);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        #endregion

        #region Validation
        // Kiểm tra dữ liệu nhập trước khi thêm/sửa.
        private bool ValidateInputs()
        {
            // Mã phòng bắt buộc.
            if (string.IsNullOrWhiteSpace(txtMaPhong.Text))
            {
                ShowWarning("Mã phòng không được để trống!");
                txtMaPhong.Focus();
                return false;
            }

            // Tên phòng bắt buộc.
            if (string.IsNullOrWhiteSpace(txtTenPhong.Text))
            {
                ShowWarning("Tên phòng không được để trống!");
                txtTenPhong.Focus();
                return false;
            }

            // Phải chọn tòa nhà hợp lệ.
            if (cboToaNha.SelectedValue == null || string.IsNullOrEmpty(cboToaNha.SelectedValue.ToString()))
            {
                ShowWarning("Vui lòng chọn tòa nhà!");
                cboToaNha.Focus();
                return false;
            }

            // Sức chứa phải > 0.
            if (nudSoChoToiDa.Value <= 0)
            {
                ShowWarning("Sức chứa tối đa phải lớn hơn 0!");
                nudSoChoToiDa.Focus();
                return false;
            }

            // Giá phòng phải parse được theo culture hiện tại và không âm.
            decimal giaPhong;
            if (!decimal.TryParse(txtGiaPhong.Text.Trim(), NumberStyles.Any, CultureInfo.CurrentCulture, out giaPhong) || giaPhong < 0)
            {
                ShowWarning("Giá phòng phải là số hợp lệ và không âm!");
                txtGiaPhong.Focus();
                return false;
            }

            return true; // Hợp lệ.
        }
        #endregion

        #region Nút Thêm
        // Thêm phòng mới.
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            // Parse giá phòng (đã kiểm tra ở ValidateInputs).
            decimal giaPhong = decimal.Parse(txtGiaPhong.Text.Trim(), NumberStyles.Any, CultureInfo.CurrentCulture);

            // Tạo entity Phong; SoChoHienTai = 0 vì phòng mới chưa có ai ở.
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
            // Gọi service thêm; xử lý kết quả/thông báo.
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
        // Cập nhật phòng đang chọn.
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            // Phải có dòng được chọn.
            if (dgvPhong.CurrentRow == null)
            {
                ShowWarning("Vui lòng chọn một phòng trên bảng để sửa!");
                return;
            }

            decimal giaPhong = decimal.Parse(txtGiaPhong.Text.Trim(), NumberStyles.Any, CultureInfo.CurrentCulture);

            // Tạo object cập nhật; SoChoHienTai truyền 0 (service/logic khác không cho sửa trực tiếp từ form này).
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
        // Xóa phòng đang chọn (có xác nhận).
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Chặn nếu chưa chọn phòng.
            if (dgvPhong.CurrentRow == null || string.IsNullOrWhiteSpace(txtMaPhong.Text))
            {
                ShowWarning("Vui lòng chọn một phòng trên bảng để xóa!");
                return;
            }

            string ma = txtMaPhong.Text.Trim();
            string ten = txtTenPhong.Text.Trim();

            // Hộp thoại xác nhận xóa.
            var confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa phòng '{ten}' (Mã: {ma})?\n\nThao tác này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes) return;

            string error;
            // Gọi service xóa phòng.
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
        // Làm mới toàn bộ: reset form, nạp lại combobox và dữ liệu.
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
            // Reset các trường nhập về giá trị mặc định.
            txtMaPhong.Text = string.Empty;
            txtTenPhong.Text = string.Empty;
            if (cboToaNha.Items.Count > 0) cboToaNha.SelectedIndex = 0;
            cboLoaiPhong.SelectedIndex = 0;  // Mặc định loại đầu tiên (thường "Nam").
            nudSoChoToiDa.Value = 4;         // Sức chứa mặc định.
            txtGiaPhong.Text = "0";
            cboTrangThai.SelectedIndex = 0;  // Mặc định trạng thái đầu tiên.

            // Mở khóa mã phòng để chuẩn bị thêm mới.
            txtMaPhong.ReadOnly = false;
            txtMaPhong.BackColor = Color.White;
            // Tắt nút Sửa/Xóa vì chưa chọn bản ghi.
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaPhong.Focus();

            dgvPhong.ClearSelection(); // Bỏ chọn dòng trên lưới.
        }

        // Hiển thị cảnh báo lỗi/validate/nghiệp vụ.
        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Hiển thị thông báo thành công.
        private void ShowInfo(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
