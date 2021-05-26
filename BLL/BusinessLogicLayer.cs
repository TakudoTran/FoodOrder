using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using MyAlgo;
using System.Drawing;

namespace BLL
{
    public class BusinessLogicLayer
    {
       // public delegate bool MyCompare(string str);
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
        #region UI

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
        public void setCbbSortType(ComboBox cb)
        {
            List<CBBItem> data = new List<CBBItem>();
            data.Add(new CBBItem
            {
                Value = 1,
                Text = "Giá tiền tăng"
            });
            data.Add(new CBBItem
            {
                Value = 2,
                Text = "Giá tiền giảm"
            });
            data.Add(new CBBItem
            {
                Value = 3,
                Text = "Gọi ít"
            });
            data.Add(new CBBItem
            {
                Value = 4,
                Text = "Gọi nhiều"
            });

            cb.Items.AddRange(data.ToArray());
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
        public void SetColumnHeaderMon(DataGridView dgv)
        {
            dgv.Columns["IdMon"].HeaderText = "Id Món";
            dgv.Columns["TenMon"].HeaderText = "Tên Món";
            dgv.Columns["GiaTien"].HeaderText = "Giá Tiền";
            dgv.Columns["SoLanGoiMon"].HeaderText = "Số Lần Gọi Món";
            dgv.Columns["DanhMuc"].HeaderText = "Danh Mục";
        }
        public void SetColumnHeaderDM(DataGridView dgv)
        {
            dgv.Columns["IdDanhMuc"].HeaderText = "ID Danh Mục";
            dgv.Columns["TenDanhMuc"].HeaderText = "Tên Danh Mục";
            dgv.Columns["Loai"].HeaderText = "Loại";
        }
        public MemoryStream GetByteValuesOfAnh(int idAnh)
        {
            byte[] bAnh = null;
            bAnh = DataAccessLayer.Instance.GetAnhMinhHoaByIdAnh(idAnh).Anh;
            MemoryStream ms = new MemoryStream(bAnh, 0, bAnh.Length);
            ms.Write(bAnh, 0, bAnh.Length);
            return ms;
        }
        #endregion

        #region Anh minh hoa
        public AnhMinhHoa GetIdAnhByIdAnh(int idAnh)
        {
            return DataAccessLayer.Instance.GetAnhMinhHoaByIdAnh(idAnh);
        }
        public int GetMaxIdAnh()
        {
            return DataAccessLayer.Instance.GetMaxIdAnh();
        }
        public bool ThemAnhVaoDb(string tenAnh, byte[] Anh)
        {
            return DataAccessLayer.Instance.ThemAnhVaoDB(tenAnh, Anh);
        }
        public List<AnhMinhHoa> GetAllAnhMinhHoa()
        {
            return DataAccessLayer.Instance.GetListAnhMinhHoa();
        }
        public List<AnhMinhHoa> GetAnhMinhHoaByTenAnh(string tenAnh)
        {
            List<AnhMinhHoa> anhMinhHoas = new List<AnhMinhHoa>();
            if (string.IsNullOrEmpty(tenAnh)) anhMinhHoas = GetAllAnhMinhHoa();
            foreach (AnhMinhHoa i in BusinessLogicLayer.Instance.GetAllAnhMinhHoa())
            {
                if (i.TenAnh.ToLower().Contains(tenAnh.ToLower()))
                {
                    anhMinhHoas.Add(i);
                }
            }
            return anhMinhHoas;
        }
        public void DefaultImages()
        {
            string path = Directory.GetCurrentDirectory();
            string defaultImgPath = path + "\\DefaultImage.jpg";
            FileStream fs = new FileStream(defaultImgPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] anh = br.ReadBytes((int)fs.Length);
            BusinessLogicLayer.Instance.ThemAnhVaoDb("DefaultImage", anh);
        }
        #endregion

        #region Mon


        public List<MonView> GetMonByIdDanhMucAndTenMon(int idMon, string st)
        {
            List<MonView> data = new List<MonView>();
            data = ConvertToListMonview(DataAccessLayer.Instance.GetMonByIdDanhMucAndTenMon(idMon, st));
            return data;
        }
        public List<Mon> GetMonByIDDanhMuc(int id)
        {
            return DataAccessLayer.Instance.GetMonByIdDanhMucAndTenMon(id, "");
        }
        public Mon GetMonByIdMon(int idMon)
        {
            Mon m = new Mon();
            foreach (Mon i in GetAllMon())
            {
                if (idMon == i.IdMon)
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
        public bool XoaMon(int idmon)
        {
            return DataAccessLayer.Instance.XoaMonTheoIdMon(idmon);

        }
        public List<MonView> Sort(int idSort, int IDLop, string name)
        {
            List<MonView> list = GetMonByIdDanhMucAndTenMon(IDLop, name);
            MonView[] arr = list.ToArray();
            switch (idSort)
            {
                case 1:
                    MyAlgorithms.Instance.SapXep(arr, MonView.DesGiaTien);
                    break;
                case 2:
                    MyAlgorithms.Instance.SapXep(arr, MonView.AscGiaTien);
                    break;
                case 3:
                    MyAlgorithms.Instance.SapXep(arr, MonView.DesSoLanGoi);
                    break;
                case 4:
                    MyAlgorithms.Instance.SapXep(arr, MonView.AscSoLanGoi);
                    break;
            }

            return arr.ToList();
        }
        #endregion

        #region Danh muc
        public List<DanhMuc> GetAllDanhMuc()
        {
            return DataAccessLayer.Instance.GetAllDanhMuc_DAL();
        }
        public int GetMaxIdDanhMuc()
        {
            return DataAccessLayer.Instance.GetMaxIdMon();
        }
        public bool ThemDanhMuc(DanhMuc dm)
        {
            return DataAccessLayer.Instance.ThemDanhMuc(dm);
        }
        public bool SuaDanhMuc(DanhMuc dm)
        {
            return DataAccessLayer.Instance.SuaDanhMuc(dm);
        }
        public bool XoaDanhMuc(int iddanhmuc)
        {
            return DataAccessLayer.Instance.XoaDanhMucTheoIdDanhMuc(iddanhmuc);
        }

        #endregion
        #region Loai
        public List<string> GetDataLoai()
        {
            return DataAccessLayer.Instance.DataLoai();
        }
        #endregion
    }
}
