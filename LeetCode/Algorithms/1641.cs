namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1641
	{
		public static int CountVowelStrings(int n)
		{
			var dp = new int[n + 1][];
			for (var i = 0; i < dp.Length; i++)
			{
				dp[i] = new int[6];
			}

			for (var vowels = 1; vowels <= 5; vowels++)
			{
				dp[1][vowels] = vowels;
			}
			for (var nValue = 2; nValue <= n; nValue++)
			{
				dp[nValue][1] = 1;
				for (var vowels = 2; vowels <= 5; vowels++)
				{
					dp[nValue][vowels] = dp[nValue][vowels - 1] + dp[nValue - 1][vowels];
				}
			}
			return dp[n][5];
		}
	}
}
