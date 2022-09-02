using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _637
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

		public static IList<double> AverageOfLevels(TreeNode root)
		{
			var result = new List<double>();

			var queue = new Queue<TreeNode>();
			queue.Enqueue(root);
			while (queue.Count > 0)
			{
				var sum = 0d;
				var count = 0;

				var temp = new Queue<TreeNode>();
				while (queue.Count > 0)
				{
					var node = queue.Dequeue();
					if (node.left != null)
					{
						temp.Enqueue(node.left);
					}
					if (node.right != null)
					{
						temp.Enqueue(node.right);
					}

					sum += node.val;
					count++;
				}
				queue = temp;
				result.Add(sum / count);
			}

			return result;
		}
	}
}
