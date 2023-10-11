using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _159
{
	public static int LengthOfLongestSubstringTwoDistinct(string s)
	{
		if (s.Length < 3)
		{
			return s.Length;
		}

		var result = 2;

		var dict = new Dictionary<char, int>();
		
		var left = 0;
		var right = 0;
		while (right < s.Length)
		{
			dict[s[right]] = right++;

			if (dict.Count == 3)
			{
				var index = GetMinValue(dict.Values);
				dict.Remove(s[index]);

				left = index + 1;
			}

			result = Math.Max(result, right - left);
		}
		return result;
	}

	private static int GetMinValue(IEnumerable<int> values)
	{
		var result = int.MaxValue;
		foreach (var value in values)
		{
			if (value < result)
			{
				result = value;
			}
		}

		return result;
	}
}
