using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCode.Concurrency
{
	// MEDIUM
	internal class _1242
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
			Parallel.ForEach(htmlParser.GetUrls(startUrl), url =>
			{
				if (url.StartsWith(host) && !visited.Contains(url))
				{
					lock (visited)
					{
						visited.Add(url);
					}
					Crawl(url, htmlParser, host, visited);
				}
			});
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
				var random = new Random();
				Thread.Sleep(random.Next(16));

				return _graph.ContainsKey(url) ? _graph[url] : new List<string>();
			}
		}
	}
}
