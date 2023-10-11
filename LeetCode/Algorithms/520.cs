namespace LeetCode.Algorithms;

// EASY
internal class _520
{
	public static bool DetectCapitalUse(string word)
	{
		var count = 0;
		for (var i = 0; i < word.Length; i++)
		{
			if ('Z' - word[i] >= 0)
			{
				count++;
			}
		}
		return count == 0 || count == word.Length || (count == 1 && 'Z' - word[0] >= 0);
	}
}
