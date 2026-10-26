using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyKyTucXa.Application;
using QuanLyKyTucXa.Domain;

namespace QuanLyKyTucXa.Presentation.SV2_SinhVienHopDong
{
    public partial class FrmHopDong : Form
    {
        private readonly DataContext _context;
        private readonly HopDongService _hopDongService;
        private bool _isBinding = false;

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
            cboTrangThai.SelectedIndex = 0;
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

            dgvHopDong.SelectionChanged += DgvHopDong_SelectionChanged;
            dgvHopDong.CellClick += DgvHopDong_CellClick;

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
                Width = 90
            });

            dgvHopDong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(HopDong.MaPhong),
                HeaderText = "Phòng",
                Width = 85
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

        private void LoadSinhVienComboBox()
        {
            if (_context?.DanhSachSinhVien == null) return;

            cboSinhVien.Items.Clear();
            foreach (var sv in _context.DanhSachSinhVien)
            {
                bool daCoHD = _hopDongService.KiemTraSinhVienCoHopDongHieuLuc(sv.MaSV);
                string tag = daCoHD ? " [Đã có phòng]" : " [Chưa thuê]";
                cboSinhVien.Items.Add(new ComboBoxItem
                {
                    Value = sv.MaSV,
                    Text = $"{sv.HoTen} ({sv.MaSV}) - {sv.Lop}{tag}"
                });
            }

            if (cboSinhVien.Items.Count > 0)
            {
                cboSinhVien.SelectedIndex = 0;
            }
        }

        private void LoadPhongComboBox(string includeMaPhong = null)
        {
            if (_context?.DanhSachPhong == null) return;

            cboPhong.Items.Clear();
            var phongList = _context.DanhSachPhong;

            foreach (var p in phongList)
            {
                // Chỉ nạp phòng còn chỗ hoặc phòng của hợp đồng đang xem
                if (p.SoChoHienTai < p.SoChoToiDa || p.MaPhong.Equals(includeMaPhong, StringComparison.OrdinalIgnoreCase))
                {
                    int choTrong = Math.Max(0, p.SoChoToiDa - p.SoChoHienTai);
                    cboPhong.Items.Add(new ComboBoxItem
                    {
                        Value = p.MaPhong,
                        Text = $"{p.TenPhong} ({p.MaPhong}) - {p.LoaiPhong} [Trống: {choTrong}/{p.SoChoToiDa}]"
                    });
                }
            }

            if (cboPhong.Items.Count > 0)
            {
                cboPhong.SelectedIndex = 0;
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
            dgvHopDong.DataSource = null;
            dgvHopDong.DataSource = list;
            _isBinding = false;

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

        private void SyncSelectionToForm()
        {
            if (dgvHopDong.CurrentRow?.DataBoundItem is HopDong hd)
            {
                txtMaHD.Text = hd.MaHopDong;
                txtMaHD.ReadOnly = true;
                txtMaHD.BackColor = Color.FromArgb(245, 245, 245);

                // Nạp lại cboPhong để đảm bảo hiển thị đúng phòng của HĐ này
                LoadPhongComboBox(hd.MaPhong);

                // Chọn sinh viên
                for (int i = 0; i < cboSinhVien.Items.Count; i++)
                {
                    if (cboSinhVien.Items[i] is ComboBoxItem item && item.Value.Equals(hd.MaSV, StringComparison.OrdinalIgnoreCase))
                    {
                        cboSinhVien.SelectedIndex = i;
                        break;
                    }
                }

                // Chọn phòng
                for (int i = 0; i < cboPhong.Items.Count; i++)
                {
                    if (cboPhong.Items[i] is ComboBoxItem item && item.Value.Equals(hd.MaPhong, StringComparison.OrdinalIgnoreCase))
                    {
                        cboPhong.SelectedIndex = i;
                        break;
                    }
                }

                dtpNgayBatDau.Value = hd.NgayBatDau;
                dtpNgayKetThuc.Value = hd.NgayKetThuc;
                nudTienDatCoc.Value = hd.TienDatCoc;
                cboTrangThai.SelectedItem = hd.TrangThai ?? "Hiệu lực";
                txtGhiChu.Text = hd.GhiChu;
            }
        }

        private void ResetForm()
        {
            txtMaHD.ReadOnly = false;
            txtMaHD.BackColor = Color.White;
            txtMaHD.Text = _hopDongService?.SinhMaHopDongTuDong() ?? "HD001";

            LoadSinhVienComboBox();
            LoadPhongComboBox();

            dtpNgayBatDau.Value = DateTime.Today;
            dtpNgayKetThuc.Value = DateTime.Today.AddMonths(5);
            nudTienDatCoc.Value = 500000;
            cboTrangThai.SelectedItem = "Hiệu lực";
            txtGhiChu.Clear();

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

            if (!(cboSinhVien.SelectedItem is ComboBoxItem svItem))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần lập hợp đồng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!(cboPhong.SelectedItem is ComboBoxItem phongItem))
            {
                MessageBox.Show("Vui lòng chọn phòng ký túc xá cho sinh viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpNgayKetThuc.Value <= dtpNgayBatDau.Value)
            {
                MessageBox.Show("Ngày kết thúc hợp đồng phải sau ngày bắt đầu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var hd = new HopDong(
                maHD,
                svItem.Value,
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
                    $"- Sinh viên: {svItem.Text}\n" +
                    $"- Phòng: {phongItem.Value}\n" +
                    $"- Sĩ số phòng đã được tự động cập nhật.",
                    "Thông báo thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadSinhVienComboBox();
                LoadPhongComboBox();
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

                    LoadSinhVienComboBox();
                    LoadPhongComboBox();
                    LoadPhongFilter();
                    LoadData();
                }
                else
                {
                    MessageBox.Show(error, "Lỗi thanh lý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
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
