using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1834
{
	public static int[] GetOrder(int[][] tasks)
	{
		var sortedTasks = new int[tasks.Length][];
		for (var i = 0; i < tasks.Length; i++)
		{
			sortedTasks[i] = new int[] { tasks[i][0], tasks[i][1], i };
		}

		Array.Sort(sortedTasks, (a, b) => a[0] - b[0]);

		var result = new int[tasks.Length];
		var resultIndex = 0;
		var taskIndex = 0;
		var currentTime = 0L;

		var comparer = Comparer<int[]>.Create((a, b) => a[1] != b[1] ? a[1] - b[1] : a[2] - b[2]);
		var pqueue = new PriorityQueue<int[], int[]>(comparer);
		while (taskIndex < tasks.Length || pqueue.Count > 0)
		{
			if (pqueue.Count == 0 && currentTime < sortedTasks[taskIndex][0])
			{
				currentTime = sortedTasks[taskIndex][0];
			}

			while (taskIndex < tasks.Length && currentTime >= sortedTasks[taskIndex][0])
			{
				pqueue.Enqueue(sortedTasks[taskIndex], sortedTasks[taskIndex]);
				taskIndex++;
			}

			var item = pqueue.Dequeue();

			currentTime += item[1];
			result[resultIndex++] = item[2];
		}

		return result;
	}
}
