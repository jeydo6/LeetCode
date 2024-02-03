using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1043
{
	public static int MaxSumAfterPartitioning(int[] arr, int k)
	{
		var dp = new int[k + 1];

		for (var start = arr.Length - 1; start >= 0; start--)
		{
			var max = 0;
			var end = Math.Min(arr.Length, start + k);

			for (var i = start; i < end; i++)
			{
				max = Math.Max(max, arr[i]);
				dp[start % dp.Length] = Math.Max(
					dp[start % dp.Length],
					dp[(i + 1) % dp.Length] + max * (i - start + 1)
				);
			}
		}

		return dp[0];
	}
}