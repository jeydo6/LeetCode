namespace LeetCode.Algorithms;

// MEDIUM
internal class _33
{
	public static int Search(int[] nums, int target)
	{
		var lo = 0;
		var hi = nums.Length - 1;
		while (lo <= hi)
		{
			var mid = lo + (hi - lo) / 2;
			if (nums[mid] == target)
			{
				return mid;
			}
			else if (nums[mid] < nums[hi])
			{
				if (target <= nums[hi] && target > nums[mid])
				{
					lo = mid + 1;
				}
				else
				{
					hi = mid - 1;
				}
			}
			else
			{
				if (target >= nums[lo] && target < nums[mid])
				{
					hi = mid - 1;
				}
				else
				{
					lo = mid + 1;
				}
			}
		}

		return -1;
	}
}