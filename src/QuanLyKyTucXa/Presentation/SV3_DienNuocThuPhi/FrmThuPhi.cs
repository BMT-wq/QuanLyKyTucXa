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
        private bool _isBinding = false;

        private class ComboBoxItemPhong
        {
            public string MaPhong { get; set; }
            public string TenPhong { get; set; }
            public int SoChoHienTai { get; set; }
            public int SoChoToiDa { get; set; }
            public override string ToString() => $"{MaPhong} - {TenPhong} ({SoChoHienTai}/{SoChoToiDa} người)";
        }

        public FrmThuPhi()
        {
            InitializeComponent();
            _context = new DataContext();
            _thuPhiService = new ThuPhiService(_context);
            InitCustomEvents();
        }

        public FrmThuPhi(DataContext context) : this()
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _thuPhiService = new ThuPhiService(_context);
        }

        private void InitCustomEvents()
        {
            this.btnThem.Click += BtnThem_Click;
            this.btnSua.Click += BtnSua_Click;
            this.btnXoa.Click += BtnXoa_Click;
            this.btnLamMoi.Click += BtnLamMoi_Click;
            this.btnThongKe.Click += BtnThongKe_Click;
            this.btnTraPhong.Click += BtnTraPhong_Click;
            this.btnThuPhiHDMoi.Click += BtnThuPhiHDMoi_Click;
            this.dgvThuPhi.CellClick += DgvThuPhi_CellClick;
            this.txtTimPhong.TextChanged += TxtTimPhong_TextChanged;
            this.btnHienThiTatCa.Click += BtnHienThiTatCa_Click;
            this.cboPhong.SelectedIndexChanged += CboPhong_SelectedIndexChanged;
            this.Load += FrmThuPhi_Load;
        }

        private void FrmThuPhi_Load(object sender, EventArgs e)
        {
            if (cboLoaiPhi.Items.Count == 0)
            {
                cboLoaiPhi.Items.AddRange(new object[] { "Tiền phòng", "Điện nước", "Tiền đặt cọc", "Hoàn tiền cọc", "Phí gửi xe", "Phí khác" });
            }
            if (cboLoaiPhi.SelectedIndex < 0 && cboLoaiPhi.Items.Count > 0)
            {
                cboLoaiPhi.SelectedIndex = 0;
            }

            LoadPhongComboBox();
            LoadDataToGrid();
        }

        private void LoadPhongComboBox()
        {
            if (_thuPhiService == null) return;

            _isBinding = true;
            cboPhong.Items.Clear();

            var phongList = _thuPhiService.GetAllPhong();
            foreach (var p in phongList)
            {
                int soNguoi = _thuPhiService.GetSoNguoiDangOPhong(p.MaPhong);
                cboPhong.Items.Add(new ComboBoxItemPhong
                {
                    MaPhong = p.MaPhong,
                    TenPhong = p.TenPhong,
                    SoChoHienTai = soNguoi,
                    SoChoToiDa = p.SoChoToiDa
                });
            }

            _isBinding = false;

            if (cboPhong.Items.Count > 0)
            {
                cboPhong.SelectedIndex = 0;
            }
        }

        private void CboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isBinding || !(cboPhong.SelectedItem is ComboBoxItemPhong item)) return;

            txtMaPhong.Text = item.MaPhong;

            // Nếu loại phí là Tiền phòng thì tự động gợi ý giá phòng
            var p = _thuPhiService.GetPhongById(item.MaPhong);
            if (p != null && cboLoaiPhi.SelectedItem?.ToString() == "Tiền phòng")
            {
                txtSoTien.Text = p.GiaPhong.ToString("0");
            }
        }

        private void LoadDataToGrid(string filterMaPhong = null)
        {
            try
            {
                var list = _thuPhiService.GetAllThuPhi();

                if (!string.IsNullOrWhiteSpace(filterMaPhong))
                {
                    string kw = filterMaPhong.Trim().ToLower();
                    list = list.Where(t => (t.MaPhong != null && t.MaPhong.ToLower().Contains(kw)) ||
                                          (t.MaHopDong != null && t.MaHopDong.ToLower().Contains(kw)) ||
                                          (t.MaPhieuThu != null && t.MaPhieuThu.ToLower().Contains(kw))).ToList();
                }

                dgvThuPhi.DataSource = null;
                dgvThuPhi.DataSource = list;

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

        private void TxtTimPhong_TextChanged(object sender, EventArgs e)
        {
            LoadDataToGrid(txtTimPhong.Text);
        }

        private void BtnHienThiTatCa_Click(object sender, EventArgs e)
        {
            txtTimPhong.Clear();
            LoadDataToGrid();
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
                    MessageBox.Show("Vui lòng chọn phòng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboPhong.Focus();
                    return;
                }

                if (!decimal.TryParse(txtSoTien.Text.Trim(), out decimal soTien) || soTien <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số tiền hợp lệ lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoTien.Focus();
                    return;
                }

                string maPhieuThu = _thuPhiService.SinhMaPhieuThuTuDong();

                // Lấy mã hợp đồng hiệu lực của phòng nếu có
                var dsHD = _thuPhiService.GetDanhSachHopDongHieuLucCuaPhong(maPhong);
                string maHopDong = dsHD.Count > 0 ? dsHD[0].MaHopDong : "HD_" + maPhong;

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
            txtSoTien.Clear();
            txtGhiChu.Clear();
            cboLoaiPhi.SelectedIndex = 0;
            dtpNgayThu.Value = DateTime.Now;

            if (cboPhong.Items.Count > 0)
            {
                cboPhong.SelectedIndex = 0;
            }
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

                // Đồng bộ cboPhong
                _isBinding = true;
                for (int i = 0; i < cboPhong.Items.Count; i++)
                {
                    if (cboPhong.Items[i] is ComboBoxItemPhong item && item.MaPhong.Equals(tp.MaPhong, StringComparison.OrdinalIgnoreCase))
                    {
                        cboPhong.SelectedIndex = i;
                        break;
                    }
                }
                _isBinding = false;
            }
        }

        /// <summary>
        /// Mở Form Quyết toán trả phòng & Trả cọc
        /// </summary>
        private void BtnTraPhong_Click(object sender, EventArgs e)
        {
            try
            {
                using (var frm = new FrmQuyetToanTraPhong(_context))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadPhongComboBox();
                        LoadDataToGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mở form quyết toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Nghiệp vụ: Ghi đồng hồ bàn giao & lập phiếu thu tiền cọc theo ngày hợp đồng
        /// </summary>
        private void BtnThuPhiHDMoi_Click(object sender, EventArgs e)
        {
            try
            {
                var dsHD = _context.DanhSachHopDong
                    .Where(h => h.TrangThai.Equals("Hiệu lực", StringComparison.OrdinalIgnoreCase))
                    .ToList();

                if (dsHD.Count == 0)
                {
                    MessageBox.Show("Hiện không có hợp đồng hiệu lực nào trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (Form dlg = new Form())
                {
                    dlg.Text = "Ghi nhận đồng hồ ban đầu & Thu cọc HĐ mới";
                    dlg.Size = new Size(540, 320);
                    dlg.StartPosition = FormStartPosition.CenterParent;
                    dlg.FormBorderStyle = FormBorderStyle.FixedDialog;
                    dlg.MaximizeBox = false;
                    dlg.MinimizeBox = false;
                    dlg.BackColor = Color.White;

                    Label lblHD = new Label { Text = "Chọn hợp đồng:", Location = new Point(20, 25), AutoSize = true, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold) };
                    ComboBox cboHD = new ComboBox { Location = new Point(170, 22), Size = new Size(330, 28), DropDownStyle = ComboBoxStyle.DropDownList, Font = new Font("Segoe UI", 9.5F) };

                    foreach (var h in dsHD)
                    {
                        var sv = _thuPhiService.GetSinhVienById(h.MaSV);
                        string ten = sv != null ? sv.HoTen : h.MaSV;
                        cboHD.Items.Add(new { Text = $"[{h.MaHopDong}] {ten} - Phòng {h.MaPhong} ({h.NgayBatDau:dd/MM/yyyy})", Value = h.MaHopDong });
                    }
                    cboHD.DisplayMember = "Text";
                    cboHD.ValueMember = "Value";
                    if (cboHD.Items.Count > 0) cboHD.SelectedIndex = 0;

                    Label lblDien = new Label { Text = "Điện ban đầu (kWh):", Location = new Point(20, 75), AutoSize = true, Font = new Font("Segoe UI", 9.5F) };
                    TextBox txtDienDau = new TextBox { Location = new Point(170, 72), Size = new Size(150, 28), Text = "0", Font = new Font("Segoe UI", 9.5F) };

                    Label lblNuoc = new Label { Text = "Nước ban đầu (m³):", Location = new Point(20, 125), AutoSize = true, Font = new Font("Segoe UI", 9.5F) };
                    TextBox txtNuocDau = new TextBox { Location = new Point(170, 122), Size = new Size(150, 28), Text = "0", Font = new Font("Segoe UI", 9.5F) };

                    Label lblNote = new Label
                    {
                        Text = "ℹ️ Hệ thống sẽ tự động lập phiếu thu tiền cọc vào đúng ngày ký HĐ và lưu mốc đồng hồ.",
                        Location = new Point(20, 170),
                        Size = new Size(480, 40),
                        ForeColor = Color.DimGray,
                        Font = new Font("Segoe UI", 8.5F, FontStyle.Italic)
                    };

                    Button btnSave = new Button
                    {
                        Text = "Lưu & Lập thu phí",
                        Location = new Point(170, 220),
                        Size = new Size(170, 38),
                        BackColor = Color.FromArgb(0, 122, 204),
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Segoe UI", 9.5F, FontStyle.Bold)
                    };

                    Button btnHuy = new Button
                    {
                        Text = "Hủy",
                        Location = new Point(360, 220),
                        Size = new Size(100, 38),
                        BackColor = Color.FromArgb(108, 117, 125),
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Segoe UI", 9.5F, FontStyle.Bold)
                    };

                    btnSave.Click += (s, ev) =>
                    {
                        dynamic selectedItem = cboHD.SelectedItem;
                        string maHD = selectedItem.Value;
                        int.TryParse(txtDienDau.Text.Trim(), out int dDau);
                        int.TryParse(txtNuocDau.Text.Trim(), out int nDau);

                        if (_thuPhiService.LapThuPhiBanDauHopDong(maHD, dDau, nDau, "Admin", out string err))
                        {
                            var hdItem = _thuPhiService.GetHopDongById(maHD);
                            MessageBox.Show(
                                $"Đã ghi nhận mốc đồng hồ thành công cho HĐ '{maHD}'!\n" +
                                $"- Phòng: {hdItem.MaPhong}\n" +
                                $"- Đồng hồ bàn giao: Điện {dDau} kWh, Nước {nDau} m³\n" +
                                $"- Phiếu thu tiền cọc ({hdItem.TienDatCoc:N0} đ) đã được tự động lập vào ngày {hdItem.NgayBatDau:dd/MM/yyyy}.",
                                "Thành công",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            dlg.DialogResult = DialogResult.OK;
                            dlg.Close();
                        }
                        else
                        {
                            MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    };

                    btnHuy.Click += (s, ev) => dlg.Close();

                    dlg.Controls.AddRange(new Control[] { lblHD, cboHD, lblDien, txtDienDau, lblNuoc, txtNuocDau, lblNote, btnSave, btnHuy });

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        LoadDataToGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
