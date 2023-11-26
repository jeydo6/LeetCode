using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1727
{
	public static int LargestSubmatrix(int[][] matrix)
	{
		var n = matrix.Length;
		var m = matrix[0].Length;

		var result = 0;
		for (var r = 0; r < n; r++)
		{
			for (var c = 0; c < m; c++)
			{
				if (matrix[r][c] != 0 && r > 0)
				{
					matrix[r][c] += matrix[r - 1][c];
				}
			}

			var row = new int[m];
			Array.Copy(matrix[r], row, m);
			Array.Sort(row);
			for (var i = 0; i < m; i++)
			{
				result = Math.Max(result, row[i] * (m - i));
			}
		}

		return result;
	}
}