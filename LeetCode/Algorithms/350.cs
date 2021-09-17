using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	internal class _350
	{
		public int[] Intersect(int[] nums1, int[] nums2)
		{
			var dict = new Dictionary<int, int>();
			for (var i = 0; i < nums1.Length; i++)
			{
				if (dict.ContainsKey(nums1[i]))
				{
					dict[nums1[i]]++;
				}
				else
				{
					dict[nums1[i]] = 1;
				}
			}

			var list = new List<int>();
			for (var i = 0; i < nums2.Length; i++)
			{
				if (dict.ContainsKey(nums2[i]) && dict[nums2[i]] > 0)
				{
					list.Add(nums2[i]);

					dict[nums2[i]]--;
				}
			}

			var result = new int[list.Count];
			list.CopyTo(result);
			return result;
		}
	}
}
