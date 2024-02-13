namespace LeetCode.Algorithms;

// EASY
internal sealed class _2108
{
	public static string FirstPalindrome(string[] words)
	{
		for (var i = 0; i < words.Length; i++)
		{
			if (IsPalindrome(words[i]))
			{
				return words[i];
			}
		}

		return string.Empty;
	}

	private static bool IsPalindrome(string word)
	{
		var lo = 0;
		var hi = word.Length - 1;

		while (lo <= hi)
		{
			if (word[lo] != word[hi])
			{
				return false;
			}

			lo++;
			hi--;
		}

		return true;
	}
}