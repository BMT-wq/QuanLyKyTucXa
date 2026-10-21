using System;
using System.Windows.Forms;
using QuanLyKyTucXa.Application;

namespace QuanLyKyTucXa.Presentation.SV3_DienNuocThuPhi
{
    public partial class FrmThuPhi : Form
    {
        private readonly DataContext _context;
        private readonly ThuPhiService _thuPhiService;

        public FrmThuPhi()
        {
            InitializeComponent();
        }

        public FrmThuPhi(DataContext context) : this()
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _thuPhiService = new ThuPhiService(_context);
        }

        private void FrmThuPhi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (_thuPhiService != null)
            {
                dgvThuPhi.DataSource = null;
                dgvThuPhi.DataSource = _thuPhiService.GetAllThuPhi();
            }
        }
    }
}
