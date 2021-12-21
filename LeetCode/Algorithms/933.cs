using System.Collections.Generic;

namespace Leetcode.Algorithms
{
	internal class _933
	{
		public class RecentCounter
		{
			private readonly Queue<int> _queue;

			public RecentCounter()
			{
				_queue = new Queue<int>();
			}

			public int Ping(int t)
			{
				_queue.Enqueue(t);
				while (_queue.Peek() < t - 3000)
				{
					_queue.Dequeue();
				}
				return _queue.Count;
			}
		}
	}
}
