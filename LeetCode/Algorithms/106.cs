using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _106
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

		public static TreeNode BuildTree(int[] inorder, int[] postorder)
		{
			if (inorder == null || postorder == null || inorder.Length != postorder.Length)
			{
				return null;
			}
			var dict = new Dictionary<int, int>();
			for (var i = 0; i < inorder.Length; i++)
			{
				dict[inorder[i]] = i;
			}
			return BuildTree(inorder, 0, inorder.Length - 1, postorder, 0, postorder.Length - 1, dict);
		}

		private static TreeNode BuildTree(int[] inorder, int si, int ei, int[] postorder, int sp, int ep, IDictionary<int, int> dict)
		{
			if (sp > ep || si > ei)
			{
				return null;
			}

			var root = new TreeNode(postorder[ep]);
			var ri = dict[postorder[ep]];

			root.left = BuildTree(inorder, si, ri - 1, postorder, sp, sp + ri - si - 1, dict);
			root.right = BuildTree(inorder, ri + 1, ei, postorder, sp + ri - si, ep - 1, dict);
			return root;
		}
	}
}
