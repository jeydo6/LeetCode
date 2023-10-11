using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _2218
{
	public static int MaxValueOfCoins(IList<IList<int>> piles, int k)
	{
		var dp = new int[piles.Count + 1][];
		for (var i = 0; i < dp.Length; i++)
		{
			dp[i] = new int[k + 1];
		}

		for (var i = 1; i <= piles.Count; i++)
		{
			for (var coins = 0; coins <= k; coins++)
			{
				var currentSum = 0;
				for (var currentCoins = 0; currentCoins <= Math.Min(piles[i - 1].Count, coins); currentCoins++)
				{
					if (currentCoins > 0)
					{
						currentSum += piles[i - 1][currentCoins - 1];
					}
					dp[i][coins] = Math.Max(dp[i][coins], dp[i - 1][coins - currentCoins] + currentSum);
				}
			}
		}
		return dp[piles.Count][k];
	}
}
