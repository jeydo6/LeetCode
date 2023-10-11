using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _716
{
	public class MaxStack
	{
		private readonly Stack<int[]> _stack;
		private readonly PriorityQueue<int[], int[]> _queue;
		private readonly HashSet<int> _removed;

		private int _count;

		public MaxStack()
		{
			_stack = new Stack<int[]>();
			_queue = new PriorityQueue<int[], int[]>(
				Comparer<int[]>.Create((a, b) => (b[0] + b[1]) - (a[0] + a[1]))
			);
			_removed = new HashSet<int>();
		}

		public void Push(int x)
		{
			_stack.Push(new int[] { x, _count });
			_queue.Enqueue(new int[] { x, _count }, new int[] { x, _count });

			_count++;
		}

		public int Pop()
		{
			while (_removed.Contains(_stack.Peek()[1]))
			{
				_stack.Pop();
			}

			var top = _stack.Pop();
			_removed.Add(top[1]);

			return top[0];
		}

		public int Top()
		{
			while (_removed.Contains(_stack.Peek()[1]))
			{
				_stack.Pop();
			}

			return _stack.Peek()[0];
		}

		public int PeekMax()
		{
			while (_removed.Contains(_queue.Peek()[1]))
			{
				_queue.Dequeue();
			}

			return _queue.Peek()[0];
		}

		public int PopMax()
		{
			while (_removed.Contains(_queue.Peek()[1]))
			{
				_queue.Dequeue();
			}

			var top = _queue.Dequeue();
			_removed.Add(top[1]);

			return top[0];
		}
	}
}
