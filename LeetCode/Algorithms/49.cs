using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _49
{
	public static IList<IList<string>> GroupAnagrams(string[] strs)
	{
		var dict = new Dictionary<string, IList<string>>();
		foreach (var str in strs)
		{
			var chars = str.ToCharArray();
			Array.Sort(chars);
			var key = new string(chars);

			if (!dict.ContainsKey(key))
			{
				dict[key] = new List<string>();
			}
			dict[key].Add(str);
		}
		
		var result = new List<IList<string>>();
		foreach (var value in dict.Values)
		{
			result.Add(value);
		}
		return result;
	}
}
