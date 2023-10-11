using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _309
	{
		public static int MaxProfit(int[] prices)
		{
			var dp = new int[prices.Length + 2][];
			for (var i = 0; i < prices.Length + 2; i++)
			{
				dp[i] = new int[2];
			}

			for (var day = prices.Length + 1; day >= 0; day--)
			{
				for (var buy = 0; buy <= 1; buy++)
				{
					if (day >= prices.Length)
					{
						dp[day][buy] = 0;
					}
					else
					{
						var r1 = dp[day + 1][buy];
						var r2 = buy == 1 ? -prices[day] + dp[day + 1][0] : prices[day] + dp[day + 2][1];

						dp[day][buy] = Math.Max(r1, r2);
					}
				}
			}

			return dp[0][1];
		}
	}
}
