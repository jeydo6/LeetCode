namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _311
	{
		public static int[][] Multiply(int[][] matrix1, int[][] matrix2)
		{
			var n = matrix1.Length;
			var k = matrix1[0].Length;
			var m = matrix2[0].Length;

			var matrix3 = new int[n][];
			for (var rowIndex = 0; rowIndex < n; rowIndex++)
			{
				matrix3[rowIndex] = new int[m];
				for (var elementIndex = 0; elementIndex < k; elementIndex++)
				{
					if (matrix1[rowIndex][elementIndex] != 0)
					{
						for (var columnIndex = 0; columnIndex < m; columnIndex++)
						{
							matrix3[rowIndex][columnIndex] += matrix1[rowIndex][elementIndex] * matrix2[elementIndex][columnIndex];
						}
					}
				}
			}
			return matrix3;
		}
	}
}
