using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1456
{
	private static readonly ISet<char> _vowels = new HashSet<char>
	{
		'a',
		'e',
		'i',
		'o',
		'u'
	};

	public static int MaxVowels(string s, int k)
	{
		var count = 0;
		for (var i = 0; i < k; i++)
		{
			count += _vowels.Contains(s[i]) ? 1 : 0;
		}
		
		var result = count;
		for (var i = k; i < s.Length; i++)
		{
			count += _vowels.Contains(s[i]) ? 1 : 0;
			count -= _vowels.Contains(s[i - k]) ? 1 : 0;
			result = Math.Max(result, count);
		}

		return result;
	}
}
