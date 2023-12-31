using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal sealed class _1624
{
	public static int MaxLengthBetweenEqualCharacters(string s)
	{
		var result = -1;

		var indexes = new Dictionary<char, int>();
		for (var i = 0; i < s.Length; i++)
		{
			indexes.TryAdd(s[i], i);
			result = Math.Max(result, i - indexes[s[i]] - 1);
		}

		return result;
	}
}