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
using UC_FlashOrder;
using MyAlgo;
using AfterOrderDialog;
using CustomMessageBox;

namespace AdminForm
{
    public partial class OrderForm : Form
    {

        private UserControlHome ucHome { get; set; }
        private UCFlashOrder ucFlashOrder { get; set; }
        public OrderForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            BLL_OrderForm.Instance.setCbbDanhMucBan(cbbBanAn);
            tongtien.Text = "0";
            ucHome = new UserControlHome();
            ucFlashOrder = new UCFlashOrder();
            LoadUcHome();
        }
        #region support menthod
        private void ClearUCinPanel(Panel pn, UserControl uc)
        {
            if (pn.Contains(uc)) pn.Controls.Remove(uc);
        }
        private void HideControlsInPnMid()
        {
            pnDanhMuc.Dock = DockStyle.None;
            pnMons.Dock = DockStyle.None;
            pnDanhMuc.Hide();
            pnMons.Hide();
            danhMuc = null;
        }
        private void ShowControlsInPnMid()
        {
            pnDanhMuc.Dock = DockStyle.Left;
            pnMons.Dock = DockStyle.Fill;
            pnDanhMuc.Show();
            pnMons.Show();
        }
        private void HidePanelSortType()
        {
            pnSapXep.Enabled = false;
            pnSapXep.Hide();
        }
        private void UnHidePanelSortType()
        {
            pnSapXep.Enabled = true;
            pnSapXep.Show();
        }
        #endregion

        #region Home

