using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class SortApp
    {
        static void Main()
        {
            //Example
            MergeSorting ms = new MergeSorting();
            int[] array = new int[] { 9, 1, 3, 2, 4, 7, 8 };
            ms.MergeSort(ref array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
