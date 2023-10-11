namespace LeetCode.Algorithms
{
	class _1448
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

		public static int GoodNodes(TreeNode root, int val = int.MinValue)
		{
			if (root == null)
			{
				return 0;
			}

			var result = root.val >= val ? 1 : 0;
			result += GoodNodes(root.left, Math.Max(val, root.val));
			result += GoodNodes(root.right, Math.Max(val, root.val));
			return result;
		}
	}
}
