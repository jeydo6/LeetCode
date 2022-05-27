using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _346
	{
		public class MovingAverage
		{
			private readonly int _size;
			private readonly Queue<int> _queue;

			private int _total;

			public MovingAverage(int size)
			{
				_size = size;
				_queue = new Queue<int>();
			}

			public double Next(int val)
			{
				_queue.Enqueue(val);

				_total += val - (_queue.Count > _size ? _queue.Dequeue() : 0);

				return _total * 1.0 / Math.Min(_size, _queue.Count);
			}
		}
	}
}
