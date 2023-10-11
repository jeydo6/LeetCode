namespace LeetCode.Algorithms;

// HARD
internal class _1359
{
	public static int CountOrders(int n)
	{
		var result = 1L;
		var MOD = 1_000_000_007;
		for (var i = 1; i <= 2 * n; ++i)
		{
			result *= i;
			if (i % 2 == 0)
			{
				result /= 2;
			}
			result %= MOD;
		}
		return (int)result;
	}
}
