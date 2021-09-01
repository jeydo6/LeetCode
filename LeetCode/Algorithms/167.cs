namespace LeetCode.Algorithms
{
	class _167
	{
		public static int[] TwoSum(int[] nums, int target)
		{
			var lo = 0;
			var hi = nums.Length - 1;
			while (lo < hi)
			{
				var sum = nums[lo] + nums[hi];
				if (sum < target)
				{
					lo++;
				}
				else if (sum > target)
				{
					hi--;
				}
				else
				{
					return new int[2] { lo + 1, hi + 1 };
				}
			}
			return null;
		}
	}
}
