namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _701
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

		public static TreeNode InsertIntoBST(TreeNode root, int val)
		{
			if (root == null)
			{
				return new TreeNode(val);
			}
			var current = root;
			while (true)
			{
				if (current.val <= val)
				{
					if (current.right != null)
					{

						current = current.right;
					}
					else
					{
						current.right = new TreeNode(val);
						break;
					}
				}
				else
				{
					if (current.left != null)
					{

						current = current.left;
					}
					else
					{
						current.left = new TreeNode(val);
						break;
					}
				}
			}
			return root;
		}
	}
}
