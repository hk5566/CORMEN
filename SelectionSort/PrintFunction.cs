using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class PrintFunction
    {
        public static void ptrArray(int[] A)
        {
            Console.WriteLine();
            for(int i = 0; i < A.Length; i++)
            {
                Console.Write("{0}, ",A[i]);
            }
        }
    }
}
