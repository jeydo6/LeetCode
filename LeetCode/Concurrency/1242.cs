using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
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
			var visited = new ConcurrentDictionary<string, string>
			{
				[startUrl] = startUrl
			};

			CrawlParallel(startUrl, htmlParser, host, visited);

			return new List<string>(visited.Keys);
		}

		public static void CrawlParallel(string startUrl, HtmlParser htmlParser, string host, ConcurrentDictionary<string, string> visited)
		{
			Parallel.ForEach(htmlParser.GetUrls(startUrl), url =>
			{
				if (url.StartsWith(host) && !visited.ContainsKey(url))
				{
					visited.TryAdd(url, url);
					CrawlParallel(url, htmlParser, host, visited);
				}
			});
		}

		public static void CrawlTasks(string startUrl, HtmlParser htmlParser, string host, ConcurrentDictionary<string, string> visited)
		{
			var tasks = htmlParser
				.GetUrls(startUrl)
				.Select(url => Task.Factory.StartNew(
					() =>
					{
						if (url.StartsWith(host) && !visited.ContainsKey(url))
						{
							visited.TryAdd(url, url);
							CrawlTasks(url, htmlParser, host, visited);
						}
					},
					CancellationToken.None,
					TaskCreationOptions.AttachedToParent,
					TaskScheduler.Default)
				)
				.ToArray();
			Task.WaitAll(tasks);
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
