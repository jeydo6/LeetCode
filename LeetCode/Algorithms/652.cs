using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _652
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

	public static IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
	{
		var result = new List<TreeNode>();
		FindDuplicateSubtrees(root, new Dictionary<string, int>(), new Dictionary<int, int>(), result);
		return result;
	}

	private static int FindDuplicateSubtrees(TreeNode root, IDictionary<string, int> tripletToID, IDictionary<int, int> counts, IList<TreeNode> result)
	{
		if (root == null)
		{
			return 0;
		}

		var triplet =
			FindDuplicateSubtrees(root.left, tripletToID, counts, result) + "," +
			root.val + "," +
			FindDuplicateSubtrees(root.right, tripletToID, counts, result);

		if (!tripletToID.ContainsKey(triplet))
		{
			tripletToID[triplet] = tripletToID.Count + 1;
		}

		var id = tripletToID[triplet];
		if (!counts.ContainsKey(id))
		{
			counts[id] = 0;
		}
		counts[id]++;

		if (counts[id] == 2)
		{
			result.Add(root);
		}
		return id;
	}
}
