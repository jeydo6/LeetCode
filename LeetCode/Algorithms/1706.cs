namespace LeetCode.Algorithms;

// MEDIUM
internal class _1706
{
	public static int[] FindBall(int[][] grid)
	{
		var result = new int[grid[0].Length];
		for (var i = 0; i < result.Length; i++)
		{
			result[i] = FindBallColumn(grid, 0, i);
		}
		return result;
	}

	private static int FindBallColumn(int[][] grid, int row, int column)
	{
		if (row == grid.Length)
		{
			return column;
		}

		var nextColumn = column + grid[row][column];
		if (nextColumn < 0 ||
			nextColumn > grid[0].Length - 1 ||
			grid[row][column] != grid[row][nextColumn])
		{
			return -1;
		}

		return FindBallColumn(grid, row + 1, nextColumn);
	}
}
