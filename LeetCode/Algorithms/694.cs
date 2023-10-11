using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _694
	{
		public static int NumDistinctIslands(int[][] grid)
		{
			var visited = new bool[grid.Length][];
			for (var row = 0; row < grid.Length; row++)
			{
				visited[row] = new bool[grid[row].Length];
			}

			var islands = new HashSet<string>();
			for (var row = 0; row < grid.Length; row++)
			{
				for (var column = 0; column < grid[0].Length; column++)
				{
					var path = GetPath(grid, row, column, visited, '0');
					if (path.Length == 0)
					{
						continue;
					}
					islands.Add(path);
				}
			}
			return islands.Count;
		}

		private static string GetPath(int[][] grid, int row, int column, bool[][] visited, char direction)
		{
			if (row < 0 || column < 0 || row >= grid.Length || column >= grid[0].Length)
			{
				return "";
			}

			if (visited[row][column] || grid[row][column] == 0)
			{
				return "";
			}

			visited[row][column] = true;
			return "" + direction +
				GetPath(grid, row + 1, column, visited, 'D') +
				GetPath(grid, row - 1, column, visited, 'U') +
				GetPath(grid, row, column + 1, visited, 'R') +
				GetPath(grid, row, column - 1, visited, 'L') +
				'0';
		}
	}
}
