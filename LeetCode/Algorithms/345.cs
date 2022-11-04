namespace LeetCode.Algorithms;

// EASY
internal class _345
{
	public static string ReverseVowels(string s)
	{
		var lo = 0;
		var hi = s.Length - 1;

		var chars = s.ToCharArray();
		while (lo < hi)
		{
			while (lo < s.Length && !IsVowel(chars[lo]))
			{
				lo++;
			}

			while (hi >= 0 && !IsVowel(chars[hi]))
			{
				hi--;
			}

			if (lo < hi)
			{
				(chars[lo], chars[hi]) = (chars[hi], chars[lo]);

				lo++;
				hi--;
			}
		}

		return new string(chars);
	}

	private static bool IsVowel(char ch) => ch is
		'a' or 'i' or 'e' or 'o' or 'u' or
		'A' or 'I' or 'E' or 'O' or 'U';
}
