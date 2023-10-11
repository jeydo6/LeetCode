using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _630
	{
		public static int ScheduleCourse(int[][] courses)
		{
			Array.Sort(courses, (a, b) => a[1] - b[1]);

			var pqueue = new PriorityQueue<int, int>();
			var time = 0;
			for (var i = 0; i < courses.Length; i++)
			{
				if (time + courses[i][0] <= courses[i][1])
				{
					time += courses[i][0];
					pqueue.Enqueue(courses[i][0], -courses[i][0]);
				}
				else if (pqueue.Count > 0 && pqueue.Peek() > courses[i][0])
				{
					time += courses[i][0] - pqueue.Dequeue();
					pqueue.Enqueue(courses[i][0], -courses[i][0]);
				}
			}

			return pqueue.Count;
		}
	}
}
