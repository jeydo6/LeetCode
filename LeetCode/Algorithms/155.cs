using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	internal class _155
	{
		public void GetResult()
		{
			var obj = new MinStack();
			obj.Push(1);
			obj.Pop();
			var param_3 = obj.Top();
			var param_4 = obj.GetMin();
		}

		private class MinStack
		{
			private readonly Stack<int> _stack;
			private int _min;
			
			public MinStack()
			{
				_stack = new Stack<int>();
				_min = int.MaxValue;
			}

			public void Push(int val)
			{
				if (_min >= val)
				{
					_stack.Push(_min);
					_min = val;
				}

				_stack.Push(val);
			}

			public void Pop()
			{
				if (_min == _stack.Peek())
				{
					_stack.Pop();
					_min = _stack.Peek();
				}

				_stack.Pop();
			}

			public int Top()
			{
				return _stack.Peek();
			}

			public int GetMin()
			{
				return _min;
			}
		}
	}
}