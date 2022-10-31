namespace Leetcode.Algorithms;

// EASY
internal class _766
{
	public static bool IsToeplitzMatrix(int[][] matrix)
	{
		var n = matrix.Length;
		var m = matrix[0].Length;

		if (n == 1 || m == 1)
		{
			return true;
		}

		for (var i = 1; i < n; i++)
		{
			for (var j = 1; j < m; j++)
			{
				if (matrix[i - 1][j - 1] != matrix[i][j])
				{
					return false;
				}
			}
		}

		return true;
	}
}
