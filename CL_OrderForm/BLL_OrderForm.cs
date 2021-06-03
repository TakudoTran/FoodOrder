using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;
using Guna.UI.WinForms;
using System.Drawing;
using BLL;
using UC_Mon;
using DAL;

namespace CL_OrderForm
{
    public class BLL_OrderForm
    {
        private static BLL_OrderForm _Instance;
        public static BLL_OrderForm Instance
        {
            get
            {
                if (_Instance == null) return _Instance = new BLL_OrderForm();
                return _Instance;
            }
        }
        private BLL_OrderForm() { }
        #region panel danh muc
        public void setButtonDanhMuc(GunaAdvenceButton btn)
        {
            btn.AnimationHoverSpeed = 0.07F;
            btn.AnimationSpeed = 0.03F;
            btn.BaseColor = System.Drawing.Color.White;
            btn.BorderColor = System.Drawing.Color.Black;
            btn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            btn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(134)))));
            btn.CheckedBorderColor = System.Drawing.Color.Gray;
            btn.CheckedForeColor = System.Drawing.Color.Black;
            btn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(10)))));
            btn.DialogResult = System.Windows.Forms.DialogResult.None;
            btn.Dock = System.Windows.Forms.DockStyle.Top;
            btn.FocusedColor = System.Drawing.Color.Empty;
            btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            btn.ForeColor = System.Drawing.Color.DimGray;
            btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(231)))), ((int)(((byte)(189)))));
            btn.LineRight = 5;
            btn.Location = new System.Drawing.Point(0, 93);
            btn.Image = null;
            btn.CheckedImage = null;
        }


        #endregion

        #region danh muc ban
        private List<CBBItem> GetCBBItems()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (BanAn i in GetAllDanhMucBan())
            {
                data.Add(new CBBItem
                {
                    Value = i.IdBan,
                    Text = i.TenBan
                });
            }
            return data;
        }
        public List<BanAn> GetAllDanhMucBan()
        {
            return DataAccessLayer.Instance.GetAllDanhMucBan_DAL();
        }
        public void setCbbDanhMucBan(ComboBox cb)
        {
            cb.Items.AddRange(GetCBBItems().ToArray());
            cb.SelectedIndex = 0;
        }
        #endregion

        #region ghi bill
        public bool AddBillToData_BLL(int idBan, List<int> idMon, List<int> sl)
        {
            return DataAccessLayer.Instance.AddBillToData_DAL(idBan, idMon, sl);
        }
        public bool UpdateSLG_BLL(List<int> idMon)
        {
            bool check = true;
            foreach(int i in idMon)
            {
                if (DataAccessLayer.Instance.UpdateSLG_DAL(i))
                {
                    check = true;
                }
                else check = false;
            }
            return check;
        }
        #endregion

    }


}
