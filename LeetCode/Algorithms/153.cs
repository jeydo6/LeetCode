namespace LeetCode.Algorithms
{
	class _153
	{
		public static int FindMin(int[] nums)
		{
			var lo = 0;
			var hi = nums.Length - 1;
			while (lo < hi)
			{
				if (nums[lo] < nums[hi])
				{
					return nums[lo];
				}

				var mid = (lo + hi) / 2;

				if (nums[mid] >= nums[lo])
				{
					lo = mid + 1;
				}
				else
				{
					hi = mid;
				}
			}
			return nums[lo];
		}
	}
}
