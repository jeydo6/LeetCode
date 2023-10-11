namespace LeetCode.Algorithms;

// EASY
internal class _1572
{
	public static int DiagonalSum(int[][] mat)
	{
		var result = 0;

		var length = mat.Length;
		for (var i = 0; i < length / 2; i++)
		{
			result += mat[i][i] + mat[i][^(i + 1)] + mat[^(i + 1)][i] + mat[^(i + 1)][^(i + 1)];
		}

		if (length % 2 == 1)
		{
			result += mat[length / 2][length / 2];
		}

		return result;
	}
}
