using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _890
	{
		public static IList<string> FindAndReplacePattern(string[] words, string pattern)
		{
			var result = new List<string>();
			for (var i = 0; i < words.Length; i++)
			{
				if (IsMatch(words[i], pattern))
				{
					result.Add(words[i]);
				}
			}

			return result;
		}

		private static bool IsMatch(string word, string pattern)
		{
			var dict = new Dictionary<char, char>();
			for (var i = 0; i < word.Length; i++)
			{
				if (!dict.ContainsKey(word[i]))
				{
					dict[word[i]] = pattern[i];
				}
				
				if(dict[word[i]] != pattern[i])
				{
					return false;
				}
			}

			var seen = new bool[26];
			foreach (var p in dict.Values)
			{
				if (seen[p - 'a'])
				{
					return false;
				}
				seen[p - 'a'] = true;
			}
			return true;
		}
	}
}
