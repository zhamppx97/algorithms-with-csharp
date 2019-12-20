/// <summary>
/// Author: zhamppx97
/// Date: Friday, December 20, 2019
/// Description: This is example of algorithm by C# (.NET Core Console Application)
/// </summary>
using System;

namespace algorithms_with_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 21, 12, 43, 34, 75, 26, 97, 88, 29, 10 };
            int K = 97;

            Console.Write("Value in array is: ");
            foreach (var item in A)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Search key is: {0}", K);
            
            SequentialSearch(A, K);
        }

        /// <summary>
        /// Searches for a given value in a given array by sequential search
        /// Input: An array A[] and a search key K
        /// Output: The index of the first element in A that matches K or -1 if there are no matching elements
        /// </summary>
        /// <param name="A"> Input an array </param>
        /// <param name="K"> Search key </param>
        private static void SequentialSearch(int[] A, int K)
        {
            int i = 0;
            int n = A.Length;

            while (i < n && A[i] != K)
            {
                i += 1;
            }

            if (i < n)
            {
                Console.WriteLine("The index that matches K is: {0} ", i);
            }
            else
            {
                Console.WriteLine("There are no matching: {0}", -1);
            }
        }
    }
}
