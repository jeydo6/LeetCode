using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _247
	{
		private static readonly char[][] _pairs = new char[][]
		{
			new char[] {'0', '0'},
			new char[] {'1', '1'},
			new char[] {'6', '9'},
			new char[] {'8', '8'},
			new char[] {'9', '6'}
		};

		public static IList<string> FindStrobogrammatic(int n)
		{
			var queue = new Queue<string>();
			int length;
			if (n % 2 == 0)
			{
				length = 0;
				queue.Enqueue("");
			}
			else
			{
				length = 1;
				queue.Enqueue("0");
				queue.Enqueue("1");
				queue.Enqueue("8");
			}

			while (length < n)
			{
				length += 2;
				for (var i = queue.Count; i > 0; --i)
				{
					var number = queue.Dequeue();
					for (var j = 0; j < _pairs.Length; j++)
					{
						if (length != n || _pairs[j][0] != '0')
						{
							queue.Enqueue(_pairs[j][0] + number + _pairs[j][1]);
						}
					}
				}
			}
			return new List<string>(queue);
		}
	}
}
