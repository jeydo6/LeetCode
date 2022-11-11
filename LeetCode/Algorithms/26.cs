namespace LeetCode.Algorithms;

// EASY
internal class _26
{
	public static int RemoveDuplicates(int[] nums)
	{
		var result = 1;
		for (var i = 1; i < nums.Length; i++)
		{
			if (nums[i - 1] != nums[i])
			{
				nums[result] = nums[i];
				result++;
			}
		}
		return result;
	}
}
