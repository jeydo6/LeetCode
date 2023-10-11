using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2279
{
	public static int MaximumBags(int[] capacity, int[] rocks, int additionalRocks)
	{
		var result = 0;

		var remainingCapacity = new int[capacity.Length];
		for (var i = 0; i < capacity.Length; i++)
		{
			remainingCapacity[i] = capacity[i] - rocks[i];
		}
		Array.Sort(remainingCapacity);

		for (var i = 0; i < capacity.Length; i++)
		{
			if (additionalRocks >= remainingCapacity[i])
			{
				additionalRocks -= remainingCapacity[i];
				result++;
			}
			else
			{
				break;
			}
		}

		return result;
	}
}
