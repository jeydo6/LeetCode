using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _721
	{
		public static IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
		{
			var owners = new Dictionary<string, string>();
			var parents = new Dictionary<string, string>();

			foreach (var account in accounts)
			{
				for (var i = 1; i < account.Count; i++)
				{
					parents[account[i]] = account[i];
					owners[account[i]] = account[0];
				}
			}

			foreach (var account in accounts)
			{
				var parent = Find(account[1], parents);
				for (var i = 2; i < account.Count; i++)
				{
					parents[Find(account[i], parents)] = parent;
				}
			}

			var unions = new Dictionary<string, ISet<string>>();
			foreach (var account in accounts)
			{
				var parent = Find(account[1], parents);
				if (!unions.ContainsKey(parent))
				{
					unions[parent] = new SortedSet<string>(StringComparer.Ordinal);
				}
				for (var i = 1; i < account.Count; i++)
				{
					unions[parent].Add(account[i]);
				}
			}

			var result = new List<IList<string>>();
			foreach (var parent in unions.Keys)
			{
				var emails = new List<string>(unions[parent]);
				emails.Insert(0, owners[parent]);
				result.Add(emails);
			}
			return result;
		}

		private static string Find(string str, IDictionary<string, string> dict)
		{
			return dict[str] == str ? str : Find(dict[str], dict);
		}
	}
}
