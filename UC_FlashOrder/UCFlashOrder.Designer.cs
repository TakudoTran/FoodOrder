namespace UC_FlashOrder
{
    partial class UCFlashOrder
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFlashOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.picSlide = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShow = new Guna.UI.WinForms.GunaGradientButton();
            this.btnChonAll = new Guna.UI.WinForms.GunaGradientButton();
            this.pnMons = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSlide)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picSlide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 271);
            this.panel1.TabIndex = 5;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.txtTien);
            this.gunaLinePanel1.LineBottom = 2;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.DarkOrange;
            this.gunaLinePanel1.LineLeft = 2;
            this.gunaLinePanel1.LineRight = 2;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 2;
            this.gunaLinePanel1.Location = new System.Drawing.Point(19, 3);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(166, 55);
            this.gunaLinePanel1.TabIndex = 7;
            // 
            // txtTien
            // 
            this.txtTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(190)))));
            this.txtTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTien.Font = new System.Drawing.Font("SVN-Blenda Script", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTien.ForeColor = System.Drawing.Color.DimGray;
            this.txtTien.Location = new System.Drawing.Point(6, 10);
            this.txtTien.Multiline = true;
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(154, 34);
            this.txtTien.TabIndex = 0;
            this.txtTien.Text = "Nhập số tiền";
            this.txtTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTien.Click += new System.EventHandler(this.txtTien_Click_1);
            this.txtTien.TextChanged += new System.EventHandler(this.txtTien_TextChanged);
            // 
            // picSlide
            // 
            this.picSlide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSlide.ErrorImage = null;
            this.picSlide.Image = ((System.Drawing.Image)(resources.GetObject("picSlide.Image")));
            this.picSlide.Location = new System.Drawing.Point(0, 0);
            this.picSlide.Name = "picSlide";
            this.picSlide.Size = new System.Drawing.Size(1405, 271);
            this.picSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlide.TabIndex = 6;
            this.picSlide.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gunaLinePanel1);
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Controls.Add(this.btnChonAll);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1212, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 428);
            this.panel2.TabIndex = 10;
            // 
            // btnShow
            // 
            this.btnShow.AnimationHoverSpeed = 0.07F;
            this.btnShow.AnimationSpeed = 0.03F;
            this.btnShow.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.btnShow.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(51)))));
            this.btnShow.BorderColor = System.Drawing.Color.Black;
            this.btnShow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShow.FocusedColor = System.Drawing.Color.Empty;
            this.btnShow.Font = new System.Drawing.Font("SVN-Blenda Script", 12F);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnShow.ImageSize = new System.Drawing.Size(30, 30);
            this.btnShow.Location = new System.Drawing.Point(19, 90);
            this.btnShow.Name = "btnShow";
            this.btnShow.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnShow.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnShow.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnShow.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShow.OnHoverImage = null;
            this.btnShow.OnPressedColor = System.Drawing.Color.Black;
            this.btnShow.Size = new System.Drawing.Size(166, 55);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Xem ";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnChonAll
            // 
            this.btnChonAll.AnimationHoverSpeed = 0.07F;
            this.btnChonAll.AnimationSpeed = 0.03F;
            this.btnChonAll.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
            this.btnChonAll.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(51)))));
            this.btnChonAll.BorderColor = System.Drawing.Color.Black;
            this.btnChonAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChonAll.FocusedColor = System.Drawing.Color.Empty;
            this.btnChonAll.Font = new System.Drawing.Font("SVN-Blenda Script", 12F);
            this.btnChonAll.ForeColor = System.Drawing.Color.White;
            this.btnChonAll.Image = ((System.Drawing.Image)(resources.GetObject("btnChonAll.Image")));
            this.btnChonAll.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnChonAll.ImageSize = new System.Drawing.Size(25, 25);
            this.btnChonAll.Location = new System.Drawing.Point(19, 183);
            this.btnChonAll.Name = "btnChonAll";
            this.btnChonAll.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnChonAll.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnChonAll.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChonAll.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChonAll.OnHoverImage = null;
            this.btnChonAll.OnPressedColor = System.Drawing.Color.Black;
            this.btnChonAll.Size = new System.Drawing.Size(166, 64);
            this.btnChonAll.TabIndex = 4;
            this.btnChonAll.Text = "Thêm tất cả";
            this.btnChonAll.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // pnMons
            // 
            this.pnMons.AutoScroll = true;
            this.pnMons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMons.Location = new System.Drawing.Point(0, 0);
            this.pnMons.Name = "pnMons";
            this.pnMons.Size = new System.Drawing.Size(1212, 428);
            this.pnMons.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 271);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1405, 5);
            this.panel4.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pnMons);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 276);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1405, 428);
            this.panel5.TabIndex = 13;
            // 
            // UCFlashOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "UCFlashOrder";
            this.Size = new System.Drawing.Size(1405, 704);
            this.panel1.ResumeLayout(false);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSlide)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaGradientButton btnShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picSlide;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel pnMons;
        private Guna.UI.WinForms.GunaGradientButton btnChonAll;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}
