using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2439
{
	public static int MinimizeArrayValue(int[] nums)
	{
		var result = 0L;
		var prefixSum = 0;
		for (var i = 0; i < nums.Length; ++i)
		{
			prefixSum += nums[i];
			result = Math.Max(result, (prefixSum + i) / (i + 1));
		}

		return (int)result;
	}
}
