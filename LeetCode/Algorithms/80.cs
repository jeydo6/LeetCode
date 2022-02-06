namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _80
	{
		public static int RemoveDuplicates(int[] nums)
		{
			var i = 0;
			foreach (var num in nums)
			{
				if (i < 2 || num > nums[i - 2])
				{
					nums[i++] = num;
				}
			}
			return i;
		}
	}
}
