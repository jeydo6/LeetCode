using System;

namespace LeetCode.Algorithms
{
	class _1266
	{
		public static int MinTimeToVisitAllPoints(int[][] points)
		{
			var result = 0;
			for (var i = 1; i < points.Length; i++)
			{
				var x = Math.Abs(points[i][0] - points[i - 1][0]);
				var y = Math.Abs(points[i][1] - points[i - 1][1]);

				result += Math.Min(x, y) + Math.Abs(x - y);
			}
			return result;
		}
	}
}
