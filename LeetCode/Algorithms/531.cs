namespace LeetCode.Algorithms;

// MEDIUM
internal class _531
{
	public static int FindLonelyPixel(char[][] picture)
	{
		var n = picture.Length;
		var m = picture[0].Length;

		var rowCount = new int[n];
		var columnCount = new int[m];
		for (var i = 0; i < n; i++)
		{
			for (var j = 0; j < m; j++)
			{
				if (picture[i][j] == 'B')
				{
					rowCount[i]++;
					columnCount[j]++;
				}
			}
		}

		var result = 0;
		for (var i = 0; i < n; i++)
		{
			for (var j = 0; j < m; j++)
			{
				if (picture[i][j] == 'B' && rowCount[i] == 1 && columnCount[j] == 1)
				{
					result++;
				}
			}
		}

		return result;
	}
}
