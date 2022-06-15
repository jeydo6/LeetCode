using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1048
	{
		public int LongestStrChain(string[] words)
		{
			Array.Sort(words, (w1, w2) => w1.Length - w2.Length);

			var result = 1;
			var dp = new Dictionary<string, int>();
			for (var i = 0; i < words.Length; i++)
			{
				var currentLength = 1;
				for (var j = 0; j < words[i].Length; j++)
				{
					var key = words[i][..j] + words[i][(j + 1)..];
					var previousLength = dp.ContainsKey(key) ? dp[key] : 0;
					currentLength = Math.Max(currentLength, previousLength + 1);
				}
				dp[words[i]] = currentLength;
				result = Math.Max(result, currentLength);
			}
			return result;
		}
	}
}
