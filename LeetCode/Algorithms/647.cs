namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _647
{
	public static int CountSubstrings(string s)
	{
		if (s.Length <= 0)
		{
			return 0;
		}

		var result = 0;
		var n = s.Length;

		var dp = new bool[n][];
		for (var i = 0; i < dp.Length; i++)
		{
			dp[i] = new bool[n];
		}

		for (var i = 0; i < n; ++i, ++result)
		{
			dp[i][i] = true;
		}

		for (var i = 0; i < n - 1; ++i)
		{
			dp[i][i + 1] = s[i] == s[i + 1];
			result += dp[i][i + 1] ? 1 : 0;
		}

		for (var length = 3; length <= n; ++length)
		{
			for (int i = 0, j = i + length - 1; j < n; ++i, ++j)
			{
				dp[i][j] = dp[i + 1][j - 1] && (s[i] == s[j]);
				result += (dp[i][j] ? 1 : 0);
			}
		}

		return result;
	}
}