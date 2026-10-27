namespace QuanLyKyTucXa.Presentation.SV1_PhongToaNha
{
    partial class FrmToaNha
    {
        private System.ComponentModel.IContainer components = null;

        // --- Header ---
        private System.Windows.Forms.Label lblHeader;

        // --- Panel nhập liệu ---
        private System.Windows.Forms.GroupBox grpNhapLieu;
        private System.Windows.Forms.Label lblMaToaNha;
        private System.Windows.Forms.TextBox txtMaToaNha;
        private System.Windows.Forms.Label lblTenToaNha;
        private System.Windows.Forms.TextBox txtTenToaNha;
        private System.Windows.Forms.Label lblSoTang;
        private System.Windows.Forms.NumericUpDown nudSoTang;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;

        // --- Các nút hành động ---
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;

        // --- Bảng dữ liệu ---
        private System.Windows.Forms.DataGridView dgvToaNha;

        // --- Status bar ---
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpNhapLieu = new System.Windows.Forms.GroupBox();
            this.lblMaToaNha = new System.Windows.Forms.Label();
            this.txtMaToaNha = new System.Windows.Forms.TextBox();
            this.lblTenToaNha = new System.Windows.Forms.Label();
            this.txtTenToaNha = new System.Windows.Forms.TextBox();
            this.lblSoTang = new System.Windows.Forms.Label();
            this.nudSoTang = new System.Windows.Forms.NumericUpDown();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvToaNha = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaNha)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(880, 50);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "  🏢  QUẢN LÝ DANH MỤC TÒA NHÀ";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpNhapLieu
            // 
            this.grpNhapLieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNhapLieu.Controls.Add(this.lblMaToaNha);
            this.grpNhapLieu.Controls.Add(this.txtMaToaNha);
            this.grpNhapLieu.Controls.Add(this.lblTenToaNha);
            this.grpNhapLieu.Controls.Add(this.txtTenToaNha);
            this.grpNhapLieu.Controls.Add(this.lblSoTang);
            this.grpNhapLieu.Controls.Add(this.nudSoTang);
            this.grpNhapLieu.Controls.Add(this.lblGhiChu);
            this.grpNhapLieu.Controls.Add(this.txtGhiChu);
            this.grpNhapLieu.Controls.Add(this.btnThem);
            this.grpNhapLieu.Controls.Add(this.btnSua);
            this.grpNhapLieu.Controls.Add(this.btnXoa);
            this.grpNhapLieu.Controls.Add(this.btnLamMoi);
            this.grpNhapLieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpNhapLieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.grpNhapLieu.Location = new System.Drawing.Point(12, 58);
            this.grpNhapLieu.Name = "grpNhapLieu";
            this.grpNhapLieu.Size = new System.Drawing.Size(856, 155);
            this.grpNhapLieu.TabIndex = 1;
            this.grpNhapLieu.TabStop = false;
            this.grpNhapLieu.Text = "Thông tin Tòa nhà";
            // 
            // lblMaToaNha
            // 
            this.lblMaToaNha.AutoSize = true;
            this.lblMaToaNha.ForeColor = System.Drawing.Color.Black;
            this.lblMaToaNha.Location = new System.Drawing.Point(15, 32);
            this.lblMaToaNha.Name = "lblMaToaNha";
            this.lblMaToaNha.Size = new System.Drawing.Size(82, 19);
            this.lblMaToaNha.TabIndex = 0;
            this.lblMaToaNha.Text = "Mã tòa nhà:";
            // 
            // txtMaToaNha
            // 
            this.txtMaToaNha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaToaNha.Location = new System.Drawing.Point(115, 29);
            this.txtMaToaNha.Name = "txtMaToaNha";
            this.txtMaToaNha.Size = new System.Drawing.Size(140, 25);
            this.txtMaToaNha.TabIndex = 1;
            // 
            // lblTenToaNha
            // 
            this.lblTenToaNha.AutoSize = true;
            this.lblTenToaNha.ForeColor = System.Drawing.Color.Black;
            this.lblTenToaNha.Location = new System.Drawing.Point(275, 32);
            this.lblTenToaNha.Name = "lblTenToaNha";
            this.lblTenToaNha.Size = new System.Drawing.Size(83, 19);
            this.lblTenToaNha.TabIndex = 2;
            this.lblTenToaNha.Text = "Tên tòa nhà:";
            // 
            // txtTenToaNha
            // 
            this.txtTenToaNha.Location = new System.Drawing.Point(375, 29);
            this.txtTenToaNha.Name = "txtTenToaNha";
            this.txtTenToaNha.Size = new System.Drawing.Size(220, 25);
            this.txtTenToaNha.TabIndex = 3;
            // 
            // lblSoTang
            // 
            this.lblSoTang.AutoSize = true;
            this.lblSoTang.ForeColor = System.Drawing.Color.Black;
            this.lblSoTang.Location = new System.Drawing.Point(615, 32);
            this.lblSoTang.Name = "lblSoTang";
            this.lblSoTang.Size = new System.Drawing.Size(59, 19);
            this.lblSoTang.TabIndex = 4;
            this.lblSoTang.Text = "Số tầng:";
            // 
            // nudSoTang
            // 
            this.nudSoTang.Location = new System.Drawing.Point(685, 29);
            this.nudSoTang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoTang.Name = "nudSoTang";
            this.nudSoTang.Size = new System.Drawing.Size(80, 25);
            this.nudSoTang.TabIndex = 5;
            this.nudSoTang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.ForeColor = System.Drawing.Color.Black;
            this.lblGhiChu.Location = new System.Drawing.Point(15, 68);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(59, 19);
            this.lblGhiChu.TabIndex = 6;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(115, 65);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(480, 25);
            this.txtGhiChu.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(115, 105);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 35);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "✚  Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(240, 105);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 35);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "✏  Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(365, 105);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 35);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "✖  Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(490, 105);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 35);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "🔄  Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvToaNha
            // 
            this.dgvToaNha.AllowUserToAddRows = false;
            this.dgvToaNha.AllowUserToDeleteRows = false;
            this.dgvToaNha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvToaNha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvToaNha.BackgroundColor = System.Drawing.Color.White;
            this.dgvToaNha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvToaNha.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvToaNha.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvToaNha.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvToaNha.ColumnHeadersHeight = 38;
            this.dgvToaNha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvToaNha.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dgvToaNha.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvToaNha.EnableHeadersVisualStyles = false;
            this.dgvToaNha.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.dgvToaNha.Location = new System.Drawing.Point(12, 220);
            this.dgvToaNha.MultiSelect = false;
            this.dgvToaNha.Name = "dgvToaNha";
            this.dgvToaNha.ReadOnly = true;
            this.dgvToaNha.RowHeadersVisible = false;
            this.dgvToaNha.RowTemplate.Height = 32;
            this.dgvToaNha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvToaNha.Size = new System.Drawing.Size(856, 290);
            this.dgvToaNha.TabIndex = 2;
            this.dgvToaNha.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToaNha_CellClick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTrangThai});
            this.statusStrip.Location = new System.Drawing.Point(0, 518);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(880, 22);
            this.statusStrip.TabIndex = 3;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(55, 17);
            this.lblTrangThai.Text = "Sẵn sàng";
            // 
            // FrmToaNha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(880, 540);
            this.Controls.Add(this.dgvToaNha);
            this.Controls.Add(this.grpNhapLieu);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "FrmToaNha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Tòa nhà";
            this.Load += new System.EventHandler(this.FrmToaNha_Load);
            this.grpNhapLieu.ResumeLayout(false);
            this.grpNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaNha)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
