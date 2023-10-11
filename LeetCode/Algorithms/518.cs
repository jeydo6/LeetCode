namespace LeetCode.Algorithms;

// MEDIUM
internal class _518
{
	public static int Change(int amount, int[] coins)
	{
		var dp = new int[amount + 1];
		dp[0] = 1;

		for (var i = coins.Length - 1; i >= 0; i--)
		{
			for (var j = coins[i]; j <= amount; j++)
			{
				dp[j] += dp[j - coins[i]];
			}
		}

		return dp[amount];
	}
}