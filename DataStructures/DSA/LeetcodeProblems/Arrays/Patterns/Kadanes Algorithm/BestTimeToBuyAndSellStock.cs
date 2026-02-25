using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LeetcodeProblems.Arrays.Patterns.Kadanes_Algorithm
{
    internal class BestTimeToBuyAndSellStock
    {
        public static void Main(string[] args)
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 }; //op: 5
            int[] prices2 = { 7, 6, 4, 3, 1 }; //op: 0

            int maxProfit = int.MinValue;
            int localProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                int buyPrice = prices[i];
            }
        }
    }
}
