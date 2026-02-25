using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures.String
{
    public class ValidParanthesis
    {
        static void Main(string[] args)
        {
            string s = "()[]{}";

            var teamA = new int[] { 2, 1, 3 };
            var teamB = new int[] { 2, 4 };
            BruteForce(teamA, teamB);

            FindUsingBinarySearch(teamA, teamB);
        }

        private static void FindUsingBinarySearch(int[] teamA, int[] teamB)
        {
            System.Array.Sort(teamA);
            int[] result = new int[teamB.Length];

            for (int i = 0; i < teamB.Length; i++)
            {
                int left = 0;
                int right = teamA.Length;

                while (left < right)
                {
                    int mid = (left + right) / 2;
                    if (teamA[mid] <= teamB[i])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid;
                    }
                }

                result[i] = left;  // left is the count
            }
        
        }

        private static void BruteForce(int[] teamA, int[] teamB)
        {
            var sol = new List<int>();

            System.Array.Sort(teamA);

            for (int i = 0; i < teamB.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < teamA.Length; j++)
                {
                    if (teamB[i] >= teamA[j])
                    {
                        count++;
                    }
                }
                sol.Add(count);
            }

            int[] result = sol.ToArray();

            foreach (var val in sol)
            {
                Console.WriteLine(val);
            }
        }


    }
}