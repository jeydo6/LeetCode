namespace LeetCode.Algorithms;

// EASY
internal sealed class _867
{
	public static int[][] Transpose(int[][] matrix)
	{
		var n = matrix.Length;
		var m = matrix[0].Length;

		var transponsed = new int[m][];
		for (var j = 0; j < m; j++)
		{
			transponsed[j] = new int[n];
		}
		for (var i = 0; i < n; i++)
		{
			for (var j = 0; j < m; j++)
			{
				transponsed[j][i] = matrix[i][j];
			}
		}
		return transponsed;
	}
}
