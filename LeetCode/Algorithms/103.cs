using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _103
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

	public static IList<IList<int>> ZigzagLevelOrder(TreeNode root)
	{
		if (root == null)
		{
			return new List<IList<int>>();
		}

		var result = new List<IList<int>>();

		var queue = new Queue<TreeNode>();
		queue.Enqueue(root);
		queue.Enqueue(null);

		var list = new LinkedList<int>();
		var isOrder = true;
		while (queue.Count > 0)
		{
			var currentNode = queue.Dequeue();
			if (currentNode != null)
			{
				if (isOrder)
				{
					list.AddLast(currentNode.val);
				}
				else
				{
					list.AddFirst(currentNode.val);
				}

				if (currentNode.left != null)
				{
					queue.Enqueue(currentNode.left);
				}
				if (currentNode.right != null)
				{
					queue.Enqueue(currentNode.right);
				}
			}
			else
			{
				result.Add(new List<int>(list));
				list = new LinkedList<int>();
				if (queue.Count > 0)
				{
					queue.Enqueue(null);
				}
				isOrder = !isOrder;
			}
		}
		return result;
	}
}
