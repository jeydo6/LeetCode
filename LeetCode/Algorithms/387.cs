namespace LeetCode.Algorithms
{
	// EASY
	internal class _387
	{
		public static int FirstUniqChar(string s)
		{
			var freq = new int[26];
			for (var i = 0; i < s.Length; i++)
			{
				freq[s[i] - 'a']++;
			}
			for (var i = 0; i < s.Length; i++)
			{
				if (freq[s[i] - 'a'] == 1)
				{
					return i;
				}
			}
			return -1;
		}
	}
}
