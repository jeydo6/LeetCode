namespace LeetCode.Algorithms;

// MEDIUM
internal class _622
{
	public class MyCircularQueue
	{
		private readonly int[] _queue;
		private int _index;
		private int _count;

		public MyCircularQueue(int capacity)
		{
			_queue = new int[capacity];
		}

		public bool EnQueue(int value)
		{
			if (_count == _queue.Length)
			{
				return false;
			}

			_queue[(_index + _count) % _queue.Length] = value;
			_count += 1;
			
			return true;
		}

		public bool DeQueue()
		{
			if (_count == 0)
			{
				return false;
			}

			_index = (_index + 1) % _queue.Length;
			_count -= 1;

			return true;
		}

		public int Front()
		{
			if (_count == 0)
			{
				return -1;
			}

			return _queue[_index];
		}

		public int Rear()
		{
			if (_count == 0)
			{
				return -1;
			}

			return _queue[(_index + _count - 1) % _queue.Length];
		}

		public bool IsEmpty()
		{
			return _count == 0;
		}

		public bool IsFull()
		{
			return _count == _queue.Length;
		}
	}
}
