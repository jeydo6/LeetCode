namespace LeetCode.Algorithms;

// MEDIUM
internal class _814
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

	public static TreeNode PruneTree(TreeNode root)
	{
		return ContainsOne(root) ? root : null;
	}

	private static bool ContainsOne(TreeNode node)
	{
		if (node == null)
		{
			return false;
		}

		var leftContainsOne = ContainsOne(node.left);
		if (!leftContainsOne)
		{
			node.left = null;
		}

		var rightContainsOne = ContainsOne(node.right);
		if (!rightContainsOne)
		{
			node.right = null;
		}

		return node.val == 1 || leftContainsOne || rightContainsOne;
	}
}
