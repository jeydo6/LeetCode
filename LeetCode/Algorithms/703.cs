using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal class _703
{
	public class KthLargest
	{
		private readonly int _k;
		private readonly PriorityQueue<int, int> _pQueue;

		public KthLargest(int k, int[] nums)
		{
			_k = k;
			_pQueue = new PriorityQueue<int, int>();
			for (var i = 0; i < nums.Length; i++)
			{
				_pQueue.Enqueue(nums[i], nums[i]);
			}

			while (_pQueue.Count > k)
			{
				_pQueue.Dequeue();
			}
		}

		public int Add(int val)
		{
			_pQueue.Enqueue(val, val);
			while (_pQueue.Count > _k)
			{
				_pQueue.Dequeue();
			}

			return _pQueue.Peek();
		}
	}
}
