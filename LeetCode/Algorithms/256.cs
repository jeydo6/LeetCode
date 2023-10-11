using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _256
	{
		public static int MinCost(int[][] costs)
		{
			if (costs.Length == 0)
			{
				return 0;
			}

			var previousRow = Copy(costs[^1]);
			for (var i = costs.Length - 2; i >= 0; i--) {

				var currentRow = Copy(costs[i]);
				currentRow[0] += Math.Min(previousRow[1], previousRow[2]);
				currentRow[1] += Math.Min(previousRow[0], previousRow[2]);
				currentRow[2] += Math.Min(previousRow[0], previousRow[1]);
				previousRow = currentRow;
			}  

			return Math.Min(
				Math.Min(previousRow[0], previousRow[1]),
				previousRow[2]
			);
		}

		private static int[] Copy(int[] sourceArray)
		{
			var destinationArray = new int[sourceArray.Length];
			Array.Copy(sourceArray, destinationArray, sourceArray.Length);

			return destinationArray;
		}
	}
}