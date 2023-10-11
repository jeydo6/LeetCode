using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1770
{
	public static int MaximumScore(int[] nums, int[] multipliers)
	{
		var dp = new int[multipliers.Length + 1];

		for (var op = multipliers.Length - 1; op >= 0; op--)
		{
			var next = new List<int>(dp);
			for (var left = op; left >= 0; left--)
			{
				dp[left] = Math.Max(
					multipliers[op] * nums[left] + next[left + 1],
					multipliers[op] * nums[nums.Length - 1 - (op - left)] + next[left]
				);
			}
		}

		return dp[0];
	}
}
