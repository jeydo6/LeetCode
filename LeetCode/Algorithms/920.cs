using System;

namespace LeetCode.Algorithms;

// HARD
internal class _920
{
	private const long Modulo = 1_000_000_007L;

	public static int NumMusicPlaylists(int n, int goal, int k)
	{
		var dp = new long[goal + 1][];
		for (var i = 0; i < dp.Length; i++)
		{
			dp[i] = new long[n + 1];
		}
		dp[0][0] = 1;

		for (var i = 1; i <= goal; i++)
		{
			for (var j = 1; j <= Math.Min(i, n); j++)
			{
				dp[i][j] = dp[i - 1][j - 1] * (n - j + 1) % Modulo;
				if (j > k)
				{
					dp[i][j] = (dp[i][j] + dp[i - 1][j] * (j - k)) % Modulo;
				}
			}
		}

		return (int)dp[goal][n];
	}
}