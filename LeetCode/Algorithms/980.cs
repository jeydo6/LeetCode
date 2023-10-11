namespace LeetCode.Algorithms;

// HARD
internal class _980
{
	public static int UniquePathsIII(int[][] grid)
	{
		var zero = 0;
		var sx = 0;
		var sy = 0;

		for (var r = 0; r < grid.Length; r++)
		{
			for (var c = 0; c < grid[0].Length; c++)
			{
				if (grid[r][c] == 0) zero++;
				else if (grid[r][c] == 1)
				{
					sx = r;
					sy = c;
				}
			}
		}

		return UniquePathsIII(grid, sx, sy, zero);
	}

	private static int UniquePathsIII(int[][] grid, int x, int y, int zero)
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
			UniquePathsIII(grid, x + 1, y, zero) +
			UniquePathsIII(grid, x - 1, y, zero) +
			UniquePathsIII(grid, x, y + 1, zero) +
			UniquePathsIII(grid, x, y - 1, zero);

		grid[x][y] = 0;

		return totalPaths;
	}
}
