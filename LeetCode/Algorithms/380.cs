using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _380
	{
		public static void GetResult()
		{
			var randomizedSet = new RandomizedSet();
			randomizedSet.Insert(1); // Inserts 1 to the set. Returns true as 1 was inserted successfully.
			randomizedSet.Remove(2); // Returns false as 2 does not exist in the set.
			randomizedSet.Insert(2); // Inserts 2 to the set, returns true. Set now contains [1,2].
			randomizedSet.GetRandom(); // getRandom() should return either 1 or 2 randomly.
			randomizedSet.Remove(1); // Removes 1 from the set, returns true. Set now contains [2].
			randomizedSet.Insert(2); // 2 was already in the set, so return false.
			randomizedSet.GetRandom(); // Since 2 is the only number in the set, getRandom() will always return 2.
		}

		public class RandomizedSet
		{
			private static readonly Random _random;

			private readonly IList<int> _list;
			private readonly IDictionary<int, int> _dict;

			static RandomizedSet()
			{
				_random = new Random();
			}

			public RandomizedSet()
			{
				_list = new List<int>();
				_dict = new Dictionary<int, int>();
			}

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
}
