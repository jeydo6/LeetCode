namespace LeetCode.Algorithms
{
	internal class _617
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

		public static TreeNode MergeTrees(TreeNode root1, TreeNode root2)
		{
			if (root1 == null && root2 == null)
			{
				return null;
			}

			if (root1 == null)
			{
				root1 = new TreeNode(0);
			}
			if (root2 == null)
			{
				root2 = new TreeNode(0);
			}

			var result = new TreeNode(root1.val + root2.val);

			if (root1.left != null || root2.left != null)
			{
				result.left = MergeTrees(root1.left, root2.left);
			}

			if (root1.right != null || root2.right != null)
			{
				result.right = MergeTrees(root1.right, root2.right);
			}

			return result;
		}
	}
}