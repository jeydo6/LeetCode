using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _64
{
	public static int MinPathSum(int[][] grid)
	{
		var n = grid.Length;
		var m = grid[0].Length;

		var dp = new int[n];
		for (var i = 0; i < n; i++)
		{
			dp[i] = grid[0][0];
		}

		for (var i = 1; i < n; i++)
		{
			dp[i] = dp[i - 1] + grid[i][0];
		}
		for (var j = 1; j < m; j++)
		{
			dp[0] += grid[0][j];
			for (var i = 1; i < n; i++)
			{
				dp[i] = Math.Min(dp[i - 1], dp[i]) + grid[i][j];
			}
		}
		return dp[n - 1];
	}
}
