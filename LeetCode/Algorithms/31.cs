namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _31
	{
		public static void NextPermutation(int[] nums)
		{
			var i = nums.Length - 2;
			while (i >= 0 && nums[i + 1] <= nums[i])
			{
				i--;
			}

			if (i >= 0)
			{
				var j = nums.Length - 1;
				while (nums[j] <= nums[i])
				{
					j--;
				}
				(nums[i], nums[j]) = (nums[j], nums[i]);
			}
			Reverse(nums, i + 1);
		}

		private static void Reverse(int[] nums, int start)
		{
			var i = start;
			var j = nums.Length - 1;
			while (i < j)
			{
				(nums[i], nums[j]) = (nums[j], nums[i]);
				i++;
				j--;
			}
		}
	}
}
