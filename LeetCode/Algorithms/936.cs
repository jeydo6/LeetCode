using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _936
	{
		public static int[] MovesToStamp(string stamp, string target)
		{
			var queue = new Queue<int>();
			var stack = new Stack<int>();
			var list = new List<(ISet<int> Made, ISet<int> Todo)>();
			var done = new bool[target.Length];

			for (var i = 0; i <= target.Length - stamp.Length; i++)
			{
				var made = new HashSet<int>();
				var todo = new HashSet<int>();

				for (var j = 0; j < stamp.Length; j++)
				{
					if (target[i + j] == stamp[j])
					{
						made.Add(i + j);
					}
					else
					{
						todo.Add(i + j);
					}
				}

				list.Add((made, todo));

				if (todo.Count == 0)
				{
					stack.Push(i);
					for (var j = i; j < i + stamp.Length; j++)
					{
						if (!done[j])
						{
							queue.Enqueue(j);
							done[j] = true;
						}
					}
				}
			}

			while (queue.Count > 0)
			{
				var i = queue.Dequeue();
				for (var j = Math.Max(0, i - stamp.Length + 1); j <= Math.Min(target.Length - stamp.Length, i); j++)
				{
					if (list[j].Todo.Contains(i))
					{
						list[j].Todo.Remove(i);
						if (list[j].Todo.Count == 0)
						{
							stack.Push(j);
							foreach (var m in list[j].Made)
							{
								if (!done[m])
								{
									queue.Enqueue(m);
									done[m] = true;
								}
							}
						}
					}
				}
			}

			for (var i = 0; i < done.Length; i++)
			{
				if (!done[i])
				{
					return Array.Empty<int>();
				}
			}

			var result = new int[stack.Count];
			for (var i = 0; i < result.Length; i++)
			{
				result[i] = stack.Pop();
			}

			return result;
		}
	}
}
