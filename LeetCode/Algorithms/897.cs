namespace Leetcode.Algorithms
{
	internal class _897
	{
		public class TreeNode
		{
			public TreeNode(int x)
			{
				val = x;
			}

			public int val;

			public TreeNode left;

			public TreeNode right;

		}

		public static TreeNode IncreasingBST(TreeNode root, TreeNode tail = null)
		{
			if (root == null)
			{
				return tail;
			}

			var result = IncreasingBST(root.left, root);
			root.left = null;
			root.right = IncreasingBST(root.right, tail);

			return result;
		}
	}
}
