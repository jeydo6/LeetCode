using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal class _232
{
	public class MyQueue
	{
		private readonly Stack<int> _in = new Stack<int>();
		private readonly Stack<int> _out = new Stack<int>();

		public void Push(int x)
		{
			_in.Push(x);
		}

		public int Pop()
		{
			Peek();
			return _out.Pop();
		}

		public int Peek()
		{
			if (_out.Count == 0)
			{
				while (_in.Count > 0)
				{
					_out.Push(_in.Pop());
				}
			}
			return _out.Peek();
		}

		public bool Empty()
		{
			return _in.Count == 0 && _out.Count == 0;
		}
	}
}
