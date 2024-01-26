namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _576
{
	private const int Modulo = 1000000000 + 7;

	public static int FindPaths(int m, int n, int maxMove, int startRow, int startColumn)
	{
		var dp = new int[m][];
		for (var i = 0; i < m; i++)
		{
			dp[i] = new int[n];
		}
		dp[startRow][startColumn] = 1;

		var count = 0;
		for (var moves = 1; moves <= maxMove; moves++)
		{
			var temp = new int[m][];
			for (var i = 0; i < m; i++)
			{
				temp[i] = new int[n];
				for (var j = 0; j < n; j++)
				{
					if (i == m - 1)
					{
						count = (count + dp[i][j]) % Modulo;
					}
					if (j == n - 1)
					{
						count = (count + dp[i][j]) % Modulo;
					}
					if (i == 0)
					{
						count = (count + dp[i][j]) % Modulo;
					}

					if (j == 0)
					{
						count = (count + dp[i][j]) % Modulo;
					}

					temp[i][j] = (
						((i > 0 ? dp[i - 1][j] : 0) + (i < m - 1 ? dp[i + 1][j] : 0)) % Modulo +
						((j > 0 ? dp[i][j - 1] : 0) + (j < n - 1 ? dp[i][j + 1] : 0)) % Modulo
					) % Modulo;
				}
			}
			dp = temp;
		}
		return count;
	}
}