using System;

namespace LeetCode.Algorithms;

// EASY
internal sealed class _1913
{
	public static int MaxProductDifference(int[] nums)
	{
		Array.Sort(nums);
		return nums[^2] * nums[^1] - nums[0] * nums[1];
	}
}