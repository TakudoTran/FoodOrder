using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class AfterOrderForm : Form
    {
        public AfterOrderForm()
        {
            InitializeComponent();

        }
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            lblDanhGia.Text = "Tệ quá! Rất không hài lòng ";
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            lblDanhGia.Text = "Hmmm! Không hài lòng lắm ";
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            lblDanhGia.Text = "Hmm! Khá hài lòng ";
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            lblDanhGia.Text = "Okay! Hài lòng ";
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            lblDanhGia.Text = "Yeahh! Rất hài lòng!!! ";
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
