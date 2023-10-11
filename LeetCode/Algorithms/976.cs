using System;

namespace LeetCode.Algorithms;

// EASY
internal class _976
{
	public static int LargestPerimeter(int[] nums)
	{
		Array.Sort(nums);

		for (var i = nums.Length - 3; i >= 0; i--)
		{
			if (nums[i] + nums[i + 1] > nums[i + 2])
			{
				return nums[i] + nums[i + 1] + nums[i + 2];
			}
		}

		return 0;
	}
}
