using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1011
{
	public static int ShipWithinDays(int[] weights, int days)
	{
		var totalLoad = 0;
		var maxLoad = 0;
		for (var i = 0; i < weights.Length; i++)
		{
			totalLoad += weights[i];
			maxLoad = Math.Max(maxLoad, weights[i]);
		}

		var lo = maxLoad;
		var hi = totalLoad;
		while (lo < hi)
		{
			var mid = lo + (hi - lo) / 2;
			if (IsFeasible(weights, days, mid))
			{
				hi = mid;
			}
			else
			{
				lo = mid + 1;
			}
		}
		return lo;
	}

	private static bool IsFeasible(int[] weights, int days, int capacity)
	{
		var daysNeeded = 1;
		var currentLoad = 0;
		for (var i = 0; i < weights.Length; i++)
		{
			currentLoad += weights[i];
			if (currentLoad > capacity)
			{
				daysNeeded++;
				currentLoad = weights[i];
			}
		}

		return daysNeeded <= days;
	}
}
