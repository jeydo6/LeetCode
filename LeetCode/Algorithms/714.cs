using System;

namespace LeetCode.Algorithms;

// MEDIUM
public class _714
{
	public static int MaxProfit(int[] prices, int fee)
	{
		var free = 0;
		var hold = -prices[0];
        
		for (var i = 1; i < prices.Length; i++)
		{
			(hold, free) = (Math.Max(hold, free - prices[i]), Math.Max(free, hold + prices[i] - fee));
		}
        
		return free;
	}
}