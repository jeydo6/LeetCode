namespace LeetCode.Algorithms
{
	public class _617
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

		public static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
		{
			if (t1 == null && t2 == null)
			{
				return null;
			}

			if (t1 == null)
			{
				t1 = new TreeNode(0);
			}
			if (t2 == null)
			{
				t2 = new TreeNode(0);
			}

			var result = new TreeNode(t1.val + t2.val);

			if (t1.left != null || t2.left != null)
			{
				result.left = MergeTrees(t1.left, t2.left);
			}

			if (t1.right != null || t2.right != null)
			{
				result.right = MergeTrees(t1.right, t2.right);
			}

			return result;
		}
	}
}