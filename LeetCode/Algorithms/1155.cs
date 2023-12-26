using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1155
{
	private const int Modulo = 1000000007;

	public static int NumRollsToTarget(int n, int k, int target)
	{
		var dp = new int[n + 1][];
		for (var i = 0; i < n + 1; i++)
		{
			dp[i] = new int[target + 1];
		}

		dp[n][target] = 1;
		for (var diceIndex = n - 1; diceIndex >= 0; diceIndex--)
		{
			for (var sum = 0; sum <= target; sum++)
			{
				var ways = 0;

				for (var i = 1; i <= Math.Min(k, target - sum); i++)
				{
					ways = (ways + dp[diceIndex + 1][sum + i]) % Modulo;
				}

				dp[diceIndex][sum] = ways;
			}
		}

		return dp[0][0];
	}
}
