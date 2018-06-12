using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class SelectionSort
    {
        public static void Selection(ref int[] x)
        {
            int i, j;
            int min, temp;

            for (i = 0; i < x.Length - 1; i++)
            {
                min = i;
                for (j = i + 1; j < x.Length; j++)
                {
                    if (x[j] < x[min])
                    {
                        min = j;
                    }
                }
                temp = x[i];
                x[i] = x[min];
                x[min] = temp;
            }
        }
    }   
}
