using System;

namespace LeetCode.Algorithms;

// EASY
internal class _1099
{
	public static int TwoSumLessThanK(int[] nums, int k)
	{
		var count = new int[1001];
		for (var i = 0; i < nums.Length; i++)
		{
			count[nums[i]]++;
		}

		var result = -1;

		var lo = 1;
		var hi = 1000;
		while (lo <= hi)
		{
			if (lo + hi >= k || count[hi] == 0)
			{
				hi--;
			}
			else
			{
				if (count[lo] > (lo < hi ? 0 : 1))
				{
					result = Math.Max(result, lo + hi);
				}
				lo++;
			}
		}

		return result;
	}
}
