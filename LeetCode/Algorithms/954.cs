using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	class _954
	{
		public static bool CanReorderDoubled(int[] array)
		{
			var sum = 0;
			var dict = new SortedDictionary<int, int>();
			foreach (var item in array)
			{
				if (!dict.ContainsKey(item))
				{
					dict[item] = 0;
				}
				dict[item]++;
				sum += item;
			}

			if (sum % 3 != 0)
			{
				return false;
			}

			var keys = new int[dict.Keys.Count];
			dict.Keys.CopyTo(keys, 0);
			foreach (var key in keys)
			{
				if (dict[key] == 0)
				{
					continue;
				}

				var temp = key < 0 ? key / 2 : key * 2;
				if (!dict.ContainsKey(temp) || dict[key] > dict[temp])
				{
					return false;
				}

				dict[temp] -= dict[key];
				dict[key] = 0;
			}

			return true;

			//var keys = new int[dict.Keys.Count];
			//dict.Keys.CopyTo(keys, 0);
			//Array.Sort(keys, new Comparison<int>((a, b) => Math.Abs(a) - Math.Abs(b)));

			//foreach (var key in keys)
			//{
			//	if (!dict.ContainsKey(2 * key))
			//	{
			//		dict[2 * key] = 0;
			//	}

			//	if (dict[key] > dict[2 * key])
			//	{
			//		return false;
			//	}

			//	dict[2 * key] -= dict[key];
			//}

			//return true;

			//var keys = new int[dict.Keys.Count];
			//dict.Keys.CopyTo(keys, 0);
			//foreach (var key in keys)
			//{
			//	if (dict[key] == 0)
			//	{
			//		continue;
			//	}

			//	var tempKey = key < 0 ? key / 2 : key * 2;
			//	var tempValue = dict.ContainsKey(tempKey) ? dict[tempKey] : 0;
			//	if (key < 0 && key % 2 != 0 || dict[key] > tempValue)
			//	{
			//		return false;
			//	}
			//	dict[tempKey] -= dict[key];
			//}

			//return true;
		}
	}
}
