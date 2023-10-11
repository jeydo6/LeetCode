using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _451
	{
		public static string FrequencySort(string s)
		{
			var dict = new Dictionary<char, int>();
			foreach (var ch in s)
			{
				if (!dict.ContainsKey(ch))
				{
					dict[ch] = 0;
				}
				dict[ch]++;
			}
        
			var buckets = new string[s.Length + 1];
			foreach (var (key, value) in dict)
			{
				buckets[value] ??= "";
				buckets[value] += key;
			}
        
			var result = "";
			for (var i = buckets.Length - 1; i >= 0; i--)
			{
				if (buckets[i] == null)
				{
					continue;
				}

				for (var j = 0; j < buckets[i].Length; j++)
				{
					result += new string(buckets[i][j], i);
				}
			}
			return result;
		}
	}
}