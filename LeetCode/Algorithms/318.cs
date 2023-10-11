using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _318
	{
		public static int MaxProduct(string[] words)
		{
			var dict = new Dictionary<int, int>();

			for (var i = 0; i < words.Length; i++)
			{
				var bitMask = 0;
				for (var j = 0; j < words[i].Length; j++)
				{
					bitMask |= 1 << (words[i][j] - 'a');
				}

				if (!dict.ContainsKey(bitMask))
				{
					dict[bitMask] = 0;
				}

				dict[bitMask] = Math.Max(dict[bitMask], words[i].Length);
			}

			var result = 0;
			foreach (var key1 in dict.Keys)
			{
				foreach (var key2 in dict.Keys)
				{
					if ((key1 & key2) == 0)
					{
						result = Math.Max(result, dict[key1] * dict[key2]);
					}
				}
			}
			return result;
		}
	}
}
