
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
            this.ptadmin = new System.Windows.Forms.PictureBox();
            this.ptcustomer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ptEixt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptadmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(154, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ptadmin
            // 
            this.ptadmin.Image = ((System.Drawing.Image)(resources.GetObject("ptadmin.Image")));
            this.ptadmin.Location = new System.Drawing.Point(49, 453);
            this.ptadmin.Name = "ptadmin";
            this.ptadmin.Size = new System.Drawing.Size(150, 150);
            this.ptadmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptadmin.TabIndex = 1;
            this.ptadmin.TabStop = false;
            this.ptadmin.Click += new System.EventHandler(this.ptadmin_Click);
            // 
            // ptcustomer
            // 
            this.ptcustomer.Image = ((System.Drawing.Image)(resources.GetObject("ptcustomer.Image")));
            this.ptcustomer.Location = new System.Drawing.Point(251, 453);
            this.ptcustomer.Name = "ptcustomer";
            this.ptcustomer.Size = new System.Drawing.Size(150, 150);
            this.ptcustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcustomer.TabIndex = 2;
            this.ptcustomer.TabStop = false;
            this.ptcustomer.Click += new System.EventHandler(this.ptcustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(255, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer";
            // 
            // ptEixt
            // 
            this.ptEixt.BackColor = System.Drawing.Color.Red;
            this.ptEixt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ptEixt.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptEixt.Location = new System.Drawing.Point(376, -1);
            this.ptEixt.Name = "ptEixt";
            this.ptEixt.Size = new System.Drawing.Size(75, 40);
            this.ptEixt.TabIndex = 5;
            this.ptEixt.Text = "X";
            this.ptEixt.UseVisualStyleBackColor = false;
            this.ptEixt.Click += new System.EventHandler(this.ptEixt_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(450, 640);
            this.Controls.Add(this.ptEixt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptcustomer);
            this.Controls.Add(this.ptadmin);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptadmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptadmin;
        private System.Windows.Forms.PictureBox ptcustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ptEixt;
    }
}