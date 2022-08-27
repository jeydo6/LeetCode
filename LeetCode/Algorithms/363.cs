using System;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _363
	{
		public static int MaxSumSubmatrix(int[][] matrix, int k)
		{
			var rows = matrix.Length;
			var cols = matrix[0].Length;

			var sums = new int[rows + 1][];
			for (var i = 0; i <= rows; i++)
			{
				sums[i] = new int[cols + 1];
			}

			var result = int.MinValue;
			for (var i = 0; i < rows; i++)
			{
				for (var j = 0; j < cols; j++)
				{
					sums[i + 1][j + 1] = sums[i + 1][j] + sums[i][j + 1] - sums[i][j] + matrix[i][j];

					for (var rectangleHeight = 0; rectangleHeight <= i; rectangleHeight++)
					{
						for (var rectangleWidth = 0; rectangleWidth <= j; rectangleWidth++)
						{
							var rectangleSum = sums[i + 1][j + 1] - sums[i + 1][j - rectangleWidth] - sums[i - rectangleHeight][j + 1] + sums[i - rectangleHeight][j - rectangleWidth];
							if (rectangleSum == k)
							{
								return rectangleSum;
							}

							if (rectangleSum < k)
							{
								result = Math.Max(result, rectangleSum);
							}
						}
					}
				}
			}

			return result;
		}
	}
}
