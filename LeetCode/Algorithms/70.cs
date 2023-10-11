namespace LeetCode.Algorithms;

// EASY
internal class _70
{
	public static int ClimbStairs(int n)
	{
		if (n == 1)
		{
			return 1;
		}
		if (n == 2)
		{
			return 2;
		}

		var dp = new int[n + 1];
		dp[0] = 0;
		dp[1] = 1;
		dp[2] = 2;
		for (var i = 3; i < n + 1; i++)
		{
			dp[i] = dp[i - 1] + dp[i - 2];
		}
		return dp[n];
	}
}
