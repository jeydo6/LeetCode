﻿namespace LeetCode.Algorithms;

// MEDIUM
internal class _790
{
	public static int NumTilings(int n)
	{
		var dp = new ulong[1001];
		dp[1] = 1;
		dp[2] = 2;
		dp[3] = 5;
		if (n <= 3)
		{
			return (int)dp[n];
		}

		var m = (ulong)1e9 + 7;
		for (var i = 4; i <= n; i++)
		{
			dp[i] = 2 * dp[i - 1] + dp[i - 3];
			dp[i] %= m;
		}
		return (int)dp[n];
	}
}
