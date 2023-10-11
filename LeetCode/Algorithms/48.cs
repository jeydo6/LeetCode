namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _48
	{
		public static void Rotate(int[][] matrix)
		{
			var n = matrix.Length;

			for (var i = 0; i < n; i++)
			{
				for (var j = i + 1; j < n; j++)
				{
					(matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
				}
			}

			for (var i = 0; i < n; i++)
			{
				for (var j = 0; j < n / 2; j++)
				{
					(matrix[i][j], matrix[i][n - j - 1]) = (matrix[i][n - j - 1], matrix[i][j]);
				}
			}
		}
	}
}
