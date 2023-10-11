namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _413
	{
		public static int NumberOfArithmeticSlices(int[] nums)
		{
			var count = 0;
			var sum = 0;
			for (var i = 2; i < nums.Length; i++)
			{
				if (nums[i] - nums[i - 1] == nums[i - 1] - nums[i - 2])
				{
					count++;
				}
				else
				{
					sum += (count + 1) * (count) / 2;
					count = 0;
				}
			}
			return sum += count * (count + 1) / 2;
		}
	}
}
