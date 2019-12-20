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
            int[] A = { 21, 12, 43, 34, 75, 26, 97, 88, 55, 10 };
            int K = 97;

            Console.Write("Value in array is: ");
            foreach (var item in A)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Search key is: {0}", K);
            
            SequentialSearch(A, K);
            MaxElement(A);

            string uniqueElements = UniqueElements(A);
            Console.WriteLine(uniqueElements);

            BinaryDigits(K);
            Console.WriteLine("The number of binary digits in K is: {0}, represent by recursive method", BinRec(K));

            SelectionSort(A);
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

        /// <summary>
        /// Determines the value of the largest element in a given array
        /// Input: An array A[] of real numbers
        /// Output: The value of the largest element in A
        /// </summary>
        /// <param name="A"> Input an array </param>
        private static void MaxElement(int[] A)
        {
            int max = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
            }

            Console.WriteLine("The value of the largest element in A[] is: {0}", max);
        }

        /// <summary>
        /// Determines whether all the elements in a given array are distinct
        /// Input: An array A[]
        /// Output: Return "true" if all the elements in A[] are distinct and "false" otherwise
        /// </summary>
        /// <param name="A"> Input an array </param>
        /// <returns> string of result </returns>
        private static string UniqueElements(int[] A)
        {
            string result;

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] == A[j])
                    {
                        result = "False: Element in A[] not distinct";
                        return result;
                    }
                }
            }

            result = "True: All the elements in A[] are distinct";
            return result;
        }

        /// <summary>
        /// The following algorithm finds the number of binary digits in the binary representation of a integer
        /// Input: An integer
        /// Output: The number of binary digits in K's binary representation
        /// </summary>
        /// <param name="K"> An integer </param>
        private static void BinaryDigits(int K)
        {
            int count = 1;
            while (K > 1)
            {
                count += 1;
                K /= 2;
            }
            Console.WriteLine("The number of binary digits in K is: {0}", count);
        }

        /// <summary>
        /// Investigate a recursive version of the algorithm discussed at method "BinaryDigits"
        /// Input: An integer
        /// Output: The number of binary digits in K's binary representation
        /// </summary>
        /// <param name="K"> An integer </param>
        /// <returns> Int of binary digits </returns>
        private static int BinRec(int K)
        {
            if (K == 1)
            {
                return 1;
            }
            else
            {
                return BinRec(K / 2) + 1;
            }
        }

        /// <summary>
        /// Exercises
        /// </summary>
        /// <param name="A"> Input an array </param>
        private static void SortAnalysis(int[] A)
        {
            int count = 0;

            for (int i = 1; i < A.Length; i++)
            {
                int v = A[i];
                int j = i - 1;
                while (j >= 0 && A[j] > v)
                {
                    count += 1;
                    A[j + 1] = A[j];
                    j -= 1;
                }
                A[j + 1] = v;
            }

            Console.WriteLine("Count is: {0}", count);
        }

        /// <summary>
        /// Sorts a given array by selection sort
        /// Input: An array A[] of orderable elements
        /// Output: Array A[] sorted in nondecreasing order
        /// </summary>
        /// <param name="A"> Input an array </param>
        private static void SelectionSort(int[] A)
        {
            int temp;
            for (int i = 0; i < A.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] < A[min])
                    {
                        min = j;
                    }

                    // Swap A[i] and A[min]
                    temp = A[i];
                    A[i] = A[min];
                    A[min] = temp;
                }
            }

            Console.Write("Selection sort in A[] is: ");
            foreach (var item in A)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
