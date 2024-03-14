namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _930
{
	public static int NumSubarraysWithSum(int[] nums, int goal)
	{
		var start = 0;
		var prefixZeros = 0;
		var currentSum = 0;
		var totalCount = 0;

		for (var end = 0; end < nums.Length; end++)
		{
			currentSum += nums[end];
			while (start < end && (nums[start] == 0 || currentSum > goal))
			{
				if (nums[start] == 1)
				{
					prefixZeros = 0;
				}
				else
				{
					prefixZeros++;
				}

				currentSum -= nums[start];
				start++;
			}

			if (currentSum == goal)
			{
				totalCount += 1 + prefixZeros;
			}
		}

		return totalCount;
	}
}