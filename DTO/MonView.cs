using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonView
    {
        public int IdMon { get; set; }
        public string TenMon { get; set; }
        public int GiaTien { get; set; }
        public int SoLanGoiMon { get; set; }
        public string DanhMuc { get; set; }
        public override string ToString()
        {
            return TenMon;
        }
        public static bool AscGiaTien(MonView m1, MonView m2)
        {
            return m1.GiaTien < m2.GiaTien;
        }
        public static bool DesGiaTien(MonView m1, MonView m2)
        {
            return m1.GiaTien > m2.GiaTien;
        }
        public static bool AscSoLanGoi(MonView m1, MonView m2)
        {
            return m1.SoLanGoiMon < m2.SoLanGoiMon;
        }
        public static bool DesSoLanGoi(MonView m1, MonView m2)
        {
            return m1.SoLanGoiMon > m2.SoLanGoiMon;
        }
    }
}

