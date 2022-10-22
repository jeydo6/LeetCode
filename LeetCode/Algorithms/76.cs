using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _76
{
	public static string MinWindow(string s, string t)
	{
		if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length < t.Length)
		{
			return string.Empty;
		}

		var dict = new Dictionary<char, int>();
		foreach (var ch in t)
		{
			if (!dict.ContainsKey(ch))
			{
				dict[ch] = 0;
			}
			dict[ch]++;
		}

		var left = 0;
		var minLeft = 0;
		var minLength = s.Length + 1;
		var count = 0;
		for (var right = 0; right < s.Length; right++)
		{
			if (dict.ContainsKey(s[right]))
			{
				dict[s[right]]--;
				if (dict[s[right]] >= 0)
				{
					count++;
				}
				while (count == t.Length)
				{
					if (right - left + 1 < minLength)
					{
						minLeft = left;
						minLength = right - left + 1;
					}
					if (dict.ContainsKey(s[left]))
					{
						dict[s[left]]++;
						if (dict[s[left]] > 0)
						{
							count--;
						}
					}
					left++;
				}
			}
		}
		if (minLength > s.Length)
		{
			return string.Empty;
		}

		return s[minLeft..(minLeft + minLength)];
	}
}
