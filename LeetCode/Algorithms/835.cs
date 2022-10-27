using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _835
{
	public static int LargestOverlap(int[][] img1, int[][] img2)
	{
		var n = img1.Length;
		var padded = new int[3 * n - 2][];
		for (var i = 0; i < 3 * n - 2; i++)
		{
			padded[i] = new int[3 * n - 2];
		}

		for (var row = 0; row < n; row++)
		{
			for (var col = 0; col < n; col++)
			{
				padded[row + n - 1][col + n - 1] = img2[row][col];
			}
		}

		var maxOverlaps = 0;
		for (var x = 0; x < 2 * n - 1; x++)
		{
			for (var y = 0; y < 2 * n - 1; ++y)
			{
				maxOverlaps = Math.Max(
					maxOverlaps,
					LargestOverlap(img1, padded, x, y)
				);
			}
		}

		return maxOverlaps;
	}

	private static int LargestOverlap(int[][] img, int[][] kernel, int x, int y)
	{
		var n = img.Length;
		var result = 0;
		for (var row = 0; row < n; row++)
		{
			for (var col = 0; col < n; col++)
			{
				result += img[row][col] * kernel[row + y][col + x];
			}
		}

		return result;
	}
}
