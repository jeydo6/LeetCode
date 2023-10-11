namespace LeetCode.Algorithms;

// MEDIUM
internal class _567
{
	public static bool CheckInclusion(string s1, string s2)
	{
		if (s1.Length > s2.Length)
		{
			return false;
		}

		var frequencies = new int[26];
		for (var i = 0; i < s1.Length; i++)
		{
			frequencies[s1[i] - 'a']++;
		}
		for (var i = 0; i < s2.Length; i++)
		{
			frequencies[s2[i] - 'a']--;

			if (i >= s1.Length)
			{
				frequencies[s2[i - s1.Length] - 'a']++;
			}

			var allZero = true;
			for (var j = 0; j < 26; j++)
			{
				if (frequencies[j] != 0)
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
