using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _152
	{
		public static int MaxProduct(int[] nums)
		{
			var result = nums[0];
			var iMax = result;
			var iMin = result;
			for (var i = 1; i < nums.Length; i++)
			{
				if (nums[i] < 0)
				{
					var temp = iMax;
					iMax = iMin;
					iMin = temp;
				}

				iMax = Math.Max(nums[i], iMax * nums[i]);
				iMin = Math.Min(nums[i], iMin * nums[i]);

				result = Math.Max(result, iMax);
			}
			return result;
		}
	}
}
