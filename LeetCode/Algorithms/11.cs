using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _11
	{
		public static int MaxArea(int[] height)
		{
			var result = 0;
			var lo = 0;
			var hi = height.Length - 1;
			while (lo < hi)
			{
				result = Math.Max(
					result,
					Math.Min(height[lo], height[hi]) * (hi - lo)
				);

				if (height[lo] < height[hi])
				{
					lo++;
				}
				else
				{
					hi--;
				}
			}
			return result;
		}
	}
}
