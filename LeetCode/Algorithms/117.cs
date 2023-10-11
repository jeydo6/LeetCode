using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _117
	{
		public class Node
		{
			public int val;
			public Node left;
			public Node right;
			public Node next;

			public Node() { }

			public Node(int _val)
			{
				val = _val;
			}

			public Node(int _val, Node _left, Node _right, Node _next)
			{
				val = _val;
				left = _left;
				right = _right;
				next = _next;
			}
		}

		public static Node Connect(Node root)
		{
			if (root == null)
			{
				return root;
			}

			var queue = new Queue<Node>();
			queue.Enqueue(root);

			while (queue.Count > 0)
			{
				var count = queue.Count;

				for (var i = 0; i < count; i++)
				{

					var node = queue.Dequeue();

					if (i < count - 1)
					{
						node.next = queue.Peek();
					}

					if (node.left != null)
					{
						queue.Enqueue(node.left);
					}
					if (node.right != null)
					{
						queue.Enqueue(node.right);
					}
				}
			}

			return root;
		}
	}
}
