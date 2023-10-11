namespace LeetCode.Algorithms
{
	// HARD
	internal class _154
	{
		public static int FindMin(int[] nums)
		{
			var lo = 0;
			var hi = nums.Length - 1;

			if (nums[lo] < nums[hi])
			{
				return nums[lo];
			}
        
			while (lo < hi)
			{
				var mid = lo + (hi - lo) / 2;
            
				if (nums[mid] > nums[hi])
				{
					lo = mid + 1;
				}
				else if (nums[mid] < nums[hi])
				{
					hi = mid;
				}
				else
				{
					hi--;
				}
			}
        
			return nums[hi];
		}
	}
}