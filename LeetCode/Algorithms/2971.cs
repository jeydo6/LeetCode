using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _2971
{
	public static long LargestPerimeter(int[] nums)
	{
		Array.Sort(nums);
		var previousElementsSum = 0;
		var result = -1;
		for (var i = 0; i < nums.Length; i++)
		{
			if (nums[i] < previousElementsSum)
			{
				result = nums[i] + previousElementsSum;
			}

			previousElementsSum += nums[i];
		}

		return result;
	}
}