using System;

namespace LeetCode.Algorithms;

// HARD
internal class _879
{
	private const int Modulo = 1_000_000_007;

	public static int ProfitableSchemes(int n, int minProfit, int[] group, int[] profits)
	{
		var dp = new int[101][][];
		for (var i = 0; i < dp.Length; i++)
		{
			dp[i] = new int[101][];
			for (var j = 0; j < dp[i].Length; j++)
			{
				dp[i][j] = new int[101];
			}
		}

		for (var count = 0; count <= n; count++)
		{
			dp[group.Length][count][minProfit] = 1;
		}

		for (var index = group.Length - 1; index >= 0; index--)
		{
			for (var count = 0; count <= n; count++)
			{
				for (var profit = 0; profit <= minProfit; profit++)
				{
					dp[index][count][profit] = dp[index + 1][count][profit];
					if (count + group[index] <= n)
					{
						dp[index][count][profit] = (
							dp[index][count][profit] +
							dp[index + 1][count + group[index]][Math.Min(minProfit, profit + profits[index])]
						) % Modulo;
					}
				}
			}
		}

		return dp[0][0][0];
	}
}
