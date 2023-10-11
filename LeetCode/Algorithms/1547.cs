using System;

namespace LeetCode.Algorithms;

// HARD
internal class _1547
{
	public static int MinCost(int n, int[] cuts)
	{
		var m = cuts.Length;
		var newCuts = new int[m + 2];
		for (var i = 0; i < m; i++)
		{
			newCuts[i + 1] = cuts[i];
		}
		newCuts[m + 1] = n;
		Array.Sort(newCuts);

		var dp = new int[m + 2][];
		for (var i = 0; i < dp.Length; i++)
		{
			dp[i] = new int[m + 2];
		}

		for (var diff = 2; diff < m + 2; diff++)
		{
			for (var left = 0; left < m + 2 - diff; left++)
			{
				var right = left + diff;
				var result = int.MaxValue;
				for (var mid = left + 1; mid < right; mid++)
				{
					result = Math.Min(result, dp[left][mid] + dp[mid][right] + newCuts[right] - newCuts[left]);
				}
				dp[left][right] = result;
			}
		}

		return dp[0][m + 1];
	}
}