        private void LoadUcHome()
        {
            pnMons.Controls.Clear();
            pnDanhMuc.Controls.Clear();
            HidePanelSortType();
            //
            ClearUCinPanel(pnMid, ucFlashOrder);
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
            ClearUCinPanel(pnMid, ucHome);
            ClearUCinPanel(pnMid, ucFlashOrder);
            ShowControlsInPnMid();
            setPanelDanhMuc(pnDanhMuc, "DA");
            UnHidePanelSortType();
        }
        private void btnDoUong_Click_1(object sender, EventArgs e)
        {
            ClearUCinPanel(pnMid, ucHome);
            ClearUCinPanel(pnMid, ucFlashOrder);
            ShowControlsInPnMid();
            setPanelDanhMuc(pnDanhMuc, "DU");
            UnHidePanelSortType();
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
                    btn.Text = "    "+i.TenDanhMuc;
                    btn.Tag = i; // button đang chứa 1 đối tượng danh mục
                    pn.Controls.Add(btn);
                    btn.Dock = DockStyle.Top;
                    BLL_OrderForm.Instance.setButtonDanhMuc(btn);
                    btn.Click += new System.EventHandler(danhMuc_Click);

                }
            }
        }
        //click Sort types

        private void radTopOrder_CheckedChanged(object sender, EventArgs e)
        {
            if(danhMuc != null)
            {
                List<Mon> mons = BusinessLogicLayer.Instance.GetMonByIDDanhMuc(danhMuc.IdDanhMuc);
                mons = MyAlgorithms.Instance.MonsSapXep_FO(mons.ToArray(), Mon.GiamSoLanGoi);
                ShowMonByDanhMuc(pnMons, mons);
            }
        }

        private void radGiaTang_CheckedChanged(object sender, EventArgs e)
        {
            if (danhMuc != null)
            {
                List<Mon> mons = BusinessLogicLayer.Instance.GetMonByIDDanhMuc(danhMuc.IdDanhMuc);
                mons = MyAlgorithms.Instance.MonsSapXep_FO(mons.ToArray(), Mon.TangGiaTien);
                ShowMonByDanhMuc(pnMons, mons);
            }
        }

        private void radGiaGiam_CheckedChanged(object sender, EventArgs e)
        {
            if (danhMuc != null)
            {
                List<Mon> mons = BusinessLogicLayer.Instance.GetMonByIDDanhMuc(danhMuc.IdDanhMuc);
                mons = MyAlgorithms.Instance.MonsSapXep_FO(mons.ToArray(), Mon.GiamGiaTien);
                ShowMonByDanhMuc(pnMons, mons);
            }
        }
        //Click Danh mục
        private DanhMuc danhMuc = null;
        private void danhMuc_Click(object sender, EventArgs e)
        {
            GunaAdvenceButton btnDm = (GunaAdvenceButton)sender;
            danhMuc = btnDm.Tag as DanhMuc;
            List<Mon> mons = BusinessLogicLayer.Instance.GetMonByIDDanhMuc(danhMuc.IdDanhMuc);
            if (radGiaGiam.Checked)
            {
                mons = MyAlgorithms.Instance.MonsSapXep_FO(mons.ToArray(), Mon.GiamGiaTien);
            }
            if (radGiaTang.Checked)
            {
                mons = MyAlgorithms.Instance.MonsSapXep_FO(mons.ToArray(), Mon.TangGiaTien);
            }
            if (radTopOrder.Checked)
            {
                mons = MyAlgorithms.Instance.MonsSapXep_FO(mons.ToArray(), Mon.GiamSoLanGoi);
            }
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
            try
            {
                UCMon obj = (UCMon)sender;
                Mon m = obj.Tag as Mon;
                SLMon objMon = new SLMon();
                objMon.IdMon = m.IdMon;
                objMon.Name = m.TenMon;
                objMon.TenMon = m.TenMon;
                objMon.SoLuong = 1;
                objMon.GiaTien = m.GiaTien;
                objMon.TongTien = m.GiaTien.ToString();
                if (pnDSL.Controls.Count == 0)
                {
                    objMon.TextChanged += SLMon_Changed;
                    pnDSL.Controls.Add(objMon);
                    tongtien.Text = objMon.TongTien;
                }
                else if (pnDSL.Controls.Count != 0)
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
                    if (!CheckNameMon)
                    {
                        objMon.TextChanged += SLMon_Changed;
                        pnDSL.Controls.Add(objMon);
                        Tien += objMon.GiaTien;
                        tongtien.Text = Tien.ToString();
                    }
                }
            }
            catch(Exception)
            {

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


        #region Flash Order
        private void LoadUcFlashOrder()
        {
            pnMons.Controls.Clear();
            pnDanhMuc.Controls.Clear();
            HidePanelSortType();
            //
            pnMid.Controls.Add(ucFlashOrder);
            ClearUCinPanel(pnMid, ucHome);
            HideControlsInPnMid();
            ucFlashOrder.Dock = DockStyle.Fill;
            ucFlashOrder.BringToFront();
        }
        private void btnFlash_Click(object sender, EventArgs e)
        {
            LoadUcFlashOrder();
            ucFlashOrder.OrderNow += ThemVaoBill;
        }

        private void ThemVaoBill(object sender, EventArgs e)
        {
            List<Mon> mons = ucFlashOrder.listMonFO;
            if(mons == null)
            {
                MyMessageBox.ShowMessage("Chưa có món nào!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for(int i = 0; i < mons.Count; i++)
            {
                SLMon objMon = new SLMon();
                objMon.IdMon = mons[i].IdMon;
                objMon.Name = mons[i].TenMon;
                objMon.TenMon = mons[i].TenMon;
                objMon.SoLuong = 1;
                objMon.GiaTien = mons[i].GiaTien;
                objMon.TongTien = mons[i].GiaTien.ToString();
                if (pnDSL.Controls.Count == 0)
                {
                    objMon.TextChanged += SLMon_Changed;
                    pnDSL.Controls.Add(objMon);
                    tongtien.Text = objMon.TongTien;
                }
                else if (pnDSL.Controls.Count != 0)
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
                    if (!CheckNameMon)
                    {
                        objMon.TextChanged += SLMon_Changed;
                        pnDSL.Controls.Add(objMon);
                        Tien += objMon.GiaTien;
                        tongtien.Text = Tien.ToString();
                    }
                }
            }
        }
        #endregion

        #region dat don
        private void datdon_Click(object sender, EventArgs e)
        {
            if(pnDSL.Controls.Count == 0)
            {
                MyMessageBox.ShowMessage("Quý khách chưa chọn món!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult res = MyMessageBox.ShowMessage("Quý khách chắc chắn đặt món?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                int idBan = ((CBBItem)cbbBanAn.SelectedItem).Value;
                List<int> idMon = new List<int>();
                List<int> slMon = new List<int>();
                foreach (var SLMon in pnDSL.Controls.OfType<SLMon>())
                {
                    idMon.Add(SLMon.IdMon);
                    slMon.Add(SLMon.SoLuong);
                }
                if (BLL_OrderForm.Instance.AddBillToData_BLL(idBan, idMon, slMon) == true && BLL_OrderForm.Instance.UpdateSLG_BLL(idMon) == true)
                {
                    MyMessageBox.ShowMessage("Đặt món thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AfterOrderForm f = new AfterOrderForm();
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.Show();
                    pnDSL.Controls.Clear();
                }
                else
                {
                    MyMessageBox.ShowMessage("Đặt món thất bại!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MyMessageBox.ShowMessage("Đặt món thất bại!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void huy_Click(object sender, EventArgs e)
        {
            if(pnDSL.Controls.Count == 0)
            {
                return;
            }
            DialogResult res = MyMessageBox.ShowMessage("Quý khách chắc chắn xóa hết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                pnDSL.Controls.Clear();
            }
        }

        #endregion
    }
}
