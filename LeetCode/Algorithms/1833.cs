using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1833
{
	public static int MaxIceCream(int[] costs, int coins)
	{
		var result = 0;

		var maxCost = costs[0];
		for (var i = 0; i < costs.Length; i++)
		{
			maxCost = Math.Max(maxCost, costs[i]);
		}

		var costsFrequencies = new int[maxCost + 1];
		for (var i = 0; i < costs.Length; i++)
		{
			costsFrequencies[costs[i]]++;
		}

		for (var cost = 1; cost <= maxCost; cost++)
		{
			if (costsFrequencies[cost] == 0)
			{
				continue;
			}

			if (cost > coins)
			{
				break;
			}

			var count = Math.Min(costsFrequencies[cost], coins / cost);
			coins -= cost * count;
			result += count;
		}

		return result;
	}
}
