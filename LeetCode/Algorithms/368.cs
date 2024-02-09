using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _368
{
	public static IList<int> LargestDivisibleSubset(int[] nums)
	{
		Array.Sort(nums);

		var lengths = new int[nums.Length];
		var prevs = new int[nums.Length];

		var maxLength = 0;
		var index = -1;
		for (var i = 0; i < nums.Length; i++)
		{
			lengths[i] = 1;
			prevs[i] = -1;
			for (var j = i - 1; j >= 0; j--)
			{
				if (nums[i] % nums[j] == 0 && lengths[j] + 1 > lengths[i])
				{
					lengths[i] = lengths[j] + 1;
					prevs[i] = j;
				}
			}
			if (lengths[i] > maxLength)
			{
				maxLength = lengths[i];
				index = i;
			}
		}
		var result = new List<int>();
		while (index != -1)
		{
			result.Add(nums[index]);
			index = prevs[index];
		}
		return result;
	}
}