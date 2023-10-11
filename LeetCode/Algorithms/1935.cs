namespace LeetCode.Algorithms
{
	class _1935
	{
		public static int CanBeTypedWords(string text, string brokenLetters)
		{
			var words = text.Split();
			var result = words.Length;
			foreach (var word in words)
			{
				foreach (var ch in word)
				{
					if (brokenLetters.Contains(ch))
					{
						result--;
						break;
					}
				}
			}
			return result;
		}
	}
}
