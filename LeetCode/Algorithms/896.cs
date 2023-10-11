namespace LeetCode.Algorithms;

// EASY
internal class _896
{
	public static bool IsMonotonic(int[] nums)
	{
		var inc = true;
		var dec = true;
		for (var i = 1; i < nums.Length; i++)
		{
			inc &= nums[i - 1] <= nums[i];
			dec &= nums[i - 1] >= nums[i];
		}
		return inc || dec;
	}
}
