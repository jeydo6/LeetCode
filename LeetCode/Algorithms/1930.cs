using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1930
{
    public static int CountPalindromicSubsequence(string s)
    {
        var letters = new HashSet<char>();
        for (var i = 0; i < s.Length; i++)
        {
            letters.Add(s[i]);
        }

        var result = 0;
        var between = new HashSet<char>();
        foreach (var letter in letters)
        {
            var i = -1;
            var j = 0;

            for (var k = 0; k < s.Length; k++)
            {
                if (s[k] == letter)
                {
                    if (i == -1)
                    {
                        i = k;
                    }

                    j = k;
                }
            }

            between.Clear();
            for (var k = i + 1; k < j; k++)
            {
                between.Add(s[k]);
            }

            result += between.Count;
        }

        return result;
    }
}