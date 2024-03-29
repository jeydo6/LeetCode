﻿namespace LeetCode.Algorithms;

// EASY
internal class _226
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
	
	public static TreeNode InvertTree(TreeNode root)
	{
		if (root == null)
		{
			return null;
		}

		(root.left, root.right) = (root.right, root.left);

		InvertTree(root.left);
		InvertTree(root.right);

		return root;
	}
}