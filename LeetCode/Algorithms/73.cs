using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _73
	{
		public static void SetZeroes(int[][] matrix)
		{
			var rows = new HashSet<int>();
			var columns = new HashSet<int>();

			for (var i = 0; i < matrix.Length; i++)
			{
				for (var j = 0; j < matrix[0].Length; j++)
				{
					if (matrix[i][j] == 0)
					{
						rows.Add(i);
						columns.Add(j);
					}
				}
			}

			for (var i = 0; i < matrix.Length; i++)
			{
				for (var j = 0; j < matrix[0].Length; j++)
				{
					if (rows.Contains(i) || columns.Contains(j))
					{
						matrix[i][j] = 0;
					}
				}
			}
		}
	}
}
