﻿namespace LeetCode.Algorithms;

// MEDIUM
internal class _97
{
	public static bool IsInterleave(string s1, string s2, string s3)
	{
		if (s3.Length != s1.Length + s2.Length)
		{
			return false;
		}

		var dp = new bool[s2.Length + 1];
		for (var i = 0; i <= s1.Length; i++)
		{
			for (var j = 0; j <= s2.Length; j++)
			{
				if (i == 0 && j == 0)
				{
					dp[j] = true;
				}
				else if (i == 0)
				{
					dp[j] = dp[j - 1] && s2[j - 1] == s3[i + j - 1];
				}
				else if (j == 0)
				{
					dp[j] = dp[j] && s1[i - 1] == s3[i + j - 1];
				}
				else
				{
					dp[j] = (dp[j] && s1[i - 1] == s3[i + j - 1]) || (dp[j - 1] && s2[j - 1] == s3[i + j - 1]);
				}
			}
		}

		return dp[^1];
	}
}
