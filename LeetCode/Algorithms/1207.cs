using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal sealed class _1207
{
	public static bool UniqueOccurrences(int[] arr)
	{
		var dict = new Dictionary<int, int>();
		foreach (var item in arr)
		{
			if (!dict.TryAdd(item, 1))
			{
				dict[item]++;
			}
		}

		var hashSet = new HashSet<int>();
		foreach (var item in dict.Values)
		{
			if (!hashSet.Add(item))
			{
				return false;
			}
		}
		return true;
	}
}
