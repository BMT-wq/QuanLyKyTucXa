using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyKyTucXa.Application;
using QuanLyKyTucXa.Domain;

namespace QuanLyKyTucXa.Presentation.SV3_DienNuocThuPhi
{
    public partial class FrmQuyetToanTraPhong : Form
    {
        private readonly DataContext _context;
        private readonly ThuPhiService _thuPhiService;
        private bool _isInitializing = false;

        private class ComboBoxItemHD
        {
            public HopDong HopDong { get; set; }
            public SinhVien SinhVien { get; set; }
            public override string ToString()
            {
                string tenSV = SinhVien != null ? SinhVien.HoTen : HopDong.MaSV;
                return $"[{HopDong.MaHopDong}] {tenSV} ({HopDong.MaSV}) - Phòng {HopDong.MaPhong} (Cọc: {HopDong.TienDatCoc:N0}đ)";
            }
        }

        public FrmQuyetToanTraPhong()
        {
            InitializeComponent();
        }

        public FrmQuyetToanTraPhong(DataContext context, string preselectMaHD = null) : this()
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _thuPhiService = new ThuPhiService(_context);

            InitEvents();
            LoadHopDongComboBox(preselectMaHD);
        }

        private void InitEvents()
        {
            cboHopDong.DropDownStyle = ComboBoxStyle.DropDown;
            cboHopDong.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboHopDong.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboHopDong.SelectedIndexChanged += CboHopDong_SelectedIndexChanged;
            cboHopDong.TextChanged += CboHopDong_TextChanged;
            cboHopDong.KeyDown += CboHopDong_KeyDown;
            cboHopDong.Validating += (s, e) => ChonHopDongTheoText();
            dtpNgayTraPhong.ValueChanged += DtpNgayTraPhong_ValueChanged;
            txtDienTra.TextChanged += TxtInput_TextChanged;
            txtNuocTra.TextChanged += TxtInput_TextChanged;
            txtTienPhongNo.TextChanged += TxtInput_TextChanged;
            txtPhiPhat.TextChanged += TxtInput_TextChanged;

            btnTinhToan.Click += BtnTinhToan_Click;
            btnXacNhan.Click += BtnXacNhan_Click;
            btnDong.Click += (s, e) => this.Close();
        }

        private void LoadHopDongComboBox(string preselectMaHD = null)
        {
            _isInitializing = true;
            cboHopDong.Items.Clear();

            var dsHDHieuLuc = _context.DanhSachHopDong
                .Where(h => h.TrangThai.Equals("Hiệu lực", StringComparison.OrdinalIgnoreCase))
                .ToList();

            int selectedIndex = -1;
            for (int i = 0; i < dsHDHieuLuc.Count; i++)
            {
                var hd = dsHDHieuLuc[i];
                var sv = _thuPhiService.GetSinhVienById(hd.MaSV);
                var item = new ComboBoxItemHD { HopDong = hd, SinhVien = sv };
                cboHopDong.Items.Add(item);

                if (!string.IsNullOrEmpty(preselectMaHD) && hd.MaHopDong.Equals(preselectMaHD, StringComparison.OrdinalIgnoreCase))
                {
                    selectedIndex = i;
                }
            }

            _isInitializing = false;

            if (cboHopDong.Items.Count > 0)
            {
                cboHopDong.SelectedIndex = selectedIndex >= 0 ? selectedIndex : 0;
            }
            else
            {
                MessageBox.Show("Hiện tại không có hợp đồng nào đang trong trạng thái 'Hiệu lực' để trả phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnXacNhan.Enabled = false;
                btnTinhToan.Enabled = false;
            }
        }

        private void CboHopDong_TextChanged(object sender, EventArgs e)
        {
            if (_isInitializing) return;

            string text = cboHopDong.Text;
            for (int i = 0; i < cboHopDong.Items.Count; i++)
            {
                if (cboHopDong.GetItemText(cboHopDong.Items[i]).Equals(text, StringComparison.OrdinalIgnoreCase))
                {
                    if (cboHopDong.SelectedIndex != i) cboHopDong.SelectedIndex = i;
                    return;
                }
            }
        }

        private void CboHopDong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            ChonHopDongTheoText();
            e.SuppressKeyPress = true;
        }

        private void ChonHopDongTheoText()
        {
            string text = cboHopDong.Text.Trim();
            if (string.IsNullOrEmpty(text)) return;

            for (int i = 0; i < cboHopDong.Items.Count; i++)
            {
                if (cboHopDong.GetItemText(cboHopDong.Items[i]).IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    cboHopDong.SelectedIndex = i;
                    return;
                }
            }
        }

