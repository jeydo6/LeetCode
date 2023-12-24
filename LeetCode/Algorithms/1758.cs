using System;

namespace LeetCode.Algorithms;

// EASY
internal sealed class _1758
{
    public static int MinOperations(string s)
    {
        var count = 0;
        for (var i = 0; i < s.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (s[i] == '1')
                {
                    count++;
                }
            }
            else
            {
                if (s[i] == '0')
                {
                    count++;
                }
            }
        }

        return Math.Min(count, s.Length - count);
    }
}