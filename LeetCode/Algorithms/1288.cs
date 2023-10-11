using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1288
	{
		public static int RemoveCoveredIntervals(int[][] intervals)
		{
			var result = 0;
			var left = -1;
			var right = -1;
			Array.Sort(intervals, (a, b) => a[0] - b[0]);
			for (var i = 0; i < intervals.Length; i++)
			{
				if (intervals[i][0] > left && intervals[i][1] > right)
				{
					left = intervals[i][0];
					result++;
				}
				right = Math.Max(right, intervals[i][1]);
			}
			return result;
		}
	}
}
