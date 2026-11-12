using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyKyTucXa.Application;
using QuanLyKyTucXa.Domain;

namespace QuanLyKyTucXa.Presentation.SV3_DienNuocThuPhi
{
    public partial class FrmDienNuoc : Form
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

        public FrmDienNuoc()
        {
            InitializeComponent();
            _context = new DataContext();
            _thuPhiService = new ThuPhiService(_context);
            InitCustomEvents();
        }

        public FrmDienNuoc(DataContext context) : this()
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _thuPhiService = new ThuPhiService(_context);
        }
        //.
        private void InitCustomEvents()
        {
            this.btnTinhTien.Click += BtnTinhTien_Click;
            this.btnLuu.Click += BtnLuu_Click;
            this.btnSua.Click += BtnSua_Click;
            this.btnXoa.Click += BtnXoa_Click;
            this.btnLamMoi.Click += BtnLamMoi_Click;
            this.btnChiaTien.Click += BtnChiaTien_Click;
            this.btnTraPhong.Click += BtnTraPhong_Click;
            this.btnDongHoHD.Click += BtnDongHoHD_Click;
            this.dgvDienNuoc.CellClick += DgvDienNuoc_CellClick;
            this.txtTimPhong.TextChanged += TxtTimPhong_TextChanged;
            this.btnHienThiTatCa.Click += BtnHienThiTatCa_Click;
            this.cboPhong.SelectedIndexChanged += CboPhong_SelectedIndexChanged;
            this.Load += FrmDienNuoc_Load;
        }

        private void FrmDienNuoc_Load(object sender, EventArgs e)
        {
            txtThangNam.Text = $"{DateTime.Now.Month}/{DateTime.Now.Year}";
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

            // Tự động tìm chỉ số điện nước mới nhất của phòng làm chỉ số cũ
            _thuPhiService.GetChiSoDienNuocMoiNhatCuaPhong(item.MaPhong, out int dienMoi, out int nuocMoi);
            txtDienCu.Text = dienMoi.ToString();
            txtNuocCu.Text = nuocMoi.ToString();
            txtDienMoi.Clear();
            txtNuocMoi.Clear();
        }

        private void LoadDataToGrid(string filterMaPhong = null)
        {
            try
            {
                var list = _thuPhiService.GetAllDienNuoc();

                if (!string.IsNullOrWhiteSpace(filterMaPhong))
                {
                    string kw = filterMaPhong.Trim().ToLower();
                    list = list.Where(d => d.MaPhong != null && d.MaPhong.ToLower().Contains(kw)).ToList();
                }

                dgvDienNuoc.DataSource = null;
                dgvDienNuoc.DataSource = list;

                if (dgvDienNuoc.Columns["MaDienNuoc"] != null)
                {
                    dgvDienNuoc.Columns["MaDienNuoc"].HeaderText = "Mã ĐN";
                    dgvDienNuoc.Columns["MaPhong"].HeaderText = "Mã Phòng";
                    dgvDienNuoc.Columns["Thang"].HeaderText = "Tháng";
                    dgvDienNuoc.Columns["Nam"].HeaderText = "Năm";
                    dgvDienNuoc.Columns["ChiSoDienCu"].HeaderText = "Điện Cũ";
                    dgvDienNuoc.Columns["ChiSoDienMoi"].HeaderText = "Điện Mới";
                    dgvDienNuoc.Columns["ChiSoNuocCu"].HeaderText = "Nước Cũ";
                    dgvDienNuoc.Columns["ChiSoNuocMoi"].HeaderText = "Nước Mới";
                    dgvDienNuoc.Columns["SoDienTieuThu"].HeaderText = "Điện Tiêu Thụ";
                    dgvDienNuoc.Columns["SoNuocTieuThu"].HeaderText = "Nước Tiêu Thụ";
                    dgvDienNuoc.Columns["DonGiaDien"].HeaderText = "Đơn Giá Điện";
                    dgvDienNuoc.Columns["DonGiaNuoc"].HeaderText = "Đơn Giá Nước";
                    dgvDienNuoc.Columns["TongTien"].HeaderText = "Tổng Tiền (VNĐ)";
                    dgvDienNuoc.Columns["DaThanhToan"].HeaderText = "Đã Thanh Toán";
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

        private void BtnTinhTien_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtDienCu.Text.Trim(), out int dienCu) &&
                    int.TryParse(txtDienMoi.Text.Trim(), out int dienMoi) &&
                    int.TryParse(txtNuocCu.Text.Trim(), out int nuocCu) &&
                    int.TryParse(txtNuocMoi.Text.Trim(), out int nuocMoi))
                {
                    if (dienMoi < dienCu)
                    {
                        MessageBox.Show("Chỉ số điện mới không được nhỏ hơn chỉ số cũ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDienMoi.Focus();
                        return;
                    }
                    if (nuocMoi < nuocCu)
                    {
                        MessageBox.Show("Chỉ số nước mới không được nhỏ hơn chỉ số cũ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNuocMoi.Focus();
                        return;
                    }

                    decimal tongTien = _thuPhiService.TinhTongTien(dienCu, dienMoi, nuocCu, nuocMoi, 3000, 15000);
                    int soDien = Math.Max(0, dienMoi - dienCu);
                    int soNuoc = Math.Max(0, nuocMoi - nuocCu);

                    string maPhong = txtMaPhong.Text.Trim();
                    var dsHD = _thuPhiService.GetDanhSachHopDongHieuLucCuaPhong(maPhong);
                    int soSV = dsHD.Count;
                    string chiaTienText = soSV > 0
                        ? $"- Chia đều {soSV} sinh viên đang ở: {tongTien / soSV:N0} đ/người\n"
                        : "- Phòng hiện chưa có sinh viên nào đang ở.\n";

                    MessageBox.Show($"--- TÍNH TOÁN TIỀN ĐIỆN NƯỚC PHÒNG {maPhong} ---\n" +
                                    $"- Điện tiêu thụ: {soDien} kWh x 3.000đ = {soDien * 3000:N0} đ\n" +
                                    $"- Nước tiêu thụ: {soNuoc} m³ x 15.000đ = {soNuoc * 15000:N0} đ\n" +
                                    $"- TỔNG CỘNG: {tongTien:N0} VNĐ\n" +
                                    $"{chiaTienText}",
                        "Kết quả tính toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập các giá trị chỉ số điện nước hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhong = txtMaPhong.Text.Trim();
                if (string.IsNullOrEmpty(maPhong))
                {
                    MessageBox.Show("Vui lòng chọn phòng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboPhong.Focus();
                    return;
                }

                int thang = DateTime.Now.Month;
                int nam = DateTime.Now.Year;
                if (!string.IsNullOrEmpty(txtThangNam.Text.Trim()))
                {
                    string[] parts = txtThangNam.Text.Trim().Split('/');
                    if (parts.Length == 2)
                    {
                        int.TryParse(parts[0], out thang);
                        int.TryParse(parts[1], out nam);
                    }
                }

                int dienCu = int.TryParse(txtDienCu.Text.Trim(), out int dc) ? dc : 0;
                int dienMoi = int.TryParse(txtDienMoi.Text.Trim(), out int dm) ? dm : 0;
                int nuocCu = int.TryParse(txtNuocCu.Text.Trim(), out int nc) ? nc : 0;
                int nuocMoi = int.TryParse(txtNuocMoi.Text.Trim(), out int nm) ? nm : 0;

                string maDN = _thuPhiService.SinhMaDienNuocTuDong(maPhong, thang, nam);

                DienNuoc dn = new DienNuoc(maDN, maPhong, thang, nam, dienCu, dienMoi, nuocCu, nuocMoi, 3000, 15000, 0, false);

                if (_thuPhiService.GhiChiSoDienNuoc(dn, out string error))
                {
                    MessageBox.Show($"Ghi chỉ số điện nước thành công! Mã: {maDN}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDienNuoc.CurrentRow == null || !(dgvDienNuoc.CurrentRow.DataBoundItem is DienNuoc selected))
                {
                    MessageBox.Show("Vui lòng chọn bản ghi cần sửa trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maPhong = txtMaPhong.Text.Trim();
                if (string.IsNullOrEmpty(maPhong))
                {
                    MessageBox.Show("Mã phòng không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int thang = selected.Thang;
                int nam = selected.Nam;
                if (!string.IsNullOrEmpty(txtThangNam.Text.Trim()))
                {
                    string[] parts = txtThangNam.Text.Trim().Split('/');
                    if (parts.Length == 2)
                    {
                        int.TryParse(parts[0], out thang);
                        int.TryParse(parts[1], out nam);
                    }
                }

                int dienCu = int.TryParse(txtDienCu.Text.Trim(), out int dc) ? dc : 0;
                int dienMoi = int.TryParse(txtDienMoi.Text.Trim(), out int dm) ? dm : 0;
                int nuocCu = int.TryParse(txtNuocCu.Text.Trim(), out int nc) ? nc : 0;
                int nuocMoi = int.TryParse(txtNuocMoi.Text.Trim(), out int nm) ? nm : 0;

                DienNuoc updated = new DienNuoc(selected.MaDienNuoc, maPhong, thang, nam, dienCu, dienMoi, nuocCu, nuocMoi, selected.DonGiaDien, selected.DonGiaNuoc, 0, selected.DaThanhToan);

                if (_thuPhiService.CapNhatChiSoDienNuoc(updated, out string error))
                {
                    MessageBox.Show("Cập nhật chỉ số điện nước thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (dgvDienNuoc.CurrentRow == null || !(dgvDienNuoc.CurrentRow.DataBoundItem is DienNuoc selected))
                {
                    MessageBox.Show("Vui lòng chọn bản ghi cần xóa trên bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa bản ghi '{selected.MaDienNuoc}' của phòng '{selected.MaPhong}' không?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    if (_thuPhiService.XoaChiSoDienNuoc(selected.MaDienNuoc, out string error))
                    {
                        MessageBox.Show("Xóa bản ghi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataToGrid();
                        BtnLamMoi_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            txtDienCu.Clear();
            txtDienMoi.Clear();
            txtNuocCu.Clear();
            txtNuocMoi.Clear();
            txtThangNam.Text = $"{DateTime.Now.Month}/{DateTime.Now.Year}";

            if (cboPhong.Items.Count > 0)
            {
                cboPhong.SelectedIndex = 0;
            }
        }

        private void DgvDienNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDienNuoc.Rows[e.RowIndex].DataBoundItem is DienNuoc dn)
            {
                txtMaPhong.Text = dn.MaPhong;
                txtThangNam.Text = $"{dn.Thang}/{dn.Nam}";
                txtDienCu.Text = dn.ChiSoDienCu.ToString();
                txtDienMoi.Text = dn.ChiSoDienMoi.ToString();
                txtNuocCu.Text = dn.ChiSoNuocCu.ToString();
                txtNuocMoi.Text = dn.ChiSoNuocMoi.ToString();

                // Đồng bộ cboPhong
                _isBinding = true;
                for (int i = 0; i < cboPhong.Items.Count; i++)
                {
                    if (cboPhong.Items[i] is ComboBoxItemPhong item && item.MaPhong.Equals(dn.MaPhong, StringComparison.OrdinalIgnoreCase))
                    {
                        cboPhong.SelectedIndex = i;
                        break;
                    }
                }
                _isBinding = false;
            }
        }

        /// <summary>
        /// Nghiệp vụ: Chia tiền điện nước đều cho các sinh viên trong phòng & Tự động tạo phiếu thu.
        /// </summary>
        private void BtnChiaTien_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDienNuoc.CurrentRow == null || !(dgvDienNuoc.CurrentRow.DataBoundItem is DienNuoc selected))
                {
                    MessageBox.Show("Vui lòng chọn một hóa đơn điện nước trên bảng để chia tiền đều cho sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!_thuPhiService.TinhChiaTienDienNuoc(selected.MaDienNuoc, out int soSV, out decimal tienMoiSV, out var dsHD, out string thongTin))
                {
                    MessageBox.Show(thongTin, "Lỗi tính chia tiền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (soSV == 0)
                {
                    MessageBox.Show($"Phòng '{selected.MaPhong}' hiện không có sinh viên nào có hợp đồng 'Hiệu lực'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string dsSVText = "";
                int idx = 1;
                foreach (var hd in dsHD)
                {
                    var sv = _thuPhiService.GetSinhVienById(hd.MaSV);
                    string ten = sv != null ? sv.HoTen : hd.MaSV;
                    dsSVText += $"  {idx++}. {ten} ({hd.MaSV}) - HĐ: {hd.MaHopDong} -> {tienMoiSV:N0} đ\n";
                }

                string msg = $"=== CHI TIẾT CHIA TIỀN ĐIỆN NƯỚC ĐỀU CHO SINH VIÊN ===\n\n" +
                             $"- Hóa đơn: {selected.MaDienNuoc} (Tháng {selected.Thang}/{selected.Nam})\n" +
                             $"- Phòng: {selected.MaPhong}\n" +
                             $"- Tổng tiền hóa đơn: {selected.TongTien:N0} VNĐ\n" +
                             $"- Sĩ số sinh viên đang ở: {soSV} người\n" +
                             $"- Số tiền chia đều: {tienMoiSV:N0} VNĐ / sinh viên\n\n" +
                             $"Danh sách sinh viên nộp:\n{dsSVText}\n" +
                             $"Bạn có muốn TỰ ĐỘNG LẬP PHIẾU THU điện nước cho {soSV} sinh viên này ngay bây giờ không?";

                var confirm = MessageBox.Show(msg, "Xác nhận lập phiếu thu chia đều", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    if (_thuPhiService.LapPhieuThuChiaDeuDienNuoc(selected.MaDienNuoc, "Admin", out string err))
                    {
                        MessageBox.Show($"Đã lập thành công {soSV} phiếu thu điện nước cho các sinh viên phòng {selected.MaPhong}!\nHóa đơn '{selected.MaDienNuoc}' đã được đánh dấu Đã Thanh Toán.",
                            "Lập phiếu thu thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataToGrid();
                    }
                    else
                    {
                        MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// Chọn đúng hợp đồng khi người dùng gõ mã SV thay vì chọn trong danh sách.
        /// </summary>
        private static void ChonHopDongTheoText(ComboBox cbo)
        {
            string text = cbo.Text.Trim();
            if (string.IsNullOrEmpty(text)) return;

            for (int i = 0; i < cbo.Items.Count; i++)
            {
                if (cbo.GetItemText(cbo.Items[i]).IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    cbo.SelectedIndex = i;
                    return;
                }
            }
        }

        /// <summary>
        /// Nghiệp vụ: Gắn đồng hồ điện nước với hợp đồng mới & lập thu phí cọc vào ngày bắt đầu HĐ
        /// </summary>
        private void BtnDongHoHD_Click(object sender, EventArgs e)
        {
            try
            {
                var dsHD = _context.DanhSachHopDong
                    .Where(h => h.TrangThai.Equals("Hiệu lực", StringComparison.OrdinalIgnoreCase))
                    .ToList();

                if (dsHD.Count == 0)
                {
                    MessageBox.Show("Không có hợp đồng hiệu lực nào trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Hộp thoại WinForms chọn Hợp đồng và ghi nhận chỉ số đồng hồ ban đầu
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
                    ComboBox cboHD = new ComboBox { Location = new Point(170, 22), Size = new Size(330, 28), DropDownStyle = ComboBoxStyle.DropDown, AutoCompleteMode = AutoCompleteMode.SuggestAppend, AutoCompleteSource = AutoCompleteSource.ListItems, Font = new Font("Segoe UI", 9.5F) };

                    foreach (var h in dsHD)
                    {
                        var sv = _thuPhiService.GetSinhVienById(h.MaSV);
                        string ten = sv != null ? sv.HoTen : h.MaSV;
                        cboHD.Items.Add(new { Text = $"[{h.MaHopDong}] {ten} ({h.MaSV}) - Phòng {h.MaPhong} ({h.NgayBatDau:dd/MM/yyyy})", Value = h.MaHopDong });
                    }
                    cboHD.DisplayMember = "Text";
                    cboHD.ValueMember = "Value";
                    if (cboHD.Items.Count > 0) cboHD.SelectedIndex = 0;

                    cboHD.KeyDown += (s, ev) =>
                    {
                        if (ev.KeyCode != Keys.Enter) return;
                        ChonHopDongTheoText(cboHD);
                        ev.SuppressKeyPress = true;
                    };
                    cboHD.Validating += (s, ev) => ChonHopDongTheoText(cboHD);

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
                        ChonHopDongTheoText(cboHD);
                        dynamic selectedItem = cboHD.SelectedItem;
                        if (selectedItem == null || cboHD.GetItemText((object)selectedItem) != cboHD.Text)
                        {
                            MessageBox.Show("Không tìm thấy hợp đồng theo mã sinh viên đã nhập. Vui lòng chọn lại trong danh sách!",
                                            "Không tìm thấy hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
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
