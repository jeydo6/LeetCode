using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _336
{
	public static IList<IList<int>> PalindromePairs(string[] words)
	{
		var result = new List<IList<int>>();
		var dict = new Dictionary<string, int>();
		for (var i = 0; i < words.Length; i++)
		{
			dict[words[i]] = i;
		}

		foreach (var (word, i) in dict)
		{
			var reversedWord = ReverseWord(word);

			if (word.Length == 1 && dict.TryGetValue(string.Empty, out var j))
			{
				result.Add(new List<int> { i, j });
				result.Add(new List<int> { j, i });
				continue;
			}

			if (dict.TryGetValue(reversedWord, out j) && j != i)
			{
				result.Add(new List<int> { i, j });
			}

			for (int k = 0; k < word.Length; k++)
			{
				if (IsPalindrome(reversedWord[..^k]) && dict.TryGetValue(reversedWord[^k..], out j))
				{
					result.Add(new List<int> { i, j });
				}
				if (IsPalindrome(reversedWord[k..]) && dict.TryGetValue(reversedWord[..k], out j))
				{
					result.Add(new List<int> { j, i });
				}
			}
		}

		return result;
	}

	private static bool IsPalindrome(string word)
	{
		var i = 0;

		while (i < word.Length / 2)
		{
			if (word[i++] != word[^i])
			{
				return false;
			}
		}

		return true;
	}

	private static string ReverseWord(string word)
	{
		var reversedChars = word.ToCharArray();
		Array.Reverse(reversedChars);

		return new string(reversedChars);
	}
}
