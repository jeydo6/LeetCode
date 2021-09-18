using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	class _95
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

		public IList<TreeNode> GenerateTrees(int n)
		{
			return GenerateTrees(1, n);
		}

		private IList<TreeNode> GenerateTrees(int start, int end)
		{
			if (start > end)
			{
				return new List<TreeNode>
				{
					null
				};
			}
			else if (start == end)
			{
				return new List<TreeNode>
				{
					new TreeNode(start)
				};
			}
			else
			{
				var result = new List<TreeNode>();
				for (var i = start; i <= end; i++)
				{
					foreach (var l in GenerateTrees(start, i - 1))
					{
						foreach (var r in GenerateTrees(i + 1, end))
						{
							result.Add(new TreeNode(i, l, r));
						}
					}
				}
				return result;
			}
		}
	}
}
