using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace MyAlgo
{
    public class Algorithms
    {
        private static Algorithms _Instance;
        public static Algorithms Instance
        {
            get
            {
                if (_Instance == null) return _Instance = new Algorithms();
                return _Instance;
            }
        }
        private Algorithms() { }

        public delegate bool Compare(MonView s1, MonView s2);
        public void SapXep(MonView[] arr,int left, int right, Compare cmp) {
            if (arr.Length < 2) return;
            else { 
                int i = left;
            int j = right;
            MonView pivot = arr[left / 2 + right / 2];
            do
            {
                while (cmp(pivot,arr[i])) i++;
                while (cmp(arr[j],pivot)) j--;
                if (i <= j) {
                    MonView temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;j--;
                }
            } while (i <= j);
            if (left < j) SapXep(arr, left, j, cmp);
            if (right > i) SapXep(arr, i, right, cmp);
            }
        }

        public delegate bool SortType(Mon s1, Mon s2);
        public void SortMon_FO(Mon[] arr, int left, int right, SortType cmp)
        {
            if (arr.Length < 2) return;
            else
            {
                int i = left;
                int j = right;
                Mon pivot = arr[left / 2 + right / 2];
                do
                {
                    while (cmp(pivot, arr[i])) i++;
                    while (cmp(arr[j], pivot)) j--;
                    if (i <= j)
                    {
                        Mon temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        i++; j--;
                    }
                } while (i <= j);
                if (left < j) SortMon_FO(arr, left, j, cmp);
                if (right > i) SortMon_FO(arr, i, right, cmp);
            }
        }
        public List<Mon> MonsSapXep_FO(Mon[] arr, SortType cmp)
        {
            SortMon_FO(arr, 0, arr.Length - 1, cmp);
            return arr.ToList();

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
