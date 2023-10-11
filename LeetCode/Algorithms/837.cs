namespace LeetCode.Algorithms;

// MEDIUM
internal class _837
{
	public static double New21Game(int n, int k, int maxPts)
	{
		var dp = new double[n + 1];
		dp[0] = 1;

		var s = k > 0 ? 1d : 0d;
		for (var i = 1; i <= n; i++)
		{
			dp[i] = s / maxPts;
			if (i < k)
			{
				s += dp[i];
			}
			if (i - maxPts >= 0 && i - maxPts < k)
			{
				s -= dp[i - maxPts];
			}
		}

		var result = 0d;
		for (var i = k; i <= n; i++)
		{
			result += dp[i];
		}
		return result;
	}
}
