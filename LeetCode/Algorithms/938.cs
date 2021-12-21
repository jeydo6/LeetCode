using System.Collections.Generic;

namespace Leetcode.Algorithms
{
	internal class _938
	{
		public class TreeNode
		{
			public TreeNode(int value)
			{
				val = value;
			}

			public int val;

			public TreeNode left;

			public TreeNode right;

		}

		public static int RangeSumBST(TreeNode root, int low, int high)
		{
			int result = 0;

			Stack<TreeNode> stack = new Stack<TreeNode>();
			stack.Push(root);

			while (stack.Count > 0)
			{
				TreeNode node = stack.Pop();
				if (node != null)
				{
					if (node.val >= low && node.val <= high)
					{
						result += node.val;
					}

					if (node.val > low)
					{
						stack.Push(node.left);
					}

					if (node.val < high)
					{
						stack.Push(node.right);
					}
				}
			}

			return result;
		}
	}
}
