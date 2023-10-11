namespace LeetCode.Algorithms
{
	class _1022
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

		public static int SumRootToLeaf(TreeNode root)
		{
			var result = 0;
			var path = new Stack<TreeNode>();

			var stack = new Stack<TreeNode>();
			stack.Push(root);
			while (stack.Count > 0)
			{
				var node = stack.Peek();
				if (path.Count > 0 && node == path.Peek())
				{
					path.Pop();
					stack.Pop();
				}
				else
				{
					path.Push(node);
					if (node.left != null)
					{
						stack.Push(node.left);
					}
					if (node.right != null)
					{
						stack.Push(node.right);
					}

					if (node.left == null && node.right == null)
					{
						var muptiplier = 1;
						foreach (var item in path)
						{
							result += item.val * muptiplier;
							muptiplier *= 2;
						}
					}
				}
			}
			return result;
		}
	}
}
