namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _114
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

		public static void Flatten(TreeNode root)
		{
			if (root == null)
			{
				return;
			}

			var node = root;
			while (node != null)
			{

				if (node.left != null)
				{
					var rightmost = node.left;
					while (rightmost.right != null)
					{
						rightmost = rightmost.right;
					}

					rightmost.right = node.right;
					node.right = node.left;
					node.left = null;
				}

				node = node.right;
			}
		}
	}
}
