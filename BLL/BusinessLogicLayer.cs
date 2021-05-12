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
       
        public void SetCbbDetailForm(ComboBox cb)
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (DanhMuc i in GetAllDanhMuc())
            {
                data.Add(new CBBItem
                {
                    Value = i.IdDanhMuc,
                    Text = i.TenDanhMuc
                });
            }
            cb.Items.AddRange(data.ToArray());
            cb.SelectedIndex = 0;
        }
        public void SetColumnHeader(DataGridView dgv)
        {
            dgv.Columns["IdMon"].HeaderText = "Id Món";
            dgv.Columns["TenMon"].HeaderText = "Tên Món";
            dgv.Columns["GiaTien"].HeaderText = "Giá Tiền";
            dgv.Columns["SoLanGoiMon"].HeaderText = "Số Lần Gọi Món";
            dgv.Columns["DanhMuc"].HeaderText = "Danh Mục";
        }
        /// <summary>
        /// //////////////////// all Funcs of Mon
        /// </summary>
        /// <returns></returns>
        public List<MonView> GetMonByIdDanhMucAndTenMon(int idMon,string st)
        {
            List<MonView> data = new List<MonView>();
            data = ConvertToListMonview(DataAccessLayer.Instance.GetMonByIdDanhMucAndTenMon(idMon, st));
            return data;
        }
        public Mon GetMonByIdMon(int idMon)
        {
            Mon m = new Mon();
            foreach(Mon i in GetAllMon())
            {
                if(idMon == i.IdMon)
                {
                    m = i;
                }
            }
            return m;
        }

        public List<Mon> GetAllMon()
        {
            return DataAccessLayer.Instance.GetAllMon_DAL();
        }
        public List<DanhMuc> GetAllDanhMuc()
        {
            return DataAccessLayer.Instance.GetAllDanhMuc_DAL();
        }
        public MonView ConvertToMonView(Mon m)
        {
            MonView mv = new MonView();
            foreach (DanhMuc i in GetAllDanhMuc())
            {
                if (m.IdDanhMuc == i.IdDanhMuc)
                {
                    mv.IdMon = m.IdMon;
                    mv.TenMon = m.TenMon;
                    mv.GiaTien = m.GiaTien;
                    mv.SoLanGoiMon = m.SoLanGoiMon;
                    mv.DanhMuc = i.TenDanhMuc;
                    break;
                }
            }
            return mv;
        }
        public List<MonView> ConvertToListMonview(List<Mon> m)
        {
            List<MonView> mv = new List<MonView>();
            foreach (Mon i in m)
            {
                mv.Add(ConvertToMonView(i));
            }
            return mv;
        }
        public int GetMaxIdMon()
        {
            return DataAccessLayer.Instance.GetMaxIdMon();
        }

        /// <summary>
        /// ////////// del, add, update
        /// </summary>
        /// <param name="mssv"></param>
        /// <returns></returns>
        public bool XoaMon(int idmon)
        {
            return DataAccessLayer.Instance.XoaMonTheoIdMon(idmon);

        }
        public bool ExcuteDB_BLL(Mon mon, int idMonDetailForm)
        {
            if (idMonDetailForm != 0)
            {
                return DataAccessLayer.Instance.EditMon(mon);
            }
            else
            {
                return DataAccessLayer.Instance.ThemMon(mon);
            }
        }

    }
}
