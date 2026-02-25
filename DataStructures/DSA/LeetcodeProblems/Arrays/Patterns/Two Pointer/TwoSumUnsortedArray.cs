using System;
using System.Collections.Generic;

namespace DSA.LeetcodeProblems.Patterns.TwoPointer
{
    public class TwoSumUnsortedArray
    {
        static void Main(string[] args)
        {
            int[] nums = new int[]{ 3, 5, 2, 4 , 6 };
            int target = 9;
            var indexPositions = TwoSum(nums, target);

            foreach (var item in indexPositions)
            {
                Console.WriteLine(item);
            }
        }

        private static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (keyValuePairs.ContainsKey(complement))
                {
                    return new int[] { i, keyValuePairs[complement] };
                }
                else
                {
                    if (!keyValuePairs.ContainsKey(nums[i]))
                    {
                        keyValuePairs.Add(nums[i], i);
                    }
                }
            }
            return null;
        }
    }
}
