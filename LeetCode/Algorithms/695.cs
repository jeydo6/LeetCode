using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	class _695
	{
		public static int MaxAreaOfIsland(int[][] grid)
		{
			var result = 0;
			for (var i = 0; i < grid.Length; i++)
			{
				for (var j = 0; j < grid[0].Length; j++)
				{
					if (grid[i][j] == 1)
					{
						result = Math.Max(result, AreaOfIsland(grid, i, j));
					}
				}
			}
			return result;
		}

		private static int AreaOfIsland(int[][] grid, int i, int j)
		{
			if (
				i >= 0 && i < grid.Length &&
				j >= 0 && j < grid[0].Length &&
				grid[i][j] == 1
			)
			{
				grid[i][j] = 0;
				return 1 + AreaOfIsland(grid, i + 1, j) + AreaOfIsland(grid, i - 1, j) + AreaOfIsland(grid, i, j - 1) + AreaOfIsland(grid, i, j + 1);
			}
			return 0;
		}
	}
}
