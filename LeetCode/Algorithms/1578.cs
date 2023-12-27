using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1578
{
	public static int MinCost(string colors, int[] neededTime)
	{
		var totalTime = 0;
		var currentMaxTime = 0;

		for (var i = 0; i < colors.Length; i++)
		{
			if (i > 0 && colors[i] != colors[i - 1])
			{
				currentMaxTime = 0;
			}

			totalTime += Math.Min(currentMaxTime, neededTime[i]);
			currentMaxTime = Math.Max(currentMaxTime, neededTime[i]);
		}

		return totalTime;
	}
}
