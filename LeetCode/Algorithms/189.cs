namespace LeetCode.Algorithms
{
	class _189
	{
		public static void Rotate(int[] nums, int k)
		{
			k %= nums.Length;
			Reverse(nums, 0, nums.Length - 1);
			Reverse(nums, 0, k - 1);
			Reverse(nums, k, nums.Length - 1);
		}

		private static void Reverse(int[] nums, int start, int end)
		{
			while (start < end)
			{
				var temp = nums[start];
				nums[start] = nums[end];
				nums[end] = temp;

				start++;
				end--;
			}
		}
	}
}
