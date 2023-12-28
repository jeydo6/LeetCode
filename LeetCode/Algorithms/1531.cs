using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal sealed class _1531
{
	public static int GetLengthOfOptimalCompression(string s, int k)
	{
		var memo = new Dictionary<int, int>();
		var set = new HashSet<int> { 1, 9, 99 };

		return GetLengthOfOptimalCompression(s, k, 0, (char)('a' + 26), 0, memo, set);
	}

	private static int GetLengthOfOptimalCompression(string s, int k, int index, char lastChar, int lastCharCount, IDictionary<int, int> memo, ISet<int> set)
	{
		if (k < 0)
		{
			return int.MaxValue / 2;
		}

		if (index == s.Length)
		{
			return 0;
		}

		var key = index * 101 * 27 * 101 + (lastChar - 'a') * 101 * 101 + lastCharCount * 101 + k;

		if (memo.ContainsKey(key))
		{
			return memo[key];
		}

		int keepChar;
		var deleteChar = GetLengthOfOptimalCompression(s, k - 1, index + 1, lastChar, lastCharCount, memo, set);
		if (s[index] == lastChar)
		{
			keepChar = GetLengthOfOptimalCompression(s, k, index + 1, lastChar, lastCharCount + 1, memo, set) + (set.Contains(lastCharCount) ? 1 : 0);
		}
		else
		{
			keepChar = GetLengthOfOptimalCompression(s, k, index + 1, s[index], 1, memo, set) + 1;
		}

		var result = Math.Min(keepChar, deleteChar);
		memo[key] = result;

		return result;
	}
}
