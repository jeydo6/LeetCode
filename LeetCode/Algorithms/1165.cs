using System;

namespace LeetCode.Algorithms;

// EASY
internal class _1165
{
	public static int CalculateTime(string keyboard, string word)
	{
		var indexes = new int[26];
		for (var i = 0; i < keyboard.Length; i++)
		{
			indexes[keyboard[i] - 'a'] = i;
		}

		var prev = 0;
		var result = 0;
		for (var i = 0; i < word.Length; i++)
		{
			result += Math.Abs(prev - indexes[word[i] - 'a']);
			prev = indexes[word[i] - 'a'];
		}
		return result;
	}
}
