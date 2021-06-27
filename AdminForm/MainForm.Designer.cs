
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnXoa_tab1 = new Guna.UI.WinForms.GunaButton();
            this.btnPrint = new Guna.UI.WinForms.GunaButton();
            this.btnXem_tab1 = new Guna.UI.WinForms.GunaButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lvBill = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSort = new Guna.UI.WinForms.GunaButton();
            this.btnXoa = new Guna.UI.WinForms.GunaButton();
            this.btnSua = new Guna.UI.WinForms.GunaButton();
            this.btnThem = new Guna.UI.WinForms.GunaButton();
            this.btnXem = new Guna.UI.WinForms.GunaButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSortType = new System.Windows.Forms.ComboBox();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachMon = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnXoaDM = new Guna.UI.WinForms.GunaButton();
            this.btnSuaDM = new Guna.UI.WinForms.GunaButton();
            this.btnThemDM = new Guna.UI.WinForms.GunaButton();
            this.cbLoaiDM = new System.Windows.Forms.ComboBox();
            this.lable = new System.Windows.Forms.Label();
            this.txtMaDanhMuc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSDanhMuc = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
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
            this.TabControl.Margin = new System.Windows.Forms.Padding(5);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1091, 703);
            this.TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.btnXoa_tab1);
            this.tabPage1.Controls.Add(this.btnPrint);
            this.tabPage1.Controls.Add(this.btnXem_tab1);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.tongtien);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbbBanAn);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(1083, 666);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản Lý Bàn Ăn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnXoa_tab1
            // 
            this.btnXoa_tab1.AnimationHoverSpeed = 0.07F;
            this.btnXoa_tab1.AnimationSpeed = 0.03F;
            this.btnXoa_tab1.BaseColor = System.Drawing.Color.Transparent;
            this.btnXoa_tab1.BorderColor = System.Drawing.Color.Black;
            this.btnXoa_tab1.BorderSize = 2;
            this.btnXoa_tab1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoa_tab1.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoa_tab1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnXoa_tab1.ForeColor = System.Drawing.Color.Black;
            this.btnXoa_tab1.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa_tab1.Image")));
            this.btnXoa_tab1.ImageSize = new System.Drawing.Size(45, 45);
            this.btnXoa_tab1.Location = new System.Drawing.Point(791, 491);
            this.btnXoa_tab1.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa_tab1.Name = "btnXoa_tab1";
            this.btnXoa_tab1.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnXoa_tab1.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnXoa_tab1.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnXoa_tab1.OnHoverImage = null;
            this.btnXoa_tab1.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa_tab1.Size = new System.Drawing.Size(200, 60);
            this.btnXoa_tab1.TabIndex = 8;
            this.btnXoa_tab1.Text = "Xóa đơn";
            this.btnXoa_tab1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXoa_tab1.Click += new System.EventHandler(this.btnXoa_tab1_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AnimationHoverSpeed = 0.07F;
            this.btnPrint.AnimationSpeed = 0.03F;
            this.btnPrint.BaseColor = System.Drawing.Color.Transparent;
            this.btnPrint.BorderColor = System.Drawing.Color.Black;
            this.btnPrint.BorderSize = 2;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrint.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageSize = new System.Drawing.Size(45, 45);
            this.btnPrint.Location = new System.Drawing.Point(791, 584);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnPrint.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnPrint.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnPrint.OnHoverImage = null;
            this.btnPrint.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrint.Size = new System.Drawing.Size(200, 60);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "In hóa đơn";
            this.btnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPrint.Click += new System.EventHandler(this.InHoaDon_Click);
            // 
            // btnXem_tab1
            // 
            this.btnXem_tab1.AnimationHoverSpeed = 0.07F;
            this.btnXem_tab1.AnimationSpeed = 0.03F;
            this.btnXem_tab1.BaseColor = System.Drawing.Color.Transparent;
            this.btnXem_tab1.BorderColor = System.Drawing.Color.Black;
            this.btnXem_tab1.BorderSize = 2;
            this.btnXem_tab1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXem_tab1.FocusedColor = System.Drawing.Color.Empty;
            this.btnXem_tab1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnXem_tab1.ForeColor = System.Drawing.Color.Black;
            this.btnXem_tab1.Image = ((System.Drawing.Image)(resources.GetObject("btnXem_tab1.Image")));
            this.btnXem_tab1.ImageSize = new System.Drawing.Size(50, 50);
            this.btnXem_tab1.Location = new System.Drawing.Point(791, 398);
            this.btnXem_tab1.Margin = new System.Windows.Forms.Padding(2);
            this.btnXem_tab1.Name = "btnXem_tab1";
            this.btnXem_tab1.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnXem_tab1.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnXem_tab1.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnXem_tab1.OnHoverImage = null;
            this.btnXem_tab1.OnPressedColor = System.Drawing.Color.Black;
            this.btnXem_tab1.Size = new System.Drawing.Size(200, 60);
            this.btnXem_tab1.TabIndex = 8;
            this.btnXem_tab1.Text = "Xem đơn";
            this.btnXem_tab1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXem_tab1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lvBill);
            this.groupBox5.Location = new System.Drawing.Point(732, 115);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(310, 265);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Lịch Sử Order";
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBill.FullRowSelect = true;
            this.lvBill.HideSelection = false;
            this.lvBill.Location = new System.Drawing.Point(4, 25);
            this.lvBill.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(302, 237);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            this.lvBill.SelectedIndexChanged += new System.EventHandler(this.lvBill_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID Bill";
            this.columnHeader4.Width = 67;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thời điểm đặt";
            this.columnHeader5.Width = 252;
            // 
            // tongtien
            // 
            this.tongtien.Enabled = false;
            this.tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongtien.Location = new System.Drawing.Point(231, 610);
            this.tongtien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tongtien.Name = "tongtien";
            this.tongtien.Size = new System.Drawing.Size(486, 34);
            this.tongtien.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 613);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tổng Tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(731, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Bàn Ăn:";
            // 
            // cbbBanAn
            // 
            this.cbbBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBanAn.FormattingEnabled = true;
            this.cbbBanAn.Location = new System.Drawing.Point(890, 53);
            this.cbbBanAn.Margin = new System.Windows.Forms.Padding(5);
            this.cbbBanAn.Name = "cbbBanAn";
            this.cbbBanAn.Size = new System.Drawing.Size(152, 34);
            this.cbbBanAn.TabIndex = 1;
            this.cbbBanAn.SelectedIndexChanged += new System.EventHandler(this.cbbBanAn_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(31, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(691, 516);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn";
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
            this.listView1.Location = new System.Drawing.Point(5, 27);
            this.listView1.Margin = new System.Windows.Forms.Padding(5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(681, 484);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "STT";
            this.columnHeader0.Width = 77;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 206;
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
            this.columnHeader3.Width = 162;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thành tiền";
            this.columnHeader6.Width = 137;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnSort);
            this.tabPage2.Controls.Add(this.btnXoa);
            this.tabPage2.Controls.Add(this.btnSua);
            this.tabPage2.Controls.Add(this.btnThem);
            this.tabPage2.Controls.Add(this.btnXem);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cboSortType);
            this.tabPage2.Controls.Add(this.cboDanhMuc);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage2.Size = new System.Drawing.Size(1083, 666);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản Lý Món Ăn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(668, 581);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Sắp xếp theo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(668, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tìm kiếm:";
            // 
            // btnSort
            // 
            this.btnSort.AnimationHoverSpeed = 0.07F;
            this.btnSort.AnimationSpeed = 0.03F;
            this.btnSort.BaseColor = System.Drawing.Color.Transparent;
            this.btnSort.BorderColor = System.Drawing.Color.Black;
            this.btnSort.BorderSize = 2;
            this.btnSort.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSort.FocusedColor = System.Drawing.Color.Empty;
            this.btnSort.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSort.ForeColor = System.Drawing.Color.Black;
            this.btnSort.Image = ((System.Drawing.Image)(resources.GetObject("btnSort.Image")));
            this.btnSort.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSort.Location = new System.Drawing.Point(895, 586);
            this.btnSort.Name = "btnSort";
            this.btnSort.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnSort.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnSort.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnSort.OnHoverImage = null;
            this.btnSort.OnPressedColor = System.Drawing.Color.Black;
            this.btnSort.Size = new System.Drawing.Size(158, 55);
            this.btnSort.TabIndex = 11;
            this.btnSort.Text = "Sắp xếp";
            this.btnSort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AnimationHoverSpeed = 0.07F;
            this.btnXoa.AnimationSpeed = 0.03F;
            this.btnXoa.BaseColor = System.Drawing.Color.Transparent;
            this.btnXoa.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.BorderSize = 2;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoa.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageSize = new System.Drawing.Size(40, 40);
            this.btnXoa.Location = new System.Drawing.Point(452, 586);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Size = new System.Drawing.Size(174, 55);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa món";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AnimationHoverSpeed = 0.07F;
            this.btnSua.AnimationSpeed = 0.03F;
            this.btnSua.BaseColor = System.Drawing.Color.Transparent;
            this.btnSua.BorderColor = System.Drawing.Color.Black;
            this.btnSua.BorderSize = 2;
            this.btnSua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSua.FocusedColor = System.Drawing.Color.Empty;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSua.Location = new System.Drawing.Point(240, 586);
            this.btnSua.Name = "btnSua";
            this.btnSua.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnSua.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnSua.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnSua.OnHoverImage = null;
            this.btnSua.OnPressedColor = System.Drawing.Color.Black;
            this.btnSua.Size = new System.Drawing.Size(174, 55);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa món";
            this.btnSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AnimationHoverSpeed = 0.07F;
            this.btnThem.AnimationSpeed = 0.03F;
            this.btnThem.BaseColor = System.Drawing.Color.Transparent;
            this.btnThem.BorderColor = System.Drawing.Color.Black;
            this.btnThem.BorderSize = 2;
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.FocusedColor = System.Drawing.Color.Empty;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageSize = new System.Drawing.Size(40, 40);
            this.btnThem.Location = new System.Drawing.Point(28, 586);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnThem.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnThem.OnHoverImage = null;
            this.btnThem.OnPressedColor = System.Drawing.Color.Black;
            this.btnThem.Size = new System.Drawing.Size(174, 55);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm món";
            this.btnThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXem
            // 
            this.btnXem.AnimationHoverSpeed = 0.07F;
            this.btnXem.AnimationSpeed = 0.03F;
            this.btnXem.BaseColor = System.Drawing.Color.Transparent;
            this.btnXem.BorderColor = System.Drawing.Color.Black;
            this.btnXem.BorderSize = 2;
            this.btnXem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXem.FocusedColor = System.Drawing.Color.Empty;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnXem.ForeColor = System.Drawing.Color.Black;
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.ImageSize = new System.Drawing.Size(35, 35);
            this.btnXem.Location = new System.Drawing.Point(452, 23);
            this.btnXem.Name = "btnXem";
            this.btnXem.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnXem.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnXem.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnXem.OnHoverImage = null;
            this.btnXem.OnPressedColor = System.Drawing.Color.Black;
            this.btnXem.Size = new System.Drawing.Size(126, 43);
            this.btnXem.TabIndex = 11;
            this.btnXem.Text = "Xem";
            this.btnXem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch.Location = new System.Drawing.Point(772, 37);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(281, 29);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Text = "Tên món (không dấu) / giá tiền";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.btnTim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh Mục:";
            // 
            // cboSortType
            // 
            this.cboSortType.FormattingEnabled = true;
            this.cboSortType.Location = new System.Drawing.Point(671, 609);
            this.cboSortType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboSortType.Name = "cboSortType";
            this.cboSortType.Size = new System.Drawing.Size(193, 32);
            this.cboSortType.TabIndex = 10;
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(177, 29);
            this.cboDanhMuc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(237, 32);
            this.cboDanhMuc.TabIndex = 1;
            this.cboDanhMuc.Click += new System.EventHandler(this.cboDanhMuc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSachMon);
            this.groupBox2.Location = new System.Drawing.Point(24, 101);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1035, 453);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Món:";
            // 
            // dgvDanhSachMon
            // 
            this.dgvDanhSachMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachMon.Location = new System.Drawing.Point(4, 25);
            this.dgvDanhSachMon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDanhSachMon.Name = "dgvDanhSachMon";
            this.dgvDanhSachMon.ReadOnly = true;
            this.dgvDanhSachMon.RowHeadersWidth = 51;
            this.dgvDanhSachMon.RowTemplate.Height = 24;
            this.dgvDanhSachMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachMon.Size = new System.Drawing.Size(1027, 425);
            this.dgvDanhSachMon.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.btnXoaDM);
            this.tabPage3.Controls.Add(this.btnSuaDM);
            this.tabPage3.Controls.Add(this.btnThemDM);
            this.tabPage3.Controls.Add(this.cbLoaiDM);
            this.tabPage3.Controls.Add(this.lable);
            this.tabPage3.Controls.Add(this.txtMaDanhMuc);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtTenDanhMuc);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage3.Size = new System.Drawing.Size(1083, 666);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quản Lý Danh Mục";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.AnimationHoverSpeed = 0.07F;
            this.btnXoaDM.AnimationSpeed = 0.03F;
            this.btnXoaDM.BaseColor = System.Drawing.Color.Transparent;
            this.btnXoaDM.BorderColor = System.Drawing.Color.Black;
            this.btnXoaDM.BorderSize = 2;
            this.btnXoaDM.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoaDM.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoaDM.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnXoaDM.ForeColor = System.Drawing.Color.Black;
            this.btnXoaDM.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDM.Image")));
            this.btnXoaDM.ImageSize = new System.Drawing.Size(40, 40);
            this.btnXoaDM.Location = new System.Drawing.Point(908, 529);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnXoaDM.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnXoaDM.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btnXoaDM.OnHoverImage = null;
            this.btnXoaDM.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoaDM.Size = new System.Drawing.Size(133, 55);
            this.btnXoaDM.TabIndex = 10;
            this.btnXoaDM.Text = "Xóa";
            this.btnXoaDM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXoaDM.Click += new System.EventHandler(this.btnXoaDM_Click);
            // 
            // btnSuaDM
            // 
            this.btnSuaDM.AnimationHoverSpeed = 0.07F;
            this.btnSuaDM.AnimationSpeed = 0.03F;
            this.btnSuaDM.BaseColor = System.Drawing.Color.Transparent;
            this.btnSuaDM.BorderColor = System.Drawing.Color.Black;
            this.btnSuaDM.BorderSize = 2;
            this.btnSuaDM.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSuaDM.FocusedColor = System.Drawing.Color.Empty;
            this.btnSuaDM.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSuaDM.ForeColor = System.Drawing.Color.Black;
            this.btnSuaDM.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaDM.Image")));
            this.btnSuaDM.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSuaDM.Location = new System.Drawing.Point(736, 527);
            this.btnSuaDM.Name = "btnSuaDM";
            this.btnSuaDM.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnSuaDM.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnSuaDM.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btnSuaDM.OnHoverImage = null;
            this.btnSuaDM.OnPressedColor = System.Drawing.Color.Black;
            this.btnSuaDM.Size = new System.Drawing.Size(133, 55);
            this.btnSuaDM.TabIndex = 10;
            this.btnSuaDM.Text = "Sửa";
            this.btnSuaDM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSuaDM.Click += new System.EventHandler(this.btnSuaDM_Click);
            // 
            // btnThemDM
            // 
            this.btnThemDM.AnimationHoverSpeed = 0.07F;
            this.btnThemDM.AnimationSpeed = 0.03F;
            this.btnThemDM.BaseColor = System.Drawing.Color.Transparent;
            this.btnThemDM.BorderColor = System.Drawing.Color.Black;
            this.btnThemDM.BorderSize = 2;
            this.btnThemDM.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemDM.FocusedColor = System.Drawing.Color.Empty;
            this.btnThemDM.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnThemDM.ForeColor = System.Drawing.Color.Black;
            this.btnThemDM.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDM.Image")));
            this.btnThemDM.ImageSize = new System.Drawing.Size(40, 40);
            this.btnThemDM.Location = new System.Drawing.Point(564, 527);
            this.btnThemDM.Name = "btnThemDM";
            this.btnThemDM.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnThemDM.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnThemDM.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btnThemDM.OnHoverImage = null;
            this.btnThemDM.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemDM.Size = new System.Drawing.Size(133, 55);
            this.btnThemDM.TabIndex = 10;
            this.btnThemDM.Text = "Thêm";
            this.btnThemDM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThemDM.Click += new System.EventHandler(this.btnThemDM_Click);
            // 
            // cbLoaiDM
            // 
            this.cbLoaiDM.FormattingEnabled = true;
            this.cbLoaiDM.Location = new System.Drawing.Point(721, 375);
            this.cbLoaiDM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbLoaiDM.Name = "cbLoaiDM";
            this.cbLoaiDM.Size = new System.Drawing.Size(321, 32);
            this.cbLoaiDM.TabIndex = 6;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(559, 377);
            this.lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(150, 25);
            this.lable.TabIndex = 5;
            this.lable.Text = "Loại Danh Mục:";
            // 
            // txtMaDanhMuc
            // 
            this.txtMaDanhMuc.Location = new System.Drawing.Point(721, 99);
            this.txtMaDanhMuc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.ReadOnly = true;
            this.txtMaDanhMuc.Size = new System.Drawing.Size(321, 29);
            this.txtMaDanhMuc.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã Danh Mục:";
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Location = new System.Drawing.Point(721, 237);
            this.txtTenDanhMuc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(321, 29);
            this.txtTenDanhMuc.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Danh Mục:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSDanhMuc);
            this.groupBox3.Location = new System.Drawing.Point(25, 74);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(507, 513);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Danh Mục:";
            // 
            // dgvDSDanhMuc
            // 
            this.dgvDSDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSDanhMuc.Location = new System.Drawing.Point(4, 25);
            this.dgvDSDanhMuc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDSDanhMuc.Name = "dgvDSDanhMuc";
            this.dgvDSDanhMuc.ReadOnly = true;
            this.dgvDSDanhMuc.RowHeadersWidth = 51;
            this.dgvDSDanhMuc.RowTemplate.Height = 24;
            this.dgvDSDanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDanhMuc.Size = new System.Drawing.Size(499, 485);
            this.dgvDSDanhMuc.TabIndex = 0;
            this.dgvDSDanhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDanhMuc_CellClick);
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage5.BackgroundImage")));
            this.tabPage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.txtFolder);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Controls.Add(this.btnOK);
            this.tabPage5.Controls.Add(this.btnBrowse);
            this.tabPage5.Controls.Add(this.defaultbill);
            this.tabPage5.Controls.Add(this.btnLoadDefaultImg);
            this.tabPage5.Location = new System.Drawing.Point(4, 33);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage5.Size = new System.Drawing.Size(1083, 666);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Set up";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(631, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Load Default:";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(636, 464);
            this.txtFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(358, 29);
            this.txtFolder.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(631, 407);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Images folder path:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.picAnh);
            this.groupBox4.Location = new System.Drawing.Point(26, 80);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(557, 514);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hình ảnh";
            // 
            // picAnh
            // 
            this.picAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAnh.Location = new System.Drawing.Point(4, 25);
            this.picAnh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(549, 486);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 1;
            this.picAnh.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(865, 527);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(129, 67);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(636, 527);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(135, 67);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Folder";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // defaultbill
            // 
            this.defaultbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultbill.Image = ((System.Drawing.Image)(resources.GetObject("defaultbill.Image")));
            this.defaultbill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.defaultbill.Location = new System.Drawing.Point(865, 147);
            this.defaultbill.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.defaultbill.Name = "defaultbill";
            this.defaultbill.Size = new System.Drawing.Size(129, 60);
            this.defaultbill.TabIndex = 0;
            this.defaultbill.Text = "Bill";
            this.defaultbill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.defaultbill.UseVisualStyleBackColor = true;
            this.defaultbill.Click += new System.EventHandler(this.Default_Bill);
            // 
            // btnLoadDefaultImg
            // 
            this.btnLoadDefaultImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDefaultImg.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadDefaultImg.Image")));
            this.btnLoadDefaultImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadDefaultImg.Location = new System.Drawing.Point(636, 147);
            this.btnLoadDefaultImg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoadDefaultImg.Name = "btnLoadDefaultImg";
            this.btnLoadDefaultImg.Size = new System.Drawing.Size(135, 60);
            this.btnLoadDefaultImg.TabIndex = 0;
            this.btnLoadDefaultImg.Text = "Image";
            this.btnLoadDefaultImg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadDefaultImg.UseVisualStyleBackColor = true;
            this.btnLoadDefaultImg.Click += new System.EventHandler(this.btnLoadDefaultImg_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 703);
            this.Controls.Add(this.TabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhà Hàng";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDanhSachMon;
        private System.Windows.Forms.ComboBox cboSortType;
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
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaButton btnXoa_tab1;
        private Guna.UI.WinForms.GunaButton btnPrint;
        private Guna.UI.WinForms.GunaButton btnXem_tab1;
        private Guna.UI.WinForms.GunaButton btnThem;
        private Guna.UI.WinForms.GunaButton btnXem;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaButton btnSort;
        private Guna.UI.WinForms.GunaButton btnXoa;
        private Guna.UI.WinForms.GunaButton btnSua;
        private Guna.UI.WinForms.GunaButton btnThemDM;
        private Guna.UI.WinForms.GunaButton btnXoaDM;
        private Guna.UI.WinForms.GunaButton btnSuaDM;
        private System.Windows.Forms.Label label9;
    }
}

