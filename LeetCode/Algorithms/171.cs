namespace LeetCode.Algorithms
{
	// EASy
	internal class _171
	{
		public static int TitleToNumber(string columnTitle)
		{
			var result = 0;
			for (var i = 0; i < columnTitle.Length; i++)
			{
				result = result * 26 + columnTitle[i] - 'A' + 1;
			}
			return result;
		}
	}
}
