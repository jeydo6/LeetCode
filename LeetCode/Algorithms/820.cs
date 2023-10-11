using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _820
	{
		public static int MinimumLengthEncoding(string[] words)
		{
			var hashSet = new HashSet<string>(words);
			for (var i = 0; i < words.Length; i++)
			{
				for (var j = 1; j < words[i].Length; j++)
				{
					hashSet.Remove(words[i][j..]);
				}
			}

			var result = 0;
			foreach (var item in hashSet)
			{
				result += item.Length + 1;
			}
			return result;
		}
	}
}
