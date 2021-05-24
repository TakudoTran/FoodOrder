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
    }
}
