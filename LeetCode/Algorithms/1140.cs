using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1140
{
	public static int StoneGameII(int[] piles)
	{
		var dp = new int[2][][];
		for (var p = 0; p < dp.Length; p++)
		{
			dp[p] = new int[piles.Length + 1][];
			for (var i = 0; i < dp[p].Length; i++)
			{
				dp[p][i] = new int[piles.Length + 1];
				for (var j = 0; j < dp[p][i].Length; j++)
				{
					dp[p][i][j] = -1;
				}
			}
		}

		return StoneGameII(piles, dp, 0, 0, 1);
	}

	private static int StoneGameII(int[] piles, int[][][] dp, int p, int i, int j)
	{
		if (i == piles.Length)
		{
			return 0;
		}

		if (dp[p][i][j] != -1)
		{
			return dp[p][i][j];
		}

		var result = p == 1 ? 1000000 : -1;
		var sum = 0;
		for (var x = 1; x <= Math.Min(2 * j, piles.Length - i); x++)
		{
			sum += piles[i + x - 1];
			if (p == 0)
			{
				result = Math.Max(result, sum + StoneGameII(piles, dp, 1, i + x, Math.Max(j, x)));
			}
			else
			{
				result = Math.Min(result, StoneGameII(piles, dp, 0, i + x, Math.Max(j, x)));
			}
		}
		return dp[p][i][j] = result;
	}
}
