using System;
using System.Collections.Generic;

namespace DSA.Recursion
{

    //Given two integers n and k, return all possible combinations of k numbers chosen from the range[1, n].
    //You may return the answer in any order.
    //Input: n = 4, k = 2
    //Output: [[1, 2],[1, 3],[1, 4],[2, 3],[2, 4],[3, 4]]
    //Explanation: There are 4 choose 2 = 6 total combinations.
    //Note that combinations are unordered, i.e., [1, 2] and [2, 1] are considered to be the same combination.
    public class Combinations
    {
        static void Main(string[] args)
        {
            var combinations = GetCombination(4, 2);

            foreach (var comb in combinations)
            { 
            
                Console.WriteLine(comb);
            }
        }


        public static IList<IList<int>> GetCombination(int n, int k)
        {
            var result = new List<IList<int>>();
            Backtrack(1, new List<int>(), n, k, result);
            return result;
        }

        private static void Backtrack(int start, List<int> path, int n, int k, List<IList<int>> result)
        {
            if (path.Count == k)
            {
                result.Add(new List<int>(path));
                return;
            }

            for (int i = start; i <= n; i++)
            {
                path.Add(i);
                Backtrack(i + 1, path, n, k, result);
                path.RemoveAt(path.Count - 1); // backtrack
            }
        }
    }
}