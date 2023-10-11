namespace LeetCode.Algorithms
{
	// EASY
	internal class _1662
	{
		public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
		{
			var word1Pointer = 0;
			var word2Pointer = 0;

			var string1Pointer = 0;
			var string2Pointer = 0;

			while (word1Pointer < word1.Length && word2Pointer < word2.Length)
			{
				if (word1[word1Pointer][string1Pointer++] != word2[word2Pointer][string2Pointer++])
				{
					return false;
				}

				if (string1Pointer == word1[word1Pointer].Length)
				{
					word1Pointer++;
					string1Pointer = 0;
				}

				if (string2Pointer == word2[word2Pointer].Length)
				{
					word2Pointer++;
					string2Pointer = 0;
				}
			}

			return word1Pointer == word1.Length && word2Pointer == word2.Length;
		}
	}
}
