using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _712
{
	public static int MinimumDeleteSum(string s1, string s2)
	{
		if (s1.Length < s2.Length)
		{
			(s1, s2) = (s2, s1);
		}

		var n = s1.Length;
		var m = s2.Length;
		var currentRow = new int[m + 1];
		for (var j = 1; j <= m; j++)
		{
			currentRow[j] = currentRow[j - 1] + s2[j - 1];
		}

		for (var i = 1; i <= n; i++)
		{
			var diagonal = currentRow[0];
			currentRow[0] += s1[i - 1];

			for (var j = 1; j <= m; j++)
			{
				int result;

				if (s1[i - 1] == s2[j - 1])
				{
					result = diagonal;
				}
				else
				{
					result = Math.Min(
						s1[i - 1] + currentRow[j],
						s2[j - 1] + currentRow[j - 1]
					);
				}

				diagonal = currentRow[j];
				currentRow[j] = result;
			}
		}

		return currentRow[m];
	}
}