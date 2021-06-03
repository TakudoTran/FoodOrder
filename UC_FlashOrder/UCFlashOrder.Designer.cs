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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFlashOrder));
            this.btnShow = new Guna.UI.WinForms.GunaGradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.picSlide = new System.Windows.Forms.PictureBox();
            this.timerFO = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChonAll = new Guna.UI.WinForms.GunaGradientButton();
            this.pnMons = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSlide)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.AnimationHoverSpeed = 0.07F;
            this.btnShow.AnimationSpeed = 0.03F;
            this.btnShow.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnShow.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnShow.BorderColor = System.Drawing.Color.Black;
            this.btnShow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShow.FocusedColor = System.Drawing.Color.Empty;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.ImageSize = new System.Drawing.Size(30, 30);
            this.btnShow.Location = new System.Drawing.Point(13, 6);
            this.btnShow.Name = "btnShow";
            this.btnShow.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnShow.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnShow.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnShow.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShow.OnHoverImage = null;
            this.btnShow.OnPressedColor = System.Drawing.Color.Black;
            this.btnShow.Size = new System.Drawing.Size(155, 55);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.picSlide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 334);
            this.panel1.TabIndex = 5;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.txtTien);
            this.gunaLinePanel1.LineBottom = 2;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Blue;
            this.gunaLinePanel1.LineLeft = 2;
            this.gunaLinePanel1.LineRight = 2;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 2;
            this.gunaLinePanel1.Location = new System.Drawing.Point(54, 276);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(157, 55);
            this.gunaLinePanel1.TabIndex = 7;
            // 
            // txtTien
            // 
            this.txtTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTien.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTien.Location = new System.Drawing.Point(2, 11);
            this.txtTien.Multiline = true;
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(152, 34);
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
            this.picSlide.Image = global::UC_FlashOrder.Properties.Resources.img1;
            this.picSlide.Location = new System.Drawing.Point(0, 0);
            this.picSlide.Name = "picSlide";
            this.picSlide.Size = new System.Drawing.Size(1405, 334);
            this.picSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlide.TabIndex = 6;
            this.picSlide.TabStop = false;
            // 
            // timerFO
            // 
            this.timerFO.Interval = 1500;
            this.timerFO.Tick += new System.EventHandler(this.timerFO_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Controls.Add(this.btnChonAll);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1209, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 356);
            this.panel2.TabIndex = 10;
            // 
            // btnChonAll
            // 
            this.btnChonAll.AnimationHoverSpeed = 0.07F;
            this.btnChonAll.AnimationSpeed = 0.03F;
            this.btnChonAll.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnChonAll.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnChonAll.BorderColor = System.Drawing.Color.Black;
            this.btnChonAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChonAll.FocusedColor = System.Drawing.Color.Empty;
            this.btnChonAll.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnChonAll.ForeColor = System.Drawing.Color.White;
            this.btnChonAll.Image = null;
            this.btnChonAll.ImageSize = new System.Drawing.Size(30, 30);
            this.btnChonAll.Location = new System.Drawing.Point(13, 192);
            this.btnChonAll.Name = "btnChonAll";
            this.btnChonAll.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnChonAll.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnChonAll.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChonAll.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChonAll.OnHoverImage = null;
            this.btnChonAll.OnPressedColor = System.Drawing.Color.Black;
            this.btnChonAll.Size = new System.Drawing.Size(155, 64);
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
            this.pnMons.Size = new System.Drawing.Size(1209, 356);
            this.pnMons.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.gunaLinePanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1166, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 334);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 334);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1405, 14);
            this.panel4.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pnMons);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 348);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1405, 356);
            this.panel5.TabIndex = 13;
            // 
            // UCFlashOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaGradientButton btnShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picSlide;
        private System.Windows.Forms.Timer timerFO;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel pnMons;
        private Guna.UI.WinForms.GunaGradientButton btnChonAll;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}
