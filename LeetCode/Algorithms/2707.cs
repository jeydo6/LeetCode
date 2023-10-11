using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2707
{
	public static int MinExtraChar(string s, string[] dictionary)
	{
		var hashSet = new HashSet<string>(dictionary);
		var dp = new int[s.Length + 1];

		for (var start = s.Length - 1; start >= 0; start--)
		{
			dp[start] = dp[start + 1] + 1;
			for (var end = start; end < s.Length; end++)
			{
				var current = s[start..(end + 1)];
				if (hashSet.Contains(current))
				{
					dp[start] = Math.Min(dp[start], dp[end + 1]);
				}
			}
		}

		return dp[0];
	}
}
