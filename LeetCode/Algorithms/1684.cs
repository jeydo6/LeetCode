namespace LeetCode.Algorithms
{
	class _1684
	{
		public static int CountConsistentStrings(string allowed, string[] words)
		{
			var result = words.Length;
			foreach (var word in words)
			{
				foreach (var ch in word)
				{
					if (!allowed.Contains(ch))
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
