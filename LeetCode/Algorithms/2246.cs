using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _2246
{
	public static int LongestPath(int[] parent, string s)
	{
		var counts = new int[parent.Length];
		for (var node = 1; node < parent.Length; node++)
		{
			counts[parent[node]]++;
		}

		var queue = new Queue<int>();
		int[][] longestChains = new int[parent.Length][];
		for (var i = 0; i < parent.Length; i++)
		{
			longestChains[i] = new int[2];
		}

		for (var node = 1; node < parent.Length; node++)
		{
			if (counts[node] == 0)
			{
				longestChains[node][0] = 1;
				queue.Enqueue(node);
			}
		}

		var result = 1;
		while (queue.Count > 0)
		{
			var currentNode = queue.Dequeue();
			var p = parent[currentNode];

			var longestChain = longestChains[currentNode][0];
			if (s[currentNode] != s[p])
			{
				if (longestChain > longestChains[p][0])
				{
					longestChains[p][1] = longestChains[p][0];
					longestChains[p][0] = longestChain;
				}
				else if (longestChain > longestChains[p][1])
				{
					longestChains[p][1] = longestChain;
				}
			}

			result = Math.Max(result, longestChains[p][0] + longestChains[p][1] + 1);
			counts[p]--;

			if (counts[p] == 0 && p != 0)
			{
				longestChains[p][0]++;
				queue.Enqueue(p);
			}
		}

		return result;
	}
}
