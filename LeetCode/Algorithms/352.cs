using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _352
{
	public class SummaryRanges
	{
		private readonly ISet<int> _values;

		public SummaryRanges()
		{
			_values= new SortedSet<int>();
		}

		public void AddNum(int value)
		{
			_values.Add(value);
		}

		public int[][] GetIntervals()
		{
			if (_values.Count == 0)
			{
				return Array.Empty<int[]>();
			}

			var intervals = new List<int[]>();
			var left = -1;
			var right = -1;
			foreach (var value in _values)
			{
				if (left < 0)
				{
					left = value;
					right = value;
				}
				else if (value == right + 1)
				{
					right = value;
				}
				else
				{
					intervals.Add(new int[] { left, right });
					left = value;
					right = value;
				}
			}
			intervals.Add(new int[] { left, right });
			
			return intervals.ToArray();
		}
	}
}
