namespace LeetCode.Algorithms;

// MEDIUM
internal class _718
{
	public static int FindLength(int[] nums1, int[] nums2)
	{
		var result = 0;
		var dp = new int[nums1.Length + 1][];
		for (var i = 0; i < dp.Length; i++)
		{
			dp[i] = new int[nums2.Length + 1];
		}

		for (var i = nums1.Length - 1; i >= 0; --i)
		{
			for (var j = nums2.Length - 1; j >= 0; --j)
			{
				if (nums1[i] == nums2[j])
				{
					dp[i][j] = dp[i + 1][j + 1] + 1;
					if (result < dp[i][j])
					{
						result = dp[i][j];
					}
				}
			}
		}
		return result;
	}
}
