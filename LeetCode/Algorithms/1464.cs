using System;

namespace LeetCode.Algorithms;

// EASY
internal sealed class _1464
{
	public static int MaxProduct(int[] nums)
	{
		Array.Sort(nums);
		return (nums[^1] - 1) * (nums[^2] - 1);
	}
}
