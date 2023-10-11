using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _799
	{
		public static double ChampagneTower(int poured, int query_row, int query_glass)
		{
			var result = new double[query_row + 2];
			result[0] = poured;
			for (var row = 1; row <= query_row; row++)
			{
				for (var i = row; i >= 0; i--)
				{
					result[i] = Math.Max(0.0, (result[i] - 1) / 2);
					result[i + 1] += result[i];
				}
			}
			return Math.Min(result[query_glass], 1.0);
		}
	}
}
