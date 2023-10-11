using System;

namespace LeetCode.Algorithms;

// HARD
internal class _2328
{
	private static readonly int[][] _directions =
	{
		new[] { 0, 1 },
		new[] { 0, -1 },
		new[] { 1, 0 },
		new[] { -1, 0 }
	};

	private const int Modulo = 1_000_000_007;

	public static int CountPaths(int[][] grid)
	{
		var n = grid.Length;
		var m = grid[0].Length;
		
		var dp = new int[n][];
		var cells = new int[n * m][];
		for (var i = 0; i < n; i++)
		{
			dp[i] = new int[m];
			for (var j = 0; j < m; j++)
			{
				dp[i][j] = 1;
				cells[i * m + j] = new[] { i, j };
			}
		}
		Array.Sort(cells, (a, b) => grid[a[0]][a[1]] - grid[b[0]][b[1]]);

		for (var c = 0; c < cells.Length; c++)
		{
			var i = cells[c][0];
			var j = cells[c][1];
			for (var d = 0; d < _directions.Length; d++)
			{
				var ci = i + _directions[d][0];
				var cj = j + _directions[d][1];
				if (ci >= 0 && ci < n &&
				    cj >= 0 && cj < m &&
				    grid[ci][cj] > grid[i][j])
				{
					dp[ci][cj] += dp[i][j];
					dp[ci][cj] %= Modulo;
				}
			}
		}

		var result = 0;
		for (var i = 0; i < n; i++)
		{
			for (var j = 0; j < m; j++)
			{
				result += dp[i][j];
				result %= Modulo;
			}
		}
		return result;
	}
}