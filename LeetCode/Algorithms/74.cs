namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _74
	{
		public static bool SearchMatrix(int[][] matrix, int target)
		{
			var n = matrix.Length;
			var m = matrix[0].Length;
			var l = 0;
			var r = m * n - 1;
			while (l != r)
			{
				var mid = (l + r - 1) >> 1;
				if (matrix[mid / m][mid % m] < target)
				{
					l = mid + 1;
				}
				else
				{
					r = mid;
				}
			}
			return matrix[r / m][r % m] == target;
		}
	}
}
