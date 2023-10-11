using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	class _653
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

		public static bool FindTarget(TreeNode root, int k)
		{
			var hashSet = new HashSet<int>();
			return FindTarget(root, k, hashSet);
		}

		private static bool FindTarget(TreeNode root, int k, HashSet<int> hashSet)
		{
			if (root == null)
			{
				return false;
			}

			if (hashSet.Contains(k - root.val))
			{
				return true;
			}
			hashSet.Add(root.val);

			return FindTarget(root.left, k, hashSet) || FindTarget(root.right, k, hashSet);
		}
	}
}
