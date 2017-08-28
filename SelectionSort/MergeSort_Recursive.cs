using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class MergeSort_Recursive
    {
        static int[] Ary = new int[] { 0, 2, 4, 6, 8, 1, 3, 5, 7, 9 };
        
        static void unUse(string[] args)
        {
            PrintFunction.ptrArray(Ary);
            int p = 0, q = Ary.Length / 2, r = Ary.Length - 1;
            mergeSorts(Ary, p, r);
            PrintFunction.ptrArray(Ary);
            Console.Read();
        }
        
        static void mergeSorts(int[] Ary, int start, int end)
        {
            if(start < end)
            {
                int mid = (end + start) / 2;
                mergeSorts(Ary, start, mid);
                mergeSorts(Ary, mid + 1, end);
                MergeSort.Merge(Ary, start, mid ,end);
            }
        }

    }
}
