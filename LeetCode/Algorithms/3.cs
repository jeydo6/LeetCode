using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	class _3
	{
		public static int LengthOfLongestSubstring(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return 0;
			}

			var dict = new Dictionary<char, int>();

			var j = 0;
			var max = 0;
			for (var i = 0; i < s.Length; i++)
			{
				if (dict.ContainsKey(s[i]))
				{
					j = Math.Max(j, dict[s[i]] + 1);
				}

				dict[s[i]] = i;
				max = Math.Max(max, i - j + 1);
			}
			return max;
		}
	}
}
