using System;

namespace LeetCode.Algorithms;

// HARD
internal class _1458
{
	public static int MaxDotProduct(int[] nums1, int[] nums2)
	{
		var firstMax = int.MinValue;
		var firstMin = int.MaxValue;
		for (var i = 0; i < nums1.Length; i++)
		{
			firstMax = Math.Max(firstMax, nums1[i]);
			firstMin = Math.Min(firstMin, nums1[i]);
		}

		var secondMax = int.MinValue;
		var secondMin = int.MaxValue;
		for (var i = 0; i < nums2.Length; i++)
		{
			secondMax = Math.Max(secondMax, nums2[i]);
			secondMin = Math.Min(secondMin, nums2[i]);
		}

		if (firstMax < 0 && secondMin > 0)
		{
			return firstMax * secondMin;
		}

		if (firstMin > 0 && secondMax < 0)
		{
			return firstMin * secondMax;
		}

		var m = nums2.Length + 1;
		var dp = new int[m];
		var prevDp = new int[m];

		for (var i = nums1.Length - 1; i >= 0; i--)
		{
			dp = new int[m];
			for (var j = nums2.Length - 1; j >= 0; j--)
			{
				var curr = nums1[i] * nums2[j] + prevDp[j + 1];
				dp[j] = Math.Max(curr, Math.Max(prevDp[j], dp[j + 1]));
			}

			prevDp = dp;
		}

		return dp[0];
	}
}
