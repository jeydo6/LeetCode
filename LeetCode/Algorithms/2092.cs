using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal sealed class _2092
{
	public static IList<int> FindAllPeople(int n, int[][] meetings, int firstPerson)
	{
		var graph = new Dictionary<int, List<int[]>>();
		for (var i = 0; i < meetings.Length; i++)
		{
			var x = meetings[i][0];
			var y = meetings[i][1];
			var t = meetings[i][2];

			graph.TryAdd(x, new List<int[]>());
			graph[x].Add(new int[] { t, y });

			graph.TryAdd(y, new List<int[]>());
			graph[y].Add(new int[] { t, x });
		}

		var earliest = new int[n];
		Array.Fill(earliest, int.MaxValue);
		earliest[0] = 0;
		earliest[firstPerson] = 0;

		var queue = new Queue<int[]>();
		queue.Enqueue(new int[] { 0, 0 });
		queue.Enqueue(new int[] { firstPerson, 0 });

		while (queue.Count > 0)
		{
			var personTime = queue.Dequeue();
			var person = personTime[0];
			var time = personTime[1];
			
			if (!graph.TryGetValue(person, out var nextPersonTimes)) continue;
			foreach (var nextPersonTime in nextPersonTimes)
			{
				var nextTime = nextPersonTime[0];
				var nextPerson = nextPersonTime[1];

				if (nextTime >= time && earliest[nextPerson] > nextTime)
				{
					earliest[nextPerson] = nextTime;
					queue.Enqueue(new int[] { nextPerson, nextTime });
				}
			}
		}

		var result = new List<int>();
		for (var i = 0; i < n; i++)
		{
			if (earliest[i] != int.MaxValue)
			{
				result.Add(i);
			}
		}

		return result;
	}
}