using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1658
{
	public static int MinOperations(int[] nums, int x)
	{
		var current = 0;
		for (var i = 0; i < nums.Length; i++)
		{
			current += nums[i];
		}

		var result = int.MaxValue;

		var left = 0;
		for (var right = 0; right < nums.Length; right++)
		{
			current -= nums[right];
			while (current < x && left <= right)
			{
				current += nums[left];
				left += 1;
			}
			if (current == x)
			{
				result = Math.Min(result, nums.Length + left - right - 1);
			}
		}

		return result != int.MaxValue ? result : -1;
	}
}
