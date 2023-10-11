namespace LeetCode.Algorithms
{
	class _91
	{
		public static int NumDecodings(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return 0;
			}

			var dp = new int[s.Length + 1];
			dp[0] = 1;
			dp[1] = s[0] == '0' ? 0 : 1;
			for (var i = 2; i <= s.Length; i++)
			{
				var first = s[i - 1] - '0';
				var second = (s[i - 2] - '0') * 10 + s[i - 1] - '0';
				if (first >= 1 && first <= 9)
				{
					dp[i] += dp[i - 1];
				}
				if (second >= 10 && second <= 26)
				{
					dp[i] += dp[i - 2];
				}
			}
			return dp[^1];
		}
	}
}
