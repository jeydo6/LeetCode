namespace LeetCode.Algorithms;

// EASY
internal class _121
{
	public static int MaxProfit(int[] prices)
	{
		var result = 0;

		var minPrice = int.MaxValue;
		for (var i = 0; i < prices.Length; i++)
		{
			if (prices[i] < minPrice)
			{
				minPrice = prices[i];
			}
			else if (prices[i] - minPrice > result)
			{
				result = prices[i] - minPrice;
			}
		}

		return result;
	}
}
