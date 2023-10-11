using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2131
{
	private const int AlphabetSize = 26;

	public static int LongestPalindrome(string[] words)
	{
		var count = new int[AlphabetSize][];
		for (var i = 0; i < AlphabetSize; i++)
		{
			count[i] = new int[AlphabetSize];
		}

		foreach (var word in words)
		{
			count[word[0] - 'a'][word[1] - 'a']++;
		}

		var result = 0;
		var central = false;
		for (var i = 0; i < AlphabetSize; i++)
		{
			if (count[i][i] % 2 == 0)
			{
				result += count[i][i];
			}
			else
			{
				result += count[i][i] - 1;
				central = true;
			}

			for (var j = i + 1; j < AlphabetSize; j++)
			{
				result += 2 * Math.Min(count[i][j], count[j][i]);
			}
		}

		if (central)
		{
			result++;
		}

		return 2 * result;
	}
}
