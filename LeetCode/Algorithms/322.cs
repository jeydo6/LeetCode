using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _322
	{
		public static int CoinChange(int[] coins, int amount)
		{
			var dp = new int[amount + 1];
			for (var i = 0; i < dp.Length; i++)
			{
				dp[i] = dp.Length;
			}

			dp[0] = 0;
			for (var i = 1; i <= amount; i++)
			{
				for (var j = 0; j < coins.Length; j++)
				{
					if (coins[j] <= i)
					{
						dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
					}
				}
			}
			return dp[amount] > amount ? -1 : dp[amount];
		}
	}
}
