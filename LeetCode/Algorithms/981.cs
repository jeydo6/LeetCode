using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _981
{
	public class TimeMap
	{
		private readonly IDictionary<string, IList<(int Timestamp, string Value)>> _items;

		public TimeMap()
		{
			_items = new Dictionary<string, IList<(int Timestamp, string Value)>>();
		}

		public void Set(string key, string value, int timestamp)
		{
			if (!_items.ContainsKey(key))
			{
				_items[key] = new List<(int Timestamp, string Value)>();
			}

			_items[key].Add((timestamp, value));
		}

		public string Get(string key, int timestamp)
		{
			if (!_items.ContainsKey(key) || _items[key].Count == 0 || timestamp < _items[key][0].Timestamp)
			{
				return "";
			}

			var lo = 0;
			var hi = _items[key].Count;

			while (lo < hi)
			{
				var mid = lo + (hi - lo) / 2;
				if (_items[key][mid].Timestamp <= timestamp)
				{
					lo = mid + 1;
				}
				else
				{
					hi = mid;
				}
			}

			if (hi == 0)
			{
				return "";
			}

			return _items[key][hi - 1].Value;
		}
	}
}
