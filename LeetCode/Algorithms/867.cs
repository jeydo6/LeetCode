namespace Leetcode.Algorithms
{
	// EASY
	internal class _867
	{
		public static int[][] Transpose(int[][] matrix)
		{
			var n = matrix.Length;
			var m = matrix[0].Length;

			var transponse = new int[m][];
			for (var j = 0; j < m; j++)
			{
				transponse[j] = new int[n];
			}
			for (var i = 0; i < n; i++)
			{
				for (var j = 0; j < m; j++)
				{
					transponse[j][i] = matrix[i][j];
				}
			}
			return transponse;
		}
	}
}
