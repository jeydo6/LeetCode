using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _847
	{
		public class Node
		{
			public readonly int bitMask;
			public readonly int current;
			public readonly int cost;

			public Node(int bit, int n, int c)
			{
				bitMask = bit;
				current = n;
				cost = c;
			}

			public override bool Equals(object o)
			{
				Node p = (Node)o;
				return bitMask == p.bitMask && current == p.current && cost == p.cost;
			}

			public override int GetHashCode()
			{
				return 1331 * bitMask + 7193 * current + 727 * cost;
			}
		}

		public static int ShortestPathLength(int[][] graph)
		{
			var hashSet = new HashSet<Node>();
			var queue = new Queue<Node>();
			for (var i = 0; i < graph.Length; i++)
			{
				var temp = 1 << i;
				hashSet.Add(new Node(temp, i, 0));
				queue.Enqueue(new Node(temp, i, 1));
			}

			while (queue.Count > 0)
			{
				var current = queue.Dequeue();

				if (current.bitMask == (1 << graph.Length) - 1)
				{
					return current.cost - 1;
				}
				else
				{
					var neighbors = graph[current.current];
					for (var j = 0; j < neighbors.Length; j++)
					{
						var bitMask = current.bitMask;
						bitMask |= (1 << neighbors[j]);
						var node = new Node(bitMask, neighbors[j], 0);
						if (!hashSet.Contains(node))
						{
							queue.Enqueue(new Node(bitMask, neighbors[j], current.cost + 1));
							hashSet.Add(node);
						}
					}
				}
			}
			return -1;
		}
	}
}
