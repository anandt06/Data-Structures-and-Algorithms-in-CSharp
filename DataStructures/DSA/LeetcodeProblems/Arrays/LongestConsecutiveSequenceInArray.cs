using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LeetcodeProblems.Arrayss
{
    internal class LongestConsecutiveSequenceInArray
    {
        static void Main(string[] args)
        {
            int[] nums = { 100, 4, 200, 1, 3, 2 };
            Console.WriteLine("Longest Consecutive Sequence Length: " + LongestConsecutive(nums));
        }

        public static int LongestConsecutive(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            HashSet<int> numSet = new HashSet<int>(nums);
            int longestStreak = 0;

            foreach (int num in numSet)
            {
                // Check if it is the start of a sequence
                if (!numSet.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentStreak = 1;

                    // Count consecutive numbers
                    while (numSet.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentStreak++;
                    }

                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            }

            return longestStreak;
        }
    }
}
