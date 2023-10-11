using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _502
{
	public static int FindMaximizedCapital(int k, int w, int[] profits, int[] capital)
	{
		var projects = new (int Capital, int Profit)[profits.Length];
		for (var i = 0; i < projects.Length; i++)
		{
			projects[i] = new(capital[i], profits[i]);
		}
		Array.Sort(projects, (p1, p2) => p1.Capital - p2.Capital);

		var pqueue = new PriorityQueue<int, int>();
		var p = 0;
		for (var i = 0; i < k; i++)
		{
			while (p < projects.Length && projects[p].Capital <= w)
			{
				var profit = projects[p++].Profit;
				pqueue.Enqueue(profit, -profit);
			}

			if (pqueue.Count == 0)
			{
				break;
			}
			w += pqueue.Dequeue();
		}
		return w;
	}
}
