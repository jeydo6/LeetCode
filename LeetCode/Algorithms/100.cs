﻿namespace LeetCode.Algorithms;

// EASY
internal class _100
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

	public static bool IsSameTree(TreeNode p, TreeNode q)
	{
		if (p == null && q == null)
		{
			return true;
		}
		else if (p == null || q == null)
		{
			return false;
		}
		else if (p.val != q.val)
		{
			return false;
		}

		return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
	}
}
