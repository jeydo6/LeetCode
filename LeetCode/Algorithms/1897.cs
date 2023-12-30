namespace LeetCode.Algorithms;

// EASY
internal sealed class _1897
{
	public static bool MakeEqual(string[] words)
	{
		var counts = new int[26];
		for (var i = 0; i < words.Length; i++)
		{
			for (var j = 0; j < words[i].Length; j++)
			{
				counts[words[i][j] - 'a']++;
			}
		}

		for (var i = 0; i < counts.Length; i++)
		{
			if (counts[i] % words.Length != 0)
			{
				return false;
			}
		}
        
		return true;
	}
}