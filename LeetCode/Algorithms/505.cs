using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _505
	{
		private static readonly int[][] _directions = new int[][]
		{
			new int[] { 0, 1 },
			new int[] { 0, -1 },
			new int[] { -1, 0 },
			new int[] { 1, 0 }
		};

		public static int ShortestDistance(int[][] maze, int[] start, int[] destination)
		{
			var distance = new int[maze.Length][];
			for (var i = 0; i < maze.Length; i++)
			{
				distance[i] = new int[maze[0].Length];
				for (var j = 0; j < maze[0].Length; j++)
				{
					distance[i][j] = int.MaxValue;
				}
			}

			distance[start[0]][start[1]] = 0;

			var queue = new Queue<int[]>();
			queue.Enqueue(start);
			while (queue.Count > 0)
			{
				var s = queue.Dequeue();
				for (var i = 0; i < _directions.Length; i++)
				{
					var x = s[0] + _directions[i][0];
					var y = s[1] + _directions[i][1];

					var count = 0;
					while (
						x >= 0 && x < maze.Length &&
						y >= 0 && y < maze[0].Length &&
						maze[x][y] == 0
					)
					{
						x += _directions[i][0];
						y += _directions[i][1];
						count++;
					}

					if (distance[s[0]][s[1]] + count < distance[x - _directions[i][0]][y - _directions[i][1]])
					{
						distance[x - _directions[i][0]][y - _directions[i][1]] = distance[s[0]][s[1]] + count;
						queue.Enqueue(new int[] { x - _directions[i][0], y - _directions[i][1] });
					}
				}
			}

			return distance[destination[0]][destination[1]] == int.MaxValue ? -1 : distance[destination[0]][destination[1]];
		}
	}
}
