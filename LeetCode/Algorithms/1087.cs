using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1087
	{
		public static string[] Expand(string s)
		{
			var allOptions = GetAllOptions(s);
			var expanded = Expand(new StringBuilder(), allOptions);
			var result = new string[expanded.Count];
			expanded.CopyTo(result, 0);
			return result;
		}

		private static IList<string> Expand(StringBuilder currentString, IList<string> allOptions)
		{
			var result = new List<string>();
			if (currentString.Length == allOptions.Count)
			{
				result.Add(currentString.ToString());
				return result;
			}

			var currentOptions = allOptions[currentString.Length];
			for (var i = 0; i < currentOptions.Length; i++)
			{
				currentString.Append(currentOptions[i]);
				var expanded = Expand(currentString, allOptions);
				for (var j = 0; j < expanded.Count; j++)
				{
					result.Add(expanded[j]);
				}
				currentString.Remove(currentString.Length - 1, 1);
			}
			return result;
		}

		private static IList<string> GetAllOptions(string s)
		{
			var allOptions = new List<string>();
			for (var position = 0; position < s.Length; position++)
			{
				var currentOptions = new List<char>();
				if (s[position] != '{')
				{
					currentOptions.Add(s[position]);
				}
				else
				{
					while (s[position] != '}')
					{
						if (s[position] >= 'a' && s[position] <= 'z')
						{
							currentOptions.Add(s[position]);
						}
						position++;
					}
					currentOptions.Sort();
				}
				allOptions.Add(new string(
					currentOptions.ToArray()
				));
			}
			return allOptions;
		}
	}
}
