using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2616
{
	public static int MinimizeMax(int[] nums, int p)
	{
		Array.Sort(nums);

		var lo = 0;
		var hi = nums[^1] - nums[0];
		while (lo < hi)
		{
			var mid = lo + (hi - lo) / 2;
			if (CountValidPairs(nums, mid) >= p)
			{
				hi = mid;
			}
			else
			{
				lo = mid + 1;
			}
		}

		return lo;
	}

	private static int CountValidPairs(int[] nums, int threshold)
	{
		var result = 0;
		var index = 0;
		while (index < nums.Length - 1)
		{
			if (nums[index + 1] - nums[index] <= threshold)
			{
				result++;
				index++;
			}

			index++;
		}

		return result;
	}
}