using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _373
{
	public static IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
	{
		var n1 = nums1.Length;
		var n2 = nums2.Length;

		var result = new List<IList<int>>();
		var visited = new HashSet<(int, int)>();

		var pQueue = new PriorityQueue<int[], int>();
		pQueue.Enqueue(new[] { nums1[0] + nums2[0], 0, 0 }, nums1[0] + nums2[0]);
		visited.Add((0, 0));

		while (k-- > 0 && pQueue.Count > 0)
		{
			var top = pQueue.Dequeue();
			var i = top[1];
			var j = top[2];

			result.Add(new List<int> { nums1[i], nums2[j] });

			if (i + 1 < n1 && !visited.Contains((i + 1, j)))
			{
				pQueue.Enqueue(new[] { nums1[i + 1] + nums2[j], i + 1, j }, nums1[i + 1] + nums2[j]);
				visited.Add((i + 1, j));
			}
			if (j + 1 < n2 && !visited.Contains((i, j + 1)))
			{
				pQueue.Enqueue(new[] { nums1[i] + nums2[j + 1], i, j + 1 }, nums1[i] + nums2[j + 1]);
				visited.Add((i, j + 1));
			}
		}

		return result;
	}
}