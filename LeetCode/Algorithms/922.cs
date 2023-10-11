namespace Leetcode.Algorithms
{
	internal class _922
	{
		public static int[] SortArrayByParityII(int[] nums)
		{
			var i = 0;
			var j = 1;
			var n = nums.Length;
			while (i < n && j < n)
			{
				while (i < n && nums[i] % 2 == 0)
				{
					i += 2;
				}
				while (j < n && nums[j] % 2 == 1)
				{
					j += 2;
				}
				if (i < n && j < n)
				{
					var temp = nums[i];
					nums[i] = nums[j];
					nums[j] = temp;
				}
			}
			return nums;
		}
	}
}
