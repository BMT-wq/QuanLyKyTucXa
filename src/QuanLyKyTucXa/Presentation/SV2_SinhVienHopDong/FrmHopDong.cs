using System;
using System.Windows.Forms;
using QuanLyKyTucXa.Application;

namespace QuanLyKyTucXa.Presentation.SV2_SinhVienHopDong
{
    public partial class FrmHopDong : Form
    {
        private readonly DataContext _context;
        private readonly HopDongService _hopDongService;

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
            LoadData();
        }

        private void LoadData()
        {
            if (_hopDongService != null)
            {
                dgvHopDong.DataSource = null;
                dgvHopDong.DataSource = _hopDongService.GetAllHopDong();
            }
        }
    }
}
