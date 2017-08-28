using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class BINARY_SEARCH
    {
        static int[] Ary = new int[] { 1, 2, 4, 6, 7, 8, 9, 15, 17, 19};
        static int value = 17;
        static int counter = 0;
        static void unUse(string[] args)
        {
            int start = 0, end = Ary.Length - 1, ans = 0;
            // [Recursive]
            // ans = BSRecursive(Ary, value, start, end);
            // [Iterative]
             ans = BSIterative(Ary, value, start, end);
            Console.WriteLine(ans);
            Console.Read();
        }

        static int BSRecursive(int[] A, int v, int low, int high)
        {

            int mid = (low + high) / 2;
            Console.WriteLine("The {3} times RSC: low:{0}, high:{1}, mid:{2} ", low, high, A[mid], counter++);

            if (low <= high)
            {
                if (A[mid] == v)
                    return mid;
                else if (A[mid] < v)
                    return BSRecursive(A, v, ++mid, high);
                else 
                    return BSRecursive(A, v, low, --mid);
            }
            return -1;
        }

        static int BSIterative(int[] A, int v, int low, int high)
        {
            while (low <= high)
            {
                int mid = (low + high) / 2;
                Console.WriteLine("The {3} times RSC: low:{0}, high:{1}, mid:{2} ", low, high, A[mid], counter++);

                if (A[mid] == v)
                    return mid;
                if (A[mid] < v)
                    low = mid++;
                else
                    high = mid--;
            }
            return -1;
        }
    }
}
