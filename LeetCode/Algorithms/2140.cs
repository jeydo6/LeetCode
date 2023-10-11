using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2140
{
	public static long MostPoints(int[][] questions)
	{
		var dp = new long[questions.Length];
		dp[^1] = questions[^1][0];

		for (var i = questions.Length - 2; i >= 0; i--)
		{
			dp[i] = questions[i][0];
			var skip = questions[i][1];
			if (i + skip + 1 < questions.Length)
			{
				dp[i] += dp[i + skip + 1];
			}
			dp[i] = Math.Max(dp[i], dp[i + 1]);
		}

		return dp[0];
	}
}
