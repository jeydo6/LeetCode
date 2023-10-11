namespace LeetCode.Algorithms
{
	class _1339
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

		private long _result = 0;

		public int MaxProduct(TreeNode root)
		{
			var total = Sum(root);
			Sum(root, total);

			return (int)(_result % 1000000007);
		}

		private long Sum(TreeNode root, long total = 0)
		{
			if (root == null)
			{
				return 0;
			}

			var left = Sum(root.left, total);
			var right = Sum(root.right, total);
			_result = Math.Max(
				_result,
				Math.Max(left * (total - left), right * (total - right))
			);
			return left + right + root.val;
		}
	}
}
