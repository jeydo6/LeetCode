using System.Collections.Generic;

namespace LeetCode.Algorithms;

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

		var rowBegin = 0;
		var rowEnd = matrix.Length - 1;
		var columnBegin = 0;
		var columnEnd = matrix[0].Length - 1;

		while (rowBegin <= rowEnd && columnBegin <= columnEnd)
		{
			for (var j = columnBegin; j <= columnEnd; j++)
			{
				result.Add(matrix[rowBegin][j]);
			}
			rowBegin++;

			for (var j = rowBegin; j <= rowEnd; j++)
			{
				result.Add(matrix[j][columnEnd]);
			}
			columnEnd--;

			if (rowBegin <= rowEnd)
			{
				for (var j = columnEnd; j >= columnBegin; j--)
				{
					result.Add(matrix[rowEnd][j]);
				}
			}
			rowEnd--;

			if (columnBegin <= columnEnd)
			{
				for (var j = rowEnd; j >= rowBegin; j--)
				{
					result.Add(matrix[j][columnBegin]);
				}
			}
			columnBegin++;
		}

		return result;
	}
}
