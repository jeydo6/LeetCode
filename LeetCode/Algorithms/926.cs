using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _926
{
	public static int MinFlipsMonoIncr(string s)
	{
		var p = new int[s.Length + 1];
		for (var i = 0; i < s.Length; i++)
		{
			p[i + 1] = p[i] + (s[i] == '1' ? 1 : 0);
		}

		var result = int.MaxValue;
		for (var i = 0; i < p.Length; i++)
		{
			result = Math.Min(result, p[i] + p.Length - i - 1 - (p[^1] - p[i]));
		}
		return result;
	}
}
