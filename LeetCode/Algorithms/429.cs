using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	class _429
	{
		public class Node
		{
			public int val;
			public IList<Node> children;

			public Node()
			{

			}

			public Node(int val)
			{
				this.val = val;
			}

			public Node(int val, IList<Node> children)
			{
				this.val = val;
				this.children = children;
			}
		}

		public static IList<IList<int>> LevelOrder(Node root)
		{
			var result = new List<IList<int>>();

			if (root == null)
			{
				return result;
			}

			var queue = new Queue<Node>();
			queue.Enqueue(root);
			while (queue.Count > 0)
			{
				var level = new List<int>();
				var levelCount = queue.Count;
				for (var i = 0; i < levelCount; i++)
				{
					var node = queue.Dequeue();
					level.Add(node.val);
					foreach (var child in node.children)
					{
						queue.Enqueue(child);
					}
				}
				result.Add(level);
			}

			return result;
		}
	}
}
