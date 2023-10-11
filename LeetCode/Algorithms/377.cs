using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _377
{
	public static int CombinationSum4(int[] nums, int target)
	{
		Array.Sort(nums);

		var dp = new int[target + 1];
		dp[0] = 1;

		for (var combinationSum = 1; combinationSum < target + 1; combinationSum++)
		{
			for (var i = 0; i < nums.Length; i++)
			{
				if (combinationSum - nums[i] >= 0)
				{
					dp[combinationSum] += dp[combinationSum - nums[i]];
				}
				else
				{
					break;
				}
			}
		}

		return dp[target];
	}
}
