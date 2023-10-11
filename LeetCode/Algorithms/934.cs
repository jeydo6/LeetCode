using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _934
{
	private static readonly int[][] _directions = new int[][]
	{
		new int[] { -1, 0 },
		new int[] { 1, 0 },
		new int[] { 0, -1 },
		new int[] { 0, 1 },
	};

	public static int ShortestBridge(int[][] grid)
	{
		var queue = new Queue<int[]>();
		var isBreak = false;
		for (var i = 0; i < grid.Length; i++)
		{
			for (var j = 0; j < grid[0].Length; j++)
			{
				if (grid[i][j] == 1)
				{
					ConnectIslands(grid, i, j, queue);
					isBreak = true;
					break;
				}
			}
			if (isBreak == true)
			{
				break;
			}
		}

		return FindNearestIsland(grid, queue);
	}

	private static void ConnectIslands(int[][] grid, int i, int j, Queue<int[]> queue)
	{
		if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == -1 || grid[i][j] == 0)
		{
			return;
		}

		grid[i][j] = -1;
		queue.Enqueue(new int[] { i, j });//adding the sub-land of the island into the Queue 

		ConnectIslands(grid, i - 1, j, queue);
		ConnectIslands(grid, i, j + 1, queue);
		ConnectIslands(grid, i + 1, j, queue);
		ConnectIslands(grid, i, j - 1, queue);

		return;
	}

	private static int FindNearestIsland(int[][] grid, Queue<int[]> queue)
	{
		var result = 0;
		while (queue.Count > 0)
		{
			var count = queue.Count;
			while (count-- > 0)
			{
				var temp = queue.Dequeue();
				for (var k = 0; k < _directions.Length; k++)
				{
					var i = temp[0] + _directions[k][0];
					var j = temp[1] + _directions[k][1];
					if (i >= grid.Length || i < 0 || j >= grid[0].Length || j < 0 || grid[i][j] == -1)
					{
						continue;
					}

					if (grid[i][j] == 1)
					{
						return result;
					}
					else
					{
						grid[i][j] = -1;
						queue.Enqueue(new int[] { i, j });
					}
				}
			}
			result++;
		}
		return -1;
	}
}
