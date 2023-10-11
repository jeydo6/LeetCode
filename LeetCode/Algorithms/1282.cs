using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1282
{
	public static IList<IList<int>> GroupThePeople(int[] groupSizes)
	{
		var result = new List<IList<int>>();
		var groupSizesDict = new Dictionary<int, IList<int>>();
		for (var i = 0; i < groupSizes.Length; i++)
		{
			if (!groupSizesDict.ContainsKey(groupSizes[i]))
			{
				groupSizesDict[groupSizes[i]] = new List<int>();
			}

			var group = groupSizesDict[groupSizes[i]];
			group.Add(i);
			if (group.Count == groupSizes[i])
			{
				result.Add(group);
				groupSizesDict.Remove(groupSizes[i]);
			}
		}

		return result;
	}
}
