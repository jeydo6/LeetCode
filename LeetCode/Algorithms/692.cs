using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _692
{
	public static IList<string> TopKFrequent(string[] words, int k)
	{
		var counts = new Dictionary<string, int>();
		foreach (var word in words)
		{
			if (!counts.ContainsKey(word))
			{
				counts[word] = 0;
			}
			counts[word]++;
		}

		var comparer = Comparer<string>.Create((w1, w2) =>
			counts[w1] == counts[w2] ? string.CompareOrdinal(w2, w1) : counts[w1] - counts[w2]
		);
		var pqueue = new PriorityQueue<string, string>(comparer);

		foreach (var word in counts.Keys)
		{
			pqueue.Enqueue(word, word);
			if (pqueue.Count > k)
			{
				pqueue.Dequeue();
			}
		}

		var result = new List<string>();
		while (pqueue.Count > 0)
		{
			result.Add(pqueue.Dequeue());
		}
		result.Reverse();

		return result;
	}
}
