using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace lab_16
{
    public class ARR
    {
        string[] arr;

        public string[] Arr
        {
            get { return arr; }
            set { arr = value; }
        }

        public ARR()
        {
            arr = new string[0];
        }

        public ARR(string[] arr)
        {
            this.arr = arr;
        }

        public string search(int n)
        {
            if (n >= 0 && n < this.arr.Length)
            {
                return this.arr[n];
            }
            else
            {
                return "Не існує такого елементу";
            }
        }

        public ARR ADD(ARR arr2)
        {
            ARR tmp = new ARR();
            int n = this.arr.Length + arr2.arr.Length;
            int m = 0, k = 0;
            string[] t = new string[n];
            for(int i = 0; i < n; i++)
            {
                if(i % 2 == 0 && this.arr.Length > m)
                {
                    t[i] = this.arr[m];
                    m++;
                }
                else if (i % 2 != 0 && arr2.arr.Length > k)
                {
                    t[i] = arr2.arr[k];
                    k++;
                }
                else if (i % 2 == 0 && this.arr.Length <= m)
                {
                    t[i] = arr2.arr[k];
                    k++;
                }
                else if (i % 2 != 0 && arr2.arr.Length <= k)
                {
                    t[i] = this.arr[m];
                    m++;
                }
            }
            tmp.arr = t;

            return tmp;
        }

        public ARR AddAndRemovingDuplicates(ARR arr3)
        {
            ARR tmp = new ARR();
            string[] arr1 = arr3.arr.Distinct().ToArray();
            string[] withDupes = { "Sunday", "Monday", "Tuersday", "Monday", "Thirsday", "Friday", "Saturday" };
            string[] noDupes = arr3.arr.Distinct().ToArray();
            tmp.arr = noDupes;
            return tmp;
        }

        public string Write()
        {
            string tmp = "";
            for(int i = 0; i < this.arr.Length; i++)
            {
                tmp = tmp + arr[i] + "; ";
            }
            return tmp;
        }
    }
}
