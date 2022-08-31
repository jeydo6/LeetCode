using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _417
	{
		private static readonly int[][] _directions = new int[][]
		{
			new int[] { 0, 1 },
			new int[] { 1, 0 },
			new int[] { -1, 0 },
			new int[] { 0, -1 }
		};

		public static IList<IList<int>> PacificAtlantic(int[][] heights)
		{
			if (heights.Length == 0 || heights[0].Length == 0)
			{
				return new List<IList<int>>();
			}

			var rows = heights.Length;
			var cols = heights[0].Length;

			var isPacificReachable = new bool[rows][];
			var isAtlanticReachable = new bool[rows][];
			for (var i = 0; i < rows; i++)
			{
				isPacificReachable[i] = new bool[cols];
				isAtlanticReachable[i] = new bool[cols];
			}

			for (var i = 0; i < rows; i++)
			{
				DFS(i, 0, isPacificReachable, heights);
				DFS(i, cols - 1, isAtlanticReachable, heights);
			}
			for (var j = 0; j < cols; j++)
			{
				DFS(0, j, isPacificReachable, heights);
				DFS(rows - 1, j, isAtlanticReachable, heights);
			}

			var result = new List<IList<int>>();
			for (var i = 0; i < rows; i++)
			{
				for (var j = 0; j < cols; j++)
				{
					if (isPacificReachable[i][j] && isAtlanticReachable[i][j])
					{
						result.Add(new List<int> { i, j });
					}
				}
			}
			return result;
		}

		private static void DFS(int row, int col, bool[][] isReachable, int[][] heights)
		{
			var rows = heights.Length;
			var cols = heights[0].Length;

			isReachable[row][col] = true;
			for (var i = 0; i < _directions.Length; i++)
			{
				var newRow = row + _directions[i][0];
				var newCol = col + _directions[i][1];

				if (
					newRow < 0 || newRow >= rows ||
					newCol < 0 || newCol >= cols
				)
				{
					continue;
				}

				if (isReachable[newRow][newCol])
				{
					continue;
				}

				if (heights[newRow][newCol] < heights[row][col])
				{
					continue;
				}

				DFS(newRow, newCol, isReachable, heights);
			}
		}
	}
}
