using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _295
{
	public class MedianFinder
	{
		private readonly List<int> _list;

		public MedianFinder()
		{
			_list = new List<int>();
		}

		public void AddNum(int num)
		{
			if (_list.Count == 0)
			{
				_list.Add(num);
			}
			else
			{
				var index = _list.BinarySearch(num);
				_list.Insert(index > 0 ? index : ~index, num);
			}
		}

		public double FindMedian()
		{
			return _list.Count % 2 == 1 ?
				_list[_list.Count / 2] :
				(_list[_list.Count / 2] + _list[_list.Count / 2 - 1]) * 0.5;
		}
	}
}
