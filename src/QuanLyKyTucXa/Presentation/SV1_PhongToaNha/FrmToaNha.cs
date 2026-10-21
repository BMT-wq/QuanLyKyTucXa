using System;
using System.Windows.Forms;
using QuanLyKyTucXa.Application;

namespace QuanLyKyTucXa.Presentation.SV1_PhongToaNha
{
    public partial class FrmToaNha : Form
    {
        private readonly DataContext _context;
        private readonly PhongService _phongService;

        public FrmToaNha()
        {
            InitializeComponent();
        }

        public FrmToaNha(DataContext context) : this()
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _phongService = new PhongService(_context);
        }

        private void FrmToaNha_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (_phongService != null)
            {
                dgvToaNha.DataSource = null;
                dgvToaNha.DataSource = _phongService.GetAllToaNha();
            }
        }
    }
}
