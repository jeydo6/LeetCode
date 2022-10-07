using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _732
{
	public class MyCalendarThree
	{
		private readonly IDictionary<int, int> _dict;

		public MyCalendarThree()
		{
			_dict = new SortedDictionary<int, int>();
		}

		public int Book(int start, int end)
		{
			if (!_dict.ContainsKey(start))
			{
				_dict[start] = 0;
			}
			_dict[start]++;

			if (!_dict.ContainsKey(end))
			{
				_dict[end] = 0;
			}
			_dict[end]--;

			var result = 0;
			var current = 0;
			foreach (var value in _dict.Values)
			{
				current += value;
				if (current > result)
				{
					result = current;
				}
			}

			return result;
		}
	}
}
