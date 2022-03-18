namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _316
	{
		public static string RemoveDuplicateLetters(string s)
		{
			var count = new int[26];
			var position = 0;
			for (var i = 0; i < s.Length; i++)
			{
				count[s[i] - 'a']++;
			}

			for (var i = 0; i < s.Length; i++)
			{
				if (s[i] < s[position])
				{
					position = i;
				}
				if (count[s[i] - 'a']-- == 0)
				{
					break;
				}
			}
			return s.Length == 0 ? "" : s[position] + RemoveDuplicateLetters(s[(position + 1)..].Replace("" + s[position], ""));
		}
	}
}
