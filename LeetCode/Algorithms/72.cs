using System;

namespace LeetCode.Algorithms;

// HARD
internal class _72
{
	public static int MinDistance(string word1, string word2)
	{
		var n = word1.Length;
		var m = word2.Length;

		if (n * m == 0)
		{
			return n + m;
		}

		var dp = new int[n + 1][];
		for (var i = 0; i < n + 1; i++)
		{
			dp[i] = new int[m + 1];
			dp[i][0] = i;
		}
		for (var j = 0; j < m + 1; j++)
		{
			dp[0][j] = j;
		}

		for (var i = 1; i < n + 1; i++)
		{
			for (var j = 1; j < m + 1; j++)
			{
				if (word2[j - 1] == word1[i - 1])
				{
					dp[i][j] = dp[i - 1][j - 1];
				}
				else
				{
					dp[i][j] = Math.Min(
						dp[i - 1][j],
						Math.Min(dp[i][j - 1], dp[i - 1][j - 1])
					) + 1;
				}
			}
		}

		return dp[n][m];
	}
}
