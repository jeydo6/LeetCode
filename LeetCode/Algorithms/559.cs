using System;
using System.Collections.Generic;

namespace Leetcode.Algorithms
{
	public class _559
	{
		public class Node
		{
			public int val;
			public IList<Node> children;

			public Node()
			{
				//
			}
			public Node(int val, IList<Node> children)
			{
				this.val = val;
				this.children = children;
			}
		}

		public int MaxDepth(Node root)
		{
			if (root == null)
			{
				return 0;
			}
			else
			{
				int depth = 0;
				if (root.children != null)
				{
					foreach (var child in root.children)
					{
						depth = Math.Max(depth, MaxDepth(child));
					}
				}
				return 1 + depth;
			}
		}
	}
}
