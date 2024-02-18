using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal sealed class _1002
{
	public static IList<string> CommonChars(string[] words)
	{
		var alphabetLength = 26;

		var totalCount = new int[alphabetLength];
		for (var i = 0; i < alphabetLength; i++)
		{
			totalCount[i] = int.MaxValue;
		}

		foreach (string word in words)
		{
			var counts = new byte[alphabetLength];
			foreach (char c in word)
			{
				counts[c - 'a']++;
			}

			for (var i = 0; i < alphabetLength; i++)
			{
				totalCount[i] = Math.Min(counts[i], totalCount[i]);
			}
		}

		var result = new List<string>();
		for (var i = 0; i < alphabetLength; i++)
		{
			while (totalCount[i]-- > 0)
			{
				result.Add(new string((char)(i + 'a'), 1));
			}
		}
		return result;
	}
}