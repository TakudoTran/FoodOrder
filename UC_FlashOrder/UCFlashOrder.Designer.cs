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
            this.txtTien = new Guna.UI.WinForms.GunaTextBox();
            this.btnShow = new Guna.UI.WinForms.GunaGradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerFO = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChonAll = new Guna.UI.WinForms.GunaGradientButton();
            this.pnMons = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTien
            // 
            this.txtTien.BaseColor = System.Drawing.Color.White;
            this.txtTien.BorderColor = System.Drawing.Color.Silver;
            this.txtTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTien.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTien.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTien.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic);
            this.txtTien.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtTien.Location = new System.Drawing.Point(933, 167);
            this.txtTien.Name = "txtTien";
            this.txtTien.PasswordChar = '\0';
            this.txtTien.SelectedText = "";
            this.txtTien.Size = new System.Drawing.Size(246, 48);
            this.txtTien.TabIndex = 1;
            this.txtTien.Text = "Nhập số tiền ";
            this.txtTien.Click += new System.EventHandler(this.txtTien_Click);
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
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.ImageSize = new System.Drawing.Size(30, 30);
            this.btnShow.Location = new System.Drawing.Point(1219, 167);
            this.btnShow.Name = "btnShow";
            this.btnShow.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnShow.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnShow.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnShow.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShow.OnHoverImage = null;
            this.btnShow.OnPressedColor = System.Drawing.Color.Black;
            this.btnShow.Size = new System.Drawing.Size(141, 48);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.txtTien);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 242);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1405, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // timerFO
            // 
            this.timerFO.Interval = 1500;
            this.timerFO.Tick += new System.EventHandler(this.timerFO_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnChonAll);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1219, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 462);
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
            this.btnChonAll.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnChonAll.ForeColor = System.Drawing.Color.White;
            this.btnChonAll.Image = null;
            this.btnChonAll.ImageSize = new System.Drawing.Size(30, 30);
            this.btnChonAll.Location = new System.Drawing.Point(6, 26);
            this.btnChonAll.Name = "btnChonAll";
            this.btnChonAll.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnChonAll.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnChonAll.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChonAll.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChonAll.OnHoverImage = null;
            this.btnChonAll.OnPressedColor = System.Drawing.Color.Black;
            this.btnChonAll.Size = new System.Drawing.Size(141, 48);
            this.btnChonAll.TabIndex = 4;
            this.btnChonAll.Text = "Chọn tất cả";
            this.btnChonAll.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // pnMons
            // 
            this.pnMons.AutoScroll = true;
            this.pnMons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMons.Location = new System.Drawing.Point(0, 242);
            this.pnMons.Name = "pnMons";
            this.pnMons.Size = new System.Drawing.Size(1219, 462);
            this.pnMons.TabIndex = 11;
            // 
            // UCFlashOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMons);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCFlashOrder";
            this.Size = new System.Drawing.Size(1405, 704);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox txtTien;
        private Guna.UI.WinForms.GunaGradientButton btnShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerFO;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel pnMons;
        private Guna.UI.WinForms.GunaGradientButton btnChonAll;
    }
}
