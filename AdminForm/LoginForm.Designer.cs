
namespace AdminForm
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ptEixt = new System.Windows.Forms.Button();
            this.btnManager = new Guna.UI.WinForms.GunaButton();
            this.btnCustomer = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(174, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer";
            // 
            // ptEixt
            // 
            this.ptEixt.BackColor = System.Drawing.Color.Red;
            this.ptEixt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ptEixt.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptEixt.Location = new System.Drawing.Point(250, -1);
            this.ptEixt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptEixt.Name = "ptEixt";
            this.ptEixt.Size = new System.Drawing.Size(50, 26);
            this.ptEixt.TabIndex = 5;
            this.ptEixt.Text = "X";
            this.ptEixt.UseVisualStyleBackColor = false;
            this.ptEixt.Click += new System.EventHandler(this.ptEixt_Click);
            // 
            // btnManager
            // 
            this.btnManager.AnimationHoverSpeed = 0.07F;
            this.btnManager.AnimationSpeed = 0.03F;
            this.btnManager.BackColor = System.Drawing.Color.Transparent;
            this.btnManager.BaseColor = System.Drawing.Color.Transparent;
            this.btnManager.BorderColor = System.Drawing.Color.Black;
            this.btnManager.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnManager.FocusedColor = System.Drawing.Color.Empty;
            this.btnManager.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnManager.ForeColor = System.Drawing.Color.White;
            this.btnManager.Image = ((System.Drawing.Image)(resources.GetObject("btnManager.Image")));
            this.btnManager.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnManager.ImageSize = new System.Drawing.Size(105, 105);
            this.btnManager.Location = new System.Drawing.Point(26, 290);
            this.btnManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManager.Name = "btnManager";
            this.btnManager.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnManager.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnManager.OnHoverForeColor = System.Drawing.Color.White;
            this.btnManager.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnManager.OnHoverImage")));
            this.btnManager.OnPressedColor = System.Drawing.Color.Black;
            this.btnManager.Size = new System.Drawing.Size(110, 116);
            this.btnManager.TabIndex = 7;
            this.btnManager.Click += new System.EventHandler(this.ptadmin_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.AnimationHoverSpeed = 0.07F;
            this.btnCustomer.AnimationSpeed = 0.03F;
            this.btnCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomer.BaseColor = System.Drawing.Color.Transparent;
            this.btnCustomer.BorderColor = System.Drawing.Color.Black;
            this.btnCustomer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCustomer.FocusedColor = System.Drawing.Color.Empty;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCustomer.ImageSize = new System.Drawing.Size(105, 105);
            this.btnCustomer.Location = new System.Drawing.Point(160, 290);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnCustomer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCustomer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCustomer.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnCustomer.OnHoverImage")));
            this.btnCustomer.OnPressedColor = System.Drawing.Color.Black;
            this.btnCustomer.Size = new System.Drawing.Size(110, 116);
            this.btnCustomer.TabIndex = 7;
            this.btnCustomer.Click += new System.EventHandler(this.ptcustomer_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(300, 416);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.ptEixt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ptEixt;
        private Guna.UI.WinForms.GunaButton btnManager;
        private Guna.UI.WinForms.GunaButton btnCustomer;
    }
}