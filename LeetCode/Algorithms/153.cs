namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _153
	{
		public static int FindMin(int[] nums)
		{
			var lo = 0;
			var hi = nums.Length - 1;
			while (lo < hi)
			{
				var mid = (lo + hi) / 2;
				if (nums[mid] < nums[hi])
				{
					hi = mid;
				}
				else
				{
					lo = mid + 1;
				}
			}
			return nums[lo];
		}
	}
}
