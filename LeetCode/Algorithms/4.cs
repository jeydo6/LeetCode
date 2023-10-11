using System;

namespace LeetCode.Algorithms;

internal class _4
{
	public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
	{
		if (nums1.Length > nums2.Length)
		{
			(nums1, nums2) = (nums2, nums1);
		}

		var n = nums1.Length;
		var m = nums2.Length;

		var lo = 0;
		var hi = n;
        
		while (lo <= hi)
		{
			var partition1 = lo + (hi - lo) / 2;
			var partition2 = (n + m + 1) / 2 - partition1;
            
			var maxLo1 = partition1 == 0 ? int.MinValue : nums1[partition1 - 1];
			var minHi1 = partition1 == n ? int.MaxValue : nums1[partition1];
			var maxLo2 = partition2 == 0 ? int.MinValue : nums2[partition2 - 1];
			var minHi2 = partition2 == m ? int.MaxValue : nums2[partition2];
            
			if (maxLo1 <= minHi2 && maxLo2 <= minHi1)
			{
				if ((n + m) % 2 == 0) {
					return (Math.Max(maxLo1, maxLo2) + Math.Min(minHi1, minHi2)) / 2.0;
				}
				return Math.Max(maxLo1, maxLo2);
			}
			
			if (maxLo1 > minHi2)
			{
				hi = partition1 - 1;
			} else
			{
				lo = partition1 + 1;
			}
		}

		return 0.0;
	}
}