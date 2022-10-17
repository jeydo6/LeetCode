namespace LeetCode.Algorithms;

// EASY
internal class _1832
{
	public static bool CheckIfPangram(string sentence)
	{
		if (sentence == null || sentence.Length < 26)
		{
			return false;
		}

		var dict = new int[26];
		foreach (var ch in sentence)
		{
			dict[ch - 'a']++;
		}

		foreach (var item  in dict)
		{
			if (item == 0)
			{
				return false;
			}
		}

		return true;
	}
}
