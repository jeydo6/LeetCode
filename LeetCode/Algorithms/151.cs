﻿using System.Text;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _151
{
	public static string ReverseWords(string s)
	{
		var result = new StringBuilder(s.Length);
		for (var i = s.Length - 1; i >= 0; i--)
		{
			var current = "";
			while (i >= 0 && s[i] != ' ')
			{
				current = s[i] + current;
				i--;
			}

			if (current.Length > 0)
			{
				result.Append((result.Length == 0 ? "" : " ") + current);
			}
		}
		return result.ToString();
	}
}
