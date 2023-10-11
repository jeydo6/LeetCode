using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _894
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

	public static IList<TreeNode> AllPossibleFBT(int n)
	{
		if (n % 2 == 0)
		{
			return new List<TreeNode>();
		}

		var dp = new IList<TreeNode>[n + 1];
		for (var i = 0; i < dp.Length; i++)
		{
			dp[i] = new List<TreeNode>();
		}

		dp[1].Add(new TreeNode());
		for (var count = 3; count <= n; count += 2)
		{
			for (var i = 1; i < count - 1; i += 2)
			{
				var j = count - 1 - i;
				foreach (var left in dp[i])
				{
					foreach (var right in dp[j])
					{
						var root = new TreeNode(0, left, right);
						dp[count].Add(root);
					}
				}
			}
		}

		return dp[^1];
	}
}