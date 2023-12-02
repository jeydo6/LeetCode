namespace LeetCode.Algorithms;

// EASY
internal class _1160
{
	public static int CountCharacters(string[] words, string chars)
	{
		var result = 0;

		var total = new int[26];
		foreach (var ch in chars)
		{
			total[ch - 'a']++;
		}

		foreach (var w in words)
		{
			var isValid = true;

			var local = new int[26];
			foreach (var ch in w)
			{
				local[ch - 'a']++;
				if (local[ch - 'a'] > total[ch - 'a'])
				{
					isValid = false;
					break;
				}
			}

			if (isValid)
			{
				result += w.Length;
			}
		}

		return result;
	}
}
