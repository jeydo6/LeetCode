using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1236
	{
		public static IList<string> Crawl(string startUrl, HtmlParser htmlParser)
		{
			var slashIndex = startUrl.IndexOf('/', 7);
			var host = slashIndex > 0 ? startUrl[..slashIndex] : startUrl;
			var visited = new HashSet<string>
			{
				startUrl
			};

			Crawl(startUrl, htmlParser, host, visited);

			return new List<string>(visited);
		}

		public static void Crawl(string startUrl, HtmlParser htmlParser, string host, ISet<string> visited)
		{
			foreach (var url in htmlParser.GetUrls(startUrl))
			{
				if (url.StartsWith(host) && !visited.Contains(url))
				{
					visited.Add(url);
					Crawl(url, htmlParser, host, visited);
				}
			}
		}

		public class HtmlParser
		{
			private readonly IDictionary<string, List<string>> _graph = new Dictionary<string, List<string>>();

			public HtmlParser(string[] urls, int[][] edges)
			{
				for (var i = 0; i < edges.Length; i++)
				{
					var key = urls[edges[i][0]];
					var value = urls[edges[i][1]];
					if (!_graph.ContainsKey(key))
					{
						_graph[key] = new List<string>();
					}
					_graph[key].Add(value);
				}
			}

			public List<string> GetUrls(string url)
			{
				var random = new System.Random();
				System.Threading.Thread.Sleep(random.Next(16));

				return _graph.ContainsKey(url) ? _graph[url] : new List<string>();
			}
		}
	}
}
