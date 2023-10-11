namespace LeetCode.Algorithms;

// MEDIUM
internal class _280
{
	public static void WiggleSort(int[] nums)
	{
		for (var i = 0; i < nums.Length - 1; i++)
		{
			if (
				((i % 2 == 0) && nums[i] > nums[i + 1]) ||
				((i % 2 == 1) && nums[i] < nums[i + 1])
			)
			{
				(nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
			}
		}
	}
}
