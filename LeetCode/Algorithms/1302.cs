using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1302
	{
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
			{
				this.val = val;
				this.left = left;
				this.right = right;
			}
		}

		public static int DeepestLeavesSum(TreeNode root)
		{
			var result = 0;
			var depth = 0;

			var stack = new Stack<(TreeNode Node, int Depth)>();
			stack.Push((root, 0));

			while (stack.Count > 0)
			{
				var (currentNode, currentDepth) = stack.Pop();
				if (currentNode.left == null && currentNode.right == null)
				{
					if (depth < currentDepth)
					{
						result = currentNode.val;
						depth = currentDepth;
					}
					else if (depth == currentDepth)
					{
						result += currentNode.val;
					}
				}
				else
				{
					if (currentNode.right != null)
					{
						stack.Push((currentNode.right, currentDepth + 1));
					}
					if (currentNode.left != null)
					{
						stack.Push((currentNode.left, currentDepth + 1));
					}
				}
			}

			return result;
		}
	}
}
