using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _993
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

		public static bool IsCousins(TreeNode root, int x, int y)
		{
			var queue = new Queue<TreeNode>();
			queue.Enqueue(root);

			while (queue.Count > 0)
			{
				var rx = false;
				var ry = false;

				var count = queue.Count;
				for (var i = 0; i < count; i++)
				{
					var node = queue.Dequeue();

					if (node.val == x)
					{
						rx = true;
					}
					if (node.val == y)
					{
						ry = true;
					}

					if (node.left != null && node.right != null)
					{
						if (node.left.val == x && node.right.val == y || node.left.val == y && node.right.val == x)
						{
							return false;
						}
					}

					if (node.left != null)
					{
						queue.Enqueue(node.left);
					}
					if (node.right != null)
					{
						queue.Enqueue(node.right);
					}
				}

				if (rx && ry)
				{
					return true;
				}
			}

			return false;
		}
	}
}
