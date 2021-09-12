namespace LeetCode.Algorithms
{
	// HARD
	class _882
	{
		public static int ReachableNodes(int[][] edges, int m, int n)
		{
			var remains = new int[n];
			var graph = new Dictionary<int, IDictionary<int, int>>();
			for (var i = 0; i < n; i++)
			{
				remains[i] = -1;
				graph[i] = new Dictionary<int, int>();
			}
			foreach (var edge in edges)
			{
				graph[edge[0]][edge[1]] = edge[2];
				graph[edge[1]][edge[0]] = edge[2];
			}

			var visited = new bool[n];
			var occupied = new int[n, n];

			remains[0] = m;

			var queue = new Queue<int[]>();
			queue.Enqueue(new int[] { 0, m });
			while (queue.Count > 0)
			{
				var current = queue.Dequeue();
				var node = current[0];
				var remain = current[1];

				visited[node] = true;

				foreach (var child in graph[node].Keys)
				{
					var distance = graph[node][child];
					if (remain >= distance)
					{
						occupied[node, child] = distance;

						var move = remain - distance - 1;
						if (move > remains[child])
						{
							remains[child] = move;
							queue.Enqueue(new int[] { child, move });
						}
					}
					else
					{
						occupied[node, child] = Math.Max(occupied[node, child], remain);
					}
				}
			}

			var result = 0;
			for (var i = 0; i < n; i++)
			{
				if (visited[i])
				{
					result++;
				}
			}
			foreach (var edge in edges)
			{
				result += Math.Min(edge[2], occupied[edge[0], edge[1]] + occupied[edge[1], edge[0]]);
			}
			return result;
		}

		private class PriorityQueue<T>
		{
			private readonly IDictionary<int, Queue<T>> _storage;
			private readonly IEqualityComparer<int> _comparer;
			private int _count;

			public PriorityQueue(IEqualityComparer<int> comparer = null)
			{
				_storage = new SortedDictionary<int, Queue<T>>();
				_comparer = comparer ?? EqualityComparer<int>.Default;
				_count = 0;
			}

			public bool IsEmpty()
			{
				return _count == 0;
			}

			public T Peek()
			{
				if (IsEmpty())
				{
					throw new Exception("PriorityQueue is empty!");
				}
				else
				{
					foreach (var queue in _storage.Values)
					{
						if (queue.Count > 0)
						{
							return queue.Peek();
						}
					}
				}

				return default;
			}

			public T Dequeue()
			{
				if (IsEmpty())
				{
					throw new Exception("PriorityQueue is empty!");
				}
				else
				{
					foreach (var queue in _storage.Values)
					{
						if (queue.Count > 0)
						{
							_count--;
							return queue.Dequeue();
						}
					}
				}

				return default;
			}

			public T Dequeue(int priority)
			{
				_count--;
				return _storage[priority].Dequeue();
			}

			public void Enqueue(T item, int priority)
			{
				if (!_storage.ContainsKey(priority))
				{
					_storage.Add(priority, new Queue<T>());
				}

				_storage[priority].Enqueue(item);
				_count++;
			}
		}
	}
}
