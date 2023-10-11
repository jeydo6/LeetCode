using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1020
{
	private static readonly int[][] _directions = new int[][]
	{
		new int[] { 0, 1 },
		new int[] { 1, 0 },
		new int[] { -1, 0 },
		new int[] { 0, -1 }
	};

	public static int NumEnclaves(int[][] grid)
	{
		var n = grid.Length;
		var m = grid[0].Length;
		var visited = new bool[n][];
		for (var i = 0; i < n; i++)
		{
			visited[i] = new bool[m];
		}

		for (var i = 0; i < n; i++)
		{
			if (grid[i][0] == 1 && !visited[i][0])
			{
				NumEnclaves(grid, i, 0, visited);
			}
			if (grid[i][m - 1] == 1 && !visited[i][m - 1])
			{
				NumEnclaves(grid, i, m - 1, visited);
			}
		}

		for (var j = 0; j < m; j++)
		{
			if (grid[0][j] == 1 && !visited[0][j])
			{
				NumEnclaves(grid, 0, j, visited);
			}
			if (grid[n - 1][j] == 1 && !visited[n - 1][j])
			{
				NumEnclaves(grid, n - 1, j, visited);
			}
		}

		var result = 0;
		for (var i = 0; i < n; i++)
		{
			for (var j = 0; j < m; j++)
			{
				if (grid[i][j] == 1 && !visited[i][j])
				{
					result++;
				}
			}
		}
		return result;
	}

	private static void NumEnclaves(int[][] grid, int x, int y, bool[][] visited)
	{
		var queue = new Queue<int[]>();
		queue.Enqueue(new int[] { x, y });
		visited[x][y] = true;

		while (queue.Count > 0)
		{
			var coordinates = queue.Dequeue();
			for (var i = 0; i < _directions.Length; i++)
			{
				var r = coordinates[0] + _directions[i][0];
				var c = coordinates[1] + _directions[i][1];
				if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length)
				{
					continue;
				}
				else if (grid[r][c] == 1 && !visited[r][c])
				{
					queue.Enqueue(new int[] { r, c });
					visited[r][c] = true;
				}
			}
		}
	}
}
