namespace LeetCode.Algorithms;

// MEDIUM
internal class _2090
{
	public static int[] GetAverages(int[] nums, int k)
	{
		if (k == 0)
		{
			return nums;
		}

		var result = new int[nums.Length];
		for (var i = 0; i < result.Length; i++)
		{
			result[i] = -1;
		}

		if (2 * k + 1 > result.Length)
		{
			return result;
		}

		var sum = 0L;
		for (int i = 0; i < (2 * k + 1); ++i)
		{
			sum += nums[i];
		}
		result[k] = (int)(sum / (2 * k + 1));

		// Iterate on rest indices which have at least 'k' elements 
		// on its left and right sides.
		for (int i = (2 * k + 1); i < n; ++i)
		{
			// We remove the discarded element and add the new element to get current window sum.
			// 'i' is the index of new inserted element, and
			// 'i - (window size)' is the index of the last removed element.
			sum = sum - nums[i - (2 * k + 1)] + nums[i];
			result[i - k] = (int)(sum / (2 * k + 1));
		}

		return result;
	}
}
