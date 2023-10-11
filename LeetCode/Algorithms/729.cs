using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _729
	{
		public class MyCalendar
		{
			private readonly List<(int Start, int End)> _list;

			public MyCalendar()
			{
				_list = new List<(int Start, int End)>();
			}

			public bool Book(int start, int end)
			{
				var range = (start, end);
				var index = _list.BinarySearch(
					range,
					Comparer<(int Start, int End)>.Create((a, b) =>
					{
						if (a.End <= b.Start)
						{
							return -1;
						}
						
						if (b.End <= a.Start)
						{
							return 1;
						}

						return 0;
					})
				);

				if (index < 0)
				{
					_list.Insert(~index, range);
					return true;
				}

				return false;
			}
		}
	}
}
