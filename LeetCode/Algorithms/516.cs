using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _516
{
	public static int LongestPalindromeSubseq(string s)
	{
		var dp = new int[s.Length];
		var dpPrev = new int[s.Length];

		for (var i = s.Length - 1; i >= 0; i--)
		{
			dp[i] = 1;
			for (var j = i + 1; j < s.Length; j++)
			{
				if (s[i] == s[j])
				{
					dp[j] = dpPrev[j - 1] + 2;
				}
				else
				{
					dp[j] = Math.Max(dpPrev[j], dp[j - 1]);
				}
			}

			for (var j = 0; j < s.Length; j++)
			{
				dpPrev[j] = dp[j];
			}
		}

		return dp[^1];
	}
}
