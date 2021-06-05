using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Mon
    {
        public int IdMon { get; set; }
        public string TenMon { get; set; }
        public int GiaTien { get; set; }
        public int SoLanGoiMon { get; set; }
        public int IdDanhMuc { get; set; }
        [System.ComponentModel.Browsable(false)]
        public int IdAnh { get; set; }
        public override string ToString()
        {
            return TenMon;
        }
        public static bool GiamGiaTien(Mon m1, Mon m2)
        {
            return m1.GiaTien < m2.GiaTien;
        }
        public static bool TangGiaTien(Mon m1, Mon m2)
        {
            return m1.GiaTien > m2.GiaTien;
        }
        public static bool GiamSoLanGoi(Mon m1, Mon m2)
        {
            return m1.SoLanGoiMon < m2.SoLanGoiMon;
        }
    }
}
