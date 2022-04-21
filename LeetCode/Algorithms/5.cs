namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _5
	{
		public static string LongestPalindrome(string s)
		{
			var n = s.Length;
			var dp = new bool[n][];
			for (var i = 0; i < n; i++)
			{
				dp[i] = new bool[n];
			}

			string result = null;
			for (var i = n - 1; i >= 0; i--)
			{
				for (var j = i; j < n; j++)
				{
					dp[i][j] = s[i] == s[j] && (j - i < 3 || dp[i + 1][j - 1]);

					if (dp[i][j] && (result == null || j - i + 1 > result.Length))
					{
						result = s[i..(j + 1)];
					}
				}
			}
			return result;
		}
	}
}
