namespace LeetCode.Algorithms
{
	// EASY
	internal class _566
	{
		public static int[][] MatrixReshape(int[][] matrix, int r, int c)
		{
			var n = matrix.Length;
			var m = matrix[0].Length;

			if (r * c != n * m)
			{
				return matrix;
			}

			var result = new int[r][];
			for (var i = 0; i < r; i++)
			{
				result[i] = new int[c];
			}

			for (var i = 0; i < r * c; i++)
			{
				result[i / c][i % c] = matrix[i / m][i % m];
			}

			return result;
		}
	}
}
