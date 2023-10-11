namespace LeetCode.Algorithms;

// HARD
internal class _1416
{
	private const int Modulo = 1_000_000_007;
	public static int NumberOfArrays(string s, int k)
	{
		var n = s.Length;
		var m = k.ToString().Length;

		var dp = new int[m + 1];
		dp[0] = 1;

		for (var start = 0; start < n; start++)
		{
			if (s[start] == '0')
			{
				dp[start % (m + 1)] = 0;
				continue;
			}

			for (var end = start; end < n; end++)
			{
				if (long.Parse(s[start..(end + 1)]) > k)
				{
					break;
				}

				dp[(end + 1) % (m + 1)] = (dp[(end + 1) % (m + 1)] + dp[start % (m + 1)]) % Modulo;
			}

			dp[start % (m + 1)] = 0;
		}
		return dp[n % (m + 1)];
	}
}
