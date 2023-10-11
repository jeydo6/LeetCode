namespace LeetCode.Algorithms
{
	// EASY
	internal class _905
	{
		public static int[] SortArrayByParity(int[] nums)
		{
			var lo = 0;
			var hi = nums.Length - 1;
			while (lo < hi)
			{
				if (nums[lo] % 2 > nums[hi] % 2)
				{
					(nums[lo], nums[hi]) = (nums[hi], nums[lo]);
				}

				if (nums[lo] % 2 == 0)
				{
					lo++;
				}
				if (nums[hi] % 2 == 1)
				{
					hi--;
				}
			}
			return nums;
		}
	}
}
