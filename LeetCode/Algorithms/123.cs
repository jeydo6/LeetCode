using System;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _123
	{
		public static int MaxProfit(int[] prices)
		{
			var dp = new int[prices.Length + 1][];
			for (var i = 0; i < prices.Length + 1; i++)
			{
				dp[i] = new int[5];
			}

			for (var day = prices.Length; day >= 0; day--)
			{
				for (var transactions = 0; transactions < 5; transactions++)
				{
					if (day >= prices.Length || transactions == 0)
					{
						dp[day][transactions] = 0;
					}
					else
					{
						var r1 = dp[day + 1][transactions];
						var r2 = transactions % 2 == 0 ? -prices[day] + dp[day + 1][transactions - 1] : prices[day] + dp[day + 1][transactions - 1];

						dp[day][transactions] = Math.Max(r1, r2);
					}
				}
			}

			return dp[0][4];
		}
	}
}
