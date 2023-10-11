using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1061
{
	public static string SmallestEquivalentString(string s1, string s2, string baseStr)
	{
		var adj = new int?[26][];
		for (var i = 0; i < 26; i++)
		{
			adj[i] = new int?[26];
		}

		for (var i = 0; i < s1.Length; i++)
		{
			adj[s1[i] - 'a'][s2[i] - 'a'] = 1;
			adj[s2[i] - 'a'][s1[i] - 'a'] = 1;
		}

		var mappingChar = new int[26];
		for (var i = 0; i < 26; i++)
		{
			mappingChar[i] = i;
		}

		var visited = new int?[26];
		for (var ch = 0; ch < 26; ch++)
		{
			if (visited[ch] == null)
			{
				var component = new List<int>();

				var minChar = GetMinChar(27, ch, adj, visited, component);

				foreach (var vertex in component)
				{
					mappingChar[vertex] = minChar;
				}
			}
		}

		var sb = new StringBuilder();
		foreach (var ch in baseStr)
		{
			sb.Append((char)(mappingChar[ch - 'a'] + 'a'));
		}

		return sb.ToString();
	}

	private static int GetMinChar(int minCh, int ch, int?[][] adj, int?[] visited, ICollection<int> component)
	{
		visited[ch] = 1;
		component.Add(ch);

		minCh = Math.Min(minCh, ch);
		for (var i = 0; i < 26; i++)
		{
			if (adj[ch][i] != null && visited[i] == null)
			{
				minCh = GetMinChar(minCh, i, adj, visited, component);
			}
		}

		return minCh;
	}
}
