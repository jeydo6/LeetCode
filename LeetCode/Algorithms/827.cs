using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	class _827
	{
		public static int LargestIsland(int[][] grid)
		{
			var index = 2;
			var n = grid.Length;
			var areas = new int[n * n + 2];
			for (var i = 0; i < n; i++)
			{
				for (var j = 0; j < n; j++)
				{
					if (grid[i][j] == 1)
					{
						areas[index] = GetAreas(grid, i, j, index++);
					}
				}
			}

			int result = 0;
			foreach (var area in areas)
			{
				result = Math.Max(result, area);
			}

			for (var i = 0; i < n; i++)
			{
				for (var j = 0; j < n; j++)
				{
					if (grid[i][j] == 0)
					{
						var seen = new HashSet<int>();
						foreach (var move in GetNeighbors(i, j, n))
						{
							if (grid[move / n][move % n] > 1)
							{
								seen.Add(grid[move / n][move % n]);
							}
						}

						var temp = 1;
						foreach (var item in seen)
						{
							temp += areas[item];
						}

						result = Math.Max(result, temp);
					}
				}
			}

			return result;
		}

		public static int GetAreas(int[][] grid, int i, int j, int index)
		{
			var result = 1;

			grid[i][j] = index;

			var n = grid.Length;
			foreach (var move in GetNeighbors(i, j, n))
			{
				if (grid[move / n][move % n] == 1)
				{
					grid[move / n][move % n] = index;
					result += GetAreas(grid, move / n, move % n, index);
				}
			}

			return result;
		}

		public static int[] GetNeighbors(int i, int j, int n)
		{
			var dr = new int[] { -1, 0, 1, 0 };
			var dc = new int[] { 0, -1, 0, 1 };

			var result = new List<int>();
			for (var k = 0; k < 4; k++)
			{
				int r = i + dr[k];
				int c = j + dc[k];
				if (0 <= r && r < n &&
					0 <= c && c < n)
				{
					result.Add(r * n + c);
				}
			}
			return result.ToArray();
		}
	}
}
