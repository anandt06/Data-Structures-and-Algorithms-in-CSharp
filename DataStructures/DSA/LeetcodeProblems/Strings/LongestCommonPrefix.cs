namespace DSA.LeetcodeProblems.Strings
{
    public class LongestCommonPrefix
    {
        static void Main(string[] args)
        {
            string[] input = ["abcd", "abcdefg", "abcdefgh"];
            GetLongestCommonPrefix(input);

        }

        public static string GetLongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";

            string prefix = strs[0];

            int i = 1;
            while (i < strs.Length)
            {
                while (strs[i].IndexOf(prefix) != 0)
                    prefix = prefix.Substring(0, prefix.Length - 1);
                i++;
            }
            return prefix;
        }
    }
}
