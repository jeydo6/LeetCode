using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1162
{
	public static int MaxDistance(int[][] grid)
	{
		var rows = grid.Length;
		var cols = grid[0].Length;

		var maxDistance = rows + cols + 1;
		for (var i = 0; i < rows; i++)
		{
			for (var j = 0; j < cols; j++)
			{
				if (grid[i][j] == 1)
				{
					grid[i][j] = 0;
				}
				else
				{
					grid[i][j] = Math.Min(
						maxDistance,
						Math.Min(
							i > 0 ? grid[i - 1][j] + 1 : maxDistance,
							j > 0 ? grid[i][j - 1] + 1 : maxDistance
						)
					);
				}
			}
		}

		var result = int.MinValue;
		for (var i = rows - 1; i >= 0; i--)
		{
			for (var j = cols - 1; j >= 0; j--)
			{
				grid[i][j] = Math.Min(
					grid[i][j],
					Math.Min(
						i < rows - 1 ? grid[i + 1][j] + 1 : maxDistance,
						j < cols - 1 ? grid[i][j + 1] + 1 : maxDistance
					)
				);

				result = Math.Max(result, grid[i][j]);
			}
		}

		return result == 0 || result == maxDistance ? -1 : result;
	}
}
