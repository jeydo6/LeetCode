using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2336
{
	public class SmallestInfiniteSet
	{
		private readonly SortedSet<int> _set;

		private int _current;

		public SmallestInfiniteSet()
		{
			_set = new SortedSet<int>();
			_current = 1;
		}

		public int PopSmallest()
		{
			if (_set.Count > 0)
			{
				var result = _set.Min;
				_set.Remove(result);
				return result;
			}
			else
			{
				var result = _current;
				_current++;
				return result;
			}
		}

		public void AddBack(int num)
		{
			if (_current <= num || _set.Contains(num))
			{
				return;
			}

			_set.Add(num);
		}
	}
}
