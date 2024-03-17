using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _57
{
	public static int[][] Insert(int[][] intervals, int[] newInterval)
	{
		var list = new List<int[]>(intervals);
		var index = GetInsertPosition(intervals, newInterval);

		if (index != intervals.Length)
		{
			list.Insert(index, newInterval);
		}
		else
		{
			list.Add(newInterval);
		}

		var result = new List<int[]>();

		for (var i = 0; i < list.Count; i++)
		{
			var currentInterval = new int[] { list[i][0], list[i][1] };
			while (i < list.Count && IsIntervalsOverlap(currentInterval, list[i]))
			{
				currentInterval = MergeIntervals(currentInterval, list[i]);
				i++;
			}
			i--;
			result.Add(currentInterval);
		}

		return result.ToArray();
	}

	private static int[] MergeIntervals(int[] a, int[] b)
	{
		return new int[]
		{
			Math.Min(a[0], b[0]),
			Math.Max(a[1], b[1])
		};
	}

	private static bool IsIntervalsOverlap(int[] a, int[] b)
	{
		return Math.Min(a[1], b[1]) - Math.Max(a[0], b[0]) >= 0;
	}

	private static int GetInsertPosition(int[][] intervals, int[] newInterval)
	{
		if (intervals.Length == 0)
		{
			return 0;
		}

		var result = intervals.Length;

		var lo = 0;
		var hi = intervals.Length - 1;
		while (lo <= hi)
		{
			var mid = lo + (hi - lo) / 2;

			if (intervals[mid][0] > newInterval[0])
			{
				result = mid;
				hi = mid - 1;
			}
			else
			{
				lo = mid + 1;
			}
		}

		return result;
	}

}
