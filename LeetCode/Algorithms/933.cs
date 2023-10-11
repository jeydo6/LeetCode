using System;
using System.Collections.Generic;

namespace Leetcode.Algorithms
{
	public class _933
	{
		public class RecentCounter
		{
			Queue<Int32> q;
			public RecentCounter()
			{
				q = new Queue<Int32>();
			}

			public Int32 Ping(Int32 t)
			{
				q.Enqueue(t);
				while (q.Peek() < t - 3000)
				{
					q.Dequeue();
				}
				return q.Count;
			}
		}
	}
}
