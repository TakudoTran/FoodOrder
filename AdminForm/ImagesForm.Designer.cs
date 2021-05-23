
namespace AdminForm
{
    partial class ImagesForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachAnh = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachAnh);
            this.groupBox1.Location = new System.Drawing.Point(36, 129);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(376, 455);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách ảnh";
            // 
            // dgvDanhSachAnh
            // 
            this.dgvDanhSachAnh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachAnh.Location = new System.Drawing.Point(3, 23);
            this.dgvDanhSachAnh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDanhSachAnh.Name = "dgvDanhSachAnh";
            this.dgvDanhSachAnh.ReadOnly = true;
            this.dgvDanhSachAnh.RowHeadersWidth = 51;
            this.dgvDanhSachAnh.Size = new System.Drawing.Size(370, 428);
            this.dgvDanhSachAnh.TabIndex = 0;
            this.dgvDanhSachAnh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachAnh_CellClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(36, 44);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(71, 20);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Tên ảnh:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(130, 44);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(277, 26);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(540, 151);
            this.picAnh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(300, 305);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 3;
            this.picAnh.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(540, 515);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(106, 65);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(735, 515);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 65);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ImagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 649);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ImagesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImagesForm";
            this.Load += new System.EventHandler(this.ImagesForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvDanhSachAnh;
    }
}