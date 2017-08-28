using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class MergeSort
    {
        static int[] Ary = new int[] { 0, 2, 4, 6, 8, 1, 3, 5, 7, 9 };
        static void unUse(string[] args)
        {
            PrintFunction.ptrArray(Ary);
            Merge(Ary, 0, 4, 9);
            PrintFunction.ptrArray(Ary);
            Console.Read();
        }

        public static void Merge(int[] A, int p, int q, int r)
        {
            int n1 = q - p + 1;
            int n2 = r - q ;
            int[] L = new int[n1 + 1];
            int[] R = new int[n2 + 1];

            for (int i = 0; i < n1; i++)
                L[i] = A[p + i];
            for (int i = 0; i < n2; i++)
                R[i] = A[q + i + 1];
            L[n1] = 1000;
            R[n2] = 1000;
            int m = 0, n = 0;

            for (int k = p; k < r + 1; k++)
            {
                if (L[m] == 1000 && R[n] == 1000) break;
               
                if (L[m] < R[n] || R[n] == 1000)
                {
                    A[k] = L[m];
                    m++;
                }
                else if(L[m] > R[n] || L[m] == 1000)
                {
                    A[k] = R[n];
                    n++;
                }
                //PrintFunction.ptrArray(Ary);

            }
        }
    }
}
