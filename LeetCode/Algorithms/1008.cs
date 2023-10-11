namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1008
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

		public static TreeNode BstFromPreorder(int[] preorder)
		{
			return BstFromPreorder(preorder, 0, preorder.Length - 1);
		}

		public static TreeNode BstFromPreorder(int[] preorder, int start, int end)
		{
			if (start > end)
			{
				return null;
			}

			var root = new TreeNode(preorder[start]);

			int index;
			for (index = start; index <= end; index++)
			{
				if (preorder[index] > preorder[start])
				{
					break;
				}
			}

			root.left = BstFromPreorder(preorder, start + 1, index - 1);
			root.right = BstFromPreorder(preorder, index, end);

			return root;
		}
	}
}
