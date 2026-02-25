namespace DSA.LeetcodeProblems.Arrays.Patterns.Sliding_Window.Fixed;

// Leetcode: 643 https://leetcode.com/problems/maximum-average-subarray-i/description/
public class MaximumSubArrayAverage
{
    public static void Main(string[] args)
    {
        int[] nums = [1, 12, -5, -6, 50, 3];
        int windowSize = 4;
        var maxAverage = FindMaximumSubArrayAverage(nums, windowSize);
    }

    // BruteForce - Complexity -> O(n^2)
    public static double FindMaximumSubArrayAverageBruteForce(int[] nums, int k)
    {
        double maxAverage = 0;
        for (int i = 0; i < nums.Length - k; i++)
        {
            int sum = 0;
            for (int j = i; j < i + k; j++)
            {
                sum = sum + nums[j];
            }
            double avg = (double)sum / k;

            if (avg > maxAverage)
            {
                maxAverage = avg;
            }
        }

        return maxAverage;
    }

    private static double FindMaximumSubArrayAverage(int[] nums, int k)
    {
        return 0;
    }
}