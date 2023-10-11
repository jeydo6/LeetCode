namespace LeetCode.Algorithms;

// EASY
internal class _1337
{
	public static int[] KWeakestRows(int[][] mat, int k)
	{
		var n = mat.Length;
		var m = mat[0].Length;

		var indexes = new int[k];
		var nextInsertIndex = 0;
		for (var c = 0; c < m && nextInsertIndex < k; c++)
		{
			for (var r = 0; r < n && nextInsertIndex < k; r++)
			{
				if (mat[r][c] == 0 && (c == 0 || mat[r][c - 1] == 1))
				{
					indexes[nextInsertIndex] = r;
					nextInsertIndex++;
				}
			}
		}

		for (var r = 0; nextInsertIndex < k; r++)
		{
			if (mat[r][m - 1] == 1)
			{
				indexes[nextInsertIndex] = r;
				nextInsertIndex++;
			}
		}
		return indexes;
	}
}
