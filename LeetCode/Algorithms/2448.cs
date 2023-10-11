using System;

namespace LeetCode.Algorithms;

// HARD
internal class _2448
{
	public static long MinCost(int[] nums, int[] cost)
	{
		var n = nums.Length;
		var numsAndCost = new int[n][];
		for (var i = 0; i < n; i++)
		{
			numsAndCost[i] = new int[] { nums[i], cost[i] };
		}
		Array.Sort(numsAndCost, (a, b) => a[0] - b[0]);

		var prefixCost = new long[n];
		prefixCost[0] = numsAndCost[0][1];
		for (var i = 1; i < n; i++)
		{
			prefixCost[i] = numsAndCost[i][1] + prefixCost[i - 1];
		}

		var totalCost = 0L;
		for (var i = 1; i < n; i++)
		{
			totalCost += 1l * numsAndCost[i][1] * (numsAndCost[i][0] - numsAndCost[0][0]);
		}

		var result = totalCost;
		for (var i = 1; i < n; i++)
		{
			var gap = numsAndCost[i][0] - numsAndCost[i - 1][0];
			totalCost += 1L * prefixCost[i - 1] * gap;
			totalCost -= 1L * (prefixCost[n - 1] - prefixCost[i - 1]) * gap;
			result = Math.Min(result, totalCost);
		}

		return result;
	}
}
