namespace LeetCode.Algorithms;

// MEDIUM
internal class _540
{
	public static int SingleNonDuplicate(int[] nums)
	{
		var lo = 0;
		var hi = nums.Length - 1;
		while (lo < hi)
		{
			var mid = (lo + hi) / 2;
			if ((mid % 2 == 0 && nums[mid] == nums[mid + 1]) || (mid % 2 == 1 && nums[mid] == nums[mid - 1]))
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
