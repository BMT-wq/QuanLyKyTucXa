using System;
using System.Windows.Forms;
using QuanLyKyTucXa.Application;

namespace QuanLyKyTucXa.Presentation.SV2_SinhVienHopDong
{
    public partial class FrmSinhVien : Form
    {
        private readonly DataContext _context;
        private readonly HopDongService _hopDongService;

        public FrmSinhVien()
        {
            InitializeComponent();
        }

        public FrmSinhVien(DataContext context) : this()
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _hopDongService = new HopDongService(_context);
        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (_hopDongService != null)
            {
                dgvSinhVien.DataSource = null;
                dgvSinhVien.DataSource = _hopDongService.GetAllSinhVien();
            }
        }
    }
}
