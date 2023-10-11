using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2007
{
	public static int[] FindOriginalArray(int[] changed)
	{
		if (changed.Length % 2 == 1)
		{
			return Array.Empty<int>();
		}

		Array.Sort(changed);
		var frequencies = new Dictionary<int, int>();
		for (var i = 0; i < changed.Length; i++)
		{
			if (!frequencies.ContainsKey(changed[i]))
			{
				frequencies[changed[i]] = 0;
			}

			frequencies[changed[i]]++;
		}

		var original = new int[changed.Length / 2];
		var index = 0;
		for (var i = 0; i < changed.Length; i++)
		{
			if (frequencies[changed[i]] > 0)
			{
				frequencies[changed[i]]--;
				var twiceNum = changed[i] * 2;

				if (frequencies.ContainsKey(twiceNum) && frequencies[twiceNum] > 0)
				{
					frequencies[twiceNum]--;
					original[index++] = changed[i];
				}
				else
				{
					return Array.Empty<int>();
				}
			}
		}

		return original;
	}
}
