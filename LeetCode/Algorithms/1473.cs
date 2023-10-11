using System;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _1473
	{
		private const int MaxCost = 1000001;

		public static int MinCost(int[] houses, int[][] cost, int m, int n, int target)
		{
			var prevMemo = new int[target + 1][];
			for (var i = 0; i < target + 1; i++)
			{
				prevMemo[i] = new int[n];
				for (var j = 0; j < n; j++)
				{
					prevMemo[i][j] = MaxCost;
				}
			}

			for (var color = 1; color <= n; color++)
			{
				if (houses[0] == color)
				{
					prevMemo[1][color - 1] = 0;
				}
				else if (houses[0] == 0)
				{
					prevMemo[1][color - 1] = cost[0][color - 1];
				}
			}

			for (var house = 1; house < m; house++)
			{
				var memo = new int[target + 1][];
				for (var i = 0; i < target + 1; i++)
				{
					memo[i] = new int[n];
					for (var j = 0; j < n; j++)
					{
						memo[i][j] = MaxCost;
					}
				}

				for (var neighborhoods = 1; neighborhoods <= Math.Min(target, house + 1); neighborhoods++)
				{
					for (var color = 1; color <= n; color++)
					{

						if (houses[house] != 0 && color != houses[house])
						{
							continue;
						}

						var currentCost = MaxCost;
						for (var prevColor = 1; prevColor <= n; prevColor++)
						{
							currentCost = Math.Min(currentCost, prevColor != color ? prevMemo[neighborhoods - 1][prevColor - 1] : prevMemo[neighborhoods][color - 1]);
						}

						var costToPaint = houses[house] != 0 ? 0 : cost[house][color - 1];
						memo[neighborhoods][color - 1] = currentCost + costToPaint;
					}
				}

				prevMemo = memo;
			}

			var minCost = MaxCost;
			for (var color = 1; color <= n; color++)
			{
				minCost = Math.Min(minCost, prevMemo[target][color - 1]);
			}

			return minCost == MaxCost ? -1 : minCost;
		}
	}
}
