using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1329
	{
		public static int[][] DiagonalSort(int[][] mat)
		{
			var rows = mat.Length;
			var cols = mat[0].Length;

			var diagonals = new Dictionary<int, PriorityQueue<int, int>>();

			for (var row = 0; row < rows; row++)
			{
				for (var col = 0; col < cols; col++)
				{
					if (!diagonals.ContainsKey(row - col))
					{
						diagonals[row - col] = new PriorityQueue<int, int>();
					}
					diagonals[row - col].Enqueue(mat[row][col], mat[row][col]);
				}
			}

			for (var row = 0; row < rows; row++)
			{
				for (var col = 0; col < cols; col++)
				{
					mat[row][col] = diagonals[row - col].Dequeue();
				}
			}

			return mat;
		}
	}
}
