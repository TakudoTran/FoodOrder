using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DBProvider;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace DAL
{
    public class DataAccessLayer
    {
        private static DataAccessLayer _Instance;
        public static DataAccessLayer Instance
        {
            get
            {
                if (_Instance == null) return _Instance = new DataAccessLayer();
                return _Instance;
            }
        }
        private DataAccessLayer() { }


        #region Anh minh hoa
        private AnhMinhHoa GetAnh(DataRow i)
        {
            return new AnhMinhHoa
            {
                IdAnh = int.Parse(i["IdAnh"].ToString()),
                TenAnh = i["TenAnh"].ToString(),
                Anh = (byte[])i["Anh"]
            };
        }

        public List<AnhMinhHoa> GetListAnhMinhHoa()
        {
            try
            {
                List<AnhMinhHoa> anhMinhHoas = new List<AnhMinhHoa>();
                string query = "select * from AnhMinhHoa";
                foreach (DataRow i in DBHelper.Instance.GetDataTable(query).Rows)
                {
                    anhMinhHoas.Add(GetAnh(i));
                }
                return anhMinhHoas;
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message);
                return null;
            }
        }

        public AnhMinhHoa GetAnhMinhHoaByIdAnh(int idAnh) {
            AnhMinhHoa anh = new AnhMinhHoa();
            foreach(AnhMinhHoa i in GetListAnhMinhHoa())
            {
                if(idAnh == i.IdAnh)
                {
                    anh = i;
                }
            }
            return anh;
        }
        public bool ThemAnhVaoDB(string tenAnh, byte[] Anh)
        {
            try
            {
                string query = "insert into AnhMinhHoa(TenAnh,Anh) values( @ten , @anh )";
                object[] param = { tenAnh, Anh };
                DBHelper.Instance.ExecuteNonQuery(query, param);
                return true;
            }
            catch(SqlException e)
            {
                if(e.Number == 2627) MessageBox.Show("Ảnh vừa chọn đã tồn tại ở CSDL");
                else MessageBox.Show("Lỗi: " + e.Message);
                return false;
            }
        }
        public int GetMaxIdAnh()
        {
            string query = "select max(IdAnh) from AnhMinhHoa";
            try
            {
                return DBHelper.Instance.GetMaxValue(query);
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message);
                return -1;

            }
        }
        #endregion
      
        #region Danh muc
        public List<DanhMuc> GetAllDanhMuc_DAL()
        {
            string query = "select * from DanhMuc";
            List<DanhMuc> lisDanhMuc = new List<DanhMuc>();
            foreach (DataRow i in DBHelper.Instance.GetDataTable(query).Rows)
            {
                lisDanhMuc.Add(GetDanhMuc(i));
            }
            return lisDanhMuc;
        }
        private DanhMuc GetDanhMuc(DataRow i)
        {
            string tenDanhMuc = "No Name";
            if (!DBNull.Value.Equals(i["TenDanhMuc"])) tenDanhMuc = i["TenDanhMuc"].ToString();
            string loai = "No Name";
            if (!DBNull.Value.Equals(i["Loai"])) loai = i["Loai"].ToString();
            return new DanhMuc
            {
                TenDanhMuc = tenDanhMuc,
                IdDanhMuc = int.Parse(i["IdDanhMuc"].ToString()),
                Loai = loai
            };
        }
        public int GetMaxIdDanhMuc()
        {
            string query = "select max(IdDanhMuc) from DanhMuc";
            try
            {
                return DBHelper.Instance.GetMaxValue(query);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message);
                return -1;
            }
        }
        public bool XoaDanhMucTheoIdDanhMuc(int IdDanhMuc)
        {
            try
            {
                string query = "delete from DanhMuc where IdDanhMuc = @id ";
                object[] prams = { IdDanhMuc };
                return DBHelper.Instance.ExecuteNonQuery(query, prams) > 0;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return false;
            }

        }
        public bool ThemDanhMuc(DanhMuc dm)
        {
            try
            {
                string query = "insert into DanhMuc(TenDanhMuc ,Loai ) " +
                                   "values ( @tendm , @loai )";
                object[] prams = { dm.TenDanhMuc,dm.Loai };

                return DBHelper.Instance.ExecuteNonQuery(query, prams) > 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi" + e.Message);
                return false;
            }
        }
        public bool SuaDanhMuc(DanhMuc dm)
        {
            try
            {
                string query = "update DanhMuc set TenDanhMuc = @tendm , Loai = @loai " +
                                   "where IdDanhMuc = @iddm ";

                object[] prams = { dm.TenDanhMuc,dm.Loai, dm.IdDanhMuc };

                return DBHelper.Instance.ExecuteNonQuery(query, prams) > 0;

            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region danh muc ban
        public List<BanAn> GetAllDanhMucBan_DAL()
        {
            string query = "select * from BanAn";
            List<BanAn> lisDanhMucBan = new List<BanAn>();
            foreach (DataRow i in DBHelper.Instance.GetDataTable(query).Rows)
            {
                lisDanhMucBan.Add(GetDanhMucBan(i));
            }
            return lisDanhMucBan;
        }
        private BanAn GetDanhMucBan(DataRow i)
        {
            string tenBan = "No Name";
            if (!DBNull.Value.Equals(i["TenBan"])) tenBan = i["TenBan"].ToString();
            return new BanAn
            {
                TenBan = tenBan,
                IdBan = int.Parse(i["IdBan"].ToString())
            };
        }
        #endregion

        #region default bill
        public bool Load_Default_Bill_DAL()
        {
            try
            {
                string query = "insert into Bill(IdBan,TongTien, NgayLapHoaDon)" +
                                   "values ( @id , @tien , @ngay )";
                string date = "2021/01/01 00/00/00";
                DateTime dt = DateTime.ParseExact(date, "yyyy/MM/dd hh/mm/ss", CultureInfo.InvariantCulture);
                object[] prams = { 1, 0,  dt};

                return DBHelper.Instance.ExecuteNonQuery(query, prams) > 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi" + e.Message);
                return false;
            }
        }
        #endregion

        #region Loai Danh Muc
        public List<string> DataLoai()
        {
            List<string> list = new List<string>();
            list.Add("DA");
            list.Add("DU");
            list.Add("Kh");
            return list;
        }
        #endregion

        #region Mon an
        public List<Mon> GetAllMon_DAL()
        {
            try
            {
                string query = "select * from Mon";
                List<Mon> listMon = new List<Mon>();
                foreach (DataRow i in DBHelper.Instance.GetDataTable(query).Rows)
                {
                    listMon.Add(getMon(i));
                }
                return listMon;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool SortMon(string str )
        {
            try
            {
                string query = "SELECT * FROM Mon ORDER BY str ";
                object[] prams = { str };
                return DBHelper.Instance.ExecuteNonQuery(query, prams) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private Mon getMon(DataRow i)
        {
            string ten = "No Name";
            int soLanGoiMon = 0;
            int gia = 0;
            int idDanhMuc = 1;
            int idAnh = 0;
            if (!DBNull.Value.Equals(i["TenMon"])) ten = i["TenMon"].ToString();
            if (!DBNull.Value.Equals(i["SoLanGoiMon"])) soLanGoiMon = int.Parse(i["SoLanGoiMon"].ToString());
            if (!DBNull.Value.Equals(i["GiaTien"])) gia = int.Parse(i["GiaTien"].ToString());
            if (!DBNull.Value.Equals(i["IdDanhMuc"])) idDanhMuc = Convert.ToInt32(i["IdDanhMuc"].ToString());
            if (!DBNull.Value.Equals(i["IdAnh"])) idAnh = int.Parse(i["IdAnh"].ToString());
            return new Mon
            {
                IdMon = int.Parse(i["IdMon"].ToString()),
                TenMon = ten,
                SoLanGoiMon = soLanGoiMon,
                GiaTien = gia,
                IdDanhMuc = idDanhMuc,
                IdAnh = idAnh

            };
        }
        public List<Mon> GetMonByIdDanhMucAndTenMon(int idDanhMuc, string st)
        {
            List<Mon> data = new List<Mon>();
            if (idDanhMuc == 0)
            {
                if (string.IsNullOrEmpty(st)) data = DataAccessLayer.Instance.GetAllMon_DAL();
                else
                {
                    foreach (Mon i in DataAccessLayer.Instance.GetAllMon_DAL())
                    {
                        if (i.TenMon.ToLower().Contains(st.ToLower()) || ((i.GiaTien).ToString()) == st) data.Add(i);
                    }
                }
            }
            else
            {
                foreach (Mon i in DataAccessLayer.Instance.GetAllMon_DAL())
                {
                    if (i.IdDanhMuc == idDanhMuc && ((i.TenMon.ToLower().Contains(st.ToLower())) || (((i.GiaTien).ToString()).Contains(st) == true))) data.Add(i);
                }
            }

            return data;
        }

        public int GetMaxIdMon()
        {
            string query = "select max(IdMon) from Mon";
            try
            {
                return DBHelper.Instance.GetMaxValue(query);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message);
                return -1;
            }
        }
        public bool XoaMonTheoIdMon(int IdMon)
        {
            try
            {
                string query = "delete from Mon where IdMon = @id ";
                object[] prams = { IdMon };
                return DBHelper.Instance.ExecuteNonQuery(query, prams) > 0;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool checkMon(int IdMon)
        {
            try
            {
                foreach (Mon i in GetAllMon_DAL())
                {
                    if (i.IdMon == IdMon)
                    {
                        return true;
                        
                    }
                    break;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ThemMon(Mon Mon)
        {
            try
            {
                string query = "insert into Mon(TenMon, GiaTien, SoLanGoiMon, IdDanhMuc, IdAnh)" +
                                   "values ( @name , @gia , @solangoi , @idDm , @idAnh )";
                object[] prams = { Mon.TenMon, Mon.GiaTien, Mon.SoLanGoiMon, Mon.IdDanhMuc, Mon.IdAnh };

                return DBHelper.Instance.ExecuteNonQuery(query, prams) > 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi " + e.Message);
                return false;
            }
        }
        public bool EditMon(Mon Mon)
        {
            try
            {
                string query = "update Mon set TenMon = @name , GiaTien = @gia ," +
                        " SoLanGoiMon = @solangoi , IdDanhMuc = @idDm , IdAnh = @idAnh where IdMon = @idmon ";

                object[] prams = { Mon.TenMon, Mon.GiaTien, Mon.SoLanGoiMon, Mon.IdDanhMuc, Mon.IdAnh, Mon.IdMon };

                return DBHelper.Instance.ExecuteNonQuery(query, prams) > 0;

            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region Dat bill
        public int GetMaxBill()
        {
            try
            {
                string query = @"select max(BillNo) from Bill";
                return DBHelper.Instance.GetMaxValue(query);
            }catch(Exception e)
            {
                return -1;
            }
        }
        public bool AddBill(int idBan)
        {
            try
            {
                string query = "insert into Bill(IdBan,TongTien, NgayLapHoaDon)" +
                                   "values ( @id , @tien , @ngay )";
                string date = DateTime.Now.ToString("yyyy/MM/dd hh/mm/ss");
                DateTime dt = DateTime.ParseExact(date, "yyyy/MM/dd hh/mm/ss", CultureInfo.InvariantCulture);
                object[] prams = { idBan, 0, dt };
                return DBHelper.Instance.ExecuteNonQuery(query, prams) > 0;
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi" + e.Message);
                return false;
            }
        }
        public bool AddBillToData_DAL(int idBan, List<int> idMon, List<int> slMon)
        {
            try
            {
                if(AddBill(idBan))
                {
                    int[] id = idMon.ToArray();
                    int[] sl = slMon.ToArray();
                    int BillMax = GetMaxBill();
                    bool addBillDetail = true;
                    for (int i = 0; i < id.Length; i++)
                    {
                        string query = "insert into BillDetail(BillNo, IdMon, SoLuong)" +
                                        "values ( @billno , @id , @sl )";
                        object[] prams = { BillMax, id[i], sl[i] };
                        addBillDetail = (DBHelper.Instance.ExecuteNonQuery(query, prams) > 0);
                    }
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message);
                return false;
            }
        }
        public bool UpdateSLG_DAL(int idMon)
        {
            try
            {
                string query = "update Mon set SoLanGoiMon = SoLanGoiMon + 1 where IdMon = @id ";

                object[] prams = { idMon };

                return DBHelper.Instance.ExecuteNonQuery(query, prams) > 0;

            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region xu li bill
        public List<BillToAcess> GetBillByTable_DAL(int idBan)
        {
            try
            {
                List<BillToAcess> data = new List<BillToAcess>();
                string query = "select Bill.BillNo, TenMon, SoLuong, GiaTien " +
                    "from Bill inner join BillDetail on Bill.BillNo = BillDetail.BillNo inner" +
                    " join Mon on BillDetail.IdMon = Mon.IdMon" +
                    " where NgayLapHoaDon = (select max(NgayLapHoaDon) from Bill where IdBan = "+idBan+")";
                foreach (DataRow i in DBHelper.Instance.GetDataTable(query).Rows)
                {
                    data.Add(GetBillNo(i));
                }
                return data;

            }catch(Exception)
            {
                return null;
            }
        }
        private BillToAcess GetBillNo(DataRow i)
        {
            return new BillToAcess
            {
                BillNo = Convert.ToInt32(i["BillNo"].ToString()),
                TenMon = i["TenMon"].ToString(),
                SoLuong = Convert.ToInt32(i["SoLuong"]),
                GiaTien = Convert.ToInt32(i["GiaTien"])
            };
        }
        public bool SetHoaDon_DAL(int TongTien, int CurrentBill)
        {
            try
            {
                string query = "update Bill set TongTien = @tien where BillNo = @bill ";

                object[] prams = { TongTien, CurrentBill };

                return DBHelper.Instance.ExecuteNonQuery(query, prams) > 0;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public void DeleteBillDetail_DAL(int CurrentBill)
        {
            try
            {
                string query = "delete from BillDetail where BillNo = @bill ";
                object[] prams = { CurrentBill };
                int check;
                check = DBHelper.Instance.ExecuteNonQuery(query, prams);
            }
            catch (Exception) { }
        }
        #endregion



    }
}
