using System;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _121
	{
		public static int MaxProfit(int[] prices)
		{

			var minPrice = int.MaxValue;
			var maxProfit = int.MinValue;
			for (var i = 0; i < prices.Length; i++)
			{
				minPrice = Math.Min(minPrice, prices[i]);
				maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
			}
			return maxProfit;
		}
	}
}
