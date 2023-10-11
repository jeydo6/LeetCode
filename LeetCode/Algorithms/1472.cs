using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1472
{
	public class BrowserHistory
	{
		private readonly Stack<string> _past = new Stack<string>();
		private readonly Stack<string> _future = new Stack<string>();

		public BrowserHistory(string homepage)
		{
			_past.Push(homepage);
		}

		public void Visit(string url)
		{
			_past.Push(url);
			_future.Clear();
		}

		public string Back(int steps)
		{
			while (steps > 0 && _past.Count > 1)
			{
				_future.Push(_past.Pop());
				steps--;
			}
			return _past.Peek();
		}

		public string Forward(int steps)
		{
			while (steps > 0 && _future.Count > 0)
			{
				_past.Push(_future.Pop());
				steps--;
			}
			return _past.Peek();
		}
	}
}
