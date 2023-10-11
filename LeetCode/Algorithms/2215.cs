using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal class _2215
{
	public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
	{
		return new List<IList<int>>
		{
			Except(nums1, nums2),
			Except(nums2, nums1)
		};
	}

	private static IList<int> Except(int[] nums1, int[] nums2)
	{
		var set1 = new HashSet<int>(nums1);
		var set2 = new HashSet<int>(nums2);

		set1.ExceptWith(set2);

		return new List<int>(set1);
	}
}
