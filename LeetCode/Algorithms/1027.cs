using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
public class _1027
{
	public static int LongestArithSeqLength(int[] nums)
	{
		var result = 0;
		var dp = new Dictionary<int, int>[nums.Length];
		for (var right = 0; right < nums.Length; right++)
		{
			dp[right] = new Dictionary<int, int>();
			for (var left = 0; left < right; left++)
			{
				var diff = nums[left] - nums[right];
				dp[right][diff] = dp[left].ContainsKey(diff) ? dp[left][diff] + 1 : 2;
				result = Math.Max(result, dp[right][diff]);
			}
		}
		return result;
	}
}