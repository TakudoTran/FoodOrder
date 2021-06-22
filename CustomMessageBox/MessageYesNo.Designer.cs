
namespace CustomMessageBox
{
    partial class MessageYesNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageYesNo));
            this.btnYes = new Guna.UI.WinForms.GunaGradientButton();
            this.btnNo = new Guna.UI.WinForms.GunaGradientButton();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.Animated = true;
            this.btnYes.AnimationHoverSpeed = 0.07F;
            this.btnYes.AnimationSpeed = 0.03F;
            this.btnYes.BackColor = System.Drawing.Color.Transparent;
            this.btnYes.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnYes.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnYes.BorderColor = System.Drawing.Color.Black;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnYes.FocusedColor = System.Drawing.Color.Empty;
            this.btnYes.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Image = null;
            this.btnYes.ImageSize = new System.Drawing.Size(20, 20);
            this.btnYes.Location = new System.Drawing.Point(83, 31);
            this.btnYes.Name = "btnYes";
            this.btnYes.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(253)))), ((int)(((byte)(65)))));
            this.btnYes.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(253)))), ((int)(((byte)(69)))));
            this.btnYes.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnYes.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnYes.OnHoverImage = null;
            this.btnYes.OnPressedColor = System.Drawing.Color.Black;
            this.btnYes.Radius = 20;
            this.btnYes.Size = new System.Drawing.Size(96, 42);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "Yes";
            this.btnYes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Animated = true;
            this.btnNo.AnimationHoverSpeed = 0.07F;
            this.btnNo.AnimationSpeed = 0.03F;
            this.btnNo.BackColor = System.Drawing.Color.Transparent;
            this.btnNo.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnNo.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnNo.BorderColor = System.Drawing.Color.Black;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNo.FocusedColor = System.Drawing.Color.Empty;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Image = null;
            this.btnNo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNo.Location = new System.Drawing.Point(259, 31);
            this.btnNo.Name = "btnNo";
            this.btnNo.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(13)))), ((int)(((byte)(94)))));
            this.btnNo.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(95)))), ((int)(((byte)(135)))));
            this.btnNo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNo.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnNo.OnHoverImage = null;
            this.btnNo.OnPressedColor = System.Drawing.Color.Black;
            this.btnNo.Radius = 20;
            this.btnNo.Size = new System.Drawing.Size(96, 42);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // picIcon
            // 
            this.picIcon.Image = global::CustomMessageBox.Properties.Resources.question;
            this.picIcon.Location = new System.Drawing.Point(147, 5);
            this.picIcon.Margin = new System.Windows.Forms.Padding(5);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(145, 145);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.Red;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(387, 2);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.picIcon);
            this.panel1.Controls.Add(this.gunaControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 155);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnNo);
            this.panel3.Controls.Add(this.btnYes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 100);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblMessage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 80);
            this.panel2.TabIndex = 5;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Font = new System.Drawing.Font("SVN-Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(435, 80);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Xóa món không?";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageYesNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(194)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(435, 335);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MessageYesNo";
            this.Text = "MessageOK";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private Guna.UI.WinForms.GunaGradientButton btnYes;
        private Guna.UI.WinForms.GunaGradientButton btnNo;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMessage;
    }
}