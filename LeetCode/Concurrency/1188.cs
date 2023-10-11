using System;
using System.Collections.Generic;
using System.Threading;

namespace LeetCode.Concurrency
{
	// MEDIUM
	internal class _1188
	{
		public class BoundedBlockingQueue : IDisposable
		{
			private readonly Queue<int> _queue;

			private readonly Semaphore _dequeue;
			private readonly Semaphore _enqueue;
			private readonly Mutex _mutex;
			
			private bool disposedValue;

			public BoundedBlockingQueue(int capacity)
			{
				_queue = new Queue<int>(capacity);

				_dequeue = new Semaphore(0, capacity);
				_enqueue = new Semaphore(capacity, capacity);
				_mutex = new Mutex();
			}

			public void Enqueue(int element)
			{
				_enqueue.WaitOne();
				_mutex.WaitOne();

				_queue.Enqueue(element);

				_mutex.ReleaseMutex();
				_dequeue.Release();
			}

			public int Dequeue()
			{
				_dequeue.WaitOne();
				_mutex.WaitOne();

				var result = _queue.Dequeue();

				_mutex.ReleaseMutex();
				_enqueue.Release();
				return result;
			}

			public int Size()
			{
				return _queue.Count;
			}

			protected virtual void Dispose(bool disposing)
			{
				if (!disposedValue)
				{
					if (disposing)
					{
						_enqueue.Dispose();
						_dequeue.Dispose();
						_mutex.Dispose();
					}

					disposedValue = true;
				}
			}

			public void Dispose()
			{
				Dispose(disposing: true);
				GC.SuppressFinalize(this);
			}
		}
	}
}
