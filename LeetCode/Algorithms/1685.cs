namespace LeetCode.Algorithms;

// MEDIUM
internal class _1685
{
	public static int[] GetSumAbsoluteDifferences(int[] nums)
	{
		var totalSum = 0;
		for (var i = 0; i < nums.Length; i++)
		{
			totalSum += nums[i];
		}

		var result = new int[nums.Length];
		var leftSum = 0;
		for (var i = 0; i < nums.Length; i++)
		{
			var rightSum = totalSum - leftSum - nums[i];
			var rightCount = nums.Length - 1 - i;

			var leftTotal = i * nums[i] - leftSum;
			var rightTotal = rightSum - rightCount * nums[i];

			result[i] = leftTotal + rightTotal;
			leftSum += nums[i];
		}

		return result;
	}
}