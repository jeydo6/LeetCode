namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _240
	{
		public static bool SearchMatrix(int[][] matrix, int target)
		{
			var row = matrix.Length - 1;
			var col = 0;

			while (row >= 0 && col < matrix[0].Length)
			{
				if (matrix[row][col] > target)
				{
					row--;
				}
				else if (matrix[row][col] < target)
				{
					col++;
				}
				else
				{
					return true;
				}
			}

			return false;
		}
	}
}
