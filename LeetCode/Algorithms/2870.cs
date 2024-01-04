using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _2870
{
	public static int MinOperations(int[] nums)
	{
		var counts = new Dictionary<int, int>();
		for (var i = 0; i < nums.Length; i++)
		{
			counts.TryAdd(nums[i], 0);
			counts[nums[i]]++;
		}

		var result = 0;
		foreach (var count in counts.Values)
		{
			if (count is 1)
			{
				return -1;
			}

			result += (int)Math.Ceiling(count / 3.0);
		}
		return result;
	}
}