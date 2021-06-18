using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAlgo;
using BLL;
using DTO;
using UserControl_Mon_FlashOrder;
using System.IO;
using CustomMessageBox;

namespace UC_FlashOrder
{
    public partial class UCFlashOrder : UserControl
    {
        private List<Mon> AllMon;
        private List<Mon> _listMonFO = null;
        public List<Mon> listMonFO
        {
            get
            {
                return _listMonFO;
            }
        }

        public UCFlashOrder()
        {
            InitializeComponent();
            AllMon = BusinessLogicLayer.Instance.GetMons_DoAn();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(txtTien.Text == "" || txtTien.Text == "Nhập số tiền")
            {
                MyMessageBox.ShowMessage("Vui lòng nhập số tiền!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (string.IsNullOrEmpty(txtTien.Text)) return;
                int Tien = int.Parse(txtTien.Text);
                List<Mon> mons = MyAlgorithms.Instance.FlashOrder(AllMon, Tien);
                _listMonFO = mons;
                pnMons.Controls.Clear();
                for (int i = 0; i < mons.Count; i++)
                {
                    UC_MonFO mon = new UC_MonFO();
                    mon.GiaTien = mons[i].GiaTien;
                    mon.TenMon = mons[i].TenMon;
                    mon.SLGoi = mons[i].SoLanGoiMon;
                    Image anh = Image.FromStream(BusinessLogicLayer.Instance.GetByteValuesOfAnh(mons[i].IdAnh));
                    mon.AnhMinhHoa = anh;

                    mon.Tag = mons[i]; // UC_mon đang chứa 1 đối tượng món
                    pnMons.Controls.Add(mon);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public event EventHandler OrderNow;
        protected virtual void OnOrderNow(EventArgs e)
        {
            OrderNow?.Invoke(this, e);
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            OnOrderNow(EventArgs.Empty);
        }
        private void txtTien_Click_1(object sender, EventArgs e)
        {
            txtTien.Clear();
        }

        private void txtTien_TextChanged(object sender, EventArgs e)
        {
            txtTien.ForeColor = Color.Black;
        }

        private void txtTien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtTien.Text)) return;
                    int Tien = int.Parse(txtTien.Text);
                    List<Mon> mons = MyAlgorithms.Instance.FlashOrder(AllMon, Tien);
                    _listMonFO = mons;
                    pnMons.Controls.Clear();
                    for (int i = 0; i < mons.Count; i++)
                    {
                        UC_MonFO mon = new UC_MonFO();
                        mon.GiaTien = mons[i].GiaTien;
                        mon.TenMon = mons[i].TenMon;
                        mon.SLGoi = mons[i].SoLanGoiMon;
                        Image anh = Image.FromStream(BusinessLogicLayer.Instance.GetByteValuesOfAnh(mons[i].IdAnh));
                        mon.AnhMinhHoa = anh;

                        mon.Tag = mons[i]; // UC_mon đang chứa 1 đối tượng món
                        pnMons.Controls.Add(mon);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txtTien.Text = "";
            }
        }
    }
}

