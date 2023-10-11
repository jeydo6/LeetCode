using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal class _225
{
	public class MyStack
	{
		private readonly LinkedList<int> _list;

		public MyStack()
		{
			_list = new LinkedList<int>();
		}

		public void Push(int x)
		{
			_list.AddLast(x);
		}

		public int Pop()
		{
			var x = _list.Last;
			_list.RemoveLast();
			return x.Value;
		}

		public int Top()
		{
			return _list.Last.Value;
		}

		public bool Empty()
		{
			return _list.Count == 0;
		}
	}
}
