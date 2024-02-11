using System;

namespace LeetCode.Algorithms;

// HARD
internal sealed class _1463
{
	public static int CherryPickup(int[][] grid)
	{
		var n = grid.Length;
		var m = grid[0].Length;

		var dp = new int[n][][];
		for (var row = 0; row < dp.Length; row++)
		{
			dp[row] = new int[m][];
			for (var col = 0; col < dp[row].Length; col++)
			{
				dp[row][col] = new int[m];
			}
		}

		for (var row = n - 1; row >= 0; row--)
		{
			for (var col1 = 0; col1 < m; col1++)
			{
				for (var col2 = 0; col2 < m; col2++)
				{
					var result = 0;
					result += grid[row][col1];

					if (col1 != col2)
					{
						result += grid[row][col2];
					}

					if (row != n - 1)
					{
						var max = 0;
						for (var newCol1 = col1 - 1; newCol1 <= col1 + 1; newCol1++)
						{
							for (var newCol2 = col2 - 1; newCol2 <= col2 + 1; newCol2++)
							{
								if (newCol1 >= 0 && newCol1 < m && newCol2 >= 0 && newCol2 < m)
								{
									max = Math.Max(max, dp[row + 1][newCol1][newCol2]);
								}
							}
						}

						result += max;
					}

					dp[row][col1][col2] = result;
				}
			}
		}

		return dp[0][0][m - 1];
	}
}