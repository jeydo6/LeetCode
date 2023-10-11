using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _378
	{
		public static int KthSmallest(int[][] matrix, int k)
		{
			var n = matrix.Length;
			
			var lo = matrix[0][0];
			var hi = matrix[n - 1][n - 1];

			while (lo < hi)
			{

				var mid = lo + (hi - lo) / 2;
				var smallLargePair = new int[]
				{
					matrix[0][0],
					matrix[n - 1][n - 1]
				};

				var count = CountLessEqual(matrix, mid, smallLargePair);

				if (count == k)
				{
					return smallLargePair[0];
				}

				if (count < k)
				{
					lo = smallLargePair[1];
				}
				else
				{
					hi = smallLargePair[0];
				}
			}
			return lo;
		}

		private static int CountLessEqual(int[][] matrix, int mid, int[] smallLargePair)
		{
			var result = 0;

			var row = matrix.Length - 1;
			var col = 0;
			while (row >= 0 && col <= matrix.Length - 1)
			{
				if (matrix[row][col] > mid)
				{
					smallLargePair[1] = Math.Min(smallLargePair[1], matrix[row][col]);
					row--;
				}
				else
				{
					smallLargePair[0] = Math.Max(smallLargePair[0], matrix[row][col]);
					col++;

					result += row + 1;
				}
			}

			return result;
		}
	}
}
