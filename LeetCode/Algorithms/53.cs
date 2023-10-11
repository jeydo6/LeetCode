using System;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _53
	{
		public static int MaxSubArray(int[] nums)
		{
			var dp = new int[nums.Length];
			dp[0] = nums[0];

			var max = dp[0];
			for (int i = 1; i < nums.Length; i++)
			{
				dp[i] = nums[i] + (dp[i - 1] > 0 ? dp[i - 1] : 0);
				max = Math.Max(max, dp[i]);
			}
			return max;
		}
	}
}
