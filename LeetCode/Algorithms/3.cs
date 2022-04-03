using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _3
	{
		public static int LengthOfLongestSubstring(string s)
		{
			var result = 0;

			var i = 0;
			var dict = new Dictionary<char, int>();
			for (var j = 0; j < s.Length; j++)
			{
				if (dict.ContainsKey(s[j]))
				{
					i = Math.Max(i, dict[s[j]] + 1);
				}

				result = Math.Max(result, j - i + 1);
				dict[s[j]] = j;
			}

			return result;
		}
	}
}
