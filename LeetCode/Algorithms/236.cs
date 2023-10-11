using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _236
	{
		private enum State
		{
			BothDone,
			LeftDone,
			BothPending
		}

		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int x) { val = x; }
		}

		public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
		{
			var result = default(TreeNode);

			var stack = new Stack<(TreeNode Node, State State)>();
			stack.Push((root, State.BothPending));

			var oneNodeFound = false;
			while (stack.Count > 0)
			{
				var (parentNode, parentState) = stack.Peek();
				if (parentState != State.BothDone)
				{
					TreeNode childNode;
					if (parentState == State.BothPending)
					{
						if (parentNode == p || parentNode == q)
						{
							if (oneNodeFound)
							{
								return result;
							}
							else
							{
								oneNodeFound = true;
								(result, _) = stack.Peek();
							}
						}

						childNode = parentNode.left;
					}
					else
					{
						childNode = parentNode.right;
					}

					stack.Pop();
					stack.Push((parentNode, parentState - 1));

					if (childNode != null)
					{
						stack.Push((childNode, State.BothPending));
					}
				}
				else
				{
					if (result == stack.Pop().Node && oneNodeFound)
					{
						result = stack.Peek().Node;
					}
				}
			}

			return null;
		}
	}
}
