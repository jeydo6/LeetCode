using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _222
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

	public static int CountNodes(TreeNode root)
	{
		if (root == null)
		{
			return 0;	
		}

		TreeNode node;
		
		var left = 0;
		node = root;
		while (node.left != null)
		{
			left++;
			node = node.left;
		}
		
		var right = 0;
		node = root;
		while (node.right != null)
		{
			right++;
			node = node.right;
		}

		if (left == right)
		{
			return 2 * ((int)Math.Pow(2, left) - 1) + 1;
		}

		return CountNodes(root.left) + CountNodes(root.right) + 1;
	}
}