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
                    if(i !=  null) anhMinhHoas.Add(GetAnh(i));
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
            try
            {
                return DBHelper.Instance.GetMaxValueOf("IdAnh", "AnhMinhHoa");
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
            return new DanhMuc
            {
                TenDanhMuc = tenDanhMuc,
                IdDanhMuc = int.Parse(i["IdDanhMuc"].ToString())
            };
        }
        public int GetMaxIdDanhMuc()
        {
            try
            {
                return DBHelper.Instance.GetMaxValueOf("IdDanhMuc", "DanhMuc");
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
                string query = "insert into DanhMuc(TenDanhMuc)" +
                                   "values ( @tendm )";
                object[] prams = { dm.TenDanhMuc };

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
                string query = "update DanhMuc set TenDanhMuc = @tendm " +
                                   "where IdDanhMuc = @iddm ";

                object[] prams = { dm.TenDanhMuc, dm.IdDanhMuc };

                return DBHelper.Instance.ExecuteNonQuery(query, prams) > 0;

            }
            catch (Exception)
            {
                return false;
            }
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
            try
            {
                return DBHelper.Instance.GetMaxValueOf("IdMon", "Mon");
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
                MessageBox.Show("Lỗi" + e.Message);
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

    }
}
