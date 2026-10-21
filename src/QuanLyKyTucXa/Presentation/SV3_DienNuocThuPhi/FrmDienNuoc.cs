using System;
using System.Windows.Forms;
using QuanLyKyTucXa.Application;

namespace QuanLyKyTucXa.Presentation.SV3_DienNuocThuPhi
{
    public partial class FrmDienNuoc : Form
    {
        private readonly DataContext _context;
        private readonly ThuPhiService _thuPhiService;

        public FrmDienNuoc()
        {
            InitializeComponent();
        }

        public FrmDienNuoc(DataContext context) : this()
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _thuPhiService = new ThuPhiService(_context);
        }

        private void FrmDienNuoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (_thuPhiService != null)
            {
                dgvDienNuoc.DataSource = null;
                dgvDienNuoc.DataSource = _thuPhiService.GetAllDienNuoc();
            }
        }
    }
}
