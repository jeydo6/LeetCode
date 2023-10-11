using System;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _84
	{
		public static int LargestRectangleArea(int[] heights)
		{
			if (heights == null || heights.Length == 0)
			{
				return 0;
			}

			var lessFromLeft = new int[heights.Length];
			var lessFromRight = new int[heights.Length];
			lessFromRight[^1] = heights.Length;
			lessFromLeft[0] = -1;

			for (var i = 1; i < heights.Length; i++)
			{
				var p = i - 1;

				while (p >= 0 && heights[p] >= heights[i])
				{
					p = lessFromLeft[p];
				}
				lessFromLeft[i] = p;
			}

			for (var i = heights.Length - 2; i >= 0; i--)
			{
				var p = i + 1;

				while (p < heights.Length && heights[p] >= heights[i])
				{
					p = lessFromRight[p];
				}
				lessFromRight[i] = p;
			}

			var max = 0;
			for (var i = 0; i < heights.Length; i++)
			{
				max = Math.Max(max, heights[i] * (lessFromRight[i] - lessFromLeft[i] - 1));
			}
			return max;
		}
	}
}
