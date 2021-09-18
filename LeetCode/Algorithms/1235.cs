using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	class _1235
	{
		public static int JobScheduling(int[] startTime, int[] endTime, int[] profit)
		{
			var keys = new List<int>
			{
				0
			};
			var values = new List<int>
			{
				0
			};

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
				if (currentValue > values[^1])
				{
					keys.Add(job[1]);
					values.Add(currentValue);
				}
			}
			return values[^1];
		}
	}

	//public class Solution
	//{

	//	readonly struct Job
	//	{
	//		public Job(int start, int end, int profit)
	//		{
	//			Start = start;
	//			End = end;
	//			Profit = profit;
	//		}

	//		public int Start { get; }

	//		public int End { get; }

	//		public int Profit { get; }
	//	}


	//	public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
	//	{

	//		Job[] jobs = new Job[startTime.Length];
	//		for (int i = 0; i < startTime.Length; i++)
	//		{
	//			jobs[i] = new Job(startTime[i], endTime[i], profit[i]);
	//		}

	//		Array.Sort(jobs, (x, y) => x.End - y.End);

	//		int[] d = new int[jobs.Length];
	//		d[0] = jobs[0].Profit;

	//		for (int i = 1; i < jobs.Length; i++)
	//		{
	//			d[i] = Math.Max(d[i - 1], jobs[i].Profit);
	//			for (int j = i - 1; j >= 0; j--)
	//			{
	//				// Jobs scheduled before current start date
	//				if (jobs[i].Start >= jobs[j].End)
	//				{
	//					d[i] = Math.Max(d[i], jobs[i].Profit + d[j]);
	//					break;
	//				}
	//			}
	//		}

	//		int max = d.Max();
	//		return max;

	//	}
	//}
}
