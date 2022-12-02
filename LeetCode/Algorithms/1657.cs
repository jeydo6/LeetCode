using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1657
{
	public static bool CloseStrings(string word1, string word2)
	{
		if (word1.Length != word2.Length)
		{
			return false;
		}

		var word1Dict = new int[26];
		var word2Dict = new int[26];
		var word1Bit = 0;
		var word2Bit = 0;
		for (var i = 0; i < word1.Length; i++)
		{
			word1Dict[word1[i] - 'a']++;
			word1Bit |= (1 << (word1[i] - 'a'));
		}
		for (var i = 0; i < word2.Length; i++)
		{
			word2Dict[word2[i] - 'a']++;
			word2Bit |= (1 << (word2[i] - 'a'));
		}

		if (word1Bit != word2Bit)
		{
			return false;
		}

		Array.Sort(word1Dict);
		Array.Sort(word2Dict);

		for (var i = 0; i < 26; i++)
		{
			if (word1Dict[i] != word2Dict[i])
			{
				return false;
			}
		}

		return true;
	}
}
