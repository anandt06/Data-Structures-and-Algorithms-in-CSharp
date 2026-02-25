using System;

namespace DSA.LeetcodeProblems.Arrays.Patterns.Sliding_Window.Fixed;


public class MaximumSubArraySum
{
    public static void Main(string[] args)
    {
        int[] nums = [2, 1, 5, 1, 3, 2];
        int windowSize = 3;
        var maxAverage = FindMaximumSubArraySum(nums, windowSize);
    }

    // using sliding window approach
   
    private static object FindMaximumSubArraySum(int[] nums, int windowSize)
    {
        int maxSum = 0;
        int windowSum = 0;
        for (int i = 0; i < windowSize; i++)
        {
            windowSum += nums[i];
        }

        for (int i = windowSize; i < nums.Length; i++)
        {
            windowSum = windowSum + nums[i] - nums[i - windowSize];
            maxSum = Math.Max(maxSum, windowSum);

        }
        return maxSum;
    }
}