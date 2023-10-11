using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1035
{
	public static int MaxUncrossedLines(int[] nums1, int[] nums2)
	{
		var dp = new int[nums2.Length + 1];
		var dpPrev = new int[nums2.Length + 1];

		for (var i = 1; i <= nums1.Length; i++)
		{
			for (var j = 1; j <= nums2.Length; j++)
			{
				if (nums1[i - 1] == nums2[j - 1])
				{
					dp[j] = 1 + dpPrev[j - 1];
				}
				else
				{
					dp[j] = Math.Max(dp[j - 1], dpPrev[j]);
				}
			}

			for (var j = 0; j < dp.Length; j++)
			{
				dpPrev[j] = dp[j];
			}
		}

		return dp[^1];
	}
}
