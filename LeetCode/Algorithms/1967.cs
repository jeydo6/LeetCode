namespace LeetCode.Algorithms
{
	class _1967
	{
		public static int NumOfStrings(string[] patterns, string word)
		{
			var count = 0;
			foreach (var pattern in patterns)
			{
				if (word.Contains(pattern))
				{
					count++;
				}
			}
			return count;
		}
	}
}
