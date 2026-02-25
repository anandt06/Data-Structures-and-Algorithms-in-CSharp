using System;

namespace DSA.LeetcodeProblems.Patterns.SlidingWindow;

public class ContinousElementSum
{
    public static void Main(string[] args)
    {
        int[] arr = { -1, 2, 3, 3, 4, 5, -1 };
        int slidingWWindowInterval = 4;

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
