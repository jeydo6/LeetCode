using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1465
	{
		public static int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts)
		{
			Array.Sort(horizontalCuts);
			Array.Sort(verticalCuts);

			var n = horizontalCuts.Length;
			var m = verticalCuts.Length;

			long maxHeight = Math.Max(horizontalCuts[0], h - horizontalCuts[n - 1]);
			for (var i = 1; i < n; i++)
			{
				maxHeight = Math.Max(maxHeight, horizontalCuts[i] - horizontalCuts[i - 1]);
			}

			long maxWidth = Math.Max(verticalCuts[0], w - verticalCuts[m - 1]);
			for (var i = 1; i < m; i++)
			{
				maxWidth = Math.Max(maxWidth, verticalCuts[i] - verticalCuts[i - 1]);
			}

			return (int)(maxWidth * maxHeight % 1000000007);
		}
	}
}
