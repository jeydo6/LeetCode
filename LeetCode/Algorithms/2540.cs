namespace LeetCode.Algorithms;

// EASY
internal sealed class _2540
{
	public static int GetCommon(int[] nums1, int[] nums2)
	{
		var p1 = 0;
		var p2 = 0;

		while (p1 < nums1.Length && p2 < nums2.Length)
		{
			if (nums1[p1] < nums2[p2]) p1++;
			else if (nums1[p1] > nums2[p2]) p2++;
			else return nums1[p1];
		}

		return -1;
	}
}