using System;

namespace LeetCode.Algorithms;

// EASY
internal class _2389
{
	public static int[] AnswerQueries(int[] nums, int[] queries)
	{
		Array.Sort(nums);
		for (var i = 1; i < nums.Length; i++)
		{
			nums[i] += nums[i - 1];
		}

		var result = new int[queries.Length];
		for (var i = 0; i < result.Length; i++)
		{
			result[i] = BinarySearch(nums, queries[i]);
		}
		return result;
	}

	private static int BinarySearch(int[] nums, int target)
	{
		var lo = 0;
		var hi = nums.Length - 1;
		while (lo < hi)
		{
			var mid = lo + (hi - lo) / 2;
			if (nums[mid] == target)
			{
				return mid + 1;
			}
			if (nums[mid] < target)
			{
				lo = mid + 1;
			}
			else
			{
				hi = mid - 1;
			}
		}
		return nums[lo] > target ? lo : lo + 1;
	}
}
