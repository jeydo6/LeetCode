namespace LeetCode.Algorithms;

// EASY
internal sealed class _1704
{
	public static bool HalvesAreAlike(string s)
	{
		const string vowels = "aeiouAEIOU";

		var left = 0;
		var right = 0;
		for (var i = 0; i < s.Length / 2; i++)
		{
			if (vowels.Contains(s[i]))
			{
				left++;
			}

			if (vowels.Contains(s[^(i + 1)]))
			{
				right++;
			}
		}
		return left == right;
	}
}
