using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msft3c
{
    public static class question2
    {
        public static void f(int[] a)
        {
            int L = a[0];
            int R = a[a.Length - 1];
            Console.WriteLine(R.ToString(), L.ToString());
            int[] arr = new int[R - L + 1];
            //System.out.println(arr.length);
            int i;
            for (i = 0; i < a.Length; i++)
            {
                //System.out.println(i+" "+(a[i]-L)+" "+ arr.length+ " "+(R-L));
                arr[a[i] - L] = 1;
            }
            for (i = 0; i < R - L + 1; i++)
            {
                if (arr[i] == 0)
                    Console.Write((i + L) + " ");
            }
            Console.Write("\n");
        }
    }
}
