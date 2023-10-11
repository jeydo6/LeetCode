using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _1260
	{
		public static IList<IList<int>> ShiftGrid(int[][] grid, int k)
		{
			var n = grid.Length;
			var m = grid[0].Length;

			var result = new List<IList<int>>();
			for (var i = 0; i < n; i++)
			{
				var row = new List<int>();
				result.Add(row);
				for (var j = 0; j < m; j++)
				{
					row.Add(0);
				}
			}

			for (var i = 0; i < n; i++)
			{
				for (var j = 0; j < m; j++)
				{
					var column = (j + k) % m;
					var wrapAroundCount = (j + k) / m;
					var row = (i + wrapAroundCount) % n;
					result[row][column] = grid[i][j];
				}
			}
			return result;
		}
	}
}
