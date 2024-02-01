using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _2966
{
	public static int[][] DivideArray(int[] nums, int k)
	{
		Array.Sort(nums);
		var result = new int[nums.Length / 3][];
		for (var i = 0; i < nums.Length; i += 3)
		{
			if (nums[i + 2] - nums[i] > k)
			{
				return Array.Empty<int[]>();
			}

			result[i / 3] = new int[] { nums[i], nums[i + 1], nums[i + 2] };
		}

		return result;
	}
}