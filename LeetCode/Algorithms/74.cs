namespace LeetCode.Algorithms;

// MEDIUM
internal class _74
{
	public static bool SearchMatrix(int[][] matrix, int target)
	{
		var n = matrix.Length;
		var m = matrix[0].Length;

		var lo = 0;
		var hi = m * n - 1;
		while (lo != hi)
		{
			var mid = lo + (hi - lo) / 2;
			if (matrix[mid / m][mid % m] < target)
			{
				lo = mid + 1;
			}
			else
			{
				hi = mid;
			}
		}
		return matrix[hi / m][hi % m] == target;
	}
}