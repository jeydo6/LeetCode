using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1254
{
	private static readonly int[][] _directions = new int[][]
	{
		new int[] { 0, 1 },
		new int[] { 1, 0 },
		new int[] { -1, 0 },
		new int[] { 0, -1 }
	};

	public static int ClosedIsland(int[][] grid)
	{
		var visited = new bool[grid.Length][];
		for (var i = 0; i < visited.Length; i++)
		{
			visited[i] = new bool[grid[0].Length];
		}

		var result = 0;
		for (var i = 0; i < visited.Length; i++)
		{
			for (var j = 0; j < visited[i].Length; j++)
			{
				if (grid[i][j] == 0 && !visited[i][j] && ClosedIsland(grid, i, j, visited))
				{
					result++;
				}
			}
		}
		return result;
	}

	private static bool ClosedIsland(int[][] grid, int x, int y, bool[][] visited)
	{
		var result = true;

		var queue = new Queue<int[]>();
		queue.Enqueue(new int[] { x, y });
		visited[x][y] = true;

		while (queue.Count > 0)
		{
			var temp = queue.Dequeue();
			x = temp[0];
			y = temp[1];

			for (var i = 0; i < _directions.Length; i++)
			{
				var r = x + _directions[i][0];
				var c = y + _directions[i][1];
				if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length)
				{
					result = false;
				}
				else if (grid[r][c] == 0 && !visited[r][c])
				{
					queue.Enqueue(new int[] { r, c });
					visited[r][c] = true;
				}
			}
		}

		return result;
	}
}
