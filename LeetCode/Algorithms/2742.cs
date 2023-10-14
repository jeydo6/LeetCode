using System;

namespace LeetCode.Algorithms;

// HARD
internal class _2742
{
	public static int PaintWalls(int[] cost, int[] time)
	{
		var n = cost.Length;
		var dp = new int[n + 1];
		var prevDp = new int[n + 1];
		Array.Fill(prevDp, (int)1e9);
		prevDp[0] = 0;

		for (var i = n - 1; i >= 0; i--)
		{
			dp = new int[n + 1];
			for (var remain = 1; remain <= n; remain++)
			{
				var paint = cost[i] + prevDp[Math.Max(0, remain - 1 - time[i])];
				var dontPaint = prevDp[remain];
				dp[remain] = Math.Min(paint, dontPaint);
			}

			prevDp = dp;
		}

		return dp[n];
	}
}
