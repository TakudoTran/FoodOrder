using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UC_Mon;
using DTO;
using BLL;

namespace AdminForm
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
        }

        private void btnDoAn_Click(object sender, EventArgs e)
        {
            pnMons.Controls.Clear();
            List<Mon> listMon = BusinessLogicLayer.Instance.GetAllMon();
            for (int i = 0; i < listMon.Count; i++)
            {
                UCMon mon = new UCMon();
                mon.GiaTien = listMon[i].GiaTien;
                mon.TenMon = listMon[i].TenMon;


                Image anh = Image.FromStream(BusinessLogicLayer.Instance.GetByteValuesOfAnh(listMon[i].IdAnh));
                mon.AnhMinhHoa = anh;
                mon.Tag = listMon[i];

                mon.Click += new EventHandler(btnMon_Click);
                pnMons.Controls.Add(mon);

            }
        }

        private void btnMon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("đâsdasdasda");
        }
    }
}
