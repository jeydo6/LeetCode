namespace LeetCode.Algorithms
{
	// HARD
	internal class _980
	{
		public static int UniquePathsIII(int[][] grid)
		{
			var zero = 0;
			var sx = 0;
			var sy = 0;

			for (int r = 0; r < grid.Length; r++)
			{
				for (int c = 0; c < grid[0].Length; c++)
				{
					if (grid[r][c] == 0) zero++;
					else if (grid[r][c] == 1)
					{
						sx = r;
						sy = c;
					}
				}
			}

			return DFS(grid, sx, sy, zero);
		}

		public static int DFS(int[][] grid, int x, int y, int zero)
		{
			if (x < 0 || y < 0 || x >= grid.Length || y >= grid[0].Length || grid[x][y] == -1)
			{
				return 0;
			}

			if (grid[x][y] == 2)
			{
				return zero == -1 ? 1 : 0;
			}

			grid[x][y] = -1;
			zero--;

			var totalPaths =
				DFS(grid, x + 1, y, zero) +
				DFS(grid, x - 1, y, zero) +
				DFS(grid, x, y + 1, zero) +
				DFS(grid, x, y - 1, zero);

			grid[x][y] = 0;

			return totalPaths;
		}
	}
}
