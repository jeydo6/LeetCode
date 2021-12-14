using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _232
	{
		public static void GetResult()
		{
			var obj = new MyQueue();
			obj.Push(1);
			var param_2 = obj.Pop();
			var param_3 = obj.Peek();
			var param_4 = obj.Empty();
		}

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
}
