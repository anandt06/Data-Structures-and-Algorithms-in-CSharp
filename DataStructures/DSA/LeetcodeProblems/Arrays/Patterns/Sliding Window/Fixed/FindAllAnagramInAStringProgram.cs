using System.Collections.Generic;

namespace DSA.LeetcodeProblems.Arrays.Patterns.Sliding_Window.Fixed;

// Leetcode : 438 https://leetcode.com/problems/find-all-anagrams-in-a-string/description/
// This program is a variation of 438 instead of index we return the matching substring

// For the actual question this approach has an issue as it always takes the first matching substring for IndexOf
// commented input is working, but current input is not working for orginal question
public class FindAllAnagramInAStringProgram
{
    public static void Main(string[] args)
    {
        string s = "abab"; // "cbaebabacd";
        string valueToCheckForAnagram = "ab"; // "abc";
        int windowSize = 2; // 3
        var anagramList = FindAllAnagramInAString(s, windowSize, valueToCheckForAnagram);
    }

    private static IList<string> FindAllAnagramInAString(string s, int windowSize, string valueToCheckForAnagram)
    {
        IList<string> anagramPairList = new List<string>();
        IList<int> startIndexOfAnagrams = new List<int>();
        string tempString = "";
        for (int i = 0; i < windowSize; i++)
        {
            tempString += s[i];
        }

        if (tempString.Length == valueToCheckForAnagram.Length)
        {
            var isAnagram = CheckIfAnagram(tempString, valueToCheckForAnagram);
            if (isAnagram)
            {
                anagramPairList.Add(tempString);
                var index = s.IndexOf(tempString);
                startIndexOfAnagrams.Add(index);
            }
        }

        for (int i = windowSize; i < s.Length; i++)
        {
            tempString = (tempString + s[i]).Remove(0,1);
            var isAnagram = CheckIfAnagram(tempString, valueToCheckForAnagram);
            if (isAnagram)
            {
                anagramPairList.Add(tempString);
                var index = s.IndexOf(tempString);
                startIndexOfAnagrams.Add(index);
            }
        }
        return anagramPairList;
    }

    private static bool CheckIfAnagram(string tempString, string valueToCheckForAnagram)
    {
        var tempStringCharArray = tempString.ToCharArray();
        var valueToCheckForAnagramCharArray = valueToCheckForAnagram.ToCharArray();
        System.Array.Sort(tempStringCharArray);
        System.Array.Sort(valueToCheckForAnagramCharArray);
        if (new string(tempStringCharArray) == new string(valueToCheckForAnagramCharArray))
        {
            return true;
        }
        return false;
    }

    static bool AreAnagrams(string s1, string s2)
    {

        if (s1.Length != s2.Length) return false;

        // create a dictionary to store
        // character frequencies
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        // count frequency of each 
        // character in string s1
        foreach (char ch in s1)
            charCount[ch] = charCount.GetValueOrDefault(ch, 0) + 1;

        // count frequency of each character in string s2
        foreach (char ch in s2)
            charCount[ch] = charCount.GetValueOrDefault(ch, 0) - 1;

        // check if all frequencies are zero
        foreach (var pair in charCount)
        {
            if (pair.Value != 0)
                return false;
        }

        return true;
    }
}
