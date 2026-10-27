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

        public FrmDienNuoc()
        {
            InitializeComponent();
            _context = new DataContext();
            _thuPhiService = new ThuPhiService(_context);
        }

        public FrmDienNuoc(DataContext context) : this()
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _thuPhiService = new ThuPhiService(_context);
        }

        private void FrmDienNuoc_Load(object sender, EventArgs e)
        {
            txtThangNam.Text = $"{DateTime.Now.Month}/{DateTime.Now.Year}";
            LoadDataToGrid();
        }

        private void LoadDataToGrid()
        {
            try
            {
                dgvDienNuoc.DataSource = null;
                dgvDienNuoc.DataSource = _thuPhiService.GetAllDienNuoc();

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

                    MessageBox.Show($"--- TÍNH TOÁN NHANH TIỀN ĐIỆN NƯỚC ---\n" +
                                    $"- Điện tiêu thụ: {soDien} kWh x 3.000đ = {soDien * 3000:N0} đ\n" +
                                    $"- Nước tiêu thụ: {soNuoc} m³ x 15.000đ = {soNuoc * 15000:N0} đ\n" +
                                    $"- TỔNG CỘNG: {tongTien:N0} VNĐ",
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
                    MessageBox.Show("Vui lòng nhập mã phòng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaPhong.Focus();
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
            txtMaPhong.Clear();
            txtDienCu.Clear();
            txtDienMoi.Clear();
            txtNuocCu.Clear();
            txtNuocMoi.Clear();
            txtThangNam.Text = $"{DateTime.Now.Month}/{DateTime.Now.Year}";
            txtMaPhong.Focus();
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
            }
        }
    }
}