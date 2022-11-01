namespace LeetCode.Algorithms;

// MEDIUM
internal class _1198
{
	public static int SmallestCommonElement(int[][] mat)
	{
		var count = new int[10001];
		var n = mat.Length;
		var m = mat[0].Length;
		for (var j = 0; j < m; ++j)
		{
			for (var i = 0; i < n; ++i)
			{
				if (++count[mat[i][j]] == n)
				{
					return mat[i][j];
				}
			}
		}

		return -1;
	}
}
