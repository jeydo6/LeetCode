using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal class _734
{
	public static bool AreSentencesSimilar(string[] sentence1, string[] sentence2, IList<IList<string>> similarPairs)
	{
		if (sentence1.Length != sentence2.Length)
		{
			return false;
		}

		var words = new Dictionary<string, ISet<string>>();
		foreach (var pair in similarPairs)
		{
			if (!words.ContainsKey(pair[0]))
			{
				words[pair[0]] = new HashSet<string>();
			}
			words[pair[0]].Add(pair[1]);

			if (!words.ContainsKey(pair[1]))
			{
				words[pair[1]] = new HashSet<string>();
			}
			words[pair[1]].Add(pair[0]);
		}

		for (var i = 0; i < sentence1.Length; i++)
		{
			if (sentence1[i] == sentence2[i])
			{
				continue;
			}

			if (words.ContainsKey(sentence1[i]) && words[sentence1[i]].Contains(sentence2[i]))
			{
				continue;
			}

			return false;
		}

		return true;
	}
}
