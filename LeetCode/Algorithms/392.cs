using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal class _392
{
	public static bool IsSubsequence(string s, string t)
	{
		var list = new List<int>[256];
		for (var i = 0; i < t.Length; i++)
		{
			if (list[t[i]] == null)
			{
				list[t[i]] = new List<int>();
			}
			list[t[i]].Add(i);
		}

		var prev = 0;
		for (var i = 0; i < s.Length; i++)
		{
			if (list[s[i]] == null)
			{
				return false;
			}
			var j = list[s[i]].BinarySearch(prev);
			if (j < 0)
			{
				j = -j - 1;
			}
			if (j == list[s[i]].Count)
			{
				return false;
			}
			prev = list[s[i]][j] + 1;
		}
		return true;
	}
}
