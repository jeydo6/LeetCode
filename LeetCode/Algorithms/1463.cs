using System;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _1463
	{
		public static int CherryPickup(int[][] grid)
		{
			var n = grid.Length;
			var m = grid[0].Length;
			var dp = new int[n][][];
			for (var i = 0; i < n; i++)
			{
				dp[i] = new int[m][];
				for (var j = 0; j < m; j++)
				{
					dp[i][j] = new int[m];
				}
			}

			return CherryPickup(grid, n, m, 0, 0, m - 1, dp);
		}

		private static int CherryPickup(int[][] grid, int n, int m, int r, int c1, int c2, int[][][] dp)
		{
			if (r == n)
			{
				return 0; // Reach to bottom row
			}
			if (dp[r][c1][c2] != 0)
			{
				return dp[r][c1][c2];
			}
			var result = 0;
			for (var i = -1; i <= 1; i++)
			{
				for (var j = -1; j <= 1; j++)
				{
					var nc1 = c1 + i;
					var nc2 = c2 + j;
					if (nc1 >= 0 && nc1 < m && nc2 >= 0 && nc2 < m)
					{
						result = Math.Max(
							result,
							CherryPickup(grid, n, m, r + 1, nc1, nc2, dp)
						);
					}
				}
			}
			var cherries = c1 == c2 ? grid[r][c1] : grid[r][c1] + grid[r][c2];
			dp[r][c1][c2] = result + cherries;
			return dp[r][c1][c2];
		}
	}
}
