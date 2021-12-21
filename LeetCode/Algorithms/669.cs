namespace Leetcode.Algorithms
{
	public class _669
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

		public static TreeNode TrimBST(TreeNode root, int l, int r)
		{
			if (root == null)
			{
				return null;
			}

			while (root.val < l || root.val > r)
			{
				if (root.val < l)
				{
					root = root.right;
				}

				if (root.val > r)
				{
					root = root.left;
				}
			}

			var temp = root;
			while (temp != null)
			{
				while (temp.left != null && temp.left.val < l)
				{
					temp.left = temp.left.right;
				}
				temp = temp.left;
			}

			temp = root;
			while (temp != null)
			{
				while (temp.right != null && temp.right.val > r)
				{
					temp.right = temp.right.left;
				}
				temp = temp.right;
			}

			return root;
		}
	}
}
