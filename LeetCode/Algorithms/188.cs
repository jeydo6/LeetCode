using System;

namespace LeetCode.Algorithms;

// HARD
internal class _188
{
	public static int MaxProfit(int k, int[] prices)
	{
		var n = prices.Length;

		if (n <= 0 || k <= 0)
		{
			return 0;
		}

		if (2 * k > n)
		{
			var temp = 0;
			for (var i = 1; i < n; i++)
			{
				temp += Math.Max(0, prices[i] - prices[i - 1]);
			}
			return temp;
		}

		var dp = new int[n][][];
		for (var i = 0; i < n; i++)
		{
			dp[i] = new int[k + 1][];
			for (var j = 0; j <= k; j++)
			{
				dp[i][j] = new int[] { -1000000000, -1000000000 };
			}
		}

		dp[0][0][0] = 0;
		dp[0][1][1] = -prices[0];

		for (var i = 1; i < n; i++)
		{
			for (var j = 0; j <= k; j++)
			{
				dp[i][j][0] = Math.Max(dp[i - 1][j][0], dp[i - 1][j][1] + prices[i]);
				if (j > 0)
				{
					dp[i][j][1] = Math.Max(dp[i - 1][j][1], dp[i - 1][j - 1][0] - prices[i]);
				}
			}
		}

		var result = 0;
		for (var j = 0; j <= k; j++)
		{
			result = Math.Max(result, dp[n - 1][j][0]);
		}

		return result;
	}
}
