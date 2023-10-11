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
		for (var i = 0; i < (2 * k + 1); i++)
		{
			sum += nums[i];
		}
		result[k] = (int)(sum / (2 * k + 1));

		for (var i = 2 * k + 1; i < result.Length; i++)
		{
			sum -= nums[i - (2 * k + 1)] - nums[i];
			result[i - k] = (int)(sum / (2 * k + 1));
		}

		return result;
	}
}
