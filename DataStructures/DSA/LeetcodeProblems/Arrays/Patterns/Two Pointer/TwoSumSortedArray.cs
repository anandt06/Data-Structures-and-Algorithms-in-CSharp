using System;
using System.Collections.Generic;

namespace DSA.LeetcodeProblems.Patterns.TwoPointer
{
    // Two pointer is consisdered in only when array is in sorted case.
    // You can still do a sort operation and use two pointer. However in those case where you want to return index of orginal
    // araay itself. you cannot use two pointer. In these cases you have to use HashMap approach
    public class TwoSumSortedArray
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4 }; // 3.2.4 => 6
            int target = 5;
            var indexPositions = TwoSum(nums, target);

            Console.WriteLine("Positions :{0} {1}", indexPositions.Item1, indexPositions.Item2);
        }


        private static (int?, int?) TwoSum(List<int> nums, int target)
        {
            int left = 0;
            int right = nums.Count - 1;
            while (left <= right)
            {
                if (nums[left] + nums[right] == target)
                {
                    return (left, right);
                }
                else if (nums[left] + nums[right] > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return (null, null);
        }
    }
}