namespace Leetcode.Algorithms;

// EASY
internal class _985
{
	public static int[] SumEvenAfterQueries(int[] nums, int[][] queries)
	{
		var result = new int[queries.Length];

		var sum = 0;
		foreach (var num in nums)
		{
			if (num % 2 == 0)
			{
				sum += num;
			}
		}

		for (var i = 0; i < queries.Length; i++)
		{
			var index = queries[i][1];
			var val = queries[i][0];

			if (nums[index] % 2 == 0)
			{
				sum -= nums[index];
			}

			nums[index] += val;

			if (nums[index] % 2 == 0)
			{
				sum += nums[index];
			}

			result[i] = sum;
		}
		return result;
	}
}
