using System;

namespace LeetCode.Algorithms;

// EASY
internal sealed class _1422
{
    public static int MaxScore(string s)
    {
        var ones = 0;
        var zeros = 0;
        var best = int.MinValue;
        for (var i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == '1')
            {
                ones++;
            }
            else
            {
                zeros++;
            }

            best = Math.Max(best, zeros - ones);
        }

        if (s[^1] == '1')
        {
            ones++;
        }

        return best + ones;
    }
}