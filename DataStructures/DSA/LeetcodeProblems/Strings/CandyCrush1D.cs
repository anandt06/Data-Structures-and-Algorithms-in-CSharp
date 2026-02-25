using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.LeetcodeProblems.Strings
{
    // Similar Question

    //Write a function to crush candy in one dimensional board.In candy crushing games, groups of like items are removed from the board.In this problem,
    //any sequence of 3 or more like items should be removed and any items adjacent to that sequence should now be considered adjacent to each other. 
    //This process should be repeated as many time as possible.You should greedily remove characters from left to right.

    //Input: "aaabbbc"
    //Output: "c"
    //Explanation:
    //1. Remove 3 'a': "aaabbbbc" => "bbbbc"
    //2. Remove 4 'b': "bbbbc" => "c"

    // Input: "aabbccddeeedcba" => ""

    // Leetcode 1209: https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string-ii/description/
    public class CandyCrush1D
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveDuplicates("abcd", 2));                // abcd
            Console.WriteLine(RemoveDuplicates("deeedbbcccbdaa", 3));      // aa
            Console.WriteLine(RemoveDuplicates("pbbcggttciiippooaais", 2));// ps
        }

        private static string RemoveDuplicates(string input, int k)
        {
            Stack<(char ch, int counter)> values = new Stack<(char ch, int counter)>();
            foreach (char c in input)
            {
                if (values.Count > 0 && values.Peek().ch == c)
                {
                    var top = values.Pop();
                    top.counter++;

                    if (top.counter < k)
                    {
                        values.Push(top);
                    }
                }
                else
                {
                    values.Push((c, 1));
                }
            }

            StringBuilder sb = new StringBuilder();
            foreach (var value in values)
            { 
                sb.Insert(0, new string(value.ch,value.counter));
            }

            return sb.ToString();
        }
    }
}