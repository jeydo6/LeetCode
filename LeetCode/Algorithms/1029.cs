using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1029
	{
		public static int TwoCitySchedCost(int[][] costs)
		{
			Array.Sort(costs, (c1, c2) => c1[0] - c2[0] - c1[1] + c2[1]);

			var n = costs.Length / 2;
			var total = 0;
			for (var i = 0; i < n; i++)
			{
				total += costs[i][0] + costs[i + n][1];
			}
			return total;
		}
	}
}
