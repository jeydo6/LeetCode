namespace LeetCode.Algorithms
{
	class _1572
	{
		public static int DiagonalSum(int[][] matrix)
		{
			var result = 0;

			var length = matrix.Length;
			for (var i = 0; i < length / 2; i++)
			{
				result += matrix[i][i] + matrix[i][^(i + 1)] + matrix[^(i + 1)][i] + matrix[^(i + 1)][^(i + 1)];
			}

			if (length % 2 == 1)
			{
				result += matrix[length / 2][length / 2];
			}

			return result;
		}
	}
}
