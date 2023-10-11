using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _1345
{
	public static int MinJumps(int[] arr)
	{
		var dict = new Dictionary<int, IList<int>>();
		for (int i = 0; i < arr.Length; i++)
		{
			if (!dict.ContainsKey(arr[i]))
			{
				dict[arr[i]] = new List<int>();
			}
			dict[arr[i]].Add(i);
		}

		var step = 0;
		var visited = new bool[arr.Length];
		visited[0] = true;
		var queue = new Queue<int>();
		queue.Enqueue(0);
		while (queue.Count > 0)
		{
			for (var size = queue.Count; size > 0; size--)
			{
				var i = queue.Dequeue();
				if (i == arr.Length - 1)
				{
					return step;
				}

				var next = dict[arr[i]];
				next.Add(i - 1);
				next.Add(i + 1);
				foreach (var j in next)
				{
					if (j >= 0 && j < arr.Length && !visited[j])
					{
						visited[j] = true;
						queue.Enqueue(j);
					}
				}
				next.Clear();
			}
			step++;
		}

		return 0;
	}
}
