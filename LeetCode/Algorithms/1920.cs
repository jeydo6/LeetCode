namespace LeetCode.Algorithms
{
	// EASY
	internal class _1920
	{
		public static int[] BuildArray(int[] nums)
		{
			var result = new int[nums.Length];
			for (var i = 0; i < nums.Length; i++)
			{
				result[i] = nums[nums[i]];
			}
			return result;
		}
	}
}
