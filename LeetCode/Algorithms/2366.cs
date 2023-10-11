namespace LeetCode.Algorithms;

// HARD
internal class _2366
{
	public static long MinimumReplacement(int[] nums)
	{
		var result = 0L;
		for (var i = nums.Length - 2; i >= 0; i--)
		{
			if (nums[i] <= nums[i + 1])
			{
				continue;
			}

			var numElements = (long)(nums[i] + nums[i + 1] - 1) / nums[i + 1];
			result += numElements - 1;

			nums[i] /= (int)numElements;
		}

		return result;
	}
}