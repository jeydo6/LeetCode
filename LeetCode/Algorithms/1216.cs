using System;

namespace LeetCode.Algorithms;

// HARD
internal class _1216
{
	public static bool IsValidPalindrome(string s, int k)
	{
		var memo = new int[s.Length];

		for (var i = s.Length - 2; i >= 0; i--)
		{
			var prev = 0;
			for (var j = i + 1; j < s.Length; j++)
			{
				var temp = memo[j];

				if (s[i] == s[j])
				{
					memo[j] = prev;
				}
				else
				{
					memo[j] = 1 + Math.Min(memo[j], memo[j - 1]);
				}

				prev = temp;
			}
		}

		return memo[^1] <= k;
	}
}
