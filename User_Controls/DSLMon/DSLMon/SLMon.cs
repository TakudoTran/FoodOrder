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
        public int IdMon { get; set; }
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
