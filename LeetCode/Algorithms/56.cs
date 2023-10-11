﻿using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _56
	{
		public static int[][] Merge(int[][] intervals)
		{
			if (intervals.Length <= 1)
			{
				return intervals;
			}

			Array.Sort(intervals, (i1, i2) => i1[0].CompareTo(i2[0]));

			var result = new List<int[]>();
			var newInterval = intervals[0];
			result.Add(newInterval);
			foreach (var interval in intervals)
			{
				if (interval[0] <= newInterval[1])
				{
					newInterval[1] = Math.Max(newInterval[1], interval[1]);
				}
				else
				{
					newInterval = interval;
					result.Add(newInterval);
				}
			}
			return result.ToArray();
		}
	}
}
