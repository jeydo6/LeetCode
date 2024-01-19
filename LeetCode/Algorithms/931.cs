using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _931
{
	public static int MinFallingPathSum(int[][] matrix)
	{
		var memo = new int?[matrix.Length][];
		for (var i = 0; i < matrix.Length; i++)
		{
			memo[i] = new int?[matrix[i].Length];
		}

		var result = int.MaxValue;
		for (var i = 0; i < matrix.Length; i++)
		{
			result = Math.Min(result, MinFallingPathSum(matrix, 0, i, memo));
		}
		return result;
	}

	private static int MinFallingPathSum(int[][] matrix, int row, int col, int?[][] memo)
	{
		if (col < 0 || col == matrix.Length)
		{
			return int.MaxValue;
		}

		if (row == matrix.Length - 1)
		{
			return matrix[row][col];
		}

		if (memo[row][col] != null)
		{
			return memo[row][col].Value;
		}

		var left = MinFallingPathSum(matrix, row + 1, col, memo);
		var middle = MinFallingPathSum(matrix, row + 1, col + 1, memo);
		var right = MinFallingPathSum(matrix, row + 1, col - 1, memo);

		memo[row][col] = Math.Min(left, Math.Min(middle, right)) + matrix[row][col];
		return memo[row][col].Value;
	}
}
