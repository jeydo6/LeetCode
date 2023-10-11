namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _669
	{
		public class TreeNode
		{
			public TreeNode(int val)
			{
				this.val = val;
			}

			public int val;

			public TreeNode left;

			public TreeNode right;
		}

		public static TreeNode TrimBST(TreeNode root, int low, int high)
		{
			if (root == null)
			{
				return root;
			}
			if (root.val > high)
			{
				return TrimBST(root.left, low, high);
			}
			if (root.val < low)
			{
				return TrimBST(root.right, low, high);
			}

			root.left = TrimBST(root.left, low, high);
			root.right = TrimBST(root.right, low, high);
			return root;
		}
	}
}
