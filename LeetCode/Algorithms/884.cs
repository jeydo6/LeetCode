using System.Collections.Generic;

namespace Leetcode.Algorithms
{
	// EASY
	internal class _884
	{
		public static string[] UncommonFromSentences(string a, string b)
		{
			var dict = new Dictionary<string, int>();

			foreach (var word in a.Split(' '))
			{
				if (!dict.ContainsKey(word))
				{
					dict[word] = 1;
				}
				else
				{
					dict[word] = ++dict[word];
				}
			}

			foreach (string word in b.Split(' '))
			{
				if (!dict.ContainsKey(word))
				{
					dict[word] = 1;
				}
				else
				{
					dict[word] = ++dict[word];
				}
			}

			var result = new List<string>();

			foreach (var keyValue in dict)
			{
				if (keyValue.Value == 1)
				{
					result.Add(keyValue.Key);
				}
			}

			return result.ToArray();
		}
	}
}
