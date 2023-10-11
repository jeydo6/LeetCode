using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2352
{
	public static int EqualPairs(int[][] grid)
	{
		var result = 0;

		var n = grid.Length;
		var rows = new Dictionary<string, int>();
		for (var i = 0; i < n; i++)
		{
			var chars = new char[n];
			for (var j = 0; j < n; j++)
			{
				chars[j] = (char)(grid[i][j] + '0');
			}

			var row = new string(chars);
			rows.TryAdd(row, 0);
			rows[row]++;
		}
		
		for (var j = 0; j < n; j++)
		{
			var chars = new char[n];
			for (var i = 0; i < n; ++i)
			{
				chars[i] = (char)(grid[i][j] + '0');
			}
			var col = new string(chars);
			result += rows.TryGetValue(col, out var count) ? count : 0;
		}

		return result;
	}
}