using System;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _72
	{
		public static int MinDistance(string word1, string word2)
		{
			var n = word1.Length;
			var m = word2.Length;

			if (n * m == 0)
			{
				return n + m;
			}

			var d = new int[n + 1][];
			for (var i = 0; i < n + 1; i++)
			{
				d[i] = new int[m + 1];
				d[i][0] = i;
			}
			for (var j = 0; j < m + 1; j++)
			{
				d[0][j] = j;
			}

			for (var i = 1; i < n + 1; i++)
			{
				for (var j = 1; j < m + 1; j++)
				{
					var left = d[i - 1][j] + 1;
					var down = d[i][j - 1] + 1;
					var leftDown = d[i - 1][j - 1];
					if (word1[i - 1] != word2[i - 1])
					{
						leftDown++;
					}
					d[i][j] = Math.Min(left, Math.Min(down, leftDown));
				}
			}

			return d[n][m];
		}
	}
}
