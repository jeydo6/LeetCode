using System;
using System.Collections.Generic;

namespace Leetcode.Algorithms
{
	internal class _1122
	{
		public static int[] RelativeSortArray(int[] arr1, int[] arr2)
		{
			var dict2 = new Dictionary<int, int>();
			for (int i = 0; i < arr2.Length; i++)
			{
				dict2[arr2[i]] = i;
			}

			Array.Sort(arr1, (item1, item2) =>
			{
				if (dict2.ContainsKey(item1) && dict2.ContainsKey(item2))
				{
					return dict2[item1].CompareTo(dict2[item2]);
				}
				else if (dict2.ContainsKey(item1))
				{
					return -1;
				}
				else if (dict2.ContainsKey(item2))
				{
					return 1;
				}
				else
				{
					return item1.CompareTo(item2);
				}
			});

			return arr1;
		}
	}
}
