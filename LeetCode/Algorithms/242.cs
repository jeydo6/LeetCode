namespace LeetCode.Algorithms
{
	// EASY
	internal class _242
	{
		public static bool IsAnagram(string s, string t)
		{
			var alphabet = new int[26];
			for (var i = 0; i < s.Length; i++)
			{
				alphabet[s[i] - 'a']++;
			}
			for (var i = 0; i < t.Length; i++)
			{
				alphabet[t[i] - 'a']--;
			}
			for (var i = 0; i < alphabet.Length; i++)
			{
				if (alphabet[i] != 0)
				{
					return false;
				}
			}

			return true;
		}
	}
}
