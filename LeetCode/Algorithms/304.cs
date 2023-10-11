using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _304
	{
		public class NumMatrix
		{
			private readonly int[][] _dp;

			public NumMatrix(int[][] matrix)
			{
				if (matrix.Length == 0 || matrix[0].Length == 0)
				{
					_dp = Array.Empty<int[]>();
					return;
				}

				var n = matrix.Length;
				var m = matrix[0].Length;
				_dp = new int[n][];
				for (var i = 0; i < n; i++)
				{
					_dp[i] = new int[m];
				}

				for (var i = 0; i < n; i++)
				{
					for (var j = 0; j < m; j++)
					{
						_dp[i + 1][j + 1] = _dp[i + 1][j] + _dp[i][j + 1] + matrix[i][j] - _dp[i][j];
					}
				}
			}

			public int SumRegion(int row1, int col1, int row2, int col2)
			{
				return _dp[row2 + 1][col2 + 1] - _dp[row1][col2 + 1] - _dp[row2 + 1][col1] + _dp[row1][col1];
			}
		}
	}
}
