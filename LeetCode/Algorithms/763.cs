using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _763
	{
		public static IList<int> PartitionLabels(string s)
		{
			var last = new int[26];
			for (var i = 0; i < s.Length; i++)
			{
				last[s[i] - 'a'] = i;
			}

			var j = 0;
			var anchor = 0;
			var result = new List<int>();
			for (var i = 0; i < s.Length; i++)
			{
				j = Math.Max(j, last[s[i] - 'a']);
				if (i == j)
				{
					result.Add(i - anchor + 1);
					anchor = i + 1;
				}
			}
			return result;
		}
	}
}
