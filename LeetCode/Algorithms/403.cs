using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal static class _403
{
    public static bool CanCross(int[] stones)
    {
        var n = stones.Length;
        var mark = new Dictionary<int, int>();
        for (var i = 0 ; i < n; i++)
        {
            mark[stones[i]] = i;
        }

        var dp = new bool[2001][];
        for (var i = 0; i < dp.Length; i++)
        {
            dp[i] = new bool[2001];
        }
        dp[0][0] = true;

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j <= n; j++)
            {
                if (dp[i][j])
                {
                    if (mark.ContainsKey(stones[i] + j))
                    {
                        dp[mark[stones[i] + j]][j] = true;
                    }
                    if (mark.ContainsKey(stones[i] + j + 1))
                    {
                        dp[mark[stones[i] + j + 1]][j + 1] = true;
                    }
                    if (mark.ContainsKey(stones[i] + j - 1))
                    {
                        dp[mark[stones[i] + j - 1]][j - 1] = true;
                    }
                }


            }
        }

        for (var i = 0; i <= n; i++)
        {
            if (dp[n - 1][i])
            {
                return true;
            }
        }
        return false;
    }
}