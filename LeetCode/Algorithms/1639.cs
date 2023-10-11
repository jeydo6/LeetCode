namespace LeetCode.Algorithms;

// HARD
internal class _1639
{
	private static readonly int Modulo = 1000000007;
	public static int NumWays(string[] words, string target)
	{
		var counts = new int[26][];
		for (var i = 0; i < counts.Length; i++)
		{
			counts[i] = new int[words[0].Length];
		}

		for (var i = 0; i < words.Length; i++)
		{
			for (var j = 0; j < words[0].Length; j++)
			{
				counts[words[i][j] - 'a'][j]++;
			}
		}

		var dp = new long[target.Length + 1][];
		for (var i = 0; i < dp.Length; i++)
		{
			dp[i] = new long[words[0].Length + 1];
		}
		dp[0][0] = 1;

		for (var i = 0; i < dp.Length; i++)
		{
			for (var j = 0; j < words[0].Length; j++)
			{
				if (i < dp.Length - 1)
				{
					dp[i + 1][j + 1] += counts[target[i] - 'a'][j] * dp[i][j];
					dp[i + 1][j + 1] %= Modulo;
				}
				dp[i][j + 1] += dp[i][j];
				dp[i][j + 1] %= Modulo;
			}
		}
		return (int)dp[^1][^1];
	}
}
