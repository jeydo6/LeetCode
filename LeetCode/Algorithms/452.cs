using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _452
	{
		public static int FindMinArrowShots(int[][] points)
		{
			if (points.Length == 0)
			{
				return 0;
			}
			Array.Sort(points, (a, b) => a[1].CompareTo(b[1]));
			var position = points[0][1];
			var count = 1;
			for (var i = 1; i < points.Length; i++)
			{
				if (position >= points[i][0])
				{
					continue;
				}
				count++;
				position = points[i][1];
			}
			return count;
		}
	}
}
