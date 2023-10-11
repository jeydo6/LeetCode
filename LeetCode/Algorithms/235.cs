namespace LeetCode.Algorithms
{
	// EASY
	internal class _235
	{
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int x) { val = x; }
		}

		public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
		{
			while ((root.val - p.val) * (root.val - q.val) > 0)
			{
				root = p.val < root.val ? root.left : root.right;
			}

			return root;
		}
	}
}
