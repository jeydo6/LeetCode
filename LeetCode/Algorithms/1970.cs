using System.Collections.Generic;

namespace LeetCode.Algorithms;

internal class _1970
{
	private static readonly int[][] _directions =
	{
		new[] { 0, 1 },
		new[] { 1, 0 },
		new[] { -1, 0 },
		new[] { 0, -1 }
	};

	public static int LatestDayToCross(int row, int col, int[][] cells)
	{
		var lo = 1;
		var hi = row * col;
		while (lo < hi)
		{
			var mid = hi - (hi - lo) / 2;
			if (LatestDayToCross(row, col, cells, mid))
			{
				lo = mid;
			}
			else
			{
				hi = mid - 1;
			}
		}

		return lo;
	}

	private static bool LatestDayToCross(int row, int col, int[][] cells, int day)
	{
		var grid = new int[row][];
		for (var i = 0; i < row; i++)
		{
			grid[i] = new int[col];
		}

		var queue = new Queue<int[]>();
		for (var i = 0; i < day; i++)
		{
			grid[cells[i][0] - 1][cells[i][1] - 1] = 1;
		}

		for (var i = 0; i < col; i++)
		{
			if (grid[0][i] == 0)
			{
				queue.Enqueue(new int[] { 0, i });
				grid[0][i] = -1;
			}
		}

		while (queue.Count > 0)
		{
			var current = queue.Dequeue();
			var currentRow = current[0];
			var currentCol = current[1];
			if (currentRow == row - 1)
			{
				return true;
			}

			foreach (var dir in _directions)
			{
				var newRow = currentRow + dir[0];
				var newCol = currentCol + dir[1];

				if (newRow >= 0 && newRow < row &&
				    newCol >= 0 && newCol < col &&
				    grid[newRow][newCol] == 0)
				{
					grid[newRow][newCol] = -1;
					queue.Enqueue(new int[] { newRow, newCol });
				}
			}
		}

		return false;
	}
}