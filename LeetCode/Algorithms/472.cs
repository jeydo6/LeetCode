using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _472
{
	public static IList<string> FindAllConcatenatedWordsInADict(string[] words)
	{
		var result = new List<string>();

		var hashSet = new HashSet<string>(words);
		for (var i = 0; i < words.Length; i++)
		{
			var dp = new bool[words[i].Length + 1];
			dp[0] = true;

			for (var j = 1; j < dp.Length; j++)
			{
				for (var k = j == (dp.Length - 1) ? 1 : 0; !dp[j] && k < j; k++)
				{
					dp[j] = dp[k] && hashSet.Contains(words[i][k..j]);
				}
			}

			if (dp[^1])
			{
				result.Add(words[i]);
			}
		}
		return result;
	}
}
