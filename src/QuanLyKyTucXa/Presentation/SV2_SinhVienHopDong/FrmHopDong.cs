using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyKyTucXa.Application;
using QuanLyKyTucXa.Domain;

namespace QuanLyKyTucXa.Presentation.SV2_SinhVienHopDong
{
    // test
    public partial class FrmHopDong : Form
    {
        private readonly DataContext _context;
        private readonly HopDongService _hopDongService;
        private bool _isBinding = false;
        private bool _dangLocSinhVien = false;

        private class ComboBoxItem
        {
            public string Value { get; set; }
            public string Text { get; set; }
            public override string ToString() => Text;
        }

        public FrmHopDong()
        {
            InitializeComponent();
        }

        public FrmHopDong(DataContext context) : this()
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _hopDongService = new HopDongService(_context);
        }

        private void FrmHopDong_Load(object sender, EventArgs e)
        {
            InitControls();
            LoadSinhVienComboBox();
            LoadPhongComboBox();
            LoadPhongFilter();
            LoadData();
            ResetForm();
        }

        private void InitControls()
        {
            cboLocTrangThai.SelectedIndex = 0;

            dtpNgayBatDau.Value = DateTime.Today;
            dtpNgayKetThuc.Value = DateTime.Today.AddMonths(5);
            nudTienDatCoc.Value = 500000;

            btnTaoHD.Click += BtnTaoHD_Click;
            btnGiaHan.Click += BtnGiaHan_Click;
            btnThanhLy.Click += BtnThanhLy_Click;
            btnLamMoi.Click += BtnLamMoi_Click;
            btnHienThiTatCa.Click += BtnHienThiTatCa_Click;

            txtTimKiem.TextChanged += TxtTimKiem_TextChanged;
            cboLocTrangThai.SelectedIndexChanged += CboLoc_SelectedIndexChanged;
            cboLocPhong.SelectedIndexChanged += CboLoc_SelectedIndexChanged;

            // Cho phép gõ tên hoặc mã sinh viên để lọc nhanh danh sách trong combobox
            cboSinhVien.TextUpdate += CboSinhVien_TextUpdate;
            cboSinhVien.SelectedIndexChanged += CboSinhVien_SelectedIndexChanged;
            cboSinhVien.Leave += CboSinhVien_Leave;

            dgvHopDong.SelectionChanged += DgvHopDong_SelectionChanged;
            dgvHopDong.CellClick += DgvHopDong_CellClick;
            dgvHopDong.CellFormatting += DgvHopDong_CellFormatting;

            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            dgvHopDong.AutoGenerateColumns = false;
            dgvHopDong.Columns.Clear();

            dgvHopDong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(HopDong.MaHopDong),
                HeaderText = "Mã HĐ",
                Width = 90
            });

            dgvHopDong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(HopDong.MaSV),
                HeaderText = "Mã SV",
                Width = 80
            });

            // Hai cột dưới đây không bind trực tiếp vì HopDong chỉ lưu Mã SV;
            // dữ liệu được điền trong sự kiện CellFormatting.
            dgvHopDong.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSinhVien",
                HeaderText = "Sinh viên",
                Width = 150
            });

            dgvHopDong.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colLop",
                HeaderText = "Lớp",
                Width = 90
            });

            dgvHopDong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(HopDong.MaPhong),
                HeaderText = "Phòng",
                Width = 75
            });

            dgvHopDong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(HopDong.NgayBatDau),
                HeaderText = "Ngày bắt đầu",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" },
                Width = 100
            });

            dgvHopDong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(HopDong.NgayKetThuc),
                HeaderText = "Ngày kết thúc",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" },
                Width = 100
            });

            dgvHopDong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(HopDong.TienDatCoc),
                HeaderText = "Tiền cọc (VNĐ)",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "#,##0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                },
                Width = 115
            });

            dgvHopDong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(HopDong.TrangThai),
                HeaderText = "Trạng thái",
                Width = 95
            });

            dgvHopDong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(HopDong.GhiChu),
                HeaderText = "Ghi chú",
                Width = 150
            });
        }

        private void LoadSinhVienComboBox(string keyword = null)
        {
            if (_context?.DanhSachSinhVien == null) return;

            bool dangLocTruocDo = _dangLocSinhVien;
            _dangLocSinhVien = true;
            try
            {
                string kw = HopDongService.ChuanHoaTimKiem(keyword);

                // Tập hợp sinh viên đang có hợp đồng hiệu lực (tính một lần cho nhanh)
                var sinhVienDaCoHopDong = new HashSet<string>(
                    _context.DanhSachHopDong
                        .Where(h => h.TrangThai == "Hiệu lực")
                        .Select(h => h.MaSV),
                    StringComparer.OrdinalIgnoreCase);

                cboSinhVien.BeginUpdate();
                cboSinhVien.Items.Clear();
                foreach (var sv in _context.DanhSachSinhVien)
                {
                    if (kw.Length > 0 &&
                        !HopDongService.ChuanHoaTimKiem(sv.MaSV).Contains(kw) &&
                        !HopDongService.ChuanHoaTimKiem(sv.HoTen).Contains(kw) &&
                        !HopDongService.ChuanHoaTimKiem(sv.Lop).Contains(kw))
                    {
                        continue;
                    }

                    string tag = sinhVienDaCoHopDong.Contains(sv.MaSV) ? " [Đã có phòng]" : " [Chưa thuê]";
                    cboSinhVien.Items.Add(new ComboBoxItem
                    {
                        Value = sv.MaSV,
                        Text = $"{sv.HoTen} ({sv.MaSV}) - {sv.Lop}{tag}"
                    });
                }
                cboSinhVien.EndUpdate();
            }
            finally
            {
                _dangLocSinhVien = dangLocTruocDo;
            }
        }

        private void LoadPhongComboBox(string includeMaPhong = null, string gioiTinh = null)
        {
            if (_context?.DanhSachPhong == null) return;

            string gt = HopDongService.ChuanHoaGioiTinh(gioiTinh);

            cboPhong.BeginUpdate();
            cboPhong.Items.Clear();

            foreach (var p in _context.DanhSachPhong)
            {
                bool conCho = p.SoChoHienTai < p.SoChoToiDa && p.TrangThai != "Đang sửa chữa";
                bool cuaHopDongDangXem = !string.IsNullOrEmpty(includeMaPhong) &&
                                         p.MaPhong.Equals(includeMaPhong, StringComparison.OrdinalIgnoreCase);

                // Chỉ nạp phòng còn chỗ hoặc phòng của hợp đồng đang xem
                if (!conCho && !cuaHopDongDangXem) continue;

                // Nam chỉ ở phòng Nam, Nữ chỉ ở phòng Nữ
                if (gt.Length > 0 && !cuaHopDongDangXem &&
                    HopDongService.ChuanHoaGioiTinh(p.LoaiPhong) != gt)
                {
                    continue;
                }

                int choTrong = Math.Max(0, p.SoChoToiDa - p.SoChoHienTai);
                cboPhong.Items.Add(new ComboBoxItem
                {
                    Value = p.MaPhong,
                    Text = $"{p.TenPhong} ({p.MaPhong}) - {p.LoaiPhong} [Trống: {choTrong}/{p.SoChoToiDa}]"
                });
            }

            cboPhong.EndUpdate();

            if (!string.IsNullOrEmpty(includeMaPhong))
            {
                ChonPhongTrongCombo(includeMaPhong);
            }
        }

        private void LoadPhongFilter()
        {
            if (_context?.DanhSachPhong == null) return;

            string selected = cboLocPhong.SelectedItem?.ToString();
            cboLocPhong.Items.Clear();
            cboLocPhong.Items.Add("Tất cả");

            foreach (var p in _context.DanhSachPhong)
            {
                cboLocPhong.Items.Add(p.MaPhong);
            }

            if (!string.IsNullOrEmpty(selected) && cboLocPhong.Items.Contains(selected))
            {
                cboLocPhong.SelectedItem = selected;
            }
            else
            {
                cboLocPhong.SelectedIndex = 0;
            }
        }

        private void LoadData()
        {
            if (_hopDongService == null) return;

            var list = ApplyFilters();
            _isBinding = true;
            try
            {
                dgvHopDong.DataSource = null;
                dgvHopDong.DataSource = list;

                // Không tự chọn dòng đầu tiên để phần thông tin hợp đồng không bị điền lại
                dgvHopDong.ClearSelection();
                if (dgvHopDong.CurrentRow != null)
                {
                    dgvHopDong.CurrentCell = null;
                }
            }
            finally
            {
                _isBinding = false;
            }

            int countHieuLuc = _hopDongService.GetAllHopDong().Count(h => h.TrangThai == "Hiệu lực");
            lblTongSo.Text = $"Tổng số: {list.Count} hợp đồng ({countHieuLuc} hợp đồng đang có hiệu lực)";
        }

        private List<HopDong> ApplyFilters()
        {
            var result = _hopDongService.GetAllHopDong();

            string keyword = txtTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                result = _hopDongService.TimKiemHopDong(keyword);
            }

            string trangThai = cboLocTrangThai.SelectedItem?.ToString();
            string maPhong = cboLocPhong.SelectedItem?.ToString();

            if ((!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả") ||
                (!string.IsNullOrEmpty(maPhong) && maPhong != "Tất cả"))
            {
                result = result.Where(h =>
                    (string.IsNullOrEmpty(trangThai) || trangThai == "Tất cả" || (h.TrangThai != null && h.TrangThai.Equals(trangThai, StringComparison.OrdinalIgnoreCase))) &&
                    (string.IsNullOrEmpty(maPhong) || maPhong == "Tất cả" || (h.MaPhong != null && h.MaPhong.Equals(maPhong, StringComparison.OrdinalIgnoreCase)))
                ).ToList();
            }

            return result;
        }

        private void DgvHopDong_SelectionChanged(object sender, EventArgs e)
        {
            if (_isBinding) return;
            SyncSelectionToForm();
        }

        private void DgvHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SyncSelectionToForm();
            }
        }

        private void DgvHopDong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (!(dgvHopDong.Rows[e.RowIndex].DataBoundItem is HopDong hd)) return;

            string tenCot = dgvHopDong.Columns[e.ColumnIndex].Name;
            if (tenCot == "colSinhVien")
            {
                var sv = _hopDongService?.GetSinhVienById(hd.MaSV);
                e.Value = sv?.HoTen ?? "(Không tìm thấy)";
                e.FormattingApplied = true;
            }
            else if (tenCot == "colLop")
            {
                var sv = _hopDongService?.GetSinhVienById(hd.MaSV);
                e.Value = sv?.Lop ?? string.Empty;
                e.FormattingApplied = true;
            }
        }

        private void CboSinhVien_TextUpdate(object sender, EventArgs e)
        {
            if (_isBinding || _dangLocSinhVien) return;

            // Khi chọn một dòng trong dropdown, ComboBox có thể phát sinh TextUpdate;
            // bỏ qua để không lọc nhầm theo toàn bộ nội dung dòng đã chọn.
            if (cboSinhVien.SelectedItem is ComboBoxItem daChon && cboSinhVien.Text == daChon.Text)
            {
                return;
            }

            string keyword = cboSinhVien.Text;
            LoadSinhVienComboBox(keyword);

            _dangLocSinhVien = true;
            try
            {
                cboSinhVien.Text = keyword;
                cboSinhVien.SelectionStart = keyword.Length;
            }
            finally
            {
                _dangLocSinhVien = false;
            }

            // Khi đang gõ tìm kiếm thì chưa xác định sinh viên -> hiển thị toàn bộ phòng
            if (!(cboSinhVien.SelectedItem is ComboBoxItem))
            {
                LoadPhongComboBox(null, null);
            }

            if (cboSinhVien.Items.Count > 0 && cboSinhVien.Focused)
            {
                cboSinhVien.DroppedDown = true;
            }
        }

        private void CboSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isBinding || _dangLocSinhVien) return;

            var sv = GetSelectedSinhVien();
            LoadPhongComboBox(null, sv?.GioiTinh);
        }

        private void CboSinhVien_Leave(object sender, EventArgs e)
        {
            if (_isBinding || _dangLocSinhVien) return;
            if (cboSinhVien.SelectedItem is ComboBoxItem) return;

            string text = cboSinhVien.Text.Trim();
            if (text.Length == 0)
            {
                LoadPhongComboBox(null, null);
                return;
            }

            var sv = TimSinhVienTheoChuoi(text);
            if (sv != null)
            {
                LoadSinhVienComboBox();
                ChonSinhVienTrongCombo(sv.MaSV);
            }
            else
            {
                LoadPhongComboBox(null, null);
            }
        }

        private SinhVien GetSelectedSinhVien()
        {
            if (cboSinhVien.SelectedItem is ComboBoxItem item)
            {
                return _hopDongService?.GetSinhVienById(item.Value);
            }

            return TimSinhVienTheoChuoi(cboSinhVien.Text);
        }

        private SinhVien TimSinhVienTheoChuoi(string text)
        {
            if (_context?.DanhSachSinhVien == null || string.IsNullOrWhiteSpace(text)) return null;

            string value = text.Trim();

            // Ưu tiên khớp chính xác theo mã sinh viên
            var theoMa = _context.DanhSachSinhVien
                .FirstOrDefault(s => string.Equals(s.MaSV, value, StringComparison.OrdinalIgnoreCase));
            if (theoMa != null) return theoMa;

            // Sau đó khớp chính xác theo họ tên (không phân biệt dấu, hoa thường)
            string chuanHoa = HopDongService.ChuanHoaTimKiem(value);
            var theoTen = _context.DanhSachSinhVien
                .Where(s => HopDongService.ChuanHoaTimKiem(s.HoTen) == chuanHoa)
                .ToList();

            return theoTen.Count == 1 ? theoTen[0] : null;
        }

        private void ChonSinhVienTrongCombo(string maSV)
        {
            for (int i = 0; i < cboSinhVien.Items.Count; i++)
            {
                if (cboSinhVien.Items[i] is ComboBoxItem item &&
                    item.Value.Equals(maSV, StringComparison.OrdinalIgnoreCase))
                {
                    cboSinhVien.SelectedIndex = i;
                    return;
                }
            }
        }

        private void ChonPhongTrongCombo(string maPhong)
        {
            for (int i = 0; i < cboPhong.Items.Count; i++)
            {
                if (cboPhong.Items[i] is ComboBoxItem item &&
                    item.Value.Equals(maPhong, StringComparison.OrdinalIgnoreCase))
                {
                    cboPhong.SelectedIndex = i;
                    return;
                }
            }
        }

        private void SyncSelectionToForm()
        {
            if (!(dgvHopDong.CurrentRow?.DataBoundItem is HopDong hd)) return;

            bool dangBindingTruocDo = _isBinding;
            _isBinding = true;
            try
            {
                txtMaHD.Text = hd.MaHopDong;
                txtMaHD.ReadOnly = true;
                txtMaHD.BackColor = Color.FromArgb(245, 245, 245);

                // Nạp lại danh sách sinh viên đầy đủ rồi chọn đúng sinh viên của hợp đồng
                LoadSinhVienComboBox();
                ChonSinhVienTrongCombo(hd.MaSV);

                // Chỉ đổ xuống các phòng phù hợp với giới tính của sinh viên
                var sv = GetSelectedSinhVien();
                LoadPhongComboBox(hd.MaPhong, sv?.GioiTinh);

                dtpNgayBatDau.Value = hd.NgayBatDau;
                dtpNgayKetThuc.Value = hd.NgayKetThuc;
                nudTienDatCoc.Value = hd.TienDatCoc;
                cboTrangThai.SelectedItem = hd.TrangThai ?? "Hiệu lực";
                txtGhiChu.Text = hd.GhiChu;
            }
            finally
            {
                _isBinding = dangBindingTruocDo;
            }
        }

        /// <summary>
        /// Làm mới: tự sinh mã hợp đồng mới, xóa trắng các thông tin còn lại và bỏ chọn dòng trong danh sách.
        /// </summary>
        private void ResetForm()
        {
            bool dangBindingTruocDo = _isBinding;
            _isBinding = true;
            try
            {
                txtMaHD.ReadOnly = false;
                txtMaHD.BackColor = Color.White;
                txtMaHD.Text = _hopDongService?.SinhMaHopDongTuDong() ?? string.Empty;

                LoadSinhVienComboBox();
                cboSinhVien.SelectedIndex = -1;
                cboSinhVien.Text = string.Empty;

                LoadPhongComboBox(null, null);
                cboPhong.SelectedIndex = -1;
                cboPhong.Text = string.Empty;

                dtpNgayBatDau.Value = DateTime.Today;
                dtpNgayKetThuc.Value = DateTime.Today.AddMonths(5);
                nudTienDatCoc.Value = nudTienDatCoc.Minimum;
                cboTrangThai.SelectedIndex = -1;
                txtGhiChu.Clear();

                dgvHopDong.ClearSelection();
                if (dgvHopDong.CurrentRow != null)
                {
                    dgvHopDong.CurrentCell = null;
                }
            }
            finally
            {
                _isBinding = dangBindingTruocDo;
            }

            txtMaHD.Focus();
        }

        private void BtnTaoHD_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text.Trim();
            if (string.IsNullOrWhiteSpace(maHD))
            {
                MessageBox.Show("Mã hợp đồng không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHD.Focus();
                return;
            }

            var sv = GetSelectedSinhVien();
            if (sv == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn sinh viên cần lập hợp đồng!\n" +
                    "Gợi ý: gõ tên hoặc mã sinh viên vào ô 'Sinh viên' để tìm nhanh.",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSinhVien.Focus();
                return;
            }

            // Hiển thị đúng sinh viên đã chọn trong combobox (không làm mất phòng đã chọn)
            if (!(cboSinhVien.SelectedItem is ComboBoxItem))
            {
                bool dangBindingTruocDo = _isBinding;
                _isBinding = true;
                try
                {
                    ChonSinhVienTrongCombo(sv.MaSV);
                }
                finally
                {
                    _isBinding = dangBindingTruocDo;
                }
            }

            if (!(cboPhong.SelectedItem is ComboBoxItem phongItem))
            {
                MessageBox.Show(
                    $"Sinh viên '{sv.HoTen}' là {sv.GioiTinh}. Vui lòng chọn phòng dành cho {sv.GioiTinh}!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPhong.Focus();
                return;
            }

            var phong = _context.DanhSachPhong
                .FirstOrDefault(p => p.MaPhong.Equals(phongItem.Value, StringComparison.OrdinalIgnoreCase));

            if (phong != null && !HopDongService.KiemTraGioiTinhPhuHop(sv, phong))
            {
                MessageBox.Show(
                    $"Sinh viên '{sv.HoTen} ({sv.MaSV})' là {(HopDongService.ChuanHoaGioiTinh(sv.GioiTinh) == "nu" ? "Nữ" : "Nam")}, " +
                    $"không thể xếp vào phòng '{phong.TenPhong}' dành cho {phong.LoaiPhong}.\n" +
                    $"Vui lòng chọn phòng dành cho {(HopDongService.ChuanHoaGioiTinh(sv.GioiTinh) == "nu" ? "Nữ" : "Nam")}!",
                    "Sai giới tính phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPhong.Focus();
                return;
            }

            if (dtpNgayKetThuc.Value <= dtpNgayBatDau.Value)
            {
                MessageBox.Show("Ngày kết thúc hợp đồng phải sau ngày bắt đầu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var hd = new HopDong(
                maHD,
                sv.MaSV,
                phongItem.Value,
                dtpNgayBatDau.Value,
                dtpNgayKetThuc.Value,
                nudTienDatCoc.Value,
                "Hiệu lực",
                txtGhiChu.Text.Trim()
            );

            if (_hopDongService.TaoHopDong(hd, out string error))
            {
                MessageBox.Show(
                    $"Tạo hợp đồng '{maHD}' thành công!\n" +
                    $"- Sinh viên: {sv.HoTen} ({sv.MaSV})\n" +
                    $"- Phòng: {phongItem.Value}\n" +
                    $"- Sĩ số phòng đã được tự động cập nhật.",
                    "Thông báo thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadPhongFilter();
                LoadData();
                ResetForm();
            }
            else
            {
                MessageBox.Show(error, "Lỗi tạo hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGiaHan_Click(object sender, EventArgs e)
        {
            if (!(dgvHopDong.CurrentRow?.DataBoundItem is HopDong hd))
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần gia hạn trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (hd.TrangThai != "Hiệu lực")
            {
                MessageBox.Show($"Chỉ có thể gia hạn hợp đồng đang 'Hiệu lực'! (Hợp đồng này hiện có trạng thái: {hd.TrangThai})", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime ngayMoi = dtpNgayKetThuc.Value;
            if (ngayMoi <= hd.NgayKetThuc)
            {
                MessageBox.Show(
                    $"Để gia hạn, vui lòng chọn 'Ngày kết thúc' mới trên form lớn hơn ngày kết thúc hiện tại ({hd.NgayKetThuc:dd/MM/yyyy})!",
                    "Yêu cầu chọn thời hạn mới",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                dtpNgayKetThuc.Focus();
                return;
            }

            var confirm = MessageBox.Show(
                $"Xác nhận gia hạn hợp đồng '{hd.MaHopDong}' cho sinh viên '{hd.MaSV}' đến ngày {ngayMoi:dd/MM/yyyy}?",
                "Xác nhận gia hạn",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                if (_hopDongService.GiaHanHopDong(hd.MaHopDong, ngayMoi, out string error))
                {
                    MessageBox.Show($"Đã gia hạn hợp đồng '{hd.MaHopDong}' thành công đến ngày {ngayMoi:dd/MM/yyyy}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show(error, "Lỗi gia hạn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnThanhLy_Click(object sender, EventArgs e)
        {
            if (!(dgvHopDong.CurrentRow?.DataBoundItem is HopDong hd))
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần thanh lý trong bảng danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (hd.TrangThai == "Đã thanh lý")
            {
                MessageBox.Show("Hợp đồng này đã được thanh lý trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn THANH LÝ hợp đồng '{hd.MaHopDong}' không?\n" +
                $"- Sinh viên: {hd.MaSV}\n" +
                $"- Phòng: {hd.MaPhong}\n" +
                $"Sau khi thanh lý, chỗ ở trong phòng {hd.MaPhong} sẽ được tự động giải phóng và mở lại trạng thái 'Còn chỗ'.",
                "Xác nhận thanh lý hợp đồng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                if (_hopDongService.ThanhLyHopDong(hd.MaHopDong, out string error))
                {
                    MessageBox.Show(
                        $"Đã thanh lý hợp đồng '{hd.MaHopDong}' thành công!\nChỗ ở phòng '{hd.MaPhong}' đã được hoàn trả.",
                        "Thông báo thanh lý",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadPhongFilter();
                    LoadData();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show(error, "Lỗi thanh lý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            // Nạp lại danh sách mới nhất rồi xóa trắng phần thông tin hợp đồng
            LoadData();
            ResetForm();
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void CboLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnHienThiTatCa_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cboLocTrangThai.SelectedIndex = 0;
            cboLocPhong.SelectedIndex = 0;
            LoadData();
        }
    }
}
