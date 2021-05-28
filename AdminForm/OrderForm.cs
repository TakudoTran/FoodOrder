using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSLMon;
using UC_Mon;
using DTO;
using BLL;
using Guna.UI.WinForms;
using CL_OrderForm;

namespace AdminForm
{
    public partial class OrderForm : Form
    {
        private UserControlHome ucHome { get; set; }
        public OrderForm()
        {
            InitializeComponent();
            tongtien.Text = "0";
            ucHome = new UserControlHome();
            LoadUcHome();
        }
        #region Home

        private void ClearUCHome(Panel pn, UserControl uc)
        {
            pn.Controls.Remove(uc);
        }
        private void HideControlsInPnMid()
        {
            pnDanhMuc.Dock = DockStyle.None;
            pnMons.Dock = DockStyle.None;
            pnDanhMuc.Hide();
            pnMons.Hide();
        }
        private void ShowControlsInPnMid()
        {
            pnDanhMuc.Dock = DockStyle.Left;
            pnMons.Dock = DockStyle.Fill;
            pnDanhMuc.Show();
            pnMons.Show();
        }
        private void LoadUcHome()
        {
            pnMons.Controls.Clear();
            pnDanhMuc.Controls.Clear();
            pnMid.Controls.Add(ucHome);
            HideControlsInPnMid();
            ucHome.Dock = DockStyle.Fill;
            ucHome.BringToFront();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadUcHome();
        }

        #endregion

        #region Do An / Do Uong

        private void btnDoAn_Click(object sender, EventArgs e)
        {
            ClearUCHome(pnMid, ucHome);
            ShowControlsInPnMid();
            setPanelDanhMuc(pnDanhMuc, "DA");
        }
        private void btnDoUong_Click_1(object sender, EventArgs e)
        {
            ClearUCHome(pnMid, ucHome);
            ShowControlsInPnMid();
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
            SLMon objMon = new SLMon();
            objMon.Name = m.TenMon;
            objMon.TenMon = m.TenMon;
            objMon.SoLuong = 1;
            objMon.GiaTien = m.GiaTien;
            objMon.TongTien = m.GiaTien.ToString();
            if(pnDSL.Controls.Count == 0 )
            {
                objMon.TextChanged += SLMon_Changed;
                pnDSL.Controls.Add(objMon);
                tongtien.Text = objMon.TongTien;
            }  
            else if(pnDSL.Controls.Count != 0)
            {
                int Tien = 0;
                bool CheckNameMon = false;
                foreach (var SLMon in pnDSL.Controls.OfType<SLMon>())
                {
                    if (objMon.TenMon == SLMon.TenMon)
                    {
                        CheckNameMon = true;
                        break;
                    }
                    Tien += SLMon.GiaTien;
                }
                if(!CheckNameMon)
                {
                    objMon.TextChanged += SLMon_Changed;
                    pnDSL.Controls.Add(objMon);
                    Tien += objMon.GiaTien;
                    tongtien.Text = Tien.ToString();
                }    
            }    
              
        }
        private void SLMon_Changed(object sender, EventArgs e)
        {
            int Tien = 0;
            foreach(var SLMon in pnDSL.Controls.OfType<SLMon>())
            {
                Tien += Convert.ToInt32(SLMon.TongTien);
            }    
            tongtien.Text = Tien.ToString();
        }
        private void tinhtien_Click(object sender, EventArgs e)
        {
            int Tien = 0;
            foreach (var SLMon in pnDSL.Controls.OfType<SLMon>())
            {
                Tien += Convert.ToInt32(SLMon.TongTien);
            }
            tongtien.Text = Tien.ToString();
        }


        #endregion
        
    }
}
