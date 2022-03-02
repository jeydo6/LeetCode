namespace LeetCode.Algorithms
{
	// EASY
	internal class _121
	{
		public static int MaxProfit(int[] prices)
		{
			var minPrice = int.MaxValue;
			var maxProfit = 0;
			for (var i = 0; i < prices.Length; i++)
			{
				if (prices[i] < minPrice)
				{
					minPrice = prices[i];
				}
				else if (prices[i] - minPrice > maxProfit)
				{
					maxProfit = prices[i] - minPrice;
				}
			}
			return maxProfit;
		}
	}
}
