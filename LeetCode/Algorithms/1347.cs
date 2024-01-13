using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1347
{
	public static int MinSteps(string s, string t)
	{
		var counts = new int[26];
		for (var i = 0; i < s.Length; i++)
		{
			counts[t[i] - 'a']++;
			counts[s[i] - 'a']--;
		}

		var result = 0;
		for (var i = 0; i < 26; i++)
		{
			result += Math.Max(0, counts[i]);
		}

		return result;
	}
}