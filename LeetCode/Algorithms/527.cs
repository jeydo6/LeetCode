using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _527
	{
		public static IList<string> WordsAbbreviation(IList<string> words)
		{
			var result = new string[words.Count];
			var prefix = new int[words.Count];

			for (var i = 0; i < words.Count; i++)
			{
				result[i] = GetAbbreviation(words[i], 0);
			}

			for (var i = 0; i < words.Count; i++)
			{
				while (true)
				{
					var hashSet = new HashSet<int>();
					for (var j = i + 1; j < words.Count; j++)
					{
						if (result[i] == result[j])
						{
							hashSet.Add(j);
						}
					}

					if (hashSet.Count == 0)
					{
						break;
					}

					hashSet.Add(i);
					foreach (var j in hashSet)
					{
						result[j] = GetAbbreviation(words[j], ++prefix[j]);
					}
				}
			}

			return new List<string>(result);
		}

		private static string GetAbbreviation(string word, int i)
		{
			if (word.Length - i <= 3)
			{
				return word;
			}
			return word[..(i + 1)] + (word.Length - i - 2) + word[^1];
		}
	}
}
