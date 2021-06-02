using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl_Mon_FlashOrder
{
    public partial class UC_MonFO: UserControl
    {
        public UC_MonFO()
        {
            InitializeComponent();
        }
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
        public int SLGoi
        {
            get
            {
                return int.Parse(lblSLGoi.Text);
            }
            set
            {
                lblSLGoi.Text = value + "";
            }
        }
        public string TenMon
        {
            get
            {
                return lblTenMon.Text;
            }
            set
            {
                lblTenMon.Text = value;
            }
        }
        public Image AnhMinhHoa
        {
            set
            {
                picHinhAnh.Image = value;
            }
        }
    }
}
