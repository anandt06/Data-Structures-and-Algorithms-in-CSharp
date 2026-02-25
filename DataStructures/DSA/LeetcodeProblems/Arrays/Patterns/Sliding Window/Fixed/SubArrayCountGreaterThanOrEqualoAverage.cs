using System;
using System.Collections.Generic;

namespace DSA.LeetcodeProblems.Arrays.Patterns.Sliding_Window.Fixed;

// Leetcode: 1343 https://leetcode.com/problems/number-of-sub-arrays-of-size-k-and-average-greater-than-or-equal-to-threshold/description/
public class SubArrayCountGreaterThanOrEqualoAverage
{
    public static void Main(string[] args)
    {
        int[] nums = [2, 2, 2, 2, 5, 5, 5, 8];
        int subArraySize = 3; // windowSize
        var thresholdAvg = 4;
        var maxAverage = FindSubArrayCountGreaterThanOrEqualoAverage(nums, subArraySize, thresholdAvg);
    }

    // using sliding window approach

    private static object FindSubArrayCountGreaterThanOrEqualoAverage(int[] nums, int windowSize, int thresholdAvg)
    {
        int counter = 0;
        long windowSum = 0;
        for (int i = 0; i < windowSize; i++)
        {
            windowSum = windowSum + nums[i];
        }
        if (windowSum / windowSize >= thresholdAvg)
        {
            counter++;
        }

        for (int i = windowSize; i < nums.Length; i++)
        {
            windowSum = windowSum + nums[i] - nums[i - windowSize];

            if (windowSum / windowSize >= thresholdAvg)
            {
                counter++;
            }
        }

        return counter;
    }
}