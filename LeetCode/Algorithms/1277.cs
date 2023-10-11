using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1277
	{
		public static int CountSquares(int[][] matrix)
		{
			var result = 0;
			for (var i = 0; i < matrix.Length; i++)
			{
				for (var j = 0; j < matrix[0].Length; j++)
				{
					if (i > 0 && j > 0 && matrix[i][j] > 0)
					{
						matrix[i][j] = Math.Min(
							matrix[i - 1][j - 1],
							Math.Min(matrix[i - 1][j], matrix[i][j - 1])
						) + 1;
					}
					result += matrix[i][j];
				}
			}
			return result;
		}
	}
}
