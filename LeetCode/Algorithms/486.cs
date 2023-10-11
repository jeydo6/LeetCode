using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _486
{
	public static bool PredictTheWinner(int[] nums)
	{
		var n = nums.Length;
		var dp = new int[n][];
		for (var i = 0; i < n; i++)
		{
			dp[i] = new int[n];
		}

		for (var i = 0; i < n; i++)
		{
			dp[i][i] = nums[i];
		}

		for (var diff = 1; diff < n; diff++)
		{
			for (var left = 0; left < n - diff; left++)
			{
				var right = left + diff;
				dp[left][right] = Math.Max(nums[left] - dp[left + 1][right],
					nums[right] - dp[left][right - 1]);
			}
		}

		return dp[0][n - 1] >= 0;
	}
}