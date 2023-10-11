using System;

namespace LeetCode.Algorithms;

// EASY
internal class _1544
{
	public static string MakeGood(string s)
	{
		var end = 0;
		var chars = s.ToCharArray();
		for (var i = 0; i < chars.Length; i++)
		{
			if (end > 0 && Math.Abs(chars[i] - chars[end - 1]) == 32)
			{
				end--;
			}
			else
			{
				chars[end] = chars[i];
				end++;
			}
		}

		return new string(chars[..end]);
	}
}
