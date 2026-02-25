using System;

namespace DSA.LeetcodeProblems.Arrays.Patterns.Kadanes_Algorithm
{
    internal class MaximumSubArraySumProgram
    {
        static void Main(string[] args)
        {
            int[] arr = { -1, -3, 2, 1, -1 };
            int[] arr1 = { 3, -4, 5, 4, -1, 7, -8 };
            FindSubArrayForMaxSumInAnArrayBruteForce(arr);
            FindSubArrayForMaxSumUsingKadanesAlgorithm(arr1);
        }

        private static void FindSubArrayForMaxSumInAnArrayBruteForce(int[] arr)
        {
            int maxSum = int.MinValue;
            int start = 0, end = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int localSum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    localSum += arr[j];

                    if (localSum > maxSum)
                    {
                        maxSum = localSum;
                        start = i;
                        end = j;
                    }
                }
            }

            Console.WriteLine($"Maximum Sum: {maxSum}");
            Console.Write("Maximum Subarray: [ ");
            for (int i = start; i <= end; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("]");
        }

        //KADEN'S ALGORITHM
        private static void FindSubArrayForMaxSumUsingKadanesAlgorithm(int[] arr)
        {
            int maxSum = int.MinValue;
            int currentSum = 0;
            int start = 0, end = 0, tempStart = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                currentSum += arr[i];
                if (currentSum > maxSum)
                {
                    maxSum = Math.Max(maxSum, currentSum);
                    start = tempStart;
                    end = i;
                }

                if (currentSum < 0)
                {
                    currentSum = 0;
                    tempStart = i + 1;
                }
            }

            Console.WriteLine($"Maximum Sum: {maxSum}");
            Console.Write("Maximum Subarray: [ ");
            for (int i = start; i <= end; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("]");
        }
    }
}