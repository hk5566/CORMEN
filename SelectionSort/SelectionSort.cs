using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_2_2
{
    class SelectionSort
    {
        static int[] A = new int[] { 4, 7, 2, 6, 7, 9, 3 };
        static void unUsed(string[] args)
        {
            
            for (int i = 0; i < A.Length - 1; i++)
            {
                ptrArray();
                int reg = i, smVal = A[i];
                int j = i + 1;
                while (j < A.Length)
                {
                    if (A[j] < smVal)
                    {
                        smVal = A[j];
                        reg = j;
                    }
                    j++;
                }
                A[reg] = A[i];
                A[i] = smVal;
            }
            ptrArray();

            Console.Read();
        }

        static void ptrArray()
        {
            foreach (int element in A){
                Console.Write("{0}, ", element);
            }
            Console.WriteLine();
        }
    }
}
