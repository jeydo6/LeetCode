using System;

namespace LeetCode.Algorithms;

// HARD
internal class _1420
{
	private const long Modulo = (long)1e9 + 7;

	public static int NumOfArrays(int n, int m, int k)
	{
		var dp = new long[n + 1][][];
		var prefix = new long[n + 1][][];

		for (var i = 0; i < n + 1; i++)
		{
			dp[i] = new long[m + 1][];
			prefix[i] = new long[m + 1][];
			for (var j = 0; j < m + 1; j++)
			{
				dp[i][j] = new long[k + 1];
				prefix[i][j] = new long[k + 1];
			}
		}

		for (var num = 1; num <= m; num++)
		{
			dp[1][num][1] = 1;
			prefix[1][num][1] = prefix[1][num - 1][1] + 1;
		}

		for (var i = 1; i <= n; i++)
		{
			for (var maxNum = 1; maxNum <= m; maxNum++)
			{
				for (var cost = 1; cost <= k; cost++)
				{
					var result = maxNum * dp[i - 1][maxNum][cost] % Modulo;
					result = (result + prefix[i - 1][maxNum - 1][cost - 1]) % Modulo;

					dp[i][maxNum][cost] += result;
					dp[i][maxNum][cost] %= Modulo;

					prefix[i][maxNum][cost] = prefix[i][maxNum - 1][cost] + dp[i][maxNum][cost];
					prefix[i][maxNum][cost] %= Modulo;
				}
			}
		}

		return (int)prefix[n][m][k];
	}
}
