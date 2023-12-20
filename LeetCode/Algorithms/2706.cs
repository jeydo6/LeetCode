using System;

namespace LeetCode.Algorithms;

// EASY
internal sealed class _2706
{
    public static int BuyChoco(int[] prices, int money)
    {
        var min1 = Math.Min(prices[0], prices[1]);
        var min2 = Math.Max(prices[0], prices[1]);

        for (var i = 2; i < prices.Length; i++)
        {
            if (prices[i] < min1)
            {
                min2 = min1;
                min1 = prices[i];
            }
            else if (prices[i] < min2)
            {
                min2 = prices[i];
            }
        }

        var minCost = min1 + min2;
        if (minCost <= money)
        {
            return money - minCost;
        }

        return money;
    }
}