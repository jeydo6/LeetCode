namespace LeetCode.Algorithms
{
	class _565
	{
		public static int ArrayNesting(int[] nums)
		{
			int maxSize = 0;
			for (var i = 0; i < nums.Length; i++)
			{
				var size = 0;
				for (var j = i; nums[j] >= 0; size++)
				{
					var temp = nums[j];
					nums[j] = -1;
					j = temp;
				}
				maxSize = Math.Max(maxSize, size);
			}
			return maxSize;
		}
	}
}
