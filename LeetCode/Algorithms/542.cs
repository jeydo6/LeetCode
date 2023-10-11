using System;

namespace LeetCode.Algorithms
{
	class _3831
	{
		public static int[][] UpdateMatrix(int[][] matrix)
		{
			var n = matrix.Length;
			var m = matrix[0].Length;

			var result = new int[n][];
			for (var i = 0; i < n; i++)
			{
				result[i] = new int[m];
				for (var j = 0; j < m; j++)
				{
					result[i][j] = int.MaxValue - n * m;
				}
			}

			for (var i = 0; i < n; i++)
			{
				for (var j = 0; j < m; j++)
				{
					if (matrix[i][j] == 0)
					{
						result[i][j] = 0;
					}
					else
					{
						if (i > 0)
						{
							result[i][j] = Math.Min(result[i][j], result[i - 1][j] + 1);
						}
						if (j > 0)
						{
							result[i][j] = Math.Min(result[i][j], result[i][j - 1] + 1);
						}

					}
				}
			}

			for (int i = n - 1; i >= 0; i--)
			{
				for (int j = m - 1; j >= 0; j--)
				{
					if (i < n - 1)
					{
						result[i][j] = Math.Min(result[i][j], result[i + 1][j] + 1);
					}
					if (j < m - 1)
					{
						result[i][j] = Math.Min(result[i][j], result[i][j + 1] + 1);
					}
				}
			}

			return result;
		}
	}
}
