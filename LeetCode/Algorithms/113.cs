using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _113
{
	public class TreeNode
	{
		public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
		{
			this.val = val;
			this.left = left;
			this.right = right;
		}

		public int val;

		public TreeNode left;

		public TreeNode right;
	}

	public static IList<IList<int>> PathSum(TreeNode root, int targetSum)
	{
		var result = new List<IList<int>>();

		if (root == null)
		{
			return result;
		}

		var stack = new Stack<(TreeNode node, List<int> path, int pathSum)>();
		stack.Push((root, new List<int> { root.val }, root.val));

		while (stack.Count > 0)
		{
			var (node, path, pathSum) = stack.Pop();

			if (node.left == null && node.right == null && pathSum == targetSum)
			{
				result.Add(path);
				continue;
			}

			if (node.left != null)
			{
				stack.Push((node.left, new List<int>(path) { node.left.val }, pathSum + node.left.val));
			}

			if (node.right != null)
			{
				stack.Push((node.right, new List<int>(path) { node.right.val }, pathSum + node.right.val));
			}
		}

		return result;
	}

	private static IList<IList<int>> DFS(TreeNode root, int targetSum, IList<int> path)
	{
		if (root == null)
		{
			return new List<IList<int>>();
		}

		var result = new List<IList<int>>();
		if (
			root.left == null &&
			root.right == null &&
			root.val == targetSum
		)
		{
			path.Add(root.val);
			result.Add(path);
		}
		result.AddRange(
			DFS(root.left, targetSum - root.val, new List<int>(path) { root.val })
		);
		result.AddRange(
			DFS(root.right, targetSum - root.val, new List<int>(path) { root.val })
		);
		return result;
	}
}
