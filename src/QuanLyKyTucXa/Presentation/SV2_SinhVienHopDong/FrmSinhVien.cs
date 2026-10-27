using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyKyTucXa.Application;
using QuanLyKyTucXa.Domain;

namespace QuanLyKyTucXa.Presentation.SV2_SinhVienHopDong
{
    public partial class FrmSinhVien : Form
    {
        private readonly DataContext _context;
        private readonly HopDongService _hopDongService;
        private bool _isBinding = false;

        public FrmSinhVien()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public FrmSinhVien(DataContext context) : this()
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _hopDongService = new HopDongService(_context);
        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            InitControls();
            LoadKhoaFilter();
            LoadData();
            ResetForm();
        }

        private void InitControls()
        {
            cboGioiTinh.SelectedIndex = 0;
            cboLocGioiTinh.SelectedIndex = 0;

            // Đăng ký sự kiện
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLamMoi.Click += BtnLamMoi_Click;
            btnHienThiTatCa.Click += BtnHienThiTatCa_Click;

            txtTimKiem.TextChanged += TxtTimKiem_TextChanged;
            cboLocKhoa.SelectedIndexChanged += CboLoc_SelectedIndexChanged;
            cboLocGioiTinh.SelectedIndexChanged += CboLoc_SelectedIndexChanged;

            dgvSinhVien.SelectionChanged += DgvSinhVien_SelectionChanged;
            dgvSinhVien.CellClick += DgvSinhVien_CellClick;

            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            dgvSinhVien.AutoGenerateColumns = false;
            dgvSinhVien.Columns.Clear();

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(SinhVien.MaSV),
                HeaderText = "Mã SV",
                Width = 85
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(SinhVien.HoTen),
                HeaderText = "Họ và tên",
                Width = 150
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(SinhVien.GioiTinh),
                HeaderText = "Giới tính",
                Width = 80
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(SinhVien.NgaySinh),
                HeaderText = "Ngày sinh",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" },
                Width = 95
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(SinhVien.Lop),
                HeaderText = "Lớp",
                Width = 90
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(SinhVien.Khoa),
                HeaderText = "Khoa",
                Width = 140
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(SinhVien.SoDienThoai),
                HeaderText = "Điện thoại",
                Width = 100
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(SinhVien.Email),
                HeaderText = "Email",
                Width = 150
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(SinhVien.SoCMND_CCCD),
                HeaderText = "CCCD/CMND",
                Width = 110
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(SinhVien.QueQuan),
                HeaderText = "Quê quán",
                Width = 120
            });
        }

        private void LoadKhoaFilter()
        {
            if (_hopDongService == null) return;

            string selected = cboLocKhoa.SelectedItem?.ToString();
            cboLocKhoa.Items.Clear();
            cboLocKhoa.Items.Add("Tất cả");

            var dsKhoa = _hopDongService.GetDanhSachKhoa();
            foreach (var k in dsKhoa)
            {
                cboLocKhoa.Items.Add(k);
            }

            if (!string.IsNullOrEmpty(selected) && cboLocKhoa.Items.Contains(selected))
            {
                cboLocKhoa.SelectedItem = selected;
            }
            else
            {
                cboLocKhoa.SelectedIndex = 0;
            }
        }

        private void LoadData()
        {
            if (_hopDongService == null) return;

            var list = ApplyFilters();
            _isBinding = true;
            dgvSinhVien.DataSource = null;
            dgvSinhVien.DataSource = list;
            _isBinding = false;

            lblTongSo.Text = $"Tổng số: {list.Count} sinh viên";
        }

        private List<SinhVien> ApplyFilters()
        {
            var result = _hopDongService.GetAllSinhVien();

            string keyword = txtTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                result = _hopDongService.TimKiemSinhVien(keyword);
            }

            string khoa = cboLocKhoa.SelectedItem?.ToString();
            string gioiTinh = cboLocGioiTinh.SelectedItem?.ToString();

            if ((!string.IsNullOrEmpty(khoa) && khoa != "Tất cả") ||
                (!string.IsNullOrEmpty(gioiTinh) && gioiTinh != "Tất cả"))
            {
                result = result.Where(s =>
                    (string.IsNullOrEmpty(khoa) || khoa == "Tất cả" || (s.Khoa != null && s.Khoa.Equals(khoa, StringComparison.OrdinalIgnoreCase))) &&
                    (string.IsNullOrEmpty(gioiTinh) || gioiTinh == "Tất cả" || (s.GioiTinh != null && s.GioiTinh.Equals(gioiTinh, StringComparison.OrdinalIgnoreCase)))
                ).ToList();
            }

            return result;
        }

        private void DgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (_isBinding) return;
            SyncSelectionToForm();
        }

        private void DgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SyncSelectionToForm();
            }
        }

        private void SyncSelectionToForm()
        {
            if (dgvSinhVien.CurrentRow?.DataBoundItem is SinhVien sv)
            {
                txtMaSV.Text = sv.MaSV;
                txtMaSV.ReadOnly = true;
                txtMaSV.BackColor = Color.FromArgb(245, 245, 245);

                txtHoTen.Text = sv.HoTen;
                dtpNgaySinh.Value = sv.NgaySinh > dtpNgaySinh.MinDate && sv.NgaySinh < dtpNgaySinh.MaxDate ? sv.NgaySinh : DateTime.Today.AddYears(-18);
                cboGioiTinh.SelectedItem = sv.GioiTinh ?? "Nam";
                txtCCCD.Text = sv.SoCMND_CCCD;
                txtDienThoai.Text = sv.SoDienThoai;
                txtEmail.Text = sv.Email;
                txtLop.Text = sv.Lop;
                txtKhoa.Text = sv.Khoa;
                txtQueQuan.Text = sv.QueQuan;
            }
        }

        private void ResetForm()
        {
            txtMaSV.ReadOnly = false;
            txtMaSV.BackColor = Color.White;
            txtMaSV.Text = _hopDongService?.SinhMaSinhVienTuDong() ?? "SV001";
            txtHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Today.AddYears(-18);
            cboGioiTinh.SelectedIndex = 0;
            txtCCCD.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            txtLop.Clear();
            txtKhoa.Clear();
            txtQueQuan.Clear();

            txtHoTen.Focus();
        }

        private bool ValidateInput(out SinhVien sv, out string error)
        {
            sv = null;
            error = string.Empty;

            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string gioiTinh = cboGioiTinh.SelectedItem?.ToString() ?? "Nam";
            DateTime ngaySinh = dtpNgaySinh.Value;
            string cccd = txtCCCD.Text.Trim();
            string sdt = txtDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();
            string lop = txtLop.Text.Trim();
            string khoa = txtKhoa.Text.Trim();
            string queQuan = txtQueQuan.Text.Trim();

            if (!Validator.IsNotEmpty(maSV, "Mã sinh viên", out error)) return false;
            if (!Validator.IsNotEmpty(hoTen, "Họ và tên", out error)) return false;

            if (DateTime.Today.Year - ngaySinh.Year < 15)
            {
                error = "Ngày sinh không hợp lệ (Sinh viên phải từ 15 tuổi trở lên)!";
                return false;
            }

            if (!Validator.IsNotEmpty(cccd, "Số CMND/CCCD", out error)) return false;
            if (!Validator.IsValidCCCD(cccd))
            {
                error = "Số CCCD/CMND không đúng định dạng (phải gồm 9 hoặc 12 chữ số)!";
                return false;
            }

            if (!Validator.IsNotEmpty(sdt, "Số điện thoại", out error)) return false;
            if (!Validator.IsValidPhone(sdt))
            {
                error = "Số điện thoại không đúng định dạng (phải gồm 10 chữ số bắt đầu bằng số 0)!";
                return false;
            }

            if (!string.IsNullOrEmpty(email) && !Validator.IsValidEmail(email))
            {
                error = "Địa chỉ Email không đúng định dạng!";
                return false;
            }

            if (!Validator.IsNotEmpty(lop, "Lớp", out error)) return false;
            if (!Validator.IsNotEmpty(khoa, "Khoa", out error)) return false;

            sv = new SinhVien(maSV, hoTen, ngaySinh, gioiTinh, cccd, sdt, email, lop, khoa, queQuan);
            return true;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out SinhVien sv, out string error))
            {
                MessageBox.Show(error, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_hopDongService.ThemSinhVien(sv, out string serviceError))
            {
                MessageBox.Show($"Đã thêm sinh viên '{sv.HoTen}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhoaFilter();
                LoadData();
                ResetForm();
            }
            else
            {
                MessageBox.Show(serviceError, "Lỗi thêm sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần cập nhật thông tin trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(out SinhVien sv, out string error))
            {
                MessageBox.Show(error, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_hopDongService.CapNhatSinhVien(sv, out string serviceError))
            {
                MessageBox.Show($"Cập nhật thông tin sinh viên '{sv.HoTen}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhoaFilter();
                LoadData();
            }
            else
            {
                MessageBox.Show(serviceError, "Lỗi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow?.DataBoundItem is SinhVien sv)
            {
                var dialogResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa sinh viên '{sv.HoTen}' (Mã: {sv.MaSV}) khỏi hệ thống không?\nThao tác này không thể hoàn tác!",
                    "Xác nhận xóa hồ sơ sinh viên",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (_hopDongService.XoaSinhVien(sv.MaSV, out string error))
                    {
                        MessageBox.Show("Đã xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadKhoaFilter();
                        LoadData();
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show(error, "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa trong bảng danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            cboLocKhoa.SelectedIndex = 0;
            cboLocGioiTinh.SelectedIndex = 0;
            LoadData();
        }
    }
}
