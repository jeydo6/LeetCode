using System.Collections.Generic;

namespace Leetcode.Algorithms
{
	public class _1207
	{
		public static bool UniqueOccurrences(int[] arr)
		{
			var dict = new Dictionary<int, int>();
			foreach (var item in arr)
			{
				if (dict.ContainsKey(item))
				{
					dict[item]++;
				}
				else
				{
					dict[item] = 1;
				}
			}

			var hashSet = new HashSet<int>();
			foreach (var item in dict.Values)
			{
				if (hashSet.Contains(item))
				{
					return false;
				}
				hashSet.Add(item);
			}
			return true;
		}
	}
}
