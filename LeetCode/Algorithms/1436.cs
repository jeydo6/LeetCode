using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	class _1436
	{
		//public static string DestCity(IList<IList<string>> paths)
		//{
		//	//var dict = new Dictionary<string, IList<string>>();
		//	//foreach (var path in paths)
		//	//{
		//	//	if (dict.ContainsKey(path[0]))
		//	//	{
		//	//		dict[path[0]].Add(path[1]);
		//	//	}
		//	//	else
		//	//	{
		//	//		dict[path[0]] = new List<string>
		//	//		{
		//	//			path[1]
		//	//		};
		//	//	}
		//	//}

		//	//foreach (var key in dict.Keys)
		//	//{

		//	//}

		//	//throw new Exception();

		//	var departures = new HashSet<string>();
		//	var arrivals = new HashSet<string>();
		//	foreach (var path in paths)
		//	{
		//		departures.Add(path[0]);
		//		arrivals.Add(path[1]);
		//	}

		//	arrivals.ExceptWith(departures);
		//	var enumerator = arrivals.GetEnumerator();
		//	enumerator.MoveNext();

		//	return enumerator.Current;
		//}

		public static string DestCity(IList<IList<string>> paths)
		{
			var dict = new Dictionary<string, string>();
			foreach (var path in paths)
			{
				dict[path[0]] = path[1];
			}

			foreach (var value in dict.Values)
			{
				if (!dict.ContainsKey(value))
				{
					return value;
				}
			}

			return "";
		}
	}
}
