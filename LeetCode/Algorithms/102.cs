using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _102
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

		public static IList<IList<int>> LevelOrder(TreeNode root)
		{
			var result = new List<IList<int>>();
			if (root == null)
			{
				return result;
			};

			var queue = new Queue<TreeNode>();
			queue.Enqueue(root);
			while (queue.Count > 0)
			{
				var list = new List<int>();

				var level = queue.Count;
				for (var i = 0; i < level; i++)
				{
					var node = queue.Peek();
					if (node.left != null)
					{
						queue.Enqueue(node.left);
					}
					if (node.right != null)
					{
						queue.Enqueue(node.right);
					}
					list.Add(node.val);
					queue.Dequeue();
				}
				result.Add(list);
			}
			return result;
		}
	}
}
