using System;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _329
	{
		private static readonly int[][] _directions = new int[4][]
		{
			new int[2] { 0, 1 },
			new int[2] { 1, 0 },
			new int[2] { 0, -1 },
			new int[2] { -1, 0 }
		};

		public static int LongestIncreasingPath(int[][] matrix)
		{
			if (matrix.Length == 0)
			{
				return 0;
			}
			var n = matrix.Length;
			var m = matrix[0].Length;

			var cache = new int[n][];
			for (var i = 0; i < n; i++)
			{
				cache[i] = new int[m];
			}

			var result = 0;
			for (var i = 0; i < n; i++)
			{
				for (var j = 0; j < m; j++)
				{
					result = Math.Max(result, DFS(matrix, i, j, cache));
				}
			}
			return result;
		}

		private static int DFS(int[][] matrix, int i, int j, int[][] cache)
		{
			if (cache[i][j] != 0)
			{
				return cache[i][j];
			}

			for (var k = 0; k < _directions.Length; k++)
			{
				var n = matrix.Length;
				var m = matrix[0].Length;

				var x = i + _directions[k][0];
				var y = j + _directions[k][1];
				if (
					0 <= x && x < n &&
					0 <= y && y < m &&
					matrix[x][y] > matrix[i][j]
				)
				{
					cache[i][j] = Math.Max(
						cache[i][j],
						DFS(matrix, x, y, cache)
					);
				}
			}
			return ++cache[i][j];
		}
	}
}
