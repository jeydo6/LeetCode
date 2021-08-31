namespace Leetcode.Algorithms
{
	public class _977
	{
		public static int[] SortedSquares(int[] nums)
		{
			var result = new int[nums.Length];
			var lo = 0;
			var hi = nums.Length - 1;
			for (var p = nums.Length - 1; p >= 0; p--)
			{
				if (Math.Abs(nums[lo]) > Math.Abs(nums[hi]))
				{
					result[p] = nums[lo] * nums[lo];
					lo++;
				}
				else
				{
					result[p] = nums[hi] * nums[hi];
					hi--;
				}
			}
			return result;
		}
	}
}