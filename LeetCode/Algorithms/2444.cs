using System;

namespace LeetCode.Algorithms;

// HARD
internal class _2444
{
	public static long CountSubarrays(int[] nums, int minK, int maxK)
	{
		var result = 0L;

		var leftBound = -1;
		var lastMin = -1;
		var lastMax = -1;
		for (var i = 0; i < nums.Length; i++)
		{
			if (nums[i] >= minK && nums[i] <= maxK)
			{
				lastMin = (nums[i] == minK) ? i : lastMin;
				lastMax = (nums[i] == maxK) ? i : lastMax;
				result += Math.Max(0, Math.Min(lastMin, lastMax) - leftBound);
			}
			else
			{
				leftBound = i;
				lastMin = -1;
				lastMax = -1;
			}
		}

		return result;
	}
}
