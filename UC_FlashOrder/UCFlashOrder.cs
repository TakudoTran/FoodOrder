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

namespace UC_FlashOrder
{
    public partial class UCFlashOrder : UserControl
    {
        private List<string> imgPaths;
        private List<Mon> AllMon;
        private List<Mon> _listMonFO = null;
        public List<Mon> listMonFO
        {
            get
            {
                return _listMonFO;
            }
            set
            {
                _listMonFO = value;
            }
        }

        public UCFlashOrder()
        {
            InitializeComponent();
            AllMon = BusinessLogicLayer.Instance.GetAllMon();
        }
        public string GetImgPath()
        {
            string currentPath = Directory.GetCurrentDirectory();
            string Imgpath = currentPath + @"\ImageSlider";
            return Imgpath;
        }

        private void btnShow_Click(object sender, EventArgs e)
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

        private void txtTien_Click(object sender, EventArgs e)
        {
            txtTien.Text = "";
        }
        private void timerFO_Tick(object sender, EventArgs e)
        {
        }
    }
}

