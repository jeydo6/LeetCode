using System.Collections.Generic;

namespace LeetCode.Algorithms;

internal class _290
{
	// EASY
	public static bool WordPattern(string pattern, string s)
	{
		var words = s.Split(" ");
		if (words.Length != pattern.Length)
		{
			return false;
		}

		var pw = new Dictionary<char, string>();
		var wp = new Dictionary<string, char>();
		for (var i = 0; i < words.Length; i++)
		{
			var w = words[i];
			var p = pattern[i];

			if (pw.ContainsKey(p))
			{
				if (pw[p] != w)
				{
					return false;
				}
			}
			else
			{
				pw[p] = w;
			}

			if (wp.ContainsKey(w))
			{
				if (wp[w] != p)
				{
					return false;
				}
			}
			else
			{
				wp[w] = p;
			}
		}

		return true;
	}
}
