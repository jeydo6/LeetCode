using System;

namespace LeetCode.Algorithms;

// HARD
internal class _1269
{
	private const int Modulo = (int)1e9 + 7;

	public static int NumWays(int steps, int arrLen)
	{
		var n = Math.Min(arrLen, steps);

		var dp = new int[n];
		var prevDp = new int[n];
		prevDp[0] = 1;

		for (var remain = 1; remain <= steps; remain++)
		{
			dp = new int[n];

			for (var current = n - 1; current >= 0; current--)
			{
				var result = prevDp[current];
				if (current > 0)
				{
					result = (result + prevDp[current - 1]) % Modulo;
				}

				if (current < n - 1)
				{
					result = (result + prevDp[current + 1]) % Modulo;
				}

				dp[current] = result;
			}

			prevDp = dp;
		}

		return dp[0];
	}
}
