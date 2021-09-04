namespace LeetCode.Algorithms
{
	// MEDIUM
	class _567
	{
		public static bool CheckInclusion(string s1, string s2)
		{
			if (s1.Length > s2.Length)
			{
				return false;
			}

			var freq = new int[26];
			for (var i = 0; i < s1.Length; i++)
			{
				freq[s1[i] - 'a']++;
			}
			for (var i = 0; i < s2.Length; i++)
			{
				freq[s2[i] - 'a']--;

				if (i >= s1.Length)
				{
					freq[s2[i - s1.Length] - 'a']++;
				}

				var allZero = true;
				for (var j = 0; j < 26; j++)
				{
					if (freq[j] != 0)
					{
						allZero = false;
						break;
					}
				}
				if (allZero)
				{
					return true;
				}
			}

			return false;
		}
	}
}
