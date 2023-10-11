using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1268
	{
		public static IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
		{
			var result = new List<IList<string>>();
			Array.Sort(products, StringComparer.Ordinal);


			var prefix = string.Empty;
			for (var i = 0; i < searchWord.Length; i++)
			{
				prefix += searchWord[i];

				var current = new List<string>();
				for (var j = 0; j < products.Length; j++)
				{
					if (products[j].StartsWith(prefix, StringComparison.Ordinal))
					{
						current.Add(products[j]);
					}

					if (current.Count == 3)
					{
						break;
					}
				}

				result.Add(current);
			}

			return result;
		}
	}
}
