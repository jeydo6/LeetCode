using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _743
	{
		public static int NetworkDelayTime(int[][] times, int n, int k)
		{
			var lists = new Dictionary<int, IList<(int Time, int Node)>>();
			for (var i = 0; i < times.Length; i++)
			{
				var source = times[i][0];
				if (!lists.ContainsKey(source))
				{
					lists[source] = new List<(int Time, int Node)>();
				}
				lists[source].Add((times[i][2], times[i][1]));
			}

			var signalReceivedAt = new int[n + 1];
			for (var i = 0; i < n + 1; i++)
			{
				signalReceivedAt[i] = int.MaxValue;
			}

			var pqueue = new PriorityQueue<(int Time, int Node), int>();
			pqueue.Enqueue((0, k), 0);
			signalReceivedAt[k] = 0;

			while (pqueue.Count > 0)
			{
				var (currentTime, currentNode) = pqueue.Dequeue();

				if (currentTime > signalReceivedAt[currentNode])
				{
					continue;
				}

				if (!lists.ContainsKey(currentNode))
				{
					continue;
				}

				for (var i = 0; i < lists[currentNode].Count; i++)
				{
					var (time, node) = lists[currentNode][i];

					if (signalReceivedAt[node] > currentTime + time)
					{
						signalReceivedAt[node] = currentTime + time;
						pqueue.Enqueue((signalReceivedAt[node], node), signalReceivedAt[node]);
					}
				}
			}

			var result = int.MinValue;
			for (var i = 1; i < n + 1; i++)
			{
				result = Math.Max(result, signalReceivedAt[i]);
			}

			return result == int.MaxValue ? -1 : result;
		}
	}
}
