using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _435
{
	public int EraseOverlapIntervals(int[][] intervals)
	{
		var result = 0;
		var k = int.MinValue;

		Array.Sort(intervals, (a, b) => a[1] - b[1]);
		for (var i = 0; i < intervals.Length; i++)
		{
			var x = intervals[i][0];
			var y = intervals[i][1];
			if (x >= k)
			{
				k = y;
			}
			else
			{
				result++;
			}
		}

		return result;
	}
}