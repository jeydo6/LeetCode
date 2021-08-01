namespace LeetCode.Algorithms
{
	class _1859
	{
		public static string SortSentence(string s)
		{
			var words = s.Split(" ");
			var result = new string[words.Length];
			foreach (var word in words)
			{
				result[word[^1] - '1'] = word[..^1];
			}
			return string.Join(" ", result);
		}
	}
}
