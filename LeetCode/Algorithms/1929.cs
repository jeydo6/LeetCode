namespace LeetCode.Algorithms
{
	// EASY
	internal class _1929
	{
		public static int[] GetConcatenation(int[] nums)
		{
			var result = new int[2 * nums.Length];
			for (var i = 0; i < nums.Length; i++)
			{
				result[i] = nums[i];
				result[i + nums.Length] = nums[i];
			}
			return result;
		}
	}
}
