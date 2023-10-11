using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _456
	{
		public static bool Find132pattern(int[] nums)
		{
			if (nums.Length < 3)
			{
				return false;
			}

			var min = new int[nums.Length];
			min[0] = nums[0];
			for (var i = 1; i < nums.Length; i++)
			{
				min[i] = Math.Min(min[i - 1], nums[i]);
			}

			var k = nums.Length;
			for (var i = nums.Length - 1; i >= 0; i--)
			{
				if (nums[i] > min[i])
				{
					while (k < nums.Length && nums[k] <= min[i])
					{
						k++;
					}

					if (k < nums.Length && nums[k] < nums[i])
					{
						return true;
					}

					nums[--k] = nums[i];
				}
			}
			return false;
		}
	}
}
