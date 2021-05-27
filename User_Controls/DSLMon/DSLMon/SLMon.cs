using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSLMon
{
    public partial class SLMon : UserControl
    {
        public SLMon()
        {
            InitializeComponent();
            this.tongtien.TextChanged += new EventHandler(Text_Changed);
        }
        private int SLConLai = 100;
        public string TenMon
        {
            get
            {
                return tenmon.Text;
            }
            set
            {
                tenmon.Text = value;
            }
        }
        public int SoLuong
        {
            get
            {
                return Convert.ToInt32(textBox1.Text);
            }
            set
            {
                textBox1.Text = value.ToString();
            }
        }
        public int GiaTien { get; set; }
        public string TongTien
        {
            get
            {
                return tongtien.Text;
            }
            set
            {
                tongtien.Text = value;
            }
        }
        private void TangSL(object sender, EventArgs e)
        {
            if (SoLuong <= SLConLai)
            {
                SoLuong++;
                tongtien.Text = (GiaTien * SoLuong).ToString();
            }
        }
        private void GiamSL(object sender, EventArgs e)
        {
            if (SoLuong > 1)
            {
                {
                    SoLuong--;
                    tongtien.Text = (GiaTien * SoLuong).ToString();
                }
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.BorderColor = Color.DeepSkyBlue;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderSize = 1;
            button2.FlatAppearance.BorderColor = Color.DeepSkyBlue;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
        public event EventHandler TextChanged;
        protected virtual void OnTextChanged(EventArgs e)
        {
            var handler = TextChanged;
            if (handler != null)
                handler(this, e);
        }
        private void Text_Changed(object sender, EventArgs e)
        {
            OnTextChanged(e);
        }
    }
}
