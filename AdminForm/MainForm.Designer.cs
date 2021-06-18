
namespace AdminForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnXoa_tab1 = new System.Windows.Forms.Button();
            this.btnXem_tab1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lvBill = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InHoaDon = new System.Windows.Forms.Button();
            this.tongtien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbBanAn = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSortType = new System.Windows.Forms.ComboBox();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachMon = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbLoaiDM = new System.Windows.Forms.ComboBox();
            this.lable = new System.Windows.Forms.Label();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.btnSuaDM = new System.Windows.Forms.Button();
            this.btnThemDM = new System.Windows.Forms.Button();
            this.txtMaDanhMuc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSDanhMuc = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.defaultbill = new System.Windows.Forms.Button();
            this.btnLoadDefaultImg = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMon)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDanhMuc)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Controls.Add(this.tabPage5);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(992, 601);
            this.TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnXoa_tab1);
            this.tabPage1.Controls.Add(this.btnXem_tab1);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.InHoaDon);
            this.tabPage1.Controls.Add(this.tongtien);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbbBanAn);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(984, 568);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản Lý Bàn Ăn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnXoa_tab1
            // 
            this.btnXoa_tab1.Location = new System.Drawing.Point(668, 410);
            this.btnXoa_tab1.Name = "btnXoa_tab1";
            this.btnXoa_tab1.Size = new System.Drawing.Size(276, 50);
            this.btnXoa_tab1.TabIndex = 3;
            this.btnXoa_tab1.Text = "Xóa đơn";
            this.btnXoa_tab1.UseVisualStyleBackColor = true;
            this.btnXoa_tab1.Click += new System.EventHandler(this.btnXoa_tab1_Click);
            // 
            // btnXem_tab1
            // 
            this.btnXem_tab1.Location = new System.Drawing.Point(668, 342);
            this.btnXem_tab1.Name = "btnXem_tab1";
            this.btnXem_tab1.Size = new System.Drawing.Size(276, 50);
            this.btnXem_tab1.TabIndex = 3;
            this.btnXem_tab1.Text = "Xem đơn";
            this.btnXem_tab1.UseVisualStyleBackColor = true;
            this.btnXem_tab1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lvBill);
            this.groupBox5.Location = new System.Drawing.Point(665, 96);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(282, 221);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Lịch sử order";
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBill.FullRowSelect = true;
            this.lvBill.HideSelection = false;
            this.lvBill.Location = new System.Drawing.Point(3, 22);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(276, 196);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            this.lvBill.SelectedIndexChanged += new System.EventHandler(this.lvBill_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID Bill";
            this.columnHeader4.Width = 73;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thời điểm đặt";
            this.columnHeader5.Width = 201;
            // 
            // InHoaDon
            // 
            this.InHoaDon.Location = new System.Drawing.Point(668, 476);
            this.InHoaDon.Name = "InHoaDon";
            this.InHoaDon.Size = new System.Drawing.Size(279, 50);
            this.InHoaDon.TabIndex = 4;
            this.InHoaDon.Text = "In hóa đơn";
            this.InHoaDon.UseVisualStyleBackColor = true;
            this.InHoaDon.Click += new System.EventHandler(this.InHoaDon_Click);
            // 
            // tongtien
            // 
            this.tongtien.Location = new System.Drawing.Point(280, 500);
            this.tongtien.Name = "tongtien";
            this.tongtien.Size = new System.Drawing.Size(371, 26);
            this.tongtien.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tổng tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn bàn Ăn:";
            // 
            // cbbBanAn
            // 
            this.cbbBanAn.FormattingEnabled = true;
            this.cbbBanAn.Location = new System.Drawing.Point(787, 58);
            this.cbbBanAn.Margin = new System.Windows.Forms.Padding(4);
            this.cbbBanAn.Name = "cbbBanAn";
            this.cbbBanAn.Size = new System.Drawing.Size(157, 28);
            this.cbbBanAn.TabIndex = 1;
            this.cbbBanAn.SelectedIndexChanged += new System.EventHandler(this.cbbBanAn_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(27, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(628, 434);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết ";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 23);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(620, 407);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "STT";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 238;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 124;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thành tiền";
            this.columnHeader6.Width = 106;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Controls.Add(this.btnSort);
            this.tabPage2.Controls.Add(this.btnXoa);
            this.tabPage2.Controls.Add(this.btnSua);
            this.tabPage2.Controls.Add(this.btnThem);
            this.tabPage2.Controls.Add(this.btnXem);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cboSortType);
            this.tabPage2.Controls.Add(this.cboDanhMuc);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(984, 589);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản Lý Món Ăn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(652, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(266, 26);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(549, 476);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(159, 35);
            this.btnSort.TabIndex = 9;
            this.btnSort.Text = "Sắp xếp theo:";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(420, 476);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 35);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(291, 476);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 35);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(162, 476);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 35);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(33, 476);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(97, 35);
            this.btnXem.TabIndex = 5;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(537, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục:";
            // 
            // cboSortType
            // 
            this.cboSortType.FormattingEnabled = true;
            this.cboSortType.Location = new System.Drawing.Point(740, 480);
            this.cboSortType.Name = "cboSortType";
            this.cboSortType.Size = new System.Drawing.Size(193, 28);
            this.cboSortType.TabIndex = 10;
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(139, 33);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(251, 28);
            this.cboDanhMuc.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSachMon);
            this.groupBox2.Location = new System.Drawing.Point(30, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(891, 342);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách món:";
            // 
            // dgvDanhSachMon
            // 
            this.dgvDanhSachMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachMon.Location = new System.Drawing.Point(3, 22);
            this.dgvDanhSachMon.Name = "dgvDanhSachMon";
            this.dgvDanhSachMon.ReadOnly = true;
            this.dgvDanhSachMon.RowHeadersWidth = 51;
            this.dgvDanhSachMon.RowTemplate.Height = 24;
            this.dgvDanhSachMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachMon.Size = new System.Drawing.Size(885, 317);
            this.dgvDanhSachMon.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbLoaiDM);
            this.tabPage3.Controls.Add(this.lable);
            this.tabPage3.Controls.Add(this.btnXoaDM);
            this.tabPage3.Controls.Add(this.btnSuaDM);
            this.tabPage3.Controls.Add(this.btnThemDM);
            this.tabPage3.Controls.Add(this.txtMaDanhMuc);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtTenDanhMuc);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(984, 589);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quản Lý Danh Mục";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbLoaiDM
            // 
            this.cbLoaiDM.FormattingEnabled = true;
            this.cbLoaiDM.Location = new System.Drawing.Point(656, 258);
            this.cbLoaiDM.Name = "cbLoaiDM";
            this.cbLoaiDM.Size = new System.Drawing.Size(292, 28);
            this.cbLoaiDM.TabIndex = 6;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(519, 258);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(46, 20);
            this.lable.TabIndex = 5;
            this.lable.Text = "Loại:";
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.Location = new System.Drawing.Point(841, 358);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(107, 37);
            this.btnXoaDM.TabIndex = 9;
            this.btnXoaDM.Text = "Xóa";
            this.btnXoaDM.UseVisualStyleBackColor = true;
            this.btnXoaDM.Click += new System.EventHandler(this.btnXoaDM_Click);
            // 
            // btnSuaDM
            // 
            this.btnSuaDM.Location = new System.Drawing.Point(679, 358);
            this.btnSuaDM.Name = "btnSuaDM";
            this.btnSuaDM.Size = new System.Drawing.Size(107, 37);
            this.btnSuaDM.TabIndex = 8;
            this.btnSuaDM.Text = "Sửa";
            this.btnSuaDM.UseVisualStyleBackColor = true;
            this.btnSuaDM.Click += new System.EventHandler(this.btnSuaDM_Click);
            // 
            // btnThemDM
            // 
            this.btnThemDM.Location = new System.Drawing.Point(523, 356);
            this.btnThemDM.Name = "btnThemDM";
            this.btnThemDM.Size = new System.Drawing.Size(107, 37);
            this.btnThemDM.TabIndex = 7;
            this.btnThemDM.Text = "Thêm";
            this.btnThemDM.UseVisualStyleBackColor = true;
            this.btnThemDM.Click += new System.EventHandler(this.btnThemDM_Click);
            // 
            // txtMaDanhMuc
            // 
            this.txtMaDanhMuc.Location = new System.Drawing.Point(656, 62);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.ReadOnly = true;
            this.txtMaDanhMuc.Size = new System.Drawing.Size(292, 26);
            this.txtMaDanhMuc.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã danh mục:";
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Location = new System.Drawing.Point(656, 160);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(292, 26);
            this.txtTenDanhMuc.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên danh mục:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSDanhMuc);
            this.groupBox3.Location = new System.Drawing.Point(22, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 481);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách danh mục:";
            // 
            // dgvDSDanhMuc
            // 
            this.dgvDSDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSDanhMuc.Location = new System.Drawing.Point(3, 22);
            this.dgvDSDanhMuc.Name = "dgvDSDanhMuc";
            this.dgvDSDanhMuc.ReadOnly = true;
            this.dgvDSDanhMuc.RowHeadersWidth = 51;
            this.dgvDSDanhMuc.RowTemplate.Height = 24;
            this.dgvDSDanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDanhMuc.Size = new System.Drawing.Size(455, 456);
            this.dgvDSDanhMuc.TabIndex = 0;
            this.dgvDSDanhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDanhMuc_CellClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtFolder);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Controls.Add(this.btnOK);
            this.tabPage5.Controls.Add(this.btnBrowse);
            this.tabPage5.Controls.Add(this.defaultbill);
            this.tabPage5.Controls.Add(this.btnLoadDefaultImg);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(984, 589);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Set up";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(577, 331);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(364, 26);
            this.txtFolder.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Folder:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.picAnh);
            this.groupBox4.Location = new System.Drawing.Point(23, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(507, 480);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hình ảnh";
            // 
            // picAnh
            // 
            this.picAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAnh.Location = new System.Drawing.Point(3, 22);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(501, 455);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 1;
            this.picAnh.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(577, 382);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(165, 85);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(796, 382);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(145, 85);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse Folder";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // defaultbill
            // 
            this.defaultbill.Location = new System.Drawing.Point(577, 153);
            this.defaultbill.Name = "defaultbill";
            this.defaultbill.Size = new System.Drawing.Size(248, 110);
            this.defaultbill.TabIndex = 0;
            this.defaultbill.Text = "Load Default Bill";
            this.defaultbill.UseVisualStyleBackColor = true;
            this.defaultbill.Click += new System.EventHandler(this.Default_Bill);
            // 
            // btnLoadDefaultImg
            // 
            this.btnLoadDefaultImg.Location = new System.Drawing.Point(577, 37);
            this.btnLoadDefaultImg.Name = "btnLoadDefaultImg";
            this.btnLoadDefaultImg.Size = new System.Drawing.Size(248, 110);
            this.btnLoadDefaultImg.TabIndex = 0;
            this.btnLoadDefaultImg.Text = "Load Default Img";
            this.btnLoadDefaultImg.UseVisualStyleBackColor = true;
            this.btnLoadDefaultImg.Click += new System.EventHandler(this.btnLoadDefaultImg_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 601);
            this.Controls.Add(this.TabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMon)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDanhMuc)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button InHoaDon;
        private System.Windows.Forms.TextBox tongtien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbBanAn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDanhSachMon;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cboSortType;
        private System.Windows.Forms.Button btnXoaDM;
        private System.Windows.Forms.Button btnSuaDM;
        private System.Windows.Forms.Button btnThemDM;
        private System.Windows.Forms.TextBox txtMaDanhMuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDSDanhMuc;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnLoadDefaultImg;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbLoaiDM;
        private System.Windows.Forms.Label lable;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button defaultbill;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnXem_tab1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnXoa_tab1;
    }
}

