using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _105
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

		private static int _preorderIndex = 0;

		public static TreeNode BuildTree(int[] preorder, int[] inorder)
		{
			var inorderDict = new Dictionary<int, int>();
			for (var i = 0; i < inorder.Length; i++)
			{
				inorderDict[inorder[i]] = i;
			}

			return BuildTree(preorder, inorderDict, 0, preorder.Length - 1);
		}

		private static TreeNode BuildTree(int[] preorder, IDictionary<int, int> inorderDict, int left, int right)
		{
			if (left > right)
			{
				return null;
			}

			var rootValue = preorder[_preorderIndex++];
			TreeNode root = new TreeNode(rootValue)
			{
				left = BuildTree(preorder, inorderDict, left, inorderDict[rootValue] - 1),
				right = BuildTree(preorder, inorderDict, inorderDict[rootValue] + 1, right)
			};

			return root;
		}
	}
}
