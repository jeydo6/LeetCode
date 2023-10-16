using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1361
{
	public static bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild)
	{
		var root = FindRoot(n, leftChild, rightChild);
		if (root == -1)
		{
			return false;
		}

		var seen = new HashSet<int>();
		var queue = new Queue<int>();
		seen.Add(root);
		queue.Enqueue(root);

		while (queue.Count > 0)
		{
			var node = queue.Dequeue();
			foreach (var child in new[] { leftChild[node], rightChild[node] })
			{
				if (child == -1)
				{
					continue;
				}

				if (seen.Contains(child))
				{
					return false;
				}

				queue.Enqueue(child);
				seen.Add(child);
			}
		}

		return seen.Count == n;
	}

	private static int FindRoot(int n, int[] left, int[] right)
	{
		var children = new HashSet<int>();

		for (var i = 0; i < left.Length; i++)
		{
			children.Add(left[i]);
		}

		for (var i = 0; i < right.Length; i++)
		{
			children.Add(right[i]);
		}

		for (var i = 0; i < n; i++)
		{
			if (!children.Contains(i))
			{
				return i;
			}
		}

		return -1;
	}
}