using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _362
{
	public class HitCounter
	{
		private readonly Queue<int> _hits;

		public HitCounter()
		{
			_hits = new Queue<int>();
		}

		public void Hit(int timestamp)
		{
			_hits.Enqueue(timestamp);
		}

		public int GetHits(int timestamp)
		{
			while (_hits.Count > 0)
			{
				var diff = timestamp - _hits.Peek();
				if (diff >= 300)
				{
					_hits.Dequeue();
				}
				else
				{
					break;
				}
			}
			return _hits.Count;
		}
	}
}
