using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1631
	{
		public static int MinimumEffortPath(int[][] heights)
		{
			var row = heights.Length;
			var col = heights[0].Length;

			var lo = 0;
			var hi = 1000000;
			var result = hi;
			while (lo <= hi)
			{
				var mid = (lo + hi) / 2;
				var visited = new bool[row][];
				for (var i = 0; i < row; i++)
				{
					visited[i] = new bool[col];
				}

				if (CanReachDestinaton(0, 0, heights, visited, row, col, mid))
				{
					result = Math.Min(result, mid);
					hi = mid - 1;
				}
				else
				{
					lo = mid + 1;
				}
			}
			return result;
		}

		private static readonly int[][] _directions = new int[4][]
		{
			new int[2] { 1, 0 },
			new int[2] { -1, 0 },
			new int[2] { 0, 1 },
			new int[2] { 0, -1 }
		};

		private static bool CanReachDestinaton(int x, int y, int[][] heights, bool[][] visited, int row, int col, int mid)
		{
			if (x == row - 1 && y == col - 1)
			{
				return true;
			}

			visited[x][y] = true;
			for (var i = 0; i < _directions.Length; i++)
			{
				var adjacentX = x + _directions[i][0];
				var adjacentY = y + _directions[i][1];

				var isValidCell = adjacentX >= 0 && adjacentX <= row - 1 && adjacentY >= 0 && adjacentY <= col - 1;
				if (isValidCell && !visited[adjacentX][adjacentY])
				{
					var currentDifference = Math.Abs(heights[adjacentX][adjacentY] - heights[x][y]);
					if (currentDifference <= mid)
					{
						if (CanReachDestinaton(adjacentX, adjacentY, heights, visited, row, col, mid))
						{
							return true;
						}
					}
				}
			}
			return false;
		}
	}
}
