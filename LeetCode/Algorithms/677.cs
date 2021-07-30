using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms
{
	class _677
	{
		public static string GetResult()
		{
			var mapSum = new MapSum();
			mapSum.Insert("apple", 3);
			mapSum.Sum("ap");
			mapSum.Insert("app", 2);
			mapSum.Sum("ap");

			return "";
		}

		public class MapSum
		{
			private readonly IDictionary<string, int> _map;

			public MapSum()
			{
				_map = new Dictionary<string, int>();
			}

			public void Insert(string key, int value)
			{
				_map[key] = value;
			}

			public int Sum(string prefix)
			{
				return _map
					.Where(kvp => kvp.Key.StartsWith(prefix))
					.Select(kvp => kvp.Value)
					.Sum();
			}
		}
	}
}
