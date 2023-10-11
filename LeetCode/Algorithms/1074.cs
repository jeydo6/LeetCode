using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _1074
	{
		public static int NumSubmatrixSumTarget(int[][] matrix, int target)
		{
			var n = matrix.Length;
			var m = matrix[0].Length;

			var prefixSum = new int[n + 1][];
			for (var i = 0; i < n + 1; i++)
			{
				prefixSum[i] = new int[m + 1];
			}

			for (var r = 1; r < n + 1; r++)
			{
				for (var c = 1; c < m + 1; c++)
				{
					prefixSum[r][c] = prefixSum[r - 1][c] + prefixSum[r][c - 1] - prefixSum[r - 1][c - 1] + matrix[r - 1][c - 1];
				}
			}

			var result = 0;
			
			for (var r1 = 1; r1 < n + 1; r1++)
			{
				for (var r2 = r1; r2 < n + 1; r2++)
				{
					var dict = new Dictionary<int, int>();
					dict[0] = 1;

					for (var c = 1; c < m + 1; c++)
					{
						var currentSum = prefixSum[r2][c] - prefixSum[r1 - 1][c];

						result += dict.ContainsKey(currentSum - target) ? dict[currentSum - target] : 0;
						dict[currentSum] = (dict.ContainsKey(currentSum) ? dict[currentSum] : 0) + 1;
					}
				}
			}

			return result;
		}
	}
}
