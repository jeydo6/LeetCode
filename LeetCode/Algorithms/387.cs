namespace LeetCode.Algorithms
{
	// EASY
	internal class _387
	{
		public static int FirstUniqChar(string s)
		{
			var counts = new int[26];
			for (var i = 0; i < s.Length; i++)
			{
				counts[s[i] - 'a']++;
			}

			for (var i = 0; i < s.Length; i++)
			{
				if (counts[s[i] - 'a'] == 1)
				{
					return i;
				}
			}

			return -1;
		}
	}
}
