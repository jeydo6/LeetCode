namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _713
{
	public static int NumSubarrayProductLessThanK(int[] nums, int k)
	{
		if (k <= 1) return 0;

		var totalCount = 0;
		var product = 1;

		var lo = 0;
		var hi = 0;
		while (hi < nums.Length)
		{
			product *= nums[hi];

			while (product >= k)
			{
				product /= nums[lo++];
			}

			totalCount += hi - lo + 1;
			hi++;
		}

		return totalCount;
	}
}