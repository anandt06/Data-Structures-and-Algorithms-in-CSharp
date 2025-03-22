using System;

namespace DSA.Blind_75
{
    // The ouput array should be formed out of multiplying all other elements in the array except self
    internal class ProductOfArrayExceptSelf
    {
        public static void Main(string[] args)
        {
            BruteForceMethod();

            BestSolutionWithPrefixAndPostFix();

        }

        // Time Complexity : O(n), Space Complexity: O(n)
        private static void BestSolutionWithPrefixAndPostFix()
        {
            int[] ipArr = [1, 2, 3, 4];
            int[] opArr = new int[ipArr.Length];

            int prefix = 1;
            for (int i = 0; i < ipArr.Length; i++)
            {
                opArr[i] = prefix;
                prefix = prefix * ipArr[i];
            }

            int postfix = 1;
            for (int i = ipArr.Length - 1; i >= 0; i--)
            {
                opArr[i] = opArr[i] * postfix;
                postfix = postfix * ipArr[i];
            }

            PrintOutputArrayElements(opArr, "BestSolutionWithPrefixAndPostFix");

        }

        // Time Complexity : O(n^2), Space Complexity: O(n)
        private static void BruteForceMethod()
        {
            int[] ipArr = [1, 2, 3, 4];
            int[] opArr = new int[ipArr.Length];
            for (int i = 0; i < ipArr.Length; i++)
            {
                int multipliedNumber = 1;
                for (int j = 0; j < ipArr.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else
                    {
                        multipliedNumber = multipliedNumber * ipArr[j];
                    }
                }
                opArr[i] = multipliedNumber;
            }

            PrintOutputArrayElements(opArr, "Brute Force");
        }

        private static void PrintOutputArrayElements(int[] opArr, string method)
        {
            Console.Write("o/p array for {0} = ", method);
            foreach (int value in opArr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
