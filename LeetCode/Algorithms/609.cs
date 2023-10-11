using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _609
{
	public static IList<IList<string>> FindDuplicate(string[] paths)
	{
		var dict = new Dictionary<string, IList<string>>();
		for (var i = 0; i < paths.Length; i++)
		{
			var values = paths[i].Split(' ');
			for (var j = 1; j < values.Length; j++)
			{
				var names = values[j].Split("(");
				names[1] = names[1].Replace(")", "");

				if (!dict.ContainsKey(names[1]))
				{
					dict[names[1]] = new List<string>();
				}

				dict[names[1]].Add(values[0] + '/' + names[0]);
			}
		}

		var result = new List<IList<string>>();
		foreach (var value in dict.Values)
		{
			if (value.Count > 1)
			{
				result.Add(value);
			}
		}

		return result;
	}
}
