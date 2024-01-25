using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1143
{
	public static int LongestCommonSubsequence(string text1, string text2)
	{
		var dp = new int[text1.Length + 1][];
		for (var i = 0; i < text1.Length + 1; i++)
		{
			dp[i] = new int[text2.Length + 1];
		}

		for (var i = 0; i < text1.Length; i++)
		{
			for (var j = 0; j < text2.Length; j++)
			{
				if (text1[i] == text2[j])
				{
					dp[i + 1][j + 1] = 1 + dp[i][j];
				}
				else
				{
					dp[i + 1][j + 1] = Math.Max(dp[i][j + 1], dp[i + 1][j]);
				}
			}
		}
		return dp[text1.Length][text2.Length];
	}
}
