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
		var pQueue = new PriorityQueue<string, string>(comparer);

		foreach (var word in counts.Keys)
		{
			pQueue.Enqueue(word, word);
			if (pQueue.Count > k)
			{
				pQueue.Dequeue();
			}
		}

		var result = new string[k];
		for (var i = k - 1; i >= 0; --i)
		{
			result[i] = pQueue.Dequeue();
		}

		return result;
	}
}
