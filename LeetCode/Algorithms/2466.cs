namespace LeetCode.Algorithms;

// MEDIUM
internal class _2466
{
	private const int Modulo = 1_000_000_007;

	public static int CountGoodStrings(int low, int high, int zero, int one)
	{
		var dp = new int[high + 1];
		dp[0] = 1;
		for (var end = 1; end <= high; end++)
		{
			if (end >= zero)
			{
				dp[end] += dp[end - zero];
			}
			if (end >= one)
			{
				dp[end] += dp[end - one];
			}
			dp[end] %= Modulo;
		}

		var result = 0;
		for (var i = low; i <= high; ++i)
		{
			result += dp[i];
			result %= Modulo;
		}
		return result;
	}
}
