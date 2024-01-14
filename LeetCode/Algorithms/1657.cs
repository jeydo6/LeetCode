using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1657
{
	public static bool CloseStrings(string word1, string word2)
	{
		if (word1.Length != word2.Length)
		{
			return false;
		}

		var words1 = new int[26];
		var words2 = new int[26];
		var word1Bit = 0;
		var word2Bit = 0;
		for (var i = 0; i < word1.Length; i++)
		{
			words1[word1[i] - 'a']++;
			word1Bit |= (1 << (word1[i] - 'a'));
		}
		for (var i = 0; i < word2.Length; i++)
		{
			words2[word2[i] - 'a']++;
			word2Bit |= (1 << (word2[i] - 'a'));
		}

		if (word1Bit != word2Bit)
		{
			return false;
		}

		Array.Sort(words1);
		Array.Sort(words2);

		for (var i = 0; i < 26; i++)
		{
			if (words1[i] != words2[i])
			{
				return false;
			}
		}

		return true;
	}
}
