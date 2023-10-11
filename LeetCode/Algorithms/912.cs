using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _912
{
	public static int[] SortArray(int[] nums)
	{
		var counts = new Dictionary<int, int>();

		var minVal = nums[0];
		var maxVal = nums[0];
		for (var i = 0; i < nums.Length; i++)
		{
			minVal = Math.Min(minVal, nums[i]);
			maxVal = Math.Max(maxVal, nums[i]);

			if (!counts.ContainsKey(nums[i]))
			{
				counts[nums[i]] = 0;
			}
			counts[nums[i]]++;
		}

		var index = 0;
		for (var val = minVal; val <= maxVal; ++val)
		{
			while (counts.ContainsKey(val))
			{
				nums[index] = val;
				index++;
				counts[val]--;
			}
		}

		return nums;
	}
}