        private void CboHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitializing || !(cboHopDong.SelectedItem is ComboBoxItemHD item)) return;

            var hd = item.HopDong;
            var sv = item.SinhVien;

            txtMaPhong.Text = hd.MaPhong;
            txtHoTen.Text = sv != null ? $"{sv.HoTen} ({sv.MaSV})" : hd.MaSV;
            txtTienCoc.Text = $"{hd.TienDatCoc:N0} VNĐ";
            txtNgayBatDau.Text = hd.NgayBatDau.ToString("dd/MM/yyyy");
            txtNgayKetThuc.Text = hd.NgayKetThuc.ToString("dd/MM/yyyy");

            // Lấy chỉ số điện nước cũ gần nhất
            _thuPhiService.GetChiSoDienNuocMoiNhatCuaPhong(hd.MaPhong, out int dienCu, out int nuocCu);
            txtDienCu.Text = dienCu.ToString();
            txtNuocCu.Text = nuocCu.ToString();

            // Mặc định đề xuất chỉ số chốt
            txtDienTra.Text = dienCu.ToString();
            txtNuocTra.Text = nuocCu.ToString();

            // Kiểm tra trả phòng trước hạn
            KiemTraTraTruocHan(hd);

            // Tính toán trước
            ThucHienTinhToan(false);
        }

        private void DtpNgayTraPhong_ValueChanged(object sender, EventArgs e)
        {
            if (cboHopDong.SelectedItem is ComboBoxItemHD item)
            {
                KiemTraTraTruocHan(item.HopDong);
                ThucHienTinhToan(false);
            }
        }

        private void KiemTraTraTruocHan(HopDong hd)
        {
            if (hd == null) return;
            DateTime ngayTra = dtpNgayTraPhong.Value.Date;
            DateTime ngayHetHan = hd.NgayKetThuc.Date;

            if (ngayTra < ngayHetHan)
            {
                lblCanhBaoTraTruoc.Text = $"⚠️ Phát hiện: Trả phòng trước hạn ({ngayTra:dd/MM/yyyy} < {ngayHetHan:dd/MM/yyyy})!";
                lblCanhBaoTraTruoc.ForeColor = Color.FromArgb(217, 83, 79);
                lblCanhBaoTraTruoc.Visible = true;
            }
            else
            {
                lblCanhBaoTraTruoc.Text = "✓ Trả phòng đúng hạn hoặc sau thời hạn hợp đồng.";
                lblCanhBaoTraTruoc.ForeColor = Color.FromArgb(40, 167, 69);
                lblCanhBaoTraTruoc.Visible = true;
            }
        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {
            if (_isInitializing) return;
            ThucHienTinhToan(false);
        }

        private bool ThucHienTinhToan(bool showMessageIfError)
        {
            if (!(cboHopDong.SelectedItem is ComboBoxItemHD item)) return false;
            if (!cboHopDong.GetItemText(item).Equals(cboHopDong.Text, StringComparison.OrdinalIgnoreCase))
            {
                if (showMessageIfError)
                {
                    MessageBox.Show("Không tìm thấy hợp đồng theo mã sinh viên đã nhập. Vui lòng chọn lại trong danh sách!",
                                    "Không tìm thấy hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return false;
            }

            var hd = item.HopDong;
            int.TryParse(txtDienTra.Text.Trim(), out int dienTra);
            int.TryParse(txtNuocTra.Text.Trim(), out int nuocTra);
            decimal.TryParse(txtTienPhongNo.Text.Trim(), out decimal tienPhongNo);
            decimal.TryParse(txtPhiPhat.Text.Trim(), out decimal phiPhat);

            DateTime ngayTra = dtpNgayTraPhong.Value;

            if (!_thuPhiService.TinhTienDienNuocTraPhong(hd.MaHopDong, ngayTra, dienTra, nuocTra,
                                                        out decimal tienDienNuocSV, out string chiTiet, out string error))
            {
                if (showMessageIfError)
                {
                    MessageBox.Show(error, "Lỗi tính điện nước", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtTienDienNuocSV.Text = "0 đ";
                txtTienCocThucNhan.Text = "Chờ nhập đúng";
                return false;
            }

            txtTienDienNuocSV.Text = $"{tienDienNuocSV:N0} VNĐ";

            decimal tienCocGoc = hd.TienDatCoc;
            decimal tienCocThucNhan = tienCocGoc - tienDienNuocSV - tienPhongNo - phiPhat;

            if (tienCocThucNhan >= 0)
            {
                txtTienCocThucNhan.Text = $"{tienCocThucNhan:N0} VNĐ";
                txtTienCocThucNhan.BackColor = Color.FromArgb(212, 237, 218);
                txtTienCocThucNhan.ForeColor = Color.FromArgb(21, 87, 36);
                lblGiaiThich.Text = $"(Hoàn trả lại cho sinh viên {tienCocThucNhan:N0} đ sau khi trừ toàn bộ các khoản nợ)";
            }
            else
            {
                decimal thieu = Math.Abs(tienCocThucNhan);
                txtTienCocThucNhan.Text = $"-{thieu:N0} VNĐ (Nợ thêm)";
                txtTienCocThucNhan.BackColor = Color.FromArgb(248, 215, 218);
                txtTienCocThucNhan.ForeColor = Color.FromArgb(114, 28, 36);
                lblGiaiThich.Text = $"(Tiền cọc không đủ bù trừ! Sinh viên cần nộp thêm: {thieu:N0} đ)";
            }

            return true;
        }

        private void BtnTinhToan_Click(object sender, EventArgs e)
        {
            ChonHopDongTheoText();
            if (ThucHienTinhToan(true))
            {
                if (cboHopDong.SelectedItem is ComboBoxItemHD item)
                {
                    int.TryParse(txtDienTra.Text.Trim(), out int dienTra);
                    int.TryParse(txtNuocTra.Text.Trim(), out int nuocTra);
                    _thuPhiService.TinhTienDienNuocTraPhong(item.HopDong.MaHopDong, dtpNgayTraPhong.Value, dienTra, nuocTra,
                                                           out decimal tienDNSV, out string chiTiet, out string err);

                    MessageBox.Show($"--- KẾT QUẢ TÍNH TOÁN NHANH TRẢ PHÒNG ---\n\n{chiTiet}\n\n" +
                                    $"- Tiền cọc gốc: {item.HopDong.TienDatCoc:N0} đ\n" +
                                    $"- Tiền điện nước SV: {tienDNSV:N0} đ\n" +
                                    $"- Tiền phòng nợ: {decimal.Parse(txtTienPhongNo.Text.Trim()):N0} đ\n" +
                                    $"- Phí phạt/khác: {decimal.Parse(txtPhiPhat.Text.Trim()):N0} đ\n" +
                                    $"===========================================\n" +
                                    $"TIỀN CỌC THỰC NHẬN: {txtTienCocThucNhan.Text}",
                                    "Chi tiết tính toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                ChonHopDongTheoText();
                if (!(cboHopDong.SelectedItem is ComboBoxItemHD item))
                {
                    MessageBox.Show("Vui lòng chọn hợp đồng cần thanh lý trả phòng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ThucHienTinhToan(true)) return;

                var hd = item.HopDong;
                var sv = item.SinhVien;
                string tenSV = sv != null ? sv.HoTen : hd.MaSV;

                int.TryParse(txtDienTra.Text.Trim(), out int dienTra);
                int.TryParse(txtNuocTra.Text.Trim(), out int nuocTra);
                decimal.TryParse(txtTienPhongNo.Text.Trim(), out decimal tienPhongNo);
                decimal.TryParse(txtPhiPhat.Text.Trim(), out decimal phiPhat);
                string lyDoPhat = txtLyDoPhat.Text.Trim();
                DateTime ngayTra = dtpNgayTraPhong.Value;

                var confirm = MessageBox.Show(
                    $"XÁC NHẬN THANH LÝ HỢP ĐỒNG & TRẢ CỌC:\n\n" +
                    $"- Sinh viên: {tenSV} ({hd.MaSV})\n" +
                    $"- Hợp đồng: {hd.MaHopDong} - Phòng: {hd.MaPhong}\n" +
                    $"- Ngày trả phòng: {ngayTra:dd/MM/yyyy}\n" +
                    $"- Kết quả trả cọc: {txtTienCocThucNhan.Text}\n\n" +
                    $"Hành động này sẽ:\n" +
                    $"1. Chuyển hợp đồng '{hd.MaHopDong}' sang 'Đã thanh lý'.\n" +
                    $"2. Hoàn trả 1 chỗ trống cho phòng '{hd.MaPhong}'.\n" +
                    $"3. Tự động lập các phiếu thu/chi quyết toán cọc trong hệ thống.\n" +
                    $"4. Mốc đồng hồ sẽ được chốt để điện nước tiếp tục tính cho các SV còn lại trong phòng!\n\n" +
                    $"Bạn có chắc chắn muốn thực hiện?",
                    "Xác nhận quyết toán",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    if (_thuPhiService.QuyetToanTraPhongVaTraCoc(hd.MaHopDong, ngayTra, dienTra, nuocTra,
                                                              tienPhongNo, phiPhat, lyDoPhat, "Admin",
                                                              out decimal tienCocThucTra, out string chiTietBaoCao, out string error))
                    {
                        MessageBox.Show(chiTietBaoCao, "Quyết toán trả phòng thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(error, "Lỗi khi quyết toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
