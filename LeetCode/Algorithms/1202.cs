using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1202
	{
		private static readonly bool[] _visited = new bool[100001];
		private static readonly IList<int>[] _verticies = new List<int>[100001];

		public static string SmallestStringWithSwaps(string s, IList<IList<int>> pairs)
		{
			for (var i = 0; i < s.Length; i++)
			{
				_verticies[i] = new List<int>();
			}

			for (var i = 0; i < pairs.Count; i++)
			{
				var source = pairs[i][0];
				var destination = pairs[i][1];
				_verticies[source].Add(destination);
				_verticies[destination].Add(source);
			}

			var result = new char[s.Length];
			for (var vertex = 0; vertex < s.Length; vertex++)
			{
				if (!_visited[vertex])
				{
					var characters = new List<char>();
					var indices = new List<int>();

					DFS(s, vertex, characters, indices);
					characters.Sort();
					indices.Sort();

					for (var index = 0; index < characters.Count; index++)
					{
						result[indices[index]] = characters[index];
					}
				}
			}
			return new string(result);
		}

		private static void DFS(string s, int vertex, IList<char> characters, IList<int> indices)
		{
			characters.Add(s[vertex]);
			indices.Add(vertex);
			_visited[vertex] = true;

			for (var i = 0; i < _verticies[vertex].Count; i++)
			{
				var adjacent = _verticies[vertex][i];
				if (!_visited[adjacent])
				{
					DFS(s, adjacent, characters, indices);
				}
			}
		}
	}
}
