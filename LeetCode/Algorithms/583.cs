using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _583
	{
		public static int MinDistance(string word1, string word2)
		{
			var dp = new int[word2.Length + 1];
			for (var i = 0; i <= word1.Length; i++)
			{
				var temp = new int[word2.Length + 1];
				for (var j = 0; j <= word2.Length; j++)
				{
					if (i == 0 || j == 0)
					{
						temp[j] = i + j;
					}
					else if (word1[i - 1] == word2[j - 1])
					{
						temp[j] = dp[j - 1];
					}
					else
					{
						temp[j] = 1 + Math.Min(dp[j], temp[j - 1]);
					}
				}
				dp = temp;
			}
			return dp[word2.Length];
		}
	}
}
