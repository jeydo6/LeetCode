using System;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _696
	{
		public static int CountBinarySubstrings(string s)
		{
			var result = 0;
			var previous = 0;
			var current = 1;
			for (var i = 1; i < s.Length; i++)
			{
				if (s[i - 1] != s[i])
				{
					result += Math.Min(previous, current);
					previous = current;
					current = 1;
				}
				else
				{
					current++;
				}
			}
			return result + Math.Min(previous, current);
		}
	}
}
