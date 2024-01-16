using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _380
{
	public class RandomizedSet
	{
		private static readonly Random _random = new Random();

		private readonly IList<int> _list = new List<int>();
		private readonly IDictionary<int, int> _dict = new Dictionary<int, int>();

		public bool Insert(int val)
		{
			if (!_dict.ContainsKey(val))
			{
				_dict[val] = _list.Count;
				_list.Add(val);

				return true;
			}

			return false;
		}

		public bool Remove(int val)
		{
			if (_dict.ContainsKey(val))
			{
				var last = _list[^1];
				var index = _dict[val];

				_dict[last] = index;
				_dict.Remove(val);

				_list[index] = last;
				_list.RemoveAt(_list.Count - 1);

				return true;
			}

			return false;
		}

		public int GetRandom()
		{
			return _list[_random.Next(_list.Count)];
		}
	}
}
