using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _433
{
	private static readonly string _chars = "ACGT";

	public static int MinMutation(string start, string end, string[] bank)
	{
		var queue = new Queue<string>();
		queue.Enqueue(start);
		var seen = new HashSet<string> { start };
		var set = new HashSet<string>(bank);

		var steps = 0;
		while (queue.Count > 0)
		{
			var count = queue.Count;
			for (var i = 0; i < count; i++)
			{
				var node = queue.Dequeue();
				if (node == end)
				{
					return steps;
				}

				foreach (var ch in _chars)
				{
					for (var j = 0; j < node.Length; j++)
					{
						var neighbor = node.Substring(0, j) + ch + node.Substring(j + 1);
						if (!seen.Contains(neighbor) && set.Contains(neighbor))
						{
							queue.Enqueue(neighbor);
							seen.Add(neighbor);
						}
					}
				}
			}

			steps++;
		}

		return -1;
	}
}
