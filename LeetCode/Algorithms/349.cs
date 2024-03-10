using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal sealed class _349
{
	public static int[] Intersection(int[] nums1, int[] nums2)
	{
		var seen = new HashSet<int>();
		for (var i = 0; i < nums1.Length; i++)
		{
			seen.Add(nums1[i]);
		}

		var result = new List<int>();
		for (var i = 0; i < nums2.Length; i++)
		{
			if (!seen.Contains(nums2[i])) continue;

			result.Add(nums2[i]);
			seen.Remove(nums2[i]);
		}

		return result.ToArray();
	}
}