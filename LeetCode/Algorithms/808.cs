using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _808
{
	public static double SoupServings(int n)
	{
		var dp = new Dictionary<int, IDictionary<int, double>>();

		var m = (int)Math.Ceiling(n / 25.0);
		for (var k = 1; k <= m; k++)
		{
			if (SoupServings(dp, k, k) > 1 - 1e-5)
			{
				return 1.0;
			}
		}

		return SoupServings(dp, m, m);
	}

	private static double SoupServings(IDictionary<int, IDictionary<int, double>> dp, int i, int j)
	{
		if (i <= 0 && j <= 0)
		{
			return 0.5;
		}

		if (i <= 0)
		{
			return 1.0;
		}

		if (j <= 0)
		{
			return 0.0;
		}

		if (dp.ContainsKey(i) && dp[i].ContainsKey(j))
		{
			return dp[i][j];
		}

		var result = (
			SoupServings(dp, i - 4, j) +
			SoupServings(dp, i - 3, j - 1) +
			SoupServings(dp, i - 2, j - 2) +
			SoupServings(dp, i - 1, j - 3)
		) / 4.0;

		if (!dp.ContainsKey(i))
		{
			dp[i] = new Dictionary<int, double>();
		}

		dp[i][j] = result;

		return result;
	}
}