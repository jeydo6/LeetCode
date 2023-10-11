using System;

namespace LeetCode.Algorithms
{
	internal class _55
	{
		public static bool CanJump(int[] nums)
		{
			var reach = 0;
			for (var i = 0; i <= reach; i++)
			{
				reach = Math.Max(reach, i + nums[i]);

				if (reach >= nums.Length - 1)
				{
					return true;
				}
			}

			return false;
		}
	}
}
