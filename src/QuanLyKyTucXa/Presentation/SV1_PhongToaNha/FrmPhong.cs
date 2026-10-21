using System;
using System.Windows.Forms;
using QuanLyKyTucXa.Application;

namespace QuanLyKyTucXa.Presentation.SV1_PhongToaNha
{
    public partial class FrmPhong : Form
    {
        private readonly DataContext _context;
        private readonly PhongService _phongService;

        public FrmPhong()
        {
            InitializeComponent();
        }

        public FrmPhong(DataContext context) : this()
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _phongService = new PhongService(_context);
        }

        private void FrmPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (_phongService != null)
            {
                dgvPhong.DataSource = null;
                dgvPhong.DataSource = _phongService.GetAllPhong();
            }
        }
    }
}
