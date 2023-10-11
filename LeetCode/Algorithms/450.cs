namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _450
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

		public static TreeNode DeleteNode(TreeNode root, int key)
		{
			if (root == null)
			{
				return null;
			}

			if (key < root.val)
			{
				root.left = DeleteNode(root.left, key);
			}
			else if (key > root.val)
			{
				root.right = DeleteNode(root.right, key);
			}
			else
			{
				if (root.left == null)
				{
					return root.right;
				}
				else if (root.right == null)
				{
					return root.left;
				}

				var min = Min(root.right);
				root.val = min.val;
				root.right = DeleteNode(root.right, root.val);
			}
			return root;
		}

		private static TreeNode Min(TreeNode node)
		{
			while (node.left != null)
			{
				node = node.left;
			}
			return node;
		}
	}
}
