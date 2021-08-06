namespace LeetCode.Algorithms
{
	class _1941
	{
		public static bool AreOccurrencesEqual(string s)
		{
			var dict = new int[26];
			foreach (var ch in s)
			{
				dict[ch - 'a']++;
			}

			var temp = dict[s[0] - 'a'];
			foreach (var value in dict)
			{
				if (value != 0 && value != temp)
				{
					return false;
				}
			}
			return true;
		}
	}
}
