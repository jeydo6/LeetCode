using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _54
	{
		public static IList<int> SpiralOrder(int[][] matrix)
		{
			var result = new List<int>();

			if (matrix.Length == 0)
			{
				return result;
			}

			int rowBegin = 0;
			int rowEnd = matrix.Length - 1;
			int columnBegin = 0;
			int columnEnd = matrix[0].Length - 1;

			while (rowBegin <= rowEnd && columnBegin <= columnEnd)
			{
				for (int j = columnBegin; j <= columnEnd; j++)
				{
					result.Add(matrix[rowBegin][j]);
				}
				rowBegin++;

				// Traverse Down
				for (int j = rowBegin; j <= rowEnd; j++)
				{
					result.Add(matrix[j][columnEnd]);
				}
				columnEnd--;

				if (rowBegin <= rowEnd)
				{
					// Traverse Left
					for (int j = columnEnd; j >= columnBegin; j--)
					{
						result.Add(matrix[rowEnd][j]);
					}
				}
				rowEnd--;

				if (columnBegin <= columnEnd)
				{
					// Traver Up
					for (int j = rowEnd; j >= rowBegin; j--)
					{
						result.Add(matrix[j][columnBegin]);
					}
				}
				columnBegin++;
			}

			return result;
		}
	}
}
