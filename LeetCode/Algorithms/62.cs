namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _62
	{
		public static int UniquePaths(int n, int m)
		{
			var dp = new int[n][];

			for (var i = 0; i < n; i++)
			{
				dp[i] = new int[m];
				for (var j = 0; j < m; j++)
				{
					dp[i][j] = 1;
				}
			}

			for (var i = 1; i < n; i++)
			{
				for (var j = 1; j < m; j++)
				{
					dp[i][j] = dp[i - 1][j] + dp[i][j - 1];
				}
			}

			return dp[n - 1][m - 1];
		}
	}
}
