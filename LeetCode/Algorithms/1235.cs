using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _1235
	{
		public static int JobScheduling(int[] startTime, int[] endTime, int[] profit)
		{
			var keys = new List<int> { 0 };
			var values = new List<int> { 0 };

			var jobs = new int[startTime.Length][];
			for (var i = 0; i < startTime.Length; i++)
			{
				jobs[i] = new int[3] { startTime[i], endTime[i], profit[i] };
			}

			Array.Sort(jobs, (a, b) => a[1] - b[1]);

			foreach (var job in jobs)
			{
				var prevKey = keys.BinarySearch(job[0] + 1);
				if (prevKey < 0)
				{
					prevKey = ~prevKey;
				}

				prevKey--;

				var currentValue = values[prevKey] + job[2];
				if (currentValue <= values[^1])
				{
					continue;
				}

				keys.Add(job[1]);
				values.Add(currentValue);
			}

			return values[^1];
		}
	}
}
