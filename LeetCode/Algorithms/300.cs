using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _300
{
	public static int LengthOfLIS(int[] nums)
	{
		var dp = new int[nums.Length];
		Array.Fill(dp, 1);

		for (var i = 1; i < nums.Length; i++)
		{
			for (var j = 0; j < i; j++)
			{
				if (nums[i] > nums[j])
				{
					dp[i] = Math.Max(dp[i], dp[j] + 1);
				}
			}
		}

		var result = 0;
		for (var i = 0; i < dp.Length; i++)
		{
			result = Math.Max(result, dp[i]);
		}

		return result;
	}
}