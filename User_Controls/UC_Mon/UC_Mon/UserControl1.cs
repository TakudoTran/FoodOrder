using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_Mon
{
    public partial class UCMon : UserControl
    {
        public int GiaTien
        {
            get
            {
                return int.Parse(lblGiaTien.Text);
            }
            set
            {
                lblGiaTien.Text = value + "";
            }
        }
        public string TenMon
        {
            get
            {
                return lblTen.Text;
            }
            set
            {
                lblTen.Text = value;
            }
        }
        public Image AnhMinhHoa
        {
            set
            {
                this.BackgroundImage = value;
            }
        }
        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                foreach (Control control in Controls)
                {
                    control.Click += value;
                }
            }
            remove
            {
                base.Click -= value;
                foreach (Control control in Controls)
                {
                    control.Click -= value;
                }
            }
        }
        public UCMon()
        {
            InitializeComponent();
            this.btnOrder.Click += new EventHandler(childControls_Click);
            this.gunaShadowPanel1.Click += new EventHandler(childControls_Click);
            this.lblTen.Click += new EventHandler(childControls_Click);

        }

        private void childControls_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
