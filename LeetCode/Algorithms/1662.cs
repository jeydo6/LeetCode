namespace LeetCode.Algorithms;

// EASY
internal class _1662
{
	public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
	{
		var wp1 = 0;
		var wp2 = 0;

		var sp1 = 0;
		var sp2 = 0;

		while (wp1 < word1.Length && wp2 < word2.Length)
		{
			if (word1[wp1][sp1++] != word2[wp2][sp2++])
			{
				return false;
			}

			if (sp1 == word1[wp1].Length)
			{
				wp1++;
				sp1 = 0;
			}

			if (sp2 == word2[wp2].Length)
			{
				wp2++;
				sp2 = 0;
			}
		}

		return wp1 == word1.Length && wp2 == word2.Length;
	}
}
