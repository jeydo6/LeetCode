namespace LeetCode.Algorithms
{
	// HARD
	internal class _1510
	{
		public static bool WinnerSquareGame(int n)
		{
			var dp = new bool[n + 1];
			for (var i = 1; i <= n; ++i)
			{
				for (var k = 1; k * k <= i; ++k)
				{
					if (!dp[i - k * k])
					{
						dp[i] = true;
						break;
					}
				}
			}
			return dp[n];
		}
	}
}
