using System;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _563
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

		private int _result;

		public int FindTilt(TreeNode root)
		{
			PostOrder(root);
			return _result;
		}

		private int PostOrder(TreeNode root)
		{
			if (root == null)
			{
				return 0;
			}

			var left = PostOrder(root.left);
			var right = PostOrder(root.right);

			_result += Math.Abs(left - right);

			return left + right + root.val;
		}
	}
}
