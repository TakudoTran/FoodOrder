using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;


namespace BLL
{
    public class BusinessLogicLayer
    {
        private static BusinessLogicLayer _Instance;
        public static BusinessLogicLayer Instance
        {
            get
            {
                if (_Instance == null) return _Instance = new BusinessLogicLayer();
                return _Instance;
            }
        }
        private BusinessLogicLayer() { }
        /// <summary>
        /// Phan nay danh cho combobox
        /// </summary>
        /// <returns></returns>
        private List<CBBItem> GetCBBItems()
        {
            List<CBBItem> data = new List<CBBItem>();
            data.Add(new CBBItem
            {
                Value = 0,
                Text = "All"
            });
            foreach (DanhMuc i in GetAllDanhMuc())
            {
                data.Add(new CBBItem
                {
                    Value = i.IdDanhMuc,
                    Text = i.TenDanhMuc
                });
            }
            return data;
        }

        public void setCbbDanhMuc(ComboBox cb)
        {
            cb.Items.AddRange(GetCBBItems().ToArray());
            cb.SelectedIndex = 0;
        }
       

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Mon> GetMonByIdDanhMucAndTenMon(int idMon,string tenMon)
        {
            return DataAccessLayer.Instance.GetMonByIdDanhMucAndTenMon(idMon, tenMon);
        }
        public List<Mon> GetAllMon()
        {
            return DataAccessLayer.Instance.GetAllMon_DAL();
        }
        public List<DanhMuc> GetAllDanhMuc()
        {
            return DataAccessLayer.Instance.GetAllDanhMuc_DAL();
        }

    }
}
