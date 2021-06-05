
namespace DSLMon
{
    partial class SLMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SLMon));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tongtien = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new Guna.UI.WinForms.GunaImageButton();
            this.tenmon = new System.Windows.Forms.Label();
            this.btnUp = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDown = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 14F);
            this.textBox1.Location = new System.Drawing.Point(322, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 34);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tongtien
            // 
            this.tongtien.AutoSize = true;
            this.tongtien.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongtien.Location = new System.Drawing.Point(426, 28);
            this.tongtien.Name = "tongtien";
            this.tongtien.Size = new System.Drawing.Size(38, 27);
            this.tongtien.TabIndex = 10;
            this.tongtien.Text = "60";
            this.tongtien.Click += new System.EventHandler(this.Text_Changed);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 5);
            this.panel1.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageSize = new System.Drawing.Size(35, 35);
            this.button3.Location = new System.Drawing.Point(3, 10);
            this.button3.Name = "button3";
            this.button3.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("button3.OnHoverImage")));
            this.button3.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.button3.Size = new System.Drawing.Size(37, 52);
            this.button3.TabIndex = 13;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tenmon
            // 
            this.tenmon.BackColor = System.Drawing.Color.Transparent;
            this.tenmon.Font = new System.Drawing.Font("SVN-Androgyne", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenmon.Location = new System.Drawing.Point(46, 11);
            this.tenmon.Name = "tenmon";
            this.tenmon.Size = new System.Drawing.Size(270, 50);
            this.tenmon.TabIndex = 15;
            this.tenmon.Text = "bún đậu mắm tôm (mẹt lớn)";
            this.tenmon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUp
            // 
            this.btnUp.AnimationHoverSpeed = 0.07F;
            this.btnUp.AnimationSpeed = 0.03F;
            this.btnUp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUp.BorderColor = System.Drawing.Color.Black;
            this.btnUp.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnUp.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnUp.CheckedForeColor = System.Drawing.Color.White;
            this.btnUp.CheckedImage = null;
            this.btnUp.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnUp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUp.FocusedColor = System.Drawing.Color.Empty;
            this.btnUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUp.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUp.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUp.Location = new System.Drawing.Point(371, 12);
            this.btnUp.Name = "btnUp";
            this.btnUp.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(0)))));
            this.btnUp.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUp.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUp.OnHoverImage = null;
            this.btnUp.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUp.OnPressedColor = System.Drawing.Color.Black;
            this.btnUp.Size = new System.Drawing.Size(25, 25);
            this.btnUp.TabIndex = 16;
            this.btnUp.Click += new System.EventHandler(this.TangSL);
            // 
            // btnDown
            // 
            this.btnDown.AnimationHoverSpeed = 0.07F;
            this.btnDown.AnimationSpeed = 0.03F;
            this.btnDown.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDown.BorderColor = System.Drawing.Color.Black;
            this.btnDown.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDown.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDown.CheckedForeColor = System.Drawing.Color.White;
            this.btnDown.CheckedImage = null;
            this.btnDown.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDown.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDown.FocusedColor = System.Drawing.Color.Empty;
            this.btnDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDown.ForeColor = System.Drawing.Color.White;
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDown.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDown.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDown.Location = new System.Drawing.Point(371, 42);
            this.btnDown.Name = "btnDown";
            this.btnDown.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(0)))));
            this.btnDown.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDown.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDown.OnHoverImage = null;
            this.btnDown.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDown.OnPressedColor = System.Drawing.Color.Black;
            this.btnDown.Size = new System.Drawing.Size(25, 25);
            this.btnDown.TabIndex = 16;
            this.btnDown.Click += new System.EventHandler(this.GiamSL);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "$";
            this.label1.Click += new System.EventHandler(this.Text_Changed);
            // 
            // SLMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.tenmon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tongtien);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SLMon";
            this.Size = new System.Drawing.Size(482, 79);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tongtien;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaImageButton button3;
        private System.Windows.Forms.Label tenmon;
        private Guna.UI.WinForms.GunaAdvenceButton btnUp;
        private Guna.UI.WinForms.GunaAdvenceButton btnDown;
        private System.Windows.Forms.Label label1;
    }
}
