using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace MyAlgo
{
    public class MyAlgorithms
    {
        private static MyAlgorithms _Instance;
        public static MyAlgorithms Instance
        {
            get
            {
                if (_Instance == null) return _Instance = new MyAlgorithms();
                return _Instance;
            }
        }
        private MyAlgorithms() { }

        public delegate bool MyCompare(MonView s1, MonView s2);
        public void SapXep(MonView[] arr, MyCompare cmp)
        {
            for (int i = 0; i < arr.Length - 1; ++i)
            {
                for (int j = i + 1; j < arr.Length; ++j)
                {
                    if (cmp(arr[i], arr[j]))
                    {
                        MonView temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        #region Flash Order
        public List<Mon> FlashOrder(List<Mon> mons, int giaTien)
        {
            int i, w;
            int n = mons.Count;

            int[,] K = new int[n + 1, giaTien + 1];
            List<Mon> recommendMons = new List<Mon>();

            // Build table K[][] in bottom up manner
            for (i = 0; i <= n; i++)
            {
                for (w = 0; w <= giaTien; w++)
                {
                    if (i == 0 || w == 0)
                        K[i, w] = 0;
                    else if (mons[i - 1].GiaTien <= w)
                        K[i, w] = Math.Max(mons[i - 1].SoLanGoiMon + K[i - 1, w - mons[i - 1].GiaTien], K[i - 1, w]);
                    else
                        K[i, w] = K[i - 1, w];
                }
            }

            // stores the result of Knapsack
            int res = K[n, giaTien];
            //Console.WriteLine(res);

            w = giaTien;
            for (i = n; i > 0 && res > 0; i--)
            {
                if (res == K[i - 1, w])
                    continue;
                else
                {

                    // This item is included.
                    // Console.Write(mons[i - 1].IdMon + " ");
                    recommendMons.Add(mons[i - 1]);
                    res = res - mons[i - 1].SoLanGoiMon;
                    w = w - mons[i - 1].GiaTien;
                }
            }
            return recommendMons;
        }
        #endregion
    }
}
