namespace Leetcode.Algorithms
{
	internal class _700
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

		public static TreeNode SearchBST(TreeNode root, int val)
		{
			if (root == null)
			{
				return null;
			}

			if (val == root.val)
			{
				return root;
			}
			else if (val < root.val)
			{
				return SearchBST(root.left, val);
			}
			else if (val > root.val)
			{
				return SearchBST(root.right, val);
			}

			return null;
		}
	}
}
