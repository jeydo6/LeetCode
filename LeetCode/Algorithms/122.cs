namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _122
	{
		public static int MaxProfit(int[] prices)
		{
			var profit = 0;

			var i = 0;
			var n = prices.Length - 1;
			while (i < n)
			{
				while (i < n && prices[i + 1] <= prices[i])
				{
					i++;
				}
				var buy = prices[i];

				while (i < n && prices[i + 1] > prices[i])
				{
					i++;
				}
				var sell = prices[i];

				profit += sell - buy;
			}

			return profit;
		}
	}
}
