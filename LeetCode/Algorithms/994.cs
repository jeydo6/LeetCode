using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	public class _994
	{
		public static int OrangesRotting(int[][] grid)
		{
			if (grid.Length == 0)
			{
				return 0;
			}

			var fresh = 0;
			var rotted = new Queue<int[]>();
			for (var i = 0; i < grid.Length; i++)
			{
				for (var j = 0; j < grid[0].Length; j++)
				{
					switch (grid[i][j])
					{
						case 1:
							fresh++;
							break;
						case 2:
							rotted.Enqueue(new[] { i, j });
							break;
					}
				}
			}

			if (fresh == 0)
			{
				return 0;
			}

			var result = 0;
			var directions = new[]
			{
				new[] { 1, 0 },
				new[] { -1, 0 },
				new[] { 0, 1 },
				new[] { 0, -1 },
			};
			while (rotted.Count > 0)
			{
				result++;
				var count = rotted.Count;
				for (var i = 0; i < count; i++)
				{
					var item = rotted.Dequeue();
					foreach (var direction in directions)
					{
						var x = item[0] + direction[0];
						var y = item[1] + direction[1];
						if (
							x < 0 || x >= grid.Length ||
							y < 0 || y >= grid[0].Length ||
							grid[x][y] == 0 || grid[x][y] == 2
						)
						{
							continue;
						}

						grid[x][y] = 2;
						rotted.Enqueue(new[] { x, y });
						fresh--;
					}
				}
			}

			if (fresh == 0)
			{
				return result - 1;
			}

			return -1;
		}
	}
}
