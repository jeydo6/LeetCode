namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _540
	{
		public static int SingleNonDuplicate(int[] nums)
		{
			var left = 0;
			var right = nums.Length - 1;
			while (left < right)
			{
				var mid = (left + right) / 2;
				if ((mid % 2 == 0 && nums[mid] == nums[mid + 1]) || (mid % 2 == 1 && nums[mid] == nums[mid - 1]))
				{
					left = mid + 1;
				}
				else
				{
					right = mid;
				}
			}
			return nums[left];
		}
	}
}
