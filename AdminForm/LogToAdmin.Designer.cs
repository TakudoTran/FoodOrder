
namespace AdminForm
{
    partial class LogToAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogToAdmin));
            this.ptEixt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptuser = new System.Windows.Forms.PictureBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.ptpw = new System.Windows.Forms.PictureBox();
            this.btlog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptpw)).BeginInit();
            this.SuspendLayout();
            // 
            // ptEixt
            // 
            this.ptEixt.BackColor = System.Drawing.Color.Red;
            this.ptEixt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ptEixt.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptEixt.ForeColor = System.Drawing.Color.White;
            this.ptEixt.Location = new System.Drawing.Point(333, 1);
            this.ptEixt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptEixt.Name = "ptEixt";
            this.ptEixt.Size = new System.Drawing.Size(67, 32);
            this.ptEixt.TabIndex = 6;
            this.ptEixt.Text = "X";
            this.ptEixt.UseVisualStyleBackColor = false;
            this.ptEixt.Click += new System.EventHandler(this.ptEixt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ptuser
            // 
            this.ptuser.BackColor = System.Drawing.Color.Transparent;
            this.ptuser.Image = global::AdminForm.Properties.Resources.user;
            this.ptuser.Location = new System.Drawing.Point(40, 258);
            this.ptuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptuser.Name = "ptuser";
            this.ptuser.Size = new System.Drawing.Size(44, 46);
            this.ptuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptuser.TabIndex = 8;
            this.ptuser.TabStop = false;
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(220)))), ((int)(((byte)(247)))));
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.Black;
            this.txtuser.Location = new System.Drawing.Point(93, 277);
            this.txtuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(244, 27);
            this.txtuser.TabIndex = 9;
            this.txtuser.Text = "Username";
            this.txtuser.Click += new System.EventHandler(this.txtuser_Click);
            this.txtuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuser_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(44, 303);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 1);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(44, 382);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 1);
            this.panel2.TabIndex = 13;
            // 
            // txtpw
            // 
            this.txtpw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(220)))), ((int)(((byte)(247)))));
            this.txtpw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpw.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpw.ForeColor = System.Drawing.Color.Black;
            this.txtpw.Location = new System.Drawing.Point(93, 354);
            this.txtpw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(244, 27);
            this.txtpw.TabIndex = 12;
            this.txtpw.Text = "Password";
            this.txtpw.Click += new System.EventHandler(this.txtpw_Click);
            this.txtpw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpw_KeyPress);
            // 
            // ptpw
            // 
            this.ptpw.BackColor = System.Drawing.Color.Transparent;
            this.ptpw.Image = global::AdminForm.Properties.Resources.pw;
            this.ptpw.Location = new System.Drawing.Point(40, 338);
            this.ptpw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptpw.Name = "ptpw";
            this.ptpw.Size = new System.Drawing.Size(44, 46);
            this.ptpw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptpw.TabIndex = 11;
            this.ptpw.TabStop = false;
            // 
            // btlog
            // 
            this.btlog.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlog.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlog.ForeColor = System.Drawing.Color.Black;
            this.btlog.Image = ((System.Drawing.Image)(resources.GetObject("btlog.Image")));
            this.btlog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btlog.Location = new System.Drawing.Point(104, 404);
            this.btlog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btlog.Name = "btlog";
            this.btlog.Size = new System.Drawing.Size(184, 64);
            this.btlog.TabIndex = 14;
            this.btlog.Text = "Sign In";
            this.btlog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btlog.UseVisualStyleBackColor = false;
            this.btlog.Click += new System.EventHandler(this.btlog_Click);
            // 
            // LogToAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 512);
            this.Controls.Add(this.btlog);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.ptpw);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.ptuser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ptEixt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LogToAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogToAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptpw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ptEixt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptuser;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.PictureBox ptpw;
        private System.Windows.Forms.Button btlog;
    }
}