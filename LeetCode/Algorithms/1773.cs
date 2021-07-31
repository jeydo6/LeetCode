using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	class _1773
	{
		private static readonly IDictionary<string, int> _map = new Dictionary<string, int>
		{
			["type"] = 0,
			["color"] = 1,
			["name"] = 2,
		};

		public static int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
		{
			var result = 0;
			foreach (var item in items)
			{
				if (item[_map[ruleKey]] == ruleValue)
				{
					result++;
				}
			}
			return result;
		}
	}
}
