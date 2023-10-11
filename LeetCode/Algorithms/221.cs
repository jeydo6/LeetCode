using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _221
	{
		public static int MaximalSquare(char[][] matrix)
		{
			if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
			{
				return 0;
			}

			var n = matrix.Length;
			var m = matrix[0].Length;
						
			var temp = new int[n + 1][];
			for (var i = 0; i < n + 1; i++)
			{
				temp[i] = new int[m + 1];
			}

			var result = 0;
			for (var i = 1; i <= n; i++)
			{
				for (var j = 1; j <= m; j++)
				{
					if (matrix[i - 1][j - 1] == '1')
					{
						temp[i][j] = Math.Min(
							Math.Min(temp[i][j - 1], temp[i - 1][j - 1]),
							temp[i - 1][j]
						) + 1;
						result = Math.Max(temp[i][j], result);
					}
				}
			}
			return result * result;
		}
	}
}
