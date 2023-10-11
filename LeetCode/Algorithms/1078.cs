using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	internal class _1078
	{
		public static string[] FindOcurrences(string text, string first, string second)
		{
			var result = new List<string>();
			var words = text.Split(' ');
			for (var i = 0; i < words.Length - 2; i++)
			{
				if (words[i] == first && words[i + 1] == second)
				{
					result.Add(words[i + 2]);
				}
			}
			return result.ToArray();
		}
	}
}
