using System;

namespace LeetCode.Algorithms;

// HARD
internal class _1406
{
	public static string StoneGameIII(int[] stoneValue)
	{
		var dp = new int[stoneValue.Length + 1];
		for (var i = stoneValue.Length - 1; i >= 0; i--)
		{
			dp[i] = stoneValue[i] - dp[i + 1];
			if (i + 2 <= stoneValue.Length)
			{
				dp[i] = Math.Max(dp[i], stoneValue[i] + stoneValue[i + 1] - dp[i + 2]);
			}
			if (i + 3 <= stoneValue.Length)
			{
				dp[i] = Math.Max(dp[i], stoneValue[i] + stoneValue[i + 1] + stoneValue[i + 2] - dp[i + 3]);
			}
		}
		if (dp[0] > 0)
		{
			return "Alice";
		}
		if (dp[0] < 0)
		{
			return "Bob";
		}
		return "Tie";
	}
}
