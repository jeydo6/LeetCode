using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	class _589
	{
		public class Node
		{
			public int val;

			public IList<Node> children;

			public Node()
			{
				//
			}

			public Node(int _val, IList<Node> _children)
			{
				val = _val;
				children = _children;
			}
		}

		public static IList<int> Preorder(Node root)
		{
			var result = new List<int>();

			if (root == null)
			{
				return result;
			}

			var stack = new Stack<Node>();
			stack.Push(root);

			while (stack.Count > 0)
			{
				var current = stack.Pop();
				result.Add(current.val);

				if (current.children != null && current.children.Count > 0)
				{
					for (var i = 0; i < current.children.Count; i++)
					{
						stack.Push(current.children[^(i + 1)]);
					}
				}
			}

			return result;
		}
	}
}
