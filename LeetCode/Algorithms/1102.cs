using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1102
	{
		private static readonly int[][] _dirs = new int[][]
		{
			new int[] { 1, 0 },
			new int[] { -1, 0 },
			new int[] { 0, 1 },
			new int[] { 0, -1 }
		};

		public static int MaximumMinimumPath(int[][] grid)
		{
			var n = grid.Length;
			var m = grid[0].Length;
			var pqueue = new PriorityQueue<int[], int>();

			var visited = new bool[n][];
			for (var i = 0; i < n; i++)
			{
				visited[i] = new bool[m];
			}

			pqueue.Enqueue(new int[] { 0, 0 }, grid[0][0]);
			visited[0][0] = true;

			var result = grid[0][0];
			while (pqueue.Count > 0)
			{
				var current = pqueue.Dequeue();
				var currentRow = current[0];
				var currentColumn = current[1];

				result = Math.Min(result, grid[currentRow][currentColumn]);

				if (currentRow == n - 1 && currentColumn == m - 1)
				{
					break;
				}

				for (var i = 0; i < _dirs.Length; i++)
				{
					var newRow = currentRow + _dirs[i][0];
					var newColumn = currentColumn + _dirs[i][1];

					if (
						newRow >= 0 && newRow < n &&
						newColumn >= 0 && newColumn < m &&
						!visited[newRow][newColumn]
					)
					{
						pqueue.Enqueue(new int[] { newRow, newColumn }, grid[newRow][newColumn]);
						visited[newRow][newColumn] = true;
					}
				}
			}
			return result;
		}
	}
}
