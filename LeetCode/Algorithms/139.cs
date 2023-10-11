using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _139
{
	public static bool WordBreak(string s, IList<string> wordDict)
	{
		var dp = new bool[s.Length];
		for (var i = 0; i < s.Length; i++)
		{
			foreach (var word in wordDict)
			{
				if (i < word.Length - 1)
				{
					continue;
				}

				if (i == word.Length - 1 || dp[i - word.Length])
				{
					if (s[(i + 1 - word.Length)..(i + 1)] == word)
					{
						dp[i] = true;
						break;
					}
				}
			}
		}

		return dp[^1];
	}
}