using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _199
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

		public static IList<int> RightSideView(TreeNode root)
		{
			if (root == null)
			{
				return new List<int>();
			}

			var queue = new Queue<TreeNode>();
			queue.Enqueue(root);

			var result = new List<int>();
			while (queue.Count > 0)
			{
				var levelLength = queue.Count;

				for (var i = 0; i < levelLength; ++i)
				{
					var node = queue.Dequeue();

					if (i == levelLength - 1)
					{
						result.Add(node.val);
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
			}

			return result;
		}
	}
}
