using System;

namespace LeetCode.Algorithms
{
	class _42
	{
		public static int Trap(int[] height)
		{
			if (height == null || height.Length == 0)
			{
				return 0;
			}

			var length = height.Length;

			var leftMax = new int[length];
			leftMax[0] = height[0];
			for (var i = 1; i < length; i++)
			{
				leftMax[i] = Math.Max(height[i], leftMax[i - 1]);
			}

			var rightMax = new int[length];
			rightMax[length - 1] = height[length - 1];
			for (var i = length - 2; i >= 0; i--)
			{
				rightMax[i] = Math.Max(height[i], rightMax[i + 1]);
			}

			var result = 0;
			for (var i = 1; i < length - 1; i++)
			{
				result += Math.Min(leftMax[i], rightMax[i]) - height[i];
			}
			return result;
		}
	}
}
