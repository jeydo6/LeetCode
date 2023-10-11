using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1493
{
	public static int LongestSubarray(int[] nums)
	{
		var result = 0;
		var zeroCount = 0;
		var start = 0;
		for (var i = 0; i < nums.Length; i++)
		{
			zeroCount += nums[i] == 0 ? 1 : 0;
			while (zeroCount > 1)
			{
				zeroCount -= (nums[start] == 0 ? 1 : 0);
				start++;
			}

			result = Math.Max(result, i - start);
		}

		return result;
	}
}