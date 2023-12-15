using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal sealed class _1436
{
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

		return string.Empty;
	}
}
