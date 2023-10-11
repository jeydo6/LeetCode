using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1647
{
	public static int MinDeletions(string s)
	{
		var frequency = new int[26];
		for (var i = 0; i < s.Length; i++)
		{
			frequency[s[i] - 'a']++;
		}

		var pqueue = new PriorityQueue<int, int>();
		for (var i = 0; i < frequency.Length; i++)
		{
			if (frequency[i] > 0)
			{
				pqueue.Enqueue(frequency[i], -frequency[i]);
			}
		}

		var result = 0;
		while (pqueue.Count > 1)
		{
			var item = pqueue.Dequeue();

			if (item == pqueue.Peek())
			{
				if (item - 1 > 0)
				{
					pqueue.Enqueue(item - 1, -(item - 1));
				}
				result++;
			}
		}

		return result;
	}
}
