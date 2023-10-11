using System;

namespace LeetCode.Algorithms;

// HARD
internal class _1326
{
	public static int MinTaps(int n, int[] ranges)
	{
		var maxReach = new int[n + 1];
		for (var i = 0; i < ranges.Length; i++)
		{
			var start = Math.Max(0, i - ranges[i]);
			var end = Math.Min(n, i + ranges[i]);

			maxReach[start] = Math.Max(maxReach[start], end);
		}

		var result = 0;
		var currentEnd = 0;
		var nextEnd = 0;
		for (var i = 0; i < maxReach.Length; i++)
		{
			if (i > nextEnd)
			{
				return -1;
			}
			if (i > currentEnd)
			{
				result++;
				currentEnd = nextEnd;
			}
			nextEnd = Math.Max(nextEnd, maxReach[i]);
		}
		return result;
	}
}
