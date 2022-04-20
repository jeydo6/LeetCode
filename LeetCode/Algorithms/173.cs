using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _173
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
		
		public class BSTIterator
		{
			private readonly IList<int> _values;

			private int _index;

			public BSTIterator(TreeNode root)
			{
				_values = new List<int>();
				_index = 0;

				Flatten(root);
			}

			public int Next()
			{
				return _values[_index++];
			}

			public bool HasNext()
			{
				return _index + 1 < _values.Count;
			}

			private void Flatten(TreeNode root)
			{
				if (root == null)
				{
					return;
				}

				Flatten(root.left);
				_values.Add(root.val);
				Flatten(root.right);
			}
		}
	}
}
