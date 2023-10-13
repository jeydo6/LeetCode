using System;

namespace LeetCode.Algorithms;

// EASY
internal class _746
{
	public static int MinCostClimbingStairs(int[] cost)
	{
		var downOne = 0;
		var downTwo = 0;
		for (var i = 2; i < cost.Length + 1; i++)
		{
			(downOne, downTwo) = (Math.Min(downOne + cost[i - 1], downTwo + cost[i - 2]), downOne);
		}

		return downOne;
	}
}
