using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _1293
	{
		public static int ShortestPath(int[][] grid, int k)
		{
			var directions = new int[4][]
			{
				new int[2] { 0, 1 },
				new int[2] { 0, -1 },
				new int[2] { 1, 0 },
				new int[2] { -1, 0 }
			};

			var n = grid.Length;
			var m = grid[0].Length;
			var visited = new bool[n][][];
			for (var i = 0; i < n; i++)
			{
				visited[i] = new bool[m][];
				for (var j = 0; j < m; j++)
				{
					visited[i][j] = new bool[k + 1];
				}
			}
			visited[0][0][0] = true;

			var queue = new Queue<int[]>();
			queue.Enqueue(new int[] { 0, 0, 0 });

			var result = 0;
			while (queue.Count > 0)
			{
				var size = queue.Count;
				for (var i = 0; i < size; i++)
				{
					var info = queue.Dequeue();
					if (info[0] == n - 1 && info[1] == m - 1)
					{
						return result;
					}

					foreach (var direction in directions)
					{
						var nextR = direction[0] + info[0];
						var nextC = direction[1] + info[1];
						var nextK = info[2];

						if (nextR >= 0 && nextR < n && nextC >= 0 && nextC < m)
						{
							if (grid[nextR][nextC] == 1)
							{
								nextK++;
							}
							if (nextK <= k && !visited[nextR][nextC][nextK])
							{
								visited[nextR][nextC][nextK] = true;
								queue.Enqueue(new int[] { nextR, nextC, nextK });
							}
						}
					}
				}
				result++;
			}

			return -1;
		}
	}
}
