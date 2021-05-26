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
using Guna.UI.WinForms;
using CL_ForOrderForm;

namespace AdminForm
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        #region Do An / Do Uong

        private void btnDoAn_Click(object sender, EventArgs e)
        {
            setPanelDanhMuc(pnDanhMuc, "DA");
        }
        private void btnDoUong_Click_1(object sender, EventArgs e)
        {
            setPanelDanhMuc(pnDanhMuc, "DU");
        }

        public void setPanelDanhMuc(GunaGradient2Panel pn, string loai)
        {
            List<DanhMuc> danhMucOfDoAn = new List<DanhMuc>();
            foreach (DanhMuc i in BusinessLogicLayer.Instance.GetAllDanhMuc())
            {
                if (i.Loai.Equals(loai)) danhMucOfDoAn.Add(i);
            }
            if (danhMucOfDoAn != null)
            {
                pn.Controls.Clear();
                foreach (DanhMuc i in danhMucOfDoAn)
                {
                    GunaAdvenceButton btn = new GunaAdvenceButton();
                    btn.Text = i.TenDanhMuc;
                    btn.Tag = i; // button đang chứa 1 đối tượng danh mục
                    pn.Controls.Add(btn);
                    btn.Dock = DockStyle.Top;
                    BLL_OrderForm.Instance.setButtonDanhMuc(btn);
                    btn.Click += new System.EventHandler(danhMuc_Click);

                }
            }
        }
        //Click Danh mục
        private void danhMuc_Click(object sender, EventArgs e)
        {
            GunaAdvenceButton btnDm = (GunaAdvenceButton)sender;
            DanhMuc dm = btnDm.Tag as DanhMuc;
            List<Mon> mons = BusinessLogicLayer.Instance.GetMonByIDDanhMuc(dm.IdDanhMuc);
            ShowMonByDanhMuc(pnMons, mons);
        }
        private void ShowMonByDanhMuc(FlowLayoutPanel pn, List<Mon> mons)
        {
            pn.Controls.Clear();
            for (int i = 0; i < mons.Count; i++)
            {
                UCMon mon = new UCMon();

                mon.GiaTien = mons[i].GiaTien;
                mon.TenMon = mons[i].TenMon;
                Image anh = Image.FromStream(BusinessLogicLayer.Instance.GetByteValuesOfAnh(mons[i].IdAnh));
                mon.AnhMinhHoa = anh;

                mon.Tag = mons[i]; // UC_mon đang chứa 1 đối tượng món

                mon.Click += btnMon_Click;
                pnMons.Controls.Add(mon);

            }
        }


        // Xử lý click chọn món ở đây
        private void btnMon_Click(object sender, EventArgs e)
        {
            UCMon obj = (UCMon)sender;
            Mon m = obj.Tag as Mon;
            MessageBox.Show(m.TenMon + "  " + m.GiaTien);
        }


        #endregion

    }
}
