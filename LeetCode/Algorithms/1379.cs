using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1379
	{
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int x) { val = x; }
		}

		public static TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
		{
			var oQueue = new Queue<TreeNode>();
			oQueue.Enqueue(original);

			var cQueue = new Queue<TreeNode>();
			cQueue.Enqueue(cloned);
			
			while (oQueue.Count > 0)
			{
				var oNode = oQueue.Dequeue();
				var cNode = cQueue.Dequeue();

				if (oNode == target)
				{
					return cNode;
				}

				if (oNode.left != null)
				{
					oQueue.Enqueue(oNode.left);
					cQueue.Enqueue(cNode.left);
				}

				if (oNode.right != null)
				{
					oQueue.Enqueue(oNode.right);
					cQueue.Enqueue(cNode.right);
				}
			}

			return null;
		}
	}
}
