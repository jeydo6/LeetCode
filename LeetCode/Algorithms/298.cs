using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _298
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

	public static int LongestConsecutive(TreeNode node, TreeNode parent = null, int length = 0)
	{
		if (node == null)
		{
			return length;
		}

		length = (parent != null && node.val == parent.val + 1) ? length + 1 : 1;

		return Math.Max(
			length,
			Math.Max(
				LongestConsecutive(node.left, node, length),
				LongestConsecutive(node.right, node, length)
			)
		);
	}
}
