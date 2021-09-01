namespace LeetCode.Algorithms
{
	class _283
	{
		public static void MoveZeroes(int[] nums)
		{
			var j = 0;
			for (var i = 0; i < nums.Length; i++)
			{
				if (nums[i] != 0)
				{
					var temp = nums[i];
					nums[i] = nums[j];
					nums[j] = temp;

					j++;
				}
			}
		}
	}
}
