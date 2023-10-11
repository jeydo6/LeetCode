namespace LeetCode.Algorithms;

internal class _1470
{
	public static int[] Shuffle(int[] nums, int n)
	{
		var result = new int[n * 2];
		for (var i = 0; i < n; i++)
		{
			result[2 * i] = nums[i];
			result[2 * i + 1] = nums[n + i];
		}
		return result;
	}
}
