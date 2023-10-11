using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1586
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
			private readonly Stack<TreeNode> _stack;
			private readonly IList<int> _list;

			private TreeNode _last;
			private int _pointer;

			public BSTIterator(TreeNode root)
			{
				_stack = new Stack<TreeNode>();
				_list = new List<int>();
				_last = root;
				_pointer = -1;
			}

			public bool HasNext()
			{
				return _stack.Count > 0 || _last != null || _pointer < _list.Count - 1;
			}

			public int Next()
			{
				_pointer++;
				if (_pointer == _list.Count)
				{
					while (_last != null)
					{
						_stack.Push(_last);
						_last = _last.left;
					}
					var curr = _stack.Pop();
					_last = curr.right;
					_list.Add(curr.val);
				}

				return _list[_pointer];
			}

			public bool HasPrev()
			{
				return _pointer > 0;
			}

			public int Prev()
			{
				_pointer--;
				return _list[_pointer];
			}
		}
	}
}
