namespace LeetCode.Algorithms;

// HARD
internal class _1444
{
	public static int Ways(string[] pizza, int k)
	{
		var rows = pizza.Length;
		var cols = pizza[0].Length;

		var apples = new int[rows + 1][];
		for (var i = 0; i < apples.Length; i++)
		{
			apples[i] = new int[cols + 1];
		}

		var dp = new int[k][][];
		for (var i = 0; i < dp.Length; i++)
		{
			dp[i] = new int[rows][];
			for (var j = 0; j < dp[i].Length; j++)
			{
				dp[i][j] = new int[cols];
			}
		}

		for (var row = rows - 1; row >= 0; row--)
		{
			for (var col = cols - 1; col >= 0; col--)
			{
				apples[row][col] = (pizza[row][col] == 'A' ? 1 : 0) + apples[row + 1][col] + apples[row][col + 1] - apples[row + 1][col + 1];
				dp[0][row][col] = apples[row][col] > 0 ? 1 : 0;
			}
		}
		var mod = 1_000_000_007;
		for (var remain = 1; remain < k; remain++)
		{
			for (var row = 0; row < rows; row++)
			{
				for (var col = 0; col < cols; col++)
				{
					for (var next_row = row + 1; next_row < rows; next_row++)
					{
						if (apples[row][col] - apples[next_row][col] > 0)
						{
							dp[remain][row][col] += dp[remain - 1][next_row][col];
							dp[remain][row][col] %= mod;
						}
					}
					for (var next_col = col + 1; next_col < cols; next_col++)
					{
						if (apples[row][col] - apples[row][next_col] > 0)
						{
							dp[remain][row][col] += dp[remain - 1][row][next_col];
							dp[remain][row][col] %= mod;
						}
					}
				}
			}
		}
		return dp[k - 1][0][0];
	}
}
