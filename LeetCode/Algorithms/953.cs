namespace LeetCode.Algorithms;

// EASY
internal class _953
{
	public static bool IsAlienSorted(string[] words, string order)
	{
		var dict = new int[26];
		for (var i = 0; i < order.Length; i++)
		{
			dict[order[i] - 'a'] = i;
		}

		for (var i = 0; i < words.Length - 1; i++)
		{
			for (var j = 0; j < words[i].Length; j++)
			{
				if (j >= words[i + 1].Length)
				{
					return false;
				}

				if (words[i][j] != words[i + 1][j])
				{
					if (dict[words[i][j] - 'a'] > dict[words[i + 1][j] - 'a'])
					{
						return false;
					}
					else
					{
						break;
					}
				}
			}
		}

		return true;
	}
}
