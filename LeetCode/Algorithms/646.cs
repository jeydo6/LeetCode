namespace LeetCode.Algorithms;

// MEDIUM
internal class _646
{
    public static int FindLongestChain(int[][] pairs)
    {
        var n = pairs.Length;
        Array.Sort(pairs, (a, b) => a[0] - b[0]);
        
        var dp = new int[n];
        Array.Fill(dp, 1);
        var result = 1;

        for (var i = n - 1; i >= 0; i--)
        {
            for (var j = i + 1; j < n; j++)
            {
                if (pairs[i][1] < pairs[j][0])
                {
                    dp[i] = Math.Max(dp[i], 1 + dp[j]);
                }
            }
            result = Math.Max(result, dp[i]);
        }

        return result;
    }
}