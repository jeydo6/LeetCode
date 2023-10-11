using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _438
{
	public static IList<int> FindAnagrams(string s, string p)
	{
		var result = new List<int>();
		if (p.Length > s.Length)
		{
			return result;
		}

		var dict = new Dictionary<char, int>();
		for (var i = 0; i < p.Length; i++)
		{
			if (!dict.ContainsKey(p[i]))
			{
				dict[p[i]] = 0;
			}
			dict[p[i]]++;
		}
		var count = dict.Count;

		var begin = 0;
		var end = 0;

		while (end < s.Length)
		{
			if (dict.ContainsKey(s[end]))
			{
				dict[s[end]]--;
				if (dict[s[end]] == 0)
				{
					count--;
				}
			}
			end++;

			while (count == 0)
			{
				if (dict.ContainsKey(s[begin]))
				{
					dict[s[begin]]++;
					if (dict[s[begin]] > 0)
					{
						count++;
					}
				}
				if (end - begin == p.Length)
				{
					result.Add(begin);
				}
				begin++;
			}
		}
		return result;
	}
}
